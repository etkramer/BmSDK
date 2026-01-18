using System.Reflection;
using BmSDK.Engine;

namespace BmSDK.Framework;

internal static unsafe class MarshalUtil
{
    public static readonly Dictionary<IntPtr, GameObject> s_managedObjects = [];

    // Temp-ish hack. Let's see about refactoring this later.
    public static object? ToManaged(IntPtr data, Type managedType)
    {
        var method = Guard.NotNull(
            typeof(MarshalUtil).GetMethod(
                nameof(ToManaged),
                BindingFlags.Public | BindingFlags.Static,
                [typeof(IntPtr)]
            )
        );

        var genericMethod = Guard.NotNull(method.MakeGenericMethod(managedType));
        return genericMethod.Invoke(null, [data]);
    }

    public static TManaged ToManaged<TManaged>(IntPtr data) =>
        ToManaged<TManaged>(data.ToPointer());

    // Marshals unmanaged data to managed, then returns it.
    public static TManaged ToManaged<TManaged>(void* data)
    {
        // Try to copy memory directly (for struct, primitive types)
        if (typeof(TManaged).IsValueType)
        {
            return MemUtil.Blit<TManaged>(data);
        }
        else if (
            typeof(TManaged).IsGenericType
            && typeof(TManaged).GetGenericTypeDefinition() == typeof(TArray<>)
        )
        {
            // Create new TArray instance - duplicates will still refer to the same native object.
            var instance = Guard.NotNull(
                Activator.CreateInstance<TManaged>() as IArray,
                $"Couldn't create an instance of array 0x{new IntPtr(data):X}"
            );

            instance.Ptr = (IntPtr)data;
            return (TManaged)instance;
        }
        else if (typeof(TManaged).IsAssignableTo(typeof(GameObject)))
        {
            var objPtr = MemUtil.Blit<IntPtr>(data);

            // Handle null object pointers.
            if (objPtr == IntPtr.Zero)
            {
                return (TManaged)(object)null!;
            }

            // We should create wrappers in edge cases even though
            // we are supposed to have one managed equivalent of each objects.
            if (!s_managedObjects.TryGetValue(objPtr, out var obj))
            {
                obj = HandleNewObject(objPtr);
            }
            return (TManaged)(object)Guard.NotNull(obj);
        }

        throw new NotImplementedException(
            $"Marshaling not (fully) implemented for type {typeof(TManaged).Name}"
        );
    }

    // Temp-ish hack. Let's see about refactoring this later.
    public static void ToUnmanaged(object? value, IntPtr data, Type managedType)
    {
        var method = Guard.NotNull(
            typeof(MarshalUtil)
                .GetMethods(BindingFlags.Public | BindingFlags.Static)
                .Where(m => m.Name == nameof(ToUnmanaged) && m.IsGenericMethodDefinition)
                .Where(m => m.GetParameters()[1].ParameterType == typeof(IntPtr))
                .FirstOrDefault()
        );

        var genericMethod = Guard.NotNull(method.MakeGenericMethod(managedType));
        genericMethod.Invoke(null, [value, data]);
    }

    public static void ToUnmanaged<TManaged>(TManaged value, IntPtr data) =>
        ToUnmanaged(value, data.ToPointer());

    // Marshals a managed object to native, then copies it into an existing buffer.
    public static void ToUnmanaged<TManaged>(TManaged value, void* data)
    {
        // Try to copy memory directly (for struct, primitive types)
        if (typeof(TManaged).IsValueType)
        {
            MemUtil.Blit(value, data);
            return;
        }
        else if (
            typeof(TManaged).IsGenericType
            && typeof(TManaged).GetGenericTypeDefinition() == typeof(TArray<>)
        )
        {
            // TODO: Fully handle two-way array marshaling.
            if (data == null)
            {
                // Do nothing (leave zeroed) and return.
                return;
            }
        }
        else if (typeof(TManaged).IsAssignableTo(typeof(GameObject)))
        {
            // Handle null object references.
            if (value is null)
            {
                ToUnmanaged(IntPtr.Zero, data);
                return;
            }

            // We already have a pointer to this object's native instance, so just assign it.
            ToUnmanaged(((GameObject)(object)value!).Ptr, data);
            return;
        }

        throw new NotImplementedException(
            $"Marshaling not (fully) implemented for type {typeof(TManaged).Name}"
        );
    }

    public static int GetSizeUnmanaged<TManaged>()
    {
        // Try to use managed size directly (for struct, primitive types)
        if (typeof(TManaged).IsValueType)
        {
            return Marshal.SizeOf<TManaged>();
        }
        else if (typeof(TManaged).IsAssignableTo(typeof(GameObject)))
        {
            return sizeof(IntPtr);
        }

        throw new NotImplementedException(
            $"Marshaling not (fully) implemented for type {typeof(TManaged).Name}"
        );
    }

    public static unsafe string GetClassPath(IntPtr objPtr)
    {
        // Fetch class name.
        var classPtr = *(IntPtr*)(objPtr + GameInfo.MemberOffsets.Object__Class).ToPointer();
        var className = *(FName*)(classPtr + GameInfo.MemberOffsets.Object__Name).ToPointer();

        // Fetch outer name.
        var classOuterPtr = *(IntPtr*)(classPtr + GameInfo.MemberOffsets.Object__Outer).ToPointer();
        var classOuterName = *(FName*)
            (classOuterPtr + GameInfo.MemberOffsets.Object__Name).ToPointer();

        return $"{classOuterName}.{className}";
    }

    public static GameObject? HandleNewObject(IntPtr objPtr)
    {
        var classPtr = *(IntPtr*)(objPtr + GameInfo.MemberOffsets.Object__Class).ToPointer();
        var classIndexPtr = classPtr + GameInfo.MemberOffsets.Object__ObjectInternalInteger;

        // Not clear yet why this happens, but maybe we don't need to worry about it.
        var classIndex = *(int*)classIndexPtr.ToPointer();
        if (classIndex < 1)
        {
            return CreateManagedWrapper(objPtr, typeof(Class));
        }

        // Match native classes to managed types
        var classPath = GetClassPath(objPtr);

        // Wrap this object in a managed instance
        var managedType = StaticInit.GetManagedTypeForClassPath(classPath);
        return CreateManagedWrapper(objPtr, managedType);
    }

    public static GameObject? CreateManagedWrapper(IntPtr objPtr, Type managedType)
    {
        // Warn in case of duplicate objects
        if (s_managedObjects.TryGetValue(objPtr, out var existingObj))
        {
            Debug.LogWarning($"Object 0x{objPtr:X} already has managed wrapper {existingObj}!");
        }

        // Create a new managed object
        var newObj = s_managedObjects[objPtr] = Guard.NotNull(
            (GameObject?)Activator.CreateInstance(managedType, true),
            $"Couldn't create an instance of managed type {managedType.Name}"
        );
        newObj.Ptr = objPtr;
        return newObj;
    }

    public static void DestroyManagedWrapper(IntPtr objPtr)
    {
        if (s_managedObjects.TryGetValue(objPtr, out var obj) && obj is Actor actor)
        {
            // Detach all script components
            if (actor.ScriptComponents.Count > 0)
            {
                foreach (var scriptComponent in actor.ScriptComponents.ToArray())
                {
                    actor.DetachScriptComponent(scriptComponent);
                }
            }
        }

        // Remove managed wrapper from storage
        s_managedObjects.Remove(objPtr);
    }
}
