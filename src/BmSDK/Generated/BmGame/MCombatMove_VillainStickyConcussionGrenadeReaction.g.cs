#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MCombatMove_VillainStickyConcussionGrenadeReaction<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MCombatMove_VillainStickyConcussionGrenadeReaction : BmSDK.BmGame.RCombatMove_VillainAttack, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MCombatMove_VillainStickyConcussionGrenadeReaction", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MCombatMove_VillainStickyConcussionGrenadeReaction() { }

    /// <summary>
    /// Constructs a new MCombatMove_VillainStickyConcussionGrenadeReaction
    /// </summary>
    public MCombatMove_VillainStickyConcussionGrenadeReaction(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MCombatMove_VillainStickyConcussionGrenadeReaction Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MCombatMove_VillainStickyConcussionGrenadeReaction(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MCombatMove_VillainStickyConcussionGrenadeReaction>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MCombatMove_VillainStickyConcussionGrenadeReaction>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MCombatMove_VillainStickyConcussionGrenadeReaction>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MCombatMove_VillainStickyConcussionGrenadeReaction>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MCombatMove_VillainStickyConcussionGrenadeReaction>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MCombatMove_VillainStickyConcussionGrenadeReaction>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MCombatMove_VillainStickyConcussionGrenadeReaction>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: RifleWeaponAnimSet
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RifleWeaponAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ObjectProperty: SmokeReactionAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SmokeReactionAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// ObjectProperty: HitReactionAnimSet
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HitReactionAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ClassProperty: SmokeDamageType
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SmokeDamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// StructProperty: ExplodedFrom
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ExplodedFrom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// FloatProperty: StunTime
    /// </summary>
    public unsafe float StunTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// FloatProperty: TotalStunTime
    /// </summary>
    public unsafe float TotalStunTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// ByteProperty: CurrCounterLimb
    /// </summary>
    public unsafe byte CurrCounterLimb
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// NameProperty: CurrStrikeBone
    /// </summary>
    public unsafe BmSDK.FName CurrStrikeBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// StructProperty: LastHitDmgInfo
    /// </summary>
    public unsafe BmSDK.BmGame.MCombatMove_VillainStickyConcussionGrenadeReaction.HitTargets LastHitDmgInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MCombatMove_VillainStickyConcussionGrenadeReaction.HitTargets>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// ArrayProperty: HitTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>> HitTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// NameProperty: MovementStanceName
    /// </summary>
    public unsafe BmSDK.FName MovementStanceName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// NameProperty: WeaponStanceName
    /// </summary>
    public unsafe BmSDK.FName WeaponStanceName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }
}
