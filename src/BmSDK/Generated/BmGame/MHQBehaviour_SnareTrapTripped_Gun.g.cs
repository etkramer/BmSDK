#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MHQBehaviour_SnareTrapTripped_Gun<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MHQBehaviour_SnareTrapTripped_Gun : BmSDK.BmGame.MHQBehaviour_SnareTrapTripped, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MHQBehaviour_SnareTrapTripped_Gun", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MHQBehaviour_SnareTrapTripped_Gun() { }

    /// <summary>
    /// Constructs a new MHQBehaviour_SnareTrapTripped_Gun
    /// </summary>
    public MHQBehaviour_SnareTrapTripped_Gun(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MHQBehaviour_SnareTrapTripped_Gun Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MHQBehaviour_SnareTrapTripped_Gun(nint ptr) : base(ptr) { }

    /// <summary>
    /// ClassProperty: DType
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// BoolProperty: bDontDropWeap
    /// </summary>
    public unsafe bool bDontDropWeap
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// BoolProperty: ExitTrapCalled
    /// </summary>
    public unsafe bool ExitTrapCalled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// BoolProperty: bOrigStasis
    /// </summary>
    public unsafe bool bOrigStasis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// BoolProperty: HitFrontOfThug
    /// </summary>
    public unsafe bool HitFrontOfThug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// BoolProperty: bUseAlternateAnim
    /// </summary>
    public unsafe bool bUseAlternateAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// StructProperty: HitNormal
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT HitNormal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// FloatProperty: TrappedTime
    /// </summary>
    public unsafe float TrappedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// FloatProperty: Timer
    /// </summary>
    public unsafe float Timer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// FloatProperty: OutAnimTime
    /// </summary>
    public unsafe float OutAnimTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// StructProperty: Transition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Transition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// ObjectProperty: ThugReactionAnimSet
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ThugReactionAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }
}
