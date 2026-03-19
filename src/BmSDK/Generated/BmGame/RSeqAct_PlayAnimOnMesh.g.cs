#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_PlayAnimOnMesh<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_PlayAnimOnMesh : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_PlayAnimOnMesh", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_PlayAnimOnMesh() { }

    /// <summary>
    /// Constructs a new RSeqAct_PlayAnimOnMesh
    /// </summary>
    public RSeqAct_PlayAnimOnMesh(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_PlayAnimOnMesh Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_PlayAnimOnMesh(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Mesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Mesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// ObjectProperty: AnimationSet
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AnimationSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// ObjectProperty: SyncPawn
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SyncPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// StrProperty: AnimName
    /// </summary>
    public unsafe BmSDK.FString AnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// BoolProperty: bForceStop
    /// </summary>
    public unsafe bool bForceStop
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 416); }
    }

    /// <summary>
    /// BoolProperty: bLooping
    /// </summary>
    public unsafe bool bLooping
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 416); }
    }

    /// <summary>
    /// BoolProperty: DisableStasisOnTargetWhenPlayed
    /// </summary>
    public unsafe bool DisableStasisOnTargetWhenPlayed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 416); }
    }

    /// <summary>
    /// BoolProperty: bPlayingInSlotTwo
    /// </summary>
    public unsafe bool bPlayingInSlotTwo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 416); }
    }

    /// <summary>
    /// BoolProperty: bLeaveDestructibleUnregisteredOnNavMesh
    /// </summary>
    public unsafe bool bLeaveDestructibleUnregisteredOnNavMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 416); }
    }

    /// <summary>
    /// FloatProperty: LastPosition
    /// </summary>
    public unsafe float LastPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// FloatProperty: BlendTime
    /// </summary>
    public unsafe float BlendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }
}
