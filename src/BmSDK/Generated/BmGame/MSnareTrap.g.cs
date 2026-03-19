#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MSnareTrap<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MSnareTrap : BmSDK.BmGame.RProjectileGadgetBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MSnareTrap", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MSnareTrap() { }

    /// <summary>
    /// Constructs a new MSnareTrap
    /// </summary>
    public MSnareTrap(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MSnareTrap Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MSnareTrap(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MSnareTrap>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSnareTrap>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MSnareTrap>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSnareTrap>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSnareTrap>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MSnareTrap>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSnareTrap>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ArrayProperty: DeployedTraps
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RInventoryGadget.TutorialText> DeployedTraps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RInventoryGadget.TutorialText>>(Ptr + 2592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2592); }
    }

    /// <summary>
    /// IntProperty: NewestTrapIdx
    /// </summary>
    public unsafe int NewestTrapIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2608); }
    }

    /// <summary>
    /// IntProperty: MaxDeployedTraps
    /// </summary>
    public unsafe int MaxDeployedTraps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2612); }
    }

    /// <summary>
    /// ObjectProperty: LastBehaviourDeployed
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LastBehaviourDeployed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2616); }
    }

    /// <summary>
    /// ObjectProperty: ThugReactionAnimSet
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ThugReactionAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2624); }
    }

    /// <summary>
    /// ObjectProperty: ThugRifleReactionAnimSet
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ThugRifleReactionAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2632); }
    }

    /// <summary>
    /// FloatProperty: ThugUnArmoredTrappedTime
    /// </summary>
    public unsafe float ThugUnArmoredTrappedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2640); }
    }

    /// <summary>
    /// FloatProperty: ThugArmoredTrappedTime
    /// </summary>
    public unsafe float ThugArmoredTrappedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2644); }
    }

    /// <summary>
    /// StructProperty: AimLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AimLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2648); }
    }

    /// <summary>
    /// StructProperty: AimDirection
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AimDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2660); }
    }
}
