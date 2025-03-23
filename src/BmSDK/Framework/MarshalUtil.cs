using System;
using System.Collections.Generic;

namespace BmSDK.Framework;

public static class MarshalUtil
{
    static readonly Dictionary<IntPtr, BaseObject> _managedObjects = [];

    // Marshals unmanaged data to managed, then returns it.
    public static unsafe TManaged MarshalToManaged<TManaged>(void* data)
    {
        // TODO: UStrProperty, UArrayProperty

        // Try to copy memory directly (for struct, primitive types)
        if (typeof(TManaged).IsValueType)
        {
            return MemUtil.Blit<TManaged>(data);
        }
        else if (typeof(TManaged).IsAssignableTo(typeof(BaseObject)))
        {
            var objPtr = MemUtil.Blit<IntPtr>(data);

            // We should already have wrappers for all objects.
            Guard.Require(
                _managedObjects.TryGetValue(objPtr, out var obj),
                $"No managed wrapper found for object at 0x{objPtr:X}"
            );
            return (TManaged)(object)Guard.NotNull(obj);
        }

        throw new NotImplementedException(
            $"Marshaling not implemented for type {typeof(TManaged).Name}"
        );
    }

    // Marshals a managed object to native, then copies it into an existing buffer.
    public static unsafe void MarshalToNative<TManaged>(TManaged value, void* data)
    {
        // TODO: UStrProperty, UArrayProperty

        // Try to copy memory directly (for struct, primitive types)
        if (typeof(TManaged).IsValueType)
        {
            MemUtil.Blit(value, data);
            return;
        }
        else if (typeof(TManaged).IsAssignableTo(typeof(BaseObject)))
        {
            // We already have a pointer to this object's native instance, so just assign it.
            MarshalToNative(((BaseObject)(object)value!).Ptr, data);
            return;
        }

        throw new NotImplementedException(
            $"Marshaling not implemented for type {typeof(TManaged).Name}"
        );
    }

    public static unsafe void CreateManagedWrapper(IntPtr objPtr, Type managedType)
    {
        Guard.Require(
            !_managedObjects.ContainsKey(objPtr),
            $"Object 0x{objPtr:X} already has a managed wrapper!"
        );

        // Create a new managed object
        var newObj = _managedObjects[objPtr] = Guard.NotNull(
            (BaseObject?)Activator.CreateInstance(managedType),
            $"Couldn't create an instance of managed type {managedType.Name}"
        );
        newObj.Ptr = objPtr;
    }

    public static unsafe void DestroyManagedWrapper(IntPtr objPtr)
    {
        Guard.Require(
            _managedObjects.Remove(objPtr),
            $"Object 0x{objPtr:X} does not have a managed wrapper!"
        );
    }
}
