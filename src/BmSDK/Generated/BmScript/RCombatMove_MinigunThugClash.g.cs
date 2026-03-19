#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCombatMove_MinigunThugClash<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RCombatMove_MinigunThugClash : BmSDK.BmGame.RCombatMove_VillainClash, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCombatMove_MinigunThugClash", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCombatMove_MinigunThugClash() { }

    /// <summary>
    /// Constructs a new RCombatMove_MinigunThugClash
    /// </summary>
    public RCombatMove_MinigunThugClash(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCombatMove_MinigunThugClash Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCombatMove_MinigunThugClash(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_MinigunThugClash>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_MinigunThugClash>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_MinigunThugClash>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_MinigunThugClash>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_MinigunThugClash>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_MinigunThugClash>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_MinigunThugClash>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: MinigunTg
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MinigunTg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// ObjectProperty: MinigunTgBehaviour
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MinigunTgBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// ArrayProperty: CamStartTime
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>> CamStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }
}
