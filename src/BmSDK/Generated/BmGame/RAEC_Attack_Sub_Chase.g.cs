#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAEC_Attack_Sub_Chase<br/>
/// (flags = 0)
/// </summary>
public partial class RAEC_Attack_Sub_Chase : BmSDK.BmGame.RAlertEventCoordinatorSolo, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAEC_Attack_Sub_Chase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAEC_Attack_Sub_Chase() { }

    /// <summary>
    /// Constructs a new RAEC_Attack_Sub_Chase
    /// </summary>
    public RAEC_Attack_Sub_Chase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAEC_Attack_Sub_Chase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAEC_Attack_Sub_Chase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_Sub_Chase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_Sub_Chase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_Sub_Chase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_Sub_Chase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_Sub_Chase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_Sub_Chase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Attack_Sub_Chase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: TargetChasePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RChasePoint TargetChasePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RChasePoint>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// ObjectProperty: ChaseRoot
    /// </summary>
    public unsafe BmSDK.BmGame.RChasePoint ChaseRoot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RChasePoint>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ObjectProperty: LadderLookNavHandle
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationHandle LadderLookNavHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// ObjectProperty: ExitPoints
    /// </summary>
    public unsafe BmSDK.BmGame.RExitPoints ExitPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RExitPoints>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// ObjectProperty: PauseAction
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIAction_PauseAtTopOfLadder PauseAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIAction_PauseAtTopOfLadder>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// ObjectProperty: PreChaseLocToTargetChaseNav
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationHandle PreChaseLocToTargetChaseNav
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// FloatProperty: PreChaseLocToChaseRootDist
    /// </summary>
    public unsafe float PreChaseLocToChaseRootDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bIntercepting
    /// </summary>
    public unsafe bool bIntercepting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bExitEarlyIfCanSeeGoal
    /// </summary>
    public unsafe bool bExitEarlyIfCanSeeGoal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// StructProperty: LadderForward
    /// </summary>
    public unsafe System.Numerics.Vector3 LadderForward
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }
}
