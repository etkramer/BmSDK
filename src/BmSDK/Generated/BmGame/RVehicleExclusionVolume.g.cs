#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleExclusionVolume<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RVehicleExclusionVolume : BmSDK.Engine.Volume, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleExclusionVolume", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleExclusionVolume() { }

    /// <summary>
    /// Constructs a new RVehicleExclusionVolume
    /// </summary>
    public RVehicleExclusionVolume(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleExclusionVolume Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleExclusionVolume(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleExclusionVolume>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleExclusionVolume>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleExclusionVolume>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleExclusionVolume>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleExclusionVolume>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleExclusionVolume>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleExclusionVolume>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// BoolProperty: IsActive
    /// </summary>
    public unsafe bool IsActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 740); }
    }

    /// <summary>
    /// BoolProperty: BlockPenguinVans
    /// </summary>
    public unsafe bool BlockPenguinVans
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 740); }
    }

    /// <summary>
    /// BoolProperty: BlockMadHatterCars
    /// </summary>
    public unsafe bool BlockMadHatterCars
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 740); }
    }

    /// <summary>
    /// BoolProperty: BlockMostWantedApcs
    /// </summary>
    public unsafe bool BlockMostWantedApcs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 740); }
    }

    /// <summary>
    /// BoolProperty: BlocksHeavyTankPatrols
    /// </summary>
    public unsafe bool BlocksHeavyTankPatrols
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 740); }
    }

    /// <summary>
    /// BoolProperty: BlockOtherVehicles
    /// </summary>
    public unsafe bool BlockOtherVehicles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 740); }
    }

    /// <summary>
    /// BoolProperty: OnlyBlockSpawning
    /// </summary>
    public unsafe bool OnlyBlockSpawning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 740); }
    }

    /// <summary>
    /// ByteProperty: LinkedDistricts
    /// </summary>
    public unsafe byte LinkedDistricts_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }
    /// <summary>
    /// ByteProperty: LinkedDistricts
    /// </summary>
    public unsafe byte LinkedDistricts_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 745); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 745); }
    }

    /// <summary>
    /// ArrayProperty: ExclusionTypes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>> ExclusionTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }
}
