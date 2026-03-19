#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVantagePointGrappleCamera<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RVantagePointGrappleCamera : BmSDK.BmGame.RCameraActor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVantagePointGrappleCamera", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVantagePointGrappleCamera() { }

    /// <summary>
    /// Constructs a new RVantagePointGrappleCamera
    /// </summary>
    public RVantagePointGrappleCamera(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVantagePointGrappleCamera Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVantagePointGrappleCamera(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVantagePointGrappleCamera>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVantagePointGrappleCamera>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVantagePointGrappleCamera>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVantagePointGrappleCamera>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVantagePointGrappleCamera>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVantagePointGrappleCamera>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVantagePointGrappleCamera>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: CurrentVantagePoint
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentVantagePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// ObjectProperty: TargetActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TargetActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// StructProperty: SilentPredCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SilentPredCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// StructProperty: CameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1276); }
    }

    /// <summary>
    /// StructProperty: BeamCameraOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BeamCameraOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// FloatProperty: PlayerTargetWeight
    /// </summary>
    public unsafe float PlayerTargetWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// StructProperty: InitialDirection
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT InitialDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1304); }
    }

    /// <summary>
    /// StructProperty: CameraRoot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CameraRoot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1316); }
    }

    /// <summary>
    /// BoolProperty: bFrozen
    /// </summary>
    public unsafe bool bFrozen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1328); }
    }

    /// <summary>
    /// BoolProperty: bFirstFrame
    /// </summary>
    public unsafe bool bFirstFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1328); }
    }

    /// <summary>
    /// BoolProperty: bNoRotation
    /// </summary>
    public unsafe bool bNoRotation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1328); }
    }

    /// <summary>
    /// StructProperty: ReferenceRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ReferenceRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1332); }
    }
}
