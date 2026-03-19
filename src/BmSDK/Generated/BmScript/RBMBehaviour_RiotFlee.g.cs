#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMBehaviour_RiotFlee<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_RiotFlee : BmSDK.BmGame.RBMBehaviour_GangMovementBaseBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMBehaviour_RiotFlee", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_RiotFlee() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_RiotFlee
    /// </summary>
    public RBMBehaviour_RiotFlee(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_RiotFlee Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_RiotFlee(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: SavedAction
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SavedAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ObjectProperty: SavedThreat
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SavedThreat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ObjectProperty: PressPoint
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PressPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// StructProperty: GoalPos
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GoalPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// FloatProperty: SavedThreatDistance
    /// </summary>
    public unsafe float SavedThreatDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// StructProperty: PressPointLoc
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PressPointLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// IntProperty: PressPointAnimationIndex
    /// </summary>
    public unsafe int PressPointAnimationIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// FloatProperty: WaitTime
    /// </summary>
    public unsafe float WaitTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// BoolProperty: bDidRunAwayCheck
    /// </summary>
    public unsafe bool bDidRunAwayCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 832) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 832); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 832); }
    }

    /// <summary>
    /// FloatProperty: ChanceOfRunAway
    /// </summary>
    public unsafe float ChanceOfRunAway
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }
}
