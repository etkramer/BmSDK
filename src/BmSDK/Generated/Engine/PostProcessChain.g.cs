#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: PostProcessChain<br/>
/// (size = 100)
/// (flags = 134217874)
/// </summary>
public partial class PostProcessChain : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.PostProcessChain", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal PostProcessChain() { }

    /// <summary>
    /// Constructs a new PostProcessChain
    /// </summary>
    public PostProcessChain(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, PostProcessChain Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected PostProcessChain(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: FindPostProcessEffect
    /// </summary>
    public unsafe BmSDK.Engine.PostProcessEffect FindPostProcessEffect(BmSDK.FName EffectName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.PostProcessChain.FindPostProcessEffect", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EffectName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PostProcessEffect>(paramsPtr + 8);
    }

    /// <summary>
    /// ArrayProperty: Effects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.PostProcessEffect> Effects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.PostProcessEffect>>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
