#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_HeavyTankTracker<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_HeavyTankTracker : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_HeavyTankTracker", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_HeavyTankTracker() { }

    /// <summary>
    /// Constructs a new RSeqAct_HeavyTankTracker
    /// </summary>
    public RSeqAct_HeavyTankTracker(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_HeavyTankTracker Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_HeavyTankTracker(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: ValueToSetAtRange1
    /// </summary>
    public unsafe float ValueToSetAtRange1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// FloatProperty: ValueToSetAtRange2
    /// </summary>
    public unsafe float ValueToSetAtRange2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// FloatProperty: ValueToSetOnMissileLockOn
    /// </summary>
    public unsafe float ValueToSetOnMissileLockOn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// ObjectProperty: ParameterToSet
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ParameterToSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// BoolProperty: Tracking
    /// </summary>
    public unsafe bool Tracking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 396) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 396); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 396); }
    }

    /// <summary>
    /// BoolProperty: Range1
    /// </summary>
    public unsafe bool Range1
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 396) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 396); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 396); }
    }

    /// <summary>
    /// BoolProperty: Range2
    /// </summary>
    public unsafe bool Range2
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 396) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 396); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 396); }
    }

    /// <summary>
    /// BoolProperty: SetRange1
    /// </summary>
    public unsafe bool SetRange1
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 396) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 396); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 396); }
    }

    /// <summary>
    /// BoolProperty: SetRange2
    /// </summary>
    public unsafe bool SetRange2
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 396) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 396); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 396); }
    }

    /// <summary>
    /// BoolProperty: SetZero
    /// </summary>
    public unsafe bool SetZero
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 396) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 396); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 396); }
    }

    /// <summary>
    /// StructProperty: MissileLockTime
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MissileLockTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }
}
