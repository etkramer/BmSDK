#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: AkSDTrigger<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AkSDTrigger : BmSDK.AkAudio.AkSDNode, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.AkSDTrigger", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkSDTrigger() { }

    /// <summary>
    /// Constructs a new AkSDTrigger
    /// </summary>
    public AkSDTrigger(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkSDTrigger Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkSDTrigger(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: VfTable_AkEvaluate
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VfTable_AkEvaluate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// ObjectProperty: Props
    /// </summary>
    public unsafe BmSDK.AkAudio.AkSDNode.VariableNodes Props
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.AkSDNode.VariableNodes>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// FloatProperty: cachedEvaluation
    /// </summary>
    public unsafe float cachedEvaluation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }
}
