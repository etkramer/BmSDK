#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleBatmobilePredictor<br/>
/// (flags = 0)
/// </summary>
public partial class RVehicleBatmobilePredictor : BmSDK.BmGame.RVehicleNPC, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleBatmobilePredictor", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleBatmobilePredictor() { }

    /// <summary>
    /// Constructs a new RVehicleBatmobilePredictor
    /// </summary>
    public RVehicleBatmobilePredictor(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleBatmobilePredictor Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleBatmobilePredictor(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobilePredictor>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobilePredictor>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobilePredictor>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobilePredictor>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobilePredictor>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobilePredictor>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobilePredictor>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: Batmobile
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobileBase Batmobile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase>(Ptr + 7620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7620); }
    }

    /// <summary>
    /// IntProperty: ChaserLink
    /// </summary>
    public unsafe int ChaserLink
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7628); }
    }

    /// <summary>
    /// IntProperty: ChaserLinkPt
    /// </summary>
    public unsafe int ChaserLinkPt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7632); }
    }

    /// <summary>
    /// IntProperty: StartWanderPoint
    /// </summary>
    public unsafe int StartWanderPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7636); }
    }

    /// <summary>
    /// BoolProperty: SelfDrivePaused
    /// </summary>
    public unsafe bool SelfDrivePaused
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7640) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7640); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 7640); }
    }

    /// <summary>
    /// StructProperty: PausedLoc
    /// </summary>
    public unsafe System.Numerics.Vector3 PausedLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 7644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7644); }
    }

    /// <summary>
    /// FloatProperty: PausedTime
    /// </summary>
    public unsafe float PausedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7656); }
    }

    /// <summary>
    /// FloatProperty: LookAheadTime
    /// </summary>
    public unsafe float LookAheadTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7660); }
    }
}
