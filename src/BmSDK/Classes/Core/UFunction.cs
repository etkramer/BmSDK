using BmSDK.Framework;

namespace BmSDK;

public partial class UFunction
{
    [Flags]
    public enum EFunctionFlags
    {
        FUNC_Defined = 0x2,
        FUNC_Iterator = 0x4,
        FUNC_Native = 0x400,
        FUNC_Event = 0x800,
        FUNC_Operator = 0x1000,
        FUNC_Static = 0x2000,
    }

    /// <summary>
    /// Property: FunctionFlags
    /// </summary>
    public EFunctionFlags FunctionFlags
    {
        get => MarshalUtil.ToManaged<EFunctionFlags>(Ptr + 108);
        set => SetPropertyValue(this, 108, value);
    }

    /// <summary>
    /// Property: iNative
    /// </summary>
    public ushort iNative
    {
        get => MarshalUtil.ToManaged<ushort>(Ptr + 112);
        set => SetPropertyValue(this, 112, value);
    }

    public unsafe TReturn? Invoke<TReturn>(UObject? self, params object[] args)
    {
        // Allocate locals
        Span<byte> localsData = stackalloc byte[PropertiesSize];
        localsData.Clear();
        Debug.Log($"Locals size: {localsData.Length}");

        {
            // TODO: Marshal params
        }

        // First param is "this" object - null because this is a static call.
        var frame = new FFrame(self, this, 0, localsData, null);

        // TODO: Don't hardcode me
        Span<byte> returnData = stackalloc byte[MarshalUtil.GetSizeUnmanaged<TReturn>()];
        fixed (byte* returnDataPtr = returnData)
        {
            GameFunctions.CallFunction(
                self?.Ptr ?? 0,
                (IntPtr)(&frame),
                (IntPtr)returnDataPtr,
                Ptr
            );

            Debug.Log(string.Join(" ", returnData.ToArray().Select(b => b.ToString("X2"))));
            return MarshalUtil.ToManaged<TReturn>(returnDataPtr);
        }
    }
}
