#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_MovePlayer<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_MovePlayer : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_MovePlayer", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_MovePlayer() { }

    /// <summary>
    /// Constructs a new RSeqAct_MovePlayer
    /// </summary>
    public RSeqAct_MovePlayer(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_MovePlayer Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_MovePlayer(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: LookAtActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LookAtActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// ObjectProperty: MoveToActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MoveToActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// ObjectProperty: CharacterToMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CharacterToMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// ObjectProperty: StoredController
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT StoredController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// StructProperty: StoredLookAtDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StoredLookAtDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// BoolProperty: bIsAtLocation
    /// </summary>
    public unsafe bool bIsAtLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bHasBeenToldAboutReachingDest
    /// </summary>
    public unsafe bool bHasBeenToldAboutReachingDest
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bQueuedMove
    /// </summary>
    public unsafe bool bQueuedMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bCinematicMode
    /// </summary>
    public unsafe bool bCinematicMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bNewMoveToMode
    /// </summary>
    public unsafe bool bNewMoveToMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bLockedInput
    /// </summary>
    public unsafe bool bLockedInput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bKeepTryingToMove
    /// </summary>
    public unsafe bool bKeepTryingToMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bRun
    /// </summary>
    public unsafe bool bRun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bBotWaitAtGoal
    /// </summary>
    public unsafe bool bBotWaitAtGoal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bAllowRemainInZoom
    /// </summary>
    public unsafe bool bAllowRemainInZoom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// FloatProperty: MoveSpeedModifier
    /// </summary>
    public unsafe float MoveSpeedModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }
}
