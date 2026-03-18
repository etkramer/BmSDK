#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AICommandNodeBase<br/>
/// (size = 84)
/// (flags = 134217874)
/// </summary>
public partial class AICommandNodeBase : BmSDK.Engine.K2NodeBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AICommandNodeBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AICommandNodeBase() { }

    /// <summary>
    /// Constructs a new AICommandNodeBase
    /// </summary>
    public AICommandNodeBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AICommandNodeBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AICommandNodeBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: SelectBestChild
    /// </summary>
    public unsafe virtual BmSDK.Engine.AICommandNodeBase SelectBestChild(BmSDK.Engine.AIController InAI, out BmSDK.Engine.AITree.FAITreeHandle Handle)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AICommandNodeBase.SelectBestChild", true);
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InAI, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Handle = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AITree.FAITreeHandle>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AICommandNodeBase>(paramsPtr + 52);
    }

    /// <summary>
    /// ClassProperty: CommandClass
    /// </summary>
    public unsafe BmSDK.Class CommandClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 76); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }
    }

    /// <summary>
    /// ObjectProperty: UtilityDMC
    /// </summary>
    public unsafe BmSDK.Engine.DMC_Prototype UtilityDMC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DMC_Prototype>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }
}
