#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMExitCondition<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMExitCondition : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMExitCondition", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMExitCondition() { }

    /// <summary>
    /// Constructs a new RBMExitCondition
    /// </summary>
    public RBMExitCondition(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMExitCondition Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMExitCondition(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: TargetPawn
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TargetPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// ObjectProperty: HostPawn
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HostPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// ObjectProperty: HostController
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HostController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// ObjectProperty: AIManager
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AIManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// ObjectProperty: ControllingBehaviour
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ControllingBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// ObjectProperty: ExitConCombiner
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ExitConCombiner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// BoolProperty: bConditionTriggered
    /// </summary>
    public unsafe bool bConditionTriggered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 424); }
    }

    /// <summary>
    /// BoolProperty: bExitConditionActive
    /// </summary>
    public unsafe bool bExitConditionActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 424); }
    }

    /// <summary>
    /// BoolProperty: bExitConditionFailedActivation
    /// </summary>
    public unsafe bool bExitConditionFailedActivation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 424); }
    }

    /// <summary>
    /// BoolProperty: bStreamedOut
    /// </summary>
    public unsafe bool bStreamedOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 424); }
    }

    /// <summary>
    /// BoolProperty: HasUsedRandomActivation
    /// </summary>
    public unsafe bool HasUsedRandomActivation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 424); }
    }

    /// <summary>
    /// BoolProperty: bTickWhileHostInStasis
    /// </summary>
    public unsafe bool bTickWhileHostInStasis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 424); }
    }

    /// <summary>
    /// NameProperty: SyncExitConditionsName
    /// </summary>
    public unsafe BmSDK.FName SyncExitConditionsName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// FloatProperty: RandomActivationTime
    /// </summary>
    public unsafe float RandomActivationTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

    /// <summary>
    /// FloatProperty: RandomActivationTimeLeft
    /// </summary>
    public unsafe float RandomActivationTimeLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }
}
