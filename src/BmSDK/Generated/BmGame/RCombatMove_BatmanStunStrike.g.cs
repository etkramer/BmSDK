#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCombatMove_BatmanStunStrike<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RCombatMove_BatmanStunStrike : BmSDK.BmGame.RCombatMove_BatmanStrike, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCombatMove_BatmanStunStrike", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCombatMove_BatmanStunStrike() { }

    /// <summary>
    /// Constructs a new RCombatMove_BatmanStunStrike
    /// </summary>
    public RCombatMove_BatmanStunStrike(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCombatMove_BatmanStunStrike Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCombatMove_BatmanStunStrike(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStunStrike>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStunStrike>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStunStrike>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStunStrike>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStunStrike>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStunStrike>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_BatmanStunStrike>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// BoolProperty: bIsStunning
    /// </summary>
    public unsafe bool bIsStunning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1564); }
    }

    /// <summary>
    /// BoolProperty: bRegisteredAction
    /// </summary>
    public unsafe bool bRegisteredAction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1564); }
    }

    /// <summary>
    /// BoolProperty: bStunPropInLeftHand
    /// </summary>
    public unsafe bool bStunPropInLeftHand
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1564); }
    }

    /// <summary>
    /// BoolProperty: bForceSuperStun
    /// </summary>
    public unsafe bool bForceSuperStun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1564); }
    }

    /// <summary>
    /// BoolProperty: bCanDoSuperStun
    /// </summary>
    public unsafe bool bCanDoSuperStun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1564); }
    }

    /// <summary>
    /// BoolProperty: bOnlyHitTarget
    /// </summary>
    public unsafe bool bOnlyHitTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1564); }
    }

    /// <summary>
    /// BoolProperty: bChargedUp
    /// </summary>
    public unsafe bool bChargedUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1564); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1564); }
    }

    /// <summary>
    /// FloatProperty: CurrStunAngle
    /// </summary>
    public unsafe float CurrStunAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1568); }
    }

    /// <summary>
    /// FloatProperty: CurrStunTime
    /// </summary>
    public unsafe float CurrStunTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1572); }
    }

    /// <summary>
    /// FloatProperty: TotalStunTime
    /// </summary>
    public unsafe float TotalStunTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1576); }
    }

    /// <summary>
    /// IntProperty: StunAngleDir
    /// </summary>
    public unsafe int StunAngleDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1580); }
    }

    /// <summary>
    /// FloatProperty: MinStunRadius
    /// </summary>
    public unsafe float MinStunRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1584); }
    }

    /// <summary>
    /// FloatProperty: MaxStunRadius
    /// </summary>
    public unsafe float MaxStunRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1588); }
    }

    /// <summary>
    /// FloatProperty: MaxStunAngle
    /// </summary>
    public unsafe float MaxStunAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1592); }
    }

    /// <summary>
    /// ComponentProperty: StunPropComponent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT StunPropComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1596); }
    }

    /// <summary>
    /// IntProperty: ConsecutiveStuns
    /// </summary>
    public unsafe int ConsecutiveStuns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1604); }
    }
}
