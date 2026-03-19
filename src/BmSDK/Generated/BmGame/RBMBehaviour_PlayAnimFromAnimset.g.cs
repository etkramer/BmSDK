#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_PlayAnimFromAnimset<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_PlayAnimFromAnimset : BmSDK.BmGame.RBMBehaviour, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_PlayAnimFromAnimset", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_PlayAnimFromAnimset() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_PlayAnimFromAnimset
    /// </summary>
    public RBMBehaviour_PlayAnimFromAnimset(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_PlayAnimFromAnimset Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_PlayAnimFromAnimset(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: AnimName
    /// </summary>
    public unsafe BmSDK.FName AnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// ObjectProperty: AnimSet
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// StructProperty: AnimId
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AnimId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// BoolProperty: bLoop
    /// </summary>
    public unsafe bool bLoop
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 608) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 608); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 608); }
    }

    /// <summary>
    /// BoolProperty: bDisableCollision
    /// </summary>
    public unsafe bool bDisableCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 608) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 608); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 608); }
    }

    /// <summary>
    /// BoolProperty: bMirror
    /// </summary>
    public unsafe bool bMirror
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 608) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 608); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 608); }
    }

    /// <summary>
    /// BoolProperty: bUnHide
    /// </summary>
    public unsafe bool bUnHide
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 608) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 608); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 608); }
    }

    /// <summary>
    /// NameProperty: DestMovementStance
    /// </summary>
    public unsafe BmSDK.FName DestMovementStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// NameProperty: DestWeaponStance
    /// </summary>
    public unsafe BmSDK.FName DestWeaponStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// IntProperty: ShowFrames
    /// </summary>
    public unsafe int ShowFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }
}
