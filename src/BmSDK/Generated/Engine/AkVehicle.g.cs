#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkVehicle<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AkVehicle : BmSDK.Engine.SVehicle, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkVehicle", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkVehicle() { }

    /// <summary>
    /// Constructs a new AkVehicle
    /// </summary>
    public AkVehicle(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkVehicle Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkVehicle(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AkVehicle>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AkVehicle>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AkVehicle>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AkVehicle>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AkVehicle>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AkVehicle>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AkVehicle>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: NewVehicleSound
    /// </summary>
    public unsafe BmSDK.Engine.AkVehicle.WhooshBys NewVehicleSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkVehicle.WhooshBys>(Ptr + 2072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2072); }
    }

    /// <summary>
    /// ObjectProperty: LastDriver
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LastDriver
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2080); }
    }

    /// <summary>
    /// ComponentProperty: VehicleSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VehicleSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2088); }
    }

    /// <summary>
    /// ArrayProperty: WhooshBys
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SVehicle.StayUprightConstraintInstance>>> WhooshBys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SVehicle.StayUprightConstraintInstance>>>>(Ptr + 2096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2096); }
    }

    /// <summary>
    /// BoolProperty: OldOutputBrake
    /// </summary>
    public unsafe bool OldOutputBrake
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2112); }
    }

    /// <summary>
    /// BoolProperty: bIsOnJump
    /// </summary>
    public unsafe bool bIsOnJump
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2112); }
    }

    /// <summary>
    /// BoolProperty: bTwoWheelsOnJump
    /// </summary>
    public unsafe bool bTwoWheelsOnJump
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2112); }
    }

    /// <summary>
    /// BoolProperty: bWasOnJump
    /// </summary>
    public unsafe bool bWasOnJump
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2112); }
    }

    /// <summary>
    /// BoolProperty: bIsOnBigJump
    /// </summary>
    public unsafe bool bIsOnBigJump
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2112); }
    }

    /// <summary>
    /// BoolProperty: bIsOnAutoAlignJump
    /// </summary>
    public unsafe bool bIsOnAutoAlignJump
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2112); }
    }

    /// <summary>
    /// FloatProperty: SpeedDelta
    /// </summary>
    public unsafe float SpeedDelta
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2116); }
    }

    /// <summary>
    /// FloatProperty: ForceSqueal
    /// </summary>
    public unsafe float ForceSqueal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2120); }
    }

    /// <summary>
    /// FloatProperty: BrakeOnStoppedCounter
    /// </summary>
    public unsafe float BrakeOnStoppedCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2124); }
    }
}
