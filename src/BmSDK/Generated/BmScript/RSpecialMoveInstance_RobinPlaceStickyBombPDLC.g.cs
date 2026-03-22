#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveInstance_RobinPlaceStickyBombPDLC<br/>
/// (size = 792)
/// (flags = 8388626)
/// </summary>
public partial class RSpecialMoveInstance_RobinPlaceStickyBombPDLC : BmSDK.BmScript.RSpecialMoveInstance_RobinPlaceStickyBomb, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveInstance_RobinPlaceStickyBombPDLC", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveInstance_RobinPlaceStickyBombPDLC() { }

    /// <summary>
    /// Constructs a new RSpecialMoveInstance_RobinPlaceStickyBombPDLC
    /// </summary>
    public RSpecialMoveInstance_RobinPlaceStickyBombPDLC(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveInstance_RobinPlaceStickyBombPDLC Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveInstance_RobinPlaceStickyBombPDLC(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_RobinPlaceStickyBombPDLC>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_RobinPlaceStickyBombPDLC>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_RobinPlaceStickyBombPDLC>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_RobinPlaceStickyBombPDLC>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_RobinPlaceStickyBombPDLC>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_RobinPlaceStickyBombPDLC>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_RobinPlaceStickyBombPDLC>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: PlaceBomb
    /// </summary>
    public unsafe override void PlaceBomb()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_RobinPlaceStickyBombPDLC.PlaceBomb", true);
        byte* paramsPtr = stackalloc byte[160];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CancelSpecialMove
    /// </summary>
    public unsafe override void CancelSpecialMove(BmSDK.BmGame.RSpecialMoveConfig NextSpecialMove)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_RobinPlaceStickyBombPDLC.CancelSpecialMove", true);
        byte* paramsPtr = stackalloc byte[248];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextSpecialMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateSpecialMove
    /// </summary>
    public unsafe override bool UpdateSpecialMove(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_RobinPlaceStickyBombPDLC.UpdateSpecialMove", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: TriggerSpecialMove
    /// </summary>
    public unsafe override void TriggerSpecialMove(BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator MoveLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_RobinPlaceStickyBombPDLC.TriggerSpecialMove", true);
        byte* paramsPtr = stackalloc byte[376];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: DummyTarget
    /// </summary>
    public unsafe BmSDK.BmScript.RRobinStickyBombTarget DummyTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RRobinStickyBombTarget>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }
}
