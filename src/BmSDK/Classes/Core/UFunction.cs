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

    struct FOutParmRec
    {
        public IntPtr Property;
        public IntPtr PropAddr;
        public IntPtr NextOutParm;
    }

    // REMOVE ME! We're *only* replacing ProcessEvent() with InvokeInternal()
    public unsafe TReturn? Invoke<TReturn>(UObject obj, object[] args)
    {
        // Allocate parms
        Span<byte> parmsData = stackalloc byte[PropertiesSize];
        parmsData.Clear();

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
            fixed (byte* parmsDataPtr = parmsData)
            {
                MarshalUtil.ToUnmanaged2(
                    args[paramIdx],
                    args[paramIdx] is null ? typeof(UObject) : args[paramIdx].GetType(),
                    parmsDataPtr + prop.Offset
                );
            }

            Debug.Log($"Found param {prop}");
            paramIdx++;
        }

        Span<byte> returnData =
            stackalloc byte[returnProp is null ? 0 : MarshalUtil.GetSizeUnmanaged<TReturn>()];

        InvokeInternal(obj, parmsData, parmsData[(returnProp?.Offset ?? 0)..]);
        fixed (byte* returnDataPtr = returnData)
        {
            Debug.Log(
                "return: " + string.Join(" ", parmsData.ToArray().Select(b => b.ToString("X2")))
            );

            return returnProp is null ? default : MarshalUtil.ToManaged<TReturn>(returnDataPtr);
        }
    }

    public unsafe void InvokeInternal(UObject obj, Span<byte> parms, Span<byte> returnParm)
    {
        // Allocate locals
        Span<byte> localsData = stackalloc byte[PropertiesSize];
        localsData.Clear();

        // Copy parms to locals
        parms.CopyTo(localsData);

        // Create stack frame
        var newStack = new FFrame(obj, this, 0, localsData);

        // Collect params marked 'out'
        var outParms = EnumerateFields()
            .OfType<UProperty>()
            .Where(prop => prop.PropertyFlags.HasFlag(UProperty.EPropertyFlags.CPF_OutParm))
            .ToList();

        // Params marked 'out' need special handling, do that now
        if (outParms.Count > 0)
        {
            var lastOut = (FOutParmRec**)&newStack.OutParms;
            var outParmRecs = stackalloc FOutParmRec[outParms.Count];
            for (var i = 0; i < outParms.Count; i++)
            {
                var outParm = outParms[i];
                FOutParmRec* outRec = &outParmRecs[i];
                fixed (byte* outParmPtr = parms[outParm.Offset..])
                {
                    outRec->PropAddr = (IntPtr)outParmPtr;
                    outRec->Property = outParm.Ptr;
                    if (*lastOut != null)
                    {
                        (*lastOut)->NextOutParm = (IntPtr)outRec;
                        lastOut = (FOutParmRec**)&(*lastOut)->NextOutParm;
                    }
                    else
                    {
                        *lastOut = outRec;
                    }
                }
            }
        }

        {
            // TODO: Assign default values for optional params
        }

        Debug.Log(
            "locals (before): "
                + string.Join(" ", localsData.ToArray().Select(b => b.ToString("X2")))
        );

        fixed (byte* returnParmPtr = returnParm)
        {
            // Use CallFunction() for simple native functions
            if (FunctionFlags.HasFlag(EFunctionFlags.FUNC_Native))
            {
                GameFunctions.CallFunction(
                    obj.Ptr,
                    (IntPtr)(&newStack),
                    (IntPtr)returnParmPtr,
                    Ptr
                );
            }
            // Let ProcessInternal() handle more complex logic for non-native functions
            else
            {
                GameFunctions.ProcessInternal(obj.Ptr, (IntPtr)(&newStack), (IntPtr)returnParmPtr);
            }
        }

        Debug.Log(
            "locals (after): "
                + string.Join(" ", localsData.ToArray().Select(b => b.ToString("X2")))
        );
    }

    // public unsafe TReturn? Invoke<TReturn>(UObject obj, object[] args)
    // {
    //     // Allocate locals
    //     Span<byte> localsData = stackalloc byte[PropertiesSize];
    //     localsData.Clear();

    //     // First param is "this" object
    //     var newStack = new FFrame(obj, this, 0, localsData);

    //     // Enumerate function fields (locals and args)
    //     var paramIdx = 0;
    //     UProperty? returnProp = null;
    //     for (UField fieldLink = Children; fieldLink != null; fieldLink = fieldLink.Next)
    //     {
    //         // Skip non-property fields (these probably don't exist?)
    //         if (fieldLink is not UProperty prop)
    //         {
    //             continue;
    //         }

    //         // Skip non-param properties (these are local variables)
    //         if (!prop.PropertyFlags.HasFlag(UProperty.EPropertyFlags.CPF_Parm))
    //         {
    //             continue;
    //         }

    //         // Mark (and don't marshal) return properties
    //         if (prop.PropertyFlags.HasFlag(UProperty.EPropertyFlags.CPF_ReturnParm))
    //         {
    //             Debug.Log($"Found return prop {prop}");
    //             returnProp = prop;
    //             continue;
    //         }

    //         // Special handling for out params
    //         if (prop.PropertyFlags.HasFlag(UProperty.EPropertyFlags.CPF_OutParm))
    //         {
    //             var lastOut = (FOutParmRec**)newStack.OutParms.ToPointer();
    //             var newOut = default(FOutParmRec);
    //             newOut.PropAddr =

    //             if (*lastOut != null)
    //             {
    //                 *lastOut->NextOutParm
    //             }
    //         }

    //         // For all other property types, marshal them
    //         fixed (byte* localsDataPtr = localsData)
    //         {
    //             MarshalUtil.ToUnmanaged2(
    //                 args[paramIdx],
    //                 args[paramIdx] is null ? typeof(UObject) : args[paramIdx].GetType(),
    //                 localsDataPtr + prop.Offset
    //             );
    //         }

    //         Debug.Log($"Found param {prop}");
    //         paramIdx++;
    //     }

    //     Debug.Log(
    //         "locals: " + string.Join(" ", localsData.ToArray().Select(b => b.ToString("X2")))
    //     );

    //     Span<byte> returnData =
    //         stackalloc byte[returnProp is null ? 0 : MarshalUtil.GetSizeUnmanaged<TReturn>()];
    //     fixed (byte* returnDataPtr = returnData)
    //     {
    //         // Use CallFunction() for simple native functions
    //         if (FunctionFlags.HasFlag(EFunctionFlags.FUNC_Native))
    //         {
    //             GameFunctions.CallFunction(
    //                 obj.Ptr,
    //                 (IntPtr)(&newStack),
    //                 (IntPtr)returnDataPtr,
    //                 Ptr
    //             );
    //         }
    //         // Let ProcessInternal() handle more complex logic for non-native functions
    //         else
    //         {
    //             GameFunctions.ProcessInternal(obj.Ptr, (IntPtr)(&newStack), (IntPtr)returnDataPtr);
    //         }

    //         Debug.Log(
    //             "return: " + string.Join(" ", returnData.ToArray().Select(b => b.ToString("X2")))
    //         );

    //         return returnProp is null ? default : MarshalUtil.ToManaged<TReturn>(returnDataPtr);
    //     }
    // }
}
