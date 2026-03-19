#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCameraActor<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RCameraActor : BmSDK.Engine.CameraActor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCameraActor", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCameraActor() { }

    /// <summary>
    /// Constructs a new RCameraActor
    /// </summary>
    public RCameraActor(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCameraActor Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCameraActor(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCameraActor>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCameraActor>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCameraActor>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCameraActor>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCameraActor>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCameraActor>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCameraActor>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: ScreenShakeModifier
    /// </summary>
    public unsafe BmSDK.BmGame.RCameraActor.OverlayPlayer ScreenShakeModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCameraActor.OverlayPlayer>(Ptr + 1224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }
    }

    /// <summary>
    /// ObjectProperty: OverlayPlayer
    /// </summary>
    public unsafe BmSDK.Engine.CameraActor.CamOverridePostProcess OverlayPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CameraActor.CamOverridePostProcess>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }

    /// <summary>
    /// BoolProperty: bRunning
    /// </summary>
    public unsafe bool bRunning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1240); }
    }

    /// <summary>
    /// BoolProperty: bCullsPawns
    /// </summary>
    public unsafe bool bCullsPawns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1240); }
    }

    /// <summary>
    /// BoolProperty: bEnableMotionBlur
    /// </summary>
    public unsafe bool bEnableMotionBlur
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1240); }
    }

    /// <summary>
    /// BoolProperty: bUseAspectRatioCorretion
    /// </summary>
    public unsafe bool bUseAspectRatioCorretion
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1240); }
    }

    /// <summary>
    /// BoolProperty: bDisallowOverlays
    /// </summary>
    public unsafe bool bDisallowOverlays
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1240); }
    }

    /// <summary>
    /// BoolProperty: bCullPawnsTillClearOfBatmobile
    /// </summary>
    public unsafe bool bCullPawnsTillClearOfBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1240); }
    }

    /// <summary>
    /// FloatProperty: AuthoredAspectRatio
    /// </summary>
    public unsafe float AuthoredAspectRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1244); }
    }
}
