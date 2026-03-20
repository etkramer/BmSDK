#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleCar<br/>
/// (flags = 0)
/// </summary>
public partial class RVehicleCar : BmSDK.BmGame.RVehicleNPC, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleCar", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleCar() { }

    /// <summary>
    /// Constructs a new RVehicleCar
    /// </summary>
    public RVehicleCar(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleCar Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleCar(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleCar>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleCar>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleCar>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleCar>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleCar>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleCar>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleCar>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// FloatProperty: CarSteerScale
    /// </summary>
    public unsafe float CarSteerScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7620); }
    }

    /// <summary>
    /// FloatProperty: CarSteerDamping
    /// </summary>
    public unsafe float CarSteerDamping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7624); }
    }

    /// <summary>
    /// FloatProperty: ChaseRange
    /// </summary>
    public unsafe float ChaseRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7628); }
    }

    /// <summary>
    /// BoolProperty: ShowHealthBarWhenTracked
    /// </summary>
    public unsafe bool ShowHealthBarWhenTracked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7632) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7632); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7632); }
    }

    /// <summary>
    /// BoolProperty: OnlyShowHealthBarWhenNoFollowers
    /// </summary>
    public unsafe bool OnlyShowHealthBarWhenNoFollowers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7632) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7632); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7632); }
    }

    /// <summary>
    /// BoolProperty: HealthBarVisible
    /// </summary>
    public unsafe bool HealthBarVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7632) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7632); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7632); }
    }

    /// <summary>
    /// BoolProperty: bProtectedByEscorts
    /// </summary>
    public unsafe bool bProtectedByEscorts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7632) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7632); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7632); }
    }

    /// <summary>
    /// BoolProperty: BumpedByCar
    /// </summary>
    public unsafe bool BumpedByCar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7632) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7632); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7632); }
    }

    /// <summary>
    /// IntProperty: HealthBarFlashThreshold
    /// </summary>
    public unsafe int HealthBarFlashThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7636); }
    }

    /// <summary>
    /// ObjectProperty: BossMovieInstance
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie BossMovieInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 7640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7640); }
    }

    /// <summary>
    /// ObjectProperty: BossModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleBoss BossModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleBoss>(Ptr + 7648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7648); }
    }

    /// <summary>
    /// ComponentProperty: EMPMissileTarget
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent EMPMissileTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 7656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7656); }
    }

    /// <summary>
    /// StrProperty: HealthBarBossName
    /// </summary>
    public unsafe BmSDK.FString HealthBarBossName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 7664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7664); }
    }

    /// <summary>
    /// IntProperty: HealthBarHealth
    /// </summary>
    public unsafe int HealthBarHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7680); }
    }

    /// <summary>
    /// IntProperty: InitialHealth
    /// </summary>
    public unsafe int InitialHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7684); }
    }

    /// <summary>
    /// ByteProperty: CurrentWeakSpot
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleCar.EAPCWeakSpot CurrentWeakSpot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleCar.EAPCWeakSpot>(Ptr + 7688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7688); }
    }
}
