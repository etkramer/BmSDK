#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: TranslatorTag<br/>
/// (size = 52)
/// (flags = 134217874)
/// </summary>
public partial class TranslatorTag : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.TranslatorTag", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal TranslatorTag() { }

    /// <summary>
    /// Constructs a new TranslatorTag
    /// </summary>
    public TranslatorTag(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, TranslatorTag Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected TranslatorTag(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: Translate
    /// </summary>
    public unsafe virtual BmSDK.FString Translate(BmSDK.FString InArgument)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.TranslatorTag.Translate", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InArgument, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 12);
    }

    /// <summary>
    /// NameProperty: Tag
    /// </summary>
    public unsafe BmSDK.FName Tag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }
}
