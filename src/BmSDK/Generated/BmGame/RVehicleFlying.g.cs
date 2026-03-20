#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleFlying<br/>
/// (flags = 0)
/// </summary>
public partial class RVehicleFlying : BmSDK.BmGame.RVehicleNPC, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleFlying", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleFlying() { }

    /// <summary>
    /// Constructs a new RVehicleFlying
    /// </summary>
    public RVehicleFlying(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleFlying Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleFlying(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleFlying>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleFlying>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleFlying>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleFlying>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleFlying>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleFlying>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleFlying>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// BoolProperty: bCanDoSimultaneousAttack
    /// </summary>
    public unsafe bool bCanDoSimultaneousAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7620) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7620); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7620); }
    }

    /// <summary>
    /// BoolProperty: ShootAimIsGood
    /// </summary>
    public unsafe bool ShootAimIsGood
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7620) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7620); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7620); }
    }

    /// <summary>
    /// FloatProperty: MinAltitude
    /// </summary>
    public unsafe float MinAltitude
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7624); }
    }

    /// <summary>
    /// FloatProperty: OptimalAltitude
    /// </summary>
    public unsafe float OptimalAltitude
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7628); }
    }

    /// <summary>
    /// FloatProperty: CurrentGroundZ
    /// </summary>
    public unsafe float CurrentGroundZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7632); }
    }

    /// <summary>
    /// FloatProperty: CurrentAltitude
    /// </summary>
    public unsafe float CurrentAltitude
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7636); }
    }

    /// <summary>
    /// ArrayProperty: MultiProjectileLaunchSockets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> MultiProjectileLaunchSockets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 7640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7640); }
    }

    /// <summary>
    /// IntProperty: CurrentLaunchSocket
    /// </summary>
    public unsafe int CurrentLaunchSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7656); }
    }

    /// <summary>
    /// ObjectProperty: loopingEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent loopingEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 7660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7660); }
    }

    /// <summary>
    /// ObjectProperty: DeadLoopingEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent DeadLoopingEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 7668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7668); }
    }

    /// <summary>
    /// ComponentProperty: ShootHelper
    /// </summary>
    public unsafe BmSDK.Engine.PrimitiveComponent ShootHelper
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent>(Ptr + 7676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7676); }
    }

    /// <summary>
    /// StructProperty: ShootFromPoint
    /// </summary>
    public unsafe System.Numerics.Vector3 ShootFromPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 7684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7684); }
    }

    /// <summary>
    /// StructProperty: ShootTargetPoint
    /// </summary>
    public unsafe System.Numerics.Vector3 ShootTargetPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 7696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7696); }
    }

    /// <summary>
    /// FloatProperty: ProjectileDuration
    /// </summary>
    public unsafe float ProjectileDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7708); }
    }

    /// <summary>
    /// IntProperty: LightsMaterialIndex
    /// </summary>
    public unsafe int LightsMaterialIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7712); }
    }

    /// <summary>
    /// FloatProperty: fDisruptorAimMaximumHeight
    /// </summary>
    public unsafe float fDisruptorAimMaximumHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7716); }
    }

    /// <summary>
    /// FloatProperty: fDisruptorAimMaximumRearDistance
    /// </summary>
    public unsafe float fDisruptorAimMaximumRearDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7720); }
    }

    /// <summary>
    /// StructProperty: BumpRepelDir
    /// </summary>
    public unsafe System.Numerics.Vector3 BumpRepelDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 7724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7724); }
    }

    /// <summary>
    /// FloatProperty: BumpRepelTime
    /// </summary>
    public unsafe float BumpRepelTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7736); }
    }

    /// <summary>
    /// StructProperty: ShootSoundHandle
    /// </summary>
    public unsafe BmSDK.Engine.AkWwise.FAkSoundHandle ShootSoundHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 7740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7740); }
    }
}
