#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveConfig_CarryPerson<br/>
/// (size = 368)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_CarryPerson : BmSDK.BmGame.RSpecialMoveConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveConfig_CarryPerson", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_CarryPerson() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_CarryPerson
    /// </summary>
    public RSpecialMoveConfig_CarryPerson(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_CarryPerson Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_CarryPerson(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: BlendInMeetingPoint
    /// </summary>
    public unsafe float BlendInMeetingPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// FloatProperty: MaxTurnRate
    /// </summary>
    public unsafe float MaxTurnRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// BoolProperty: DropPerson
    /// </summary>
    public unsafe bool DropPerson
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 304) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 304); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 304); }
    }

    /// <summary>
    /// ObjectProperty: AnimSetPlayer
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet AnimSetPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// ObjectProperty: AnimSetOtherPerson
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet AnimSetOtherPerson
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// NameProperty: PickupAnimName
    /// </summary>
    public unsafe BmSDK.FName PickupAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// NameProperty: IdleAnimName
    /// </summary>
    public unsafe BmSDK.FName IdleAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// NameProperty: IdleToWalkAnimName
    /// </summary>
    public unsafe BmSDK.FName IdleToWalkAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// NameProperty: WalkAnimName
    /// </summary>
    public unsafe BmSDK.FName WalkAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// NameProperty: WalkToIdleAnimName
    /// </summary>
    public unsafe BmSDK.FName WalkToIdleAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// NameProperty: DropAnimName
    /// </summary>
    public unsafe BmSDK.FName DropAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// FloatProperty: DropAnimEndTimeSeconds
    /// </summary>
    public unsafe float DropAnimEndTimeSeconds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }
}
