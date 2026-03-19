#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnVillainCombatExpertBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RPawnVillainCombatExpertBase : BmSDK.BmGame.RPawnVillainNinjaBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnVillainCombatExpertBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnVillainCombatExpertBase() { }

    /// <summary>
    /// Constructs a new RPawnVillainCombatExpertBase
    /// </summary>
    public RPawnVillainCombatExpertBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnVillainCombatExpertBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnVillainCombatExpertBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainCombatExpertBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainCombatExpertBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainCombatExpertBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainCombatExpertBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainCombatExpertBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainCombatExpertBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainCombatExpertBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: CECombatAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CECombatAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 6724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6724); }
    }

    /// <summary>
    /// ObjectProperty: BMCombatAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BMCombatAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 6732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6732); }
    }

    /// <summary>
    /// ObjectProperty: InteractionAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT InteractionAnimset_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 6740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6740); }
    }
    /// <summary>
    /// ObjectProperty: InteractionAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT InteractionAnimset_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 6748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6748); }
    }

    /// <summary>
    /// ObjectProperty: AllyInteractionAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AllyInteractionAnimset_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 6756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6756); }
    }
    /// <summary>
    /// ObjectProperty: AllyInteractionAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AllyInteractionAnimset_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 6764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6764); }
    }

    /// <summary>
    /// IntProperty: NumBlocks
    /// </summary>
    public unsafe int NumBlocks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6772); }
    }

    /// <summary>
    /// IntProperty: NumTimesHitWhileVulnerable
    /// </summary>
    public unsafe int NumTimesHitWhileVulnerable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6776); }
    }
}
