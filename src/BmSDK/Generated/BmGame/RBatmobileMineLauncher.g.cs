#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBatmobileMineLauncher<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBatmobileMineLauncher : BmSDK.BmGame.RVehicleWeapon, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBatmobileMineLauncher", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBatmobileMineLauncher() { }

    /// <summary>
    /// Constructs a new RBatmobileMineLauncher
    /// </summary>
    public RBatmobileMineLauncher(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBatmobileMineLauncher Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBatmobileMineLauncher(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileMineLauncher>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileMineLauncher>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileMineLauncher>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileMineLauncher>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileMineLauncher>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileMineLauncher>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileMineLauncher>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// IntProperty: MaxNumMines
    /// </summary>
    public unsafe int MaxNumMines
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2396); }
    }

    /// <summary>
    /// IntProperty: MinNumMines
    /// </summary>
    public unsafe int MinNumMines
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2400); }
    }

    /// <summary>
    /// FloatProperty: BuildUpTime
    /// </summary>
    public unsafe float BuildUpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2404); }
    }

    /// <summary>
    /// FloatProperty: MineSpreadRadius
    /// </summary>
    public unsafe float MineSpreadRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2408); }
    }

    /// <summary>
    /// FloatProperty: FireInterval
    /// </summary>
    public unsafe float FireInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2412); }
    }

    /// <summary>
    /// FloatProperty: CurrentBuildUpTime
    /// </summary>
    public unsafe float CurrentBuildUpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2416); }
    }

    /// <summary>
    /// IntProperty: NumMinesToFire
    /// </summary>
    public unsafe int NumMinesToFire
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2420); }
    }

    /// <summary>
    /// IntProperty: CurrentMine
    /// </summary>
    public unsafe int CurrentMine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2424); }
    }

    /// <summary>
    /// ObjectProperty: MineArchetype
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MineArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2428); }
    }

    /// <summary>
    /// ObjectProperty: FireFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FireFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2436); }
    }

    /// <summary>
    /// ArrayProperty: MineLaunchSockets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> MineLaunchSockets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 2444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2444); }
    }

    /// <summary>
    /// FloatProperty: ProximityRadius
    /// </summary>
    public unsafe float ProximityRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2460); }
    }

    /// <summary>
    /// StructProperty: InitialTargetLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT InitialTargetLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2464); }
    }

    /// <summary>
    /// ArrayProperty: Mines
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> Mines
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2476); }
    }
}
