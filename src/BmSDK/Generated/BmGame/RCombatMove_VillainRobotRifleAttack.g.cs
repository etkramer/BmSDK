#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCombatMove_VillainRobotRifleAttack<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RCombatMove_VillainRobotRifleAttack : BmSDK.BmGame.RCombatMove_VillainAttack, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCombatMove_VillainRobotRifleAttack", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCombatMove_VillainRobotRifleAttack() { }

    /// <summary>
    /// Constructs a new RCombatMove_VillainRobotRifleAttack
    /// </summary>
    public RCombatMove_VillainRobotRifleAttack(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCombatMove_VillainRobotRifleAttack Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCombatMove_VillainRobotRifleAttack(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainRobotRifleAttack>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainRobotRifleAttack>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainRobotRifleAttack>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainRobotRifleAttack>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainRobotRifleAttack>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainRobotRifleAttack>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainRobotRifleAttack>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// FloatProperty: AttackTimer
    /// </summary>
    public unsafe float AttackTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ObjectProperty: Gun
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Gun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// StructProperty: ReloadID
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ReloadID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }
}
