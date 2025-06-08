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

    public unsafe TReturn? Invoke<TReturn>(UObject obj, object[] args)
    {
        // TODO: Use actual 'ReturnValue' property
        var returnSize = MarshalUtil.GetSizeUnmanaged<TReturn>();

        // Allocate locals
        Span<byte> localsData = stackalloc byte[PropertiesSize];
        localsData.Clear();

        {
            // TODO: Marshal params
        }

        // First param is "this" object
        var newStack = new FFrame(obj, this, 0, localsData);

        Span<byte> returnData = stackalloc byte[returnSize];
        fixed (byte* returnDataPtr = returnData)
        {
            // Use CallFunction() for simple native functions
            if (FunctionFlags.HasFlag(EFunctionFlags.FUNC_Native))
            {
                GameFunctions.CallFunction(
                    obj.Ptr,
                    (IntPtr)(&newStack),
                    (IntPtr)returnDataPtr,
                    Ptr
                );
            }
            // Let ProcessInternal() handle more complex logic for non-native functions
            else
            {
                GameFunctions.ProcessInternal(obj.Ptr, (IntPtr)(&newStack), (IntPtr)returnDataPtr);
            }

            Debug.Log(
                "returnData: "
                    + string.Join(" ", returnData.ToArray().Select(b => b.ToString("X2")))
            );
            return MarshalUtil.ToManaged<TReturn>(returnDataPtr);
        }
    }
}
