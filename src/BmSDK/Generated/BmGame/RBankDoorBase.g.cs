#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBankDoorBase<br/>
/// (flags = 0)
/// </summary>
public partial class RBankDoorBase : BmSDK.Engine.NavMeshObstacle, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBankDoorBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBankDoorBase() { }

    /// <summary>
    /// Constructs a new RBankDoorBase
    /// </summary>
    public RBankDoorBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBankDoorBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBankDoorBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBankDoorBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBankDoorBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBankDoorBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBankDoorBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBankDoorBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBankDoorBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBankDoorBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: VfTable_IInterface_NavMeshPathObject
    /// </summary>
    public unsafe System.IntPtr VfTable_IInterface_NavMeshPathObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// ComponentProperty: SkeletalMeshComp
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent SkeletalMeshComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// StructProperty: movement_ClosedToOpen
    /// </summary>
    public unsafe System.Numerics.Vector3 movement_ClosedToOpen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// FloatProperty: TransitionDuration
    /// </summary>
    public unsafe float TransitionDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// ObjectProperty: controlPanelFront
    /// </summary>
    public unsafe BmSDK.BmGame.RBankDoorControlPanelBase controlPanelFront
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBankDoorControlPanelBase>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ObjectProperty: controlPanelRear
    /// </summary>
    public unsafe BmSDK.BmGame.RBankDoorControlPanelBase controlPanelRear
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBankDoorControlPanelBase>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ObjectProperty: lockingPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawn lockingPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawn>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ObjectProperty: SeqAct
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_BankDoorControl SeqAct
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_BankDoorControl>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ObjectProperty: AnimNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence AnimNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ObjectProperty: AnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet AnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ObjectProperty: XrayMat
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant XrayMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ComponentProperty: arrowComp
    /// </summary>
    public unsafe BmSDK.Engine.ArrowComponent arrowComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ArrowComponent>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bOpening
    /// </summary>
    public unsafe bool bOpening
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bClosing
    /// </summary>
    public unsafe bool bClosing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bClosed
    /// </summary>
    public unsafe bool bClosed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bBlownUp
    /// </summary>
    public unsafe bool bBlownUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bLastQueriedFromFront
    /// </summary>
    public unsafe bool bLastQueriedFromFront
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: requiresDiscoveryBark
    /// </summary>
    public unsafe bool requiresDiscoveryBark
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bDbgDrawNavCutting
    /// </summary>
    public unsafe bool bDbgDrawNavCutting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// FloatProperty: openProportion
    /// </summary>
    public unsafe float openProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// FloatProperty: NavBlockerScale
    /// </summary>
    public unsafe float NavBlockerScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// FloatProperty: forwardDirectionExtraYawDegrees
    /// </summary>
    public unsafe float forwardDirectionExtraYawDegrees
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// NameProperty: blastedOpenAnim
    /// </summary>
    public unsafe BmSDK.FName blastedOpenAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// NameProperty: barkFlagName
    /// </summary>
    public unsafe BmSDK.FName barkFlagName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }
}
