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
        else if (typeof(TManaged).IsAssignableTo(typeof(GameObject)))
        {
            var objPtr = MemUtil.Blit<IntPtr>(data);

            // Handle null object pointers.
            if (objPtr == IntPtr.Zero)
            {
                return (TManaged)(object)null!;
            }

            // We should already have wrappers for all objects.
            Guard.Require(
                s_managedObjects.TryGetValue(objPtr, out var obj),
                $"No managed wrapper found for object at 0x{objPtr:X}"
            );
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

    public static void CreateManagedWrapper(IntPtr objPtr, Type managedType)
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

        // Prevent class objects from being GC'd. Keeps things simple,
        // and shouldn't be *too* bad for perf as there's only so many of them.
        if (newObj is Class)
        {
            newObj.AddToRoot();
        }
    }

    public static void DestroyManagedWrapper(IntPtr objPtr)
    {
        if (s_managedObjects.TryGetValue(objPtr, out var obj) && obj is Actor actor)
        {
            // Detach all script components
            if (actor.ScriptComponents.Any())
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
