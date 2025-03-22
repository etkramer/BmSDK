using System;

namespace BmSDK.Framework;

public static class MarshalUtil
{
    // Marshals unmanaged data to managed, then returns it.
    public static unsafe TManaged MarshalToManaged<TManaged>(void* data)
    {
        // TODO: UStrProperty, UArrayProperty
        // TODO 2: UObjectProperty (still incomplete)

        // Try to copy memory directly (for struct, primitive types)
        if (typeof(TManaged).IsValueType)
        {
            return MemUtil.Blit<TManaged>(data);
        }
        else if (typeof(TManaged).IsAssignableTo(typeof(UObject)))
        {
            // TODO: Should check if we already have a managed class associated with
            // this object pointer, then either return it or create a new one.

            // NOTE: Will want to check UObject.Class, not just assume TManaged is as specific as possible.

            var obj = Guard.NotNull((UObject?)(object?)Activator.CreateInstance<TManaged>(), $"Couldn't create a managed instance of {typeof(TManaged).Name}");
            obj.Ptr = MemUtil.Blit<IntPtr>(data);

            return (TManaged)(object)obj;
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