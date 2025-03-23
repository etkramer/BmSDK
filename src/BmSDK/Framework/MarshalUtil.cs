using System;
using System.Collections.Generic;

namespace BmSDK.Framework;

public static class MarshalUtil
{
    static readonly Dictionary<IntPtr, UObject> _managedObjects = [];

    // Marshals unmanaged data to managed, then returns it.
    public static unsafe TManaged MarshalToManaged<TManaged>(void* data)
    {
        // TODO: UStrProperty, UArrayProperty

        // Try to copy memory directly (for struct, primitive types)
        if (typeof(TManaged).IsValueType)
        {
            return MemUtil.Blit<TManaged>(data);
        }
        else if (typeof(TManaged).IsAssignableTo(typeof(UObject)))
        {
            var objPtr = MemUtil.Blit<IntPtr>(data);

            // Does this already have a managed wrapper?
            if (_managedObjects.TryGetValue(objPtr, out var obj))
            {
                // If so, return it
                return (TManaged)(object)obj;
            }
            else
            {
                // TODO: We want to check UObject.Class, not just assume TManaged is as specific as possible.
                var objType = typeof(TManaged);

                // Create a new managed object
                var newObj = _managedObjects[objPtr] = Guard.NotNull((UObject?)Activator.CreateInstance(objType), $"Couldn't create an instance of managed type {objType.Name}");
                newObj.Ptr = MemUtil.Blit<IntPtr>(data);

                return (TManaged)(object)newObj;
            }
        }

        throw new NotImplementedException($"Marshaling not implemented for type {typeof(TManaged).Name}");
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
        else if (typeof(TManaged).IsAssignableTo(typeof(UObject)))
        {
            // We already have a pointer to this object's native instance, so just assign it.
            MarshalToNative(((UObject)(object)value!).Ptr, data);
            return;
        }

        throw new NotImplementedException($"Marshaling not implemented for type {typeof(TManaged).Name}");
    }
}