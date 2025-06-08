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

        // Enumerate function fields (locals and args)
        var paramIdx = 0;
        UProperty? returnProp = null;
        for (UField fieldLink = Children; fieldLink != null; fieldLink = fieldLink.Next)
        {
            // Skip non-property fields (these probably don't exist?)
            if (fieldLink is not UProperty prop)
            {
                continue;
            }

            // Skip non-param properties (these are local variables)
            if (!prop.PropertyFlags.HasFlag(UProperty.EPropertyFlags.CPF_Parm))
            {
                continue;
            }

            // Mark (and don't marshal) return properties
            if (prop.PropertyFlags.HasFlag(UProperty.EPropertyFlags.CPF_ReturnParm))
            {
                Debug.Log($"Found return prop {prop}");
                returnProp = prop;
                continue;
            }

            // For all other property types, marshal them
            fixed (byte* localsDataPtr = localsData)
            {
                MarshalUtil.ToUnmanaged2(
                    args[paramIdx],
                    args[paramIdx] is null ? typeof(UObject) : args[paramIdx].GetType(),
                    localsDataPtr + prop.Offset
                );
            }

            Debug.Log($"Found param {prop}");
            paramIdx++;
        }

        // First param is "this" object
        var newStack = new FFrame(obj, this, 0, localsData);

        Debug.Log(
            "locals: " + string.Join(" ", localsData.ToArray().Select(b => b.ToString("X2")))
        );

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
                "return: " + string.Join(" ", returnData.ToArray().Select(b => b.ToString("X2")))
            );
            return MarshalUtil.ToManaged<TReturn>(returnDataPtr);
        }
    }
}
