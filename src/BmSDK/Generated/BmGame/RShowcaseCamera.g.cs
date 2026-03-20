#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RShowcaseCamera<br/>
/// (size = 1448)
/// (flags = 10485778)
/// </summary>
public partial class RShowcaseCamera : BmSDK.BmGame.RCameraActor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RShowcaseCamera", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RShowcaseCamera() { }

    /// <summary>
    /// Constructs a new RShowcaseCamera
    /// </summary>
    public RShowcaseCamera(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RShowcaseCamera Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RShowcaseCamera(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RShowcaseCamera>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RShowcaseCamera>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RShowcaseCamera>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RShowcaseCamera>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RShowcaseCamera>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RShowcaseCamera>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RShowcaseCamera>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: UpdateLightRigs
    /// </summary>
    public unsafe virtual void UpdateLightRigs()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RShowcaseCamera.UpdateLightRigs", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateInput
    /// </summary>
    public unsafe virtual void UpdateInput(float fFrameTime, float fr, float fU, float FF)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RShowcaseCamera.UpdateInput", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fFrameTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fr, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fU, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FF, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateFrame
    /// </summary>
    public unsafe virtual bool UpdateFrame(float fFrameTime, BmSDK.BmGame.RPlayerInput iInput)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RShowcaseCamera.UpdateFrame", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fFrameTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iInput, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: LightRigsRelease
    /// </summary>
    public unsafe virtual void LightRigsRelease()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RShowcaseCamera.LightRigsRelease", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: LightRigsInitialize
    /// </summary>
    public unsafe virtual void LightRigsInitialize()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RShowcaseCamera.LightRigsInitialize", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetMode
    /// </summary>
    public unsafe virtual void SetMode(BmSDK.BmGame.RShowcaseCamera.ShowcaseCameraMode eMode, BmSDK.BmGame.RShowcaseCamera.ShowcaseCameraVantageRequirement eRequirement)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RShowcaseCamera.SetMode", true);
        byte* paramsPtr = stackalloc byte[2];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eMode, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(eRequirement, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetInspectParams
    /// </summary>
    public unsafe virtual void SetInspectParams(System.Numerics.Vector4 vHeights, System.Numerics.Vector4 vAngles, System.Numerics.Vector3 vFOVs, float fDistance)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RShowcaseCamera.SetInspectParams", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vHeights, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vAngles, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vFOVs, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDistance, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetVantageParams
    /// </summary>
    public unsafe virtual void SetVantageParams(System.Numerics.Vector3 vPosition, System.Numerics.Vector3 vLookAt, float fFOV)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RShowcaseCamera.SetVantageParams", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vPosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vLookAt, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fFOV, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ByteProperty: m_eMode
    /// </summary>
    public unsafe BmSDK.BmGame.RShowcaseCamera.ShowcaseCameraMode m_eMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RShowcaseCamera.ShowcaseCameraMode>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// FloatProperty: m_fAutoModeDelay
    /// </summary>
    public unsafe float m_fAutoModeDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }

    /// <summary>
    /// StructProperty: m_vVantagePosition
    /// </summary>
    public unsafe System.Numerics.Vector3 m_vVantagePosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// StructProperty: m_vVantageLookAt
    /// </summary>
    public unsafe System.Numerics.Vector3 m_vVantageLookAt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }

    /// <summary>
    /// FloatProperty: m_fVantageFOV
    /// </summary>
    public unsafe float m_fVantageFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }
    }

    /// <summary>
    /// StructProperty: m_vInspectHeights
    /// </summary>
    public unsafe System.Numerics.Vector4 m_vInspectHeights
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector4>(Ptr + 1296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }
    }

    /// <summary>
    /// StructProperty: m_vInspectAngles
    /// </summary>
    public unsafe System.Numerics.Vector4 m_vInspectAngles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector4>(Ptr + 1312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }
    }

    /// <summary>
    /// StructProperty: m_vInspectFOVs
    /// </summary>
    public unsafe System.Numerics.Vector3 m_vInspectFOVs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }
    }

    /// <summary>
    /// FloatProperty: m_fInspectDistance
    /// </summary>
    public unsafe float m_fInspectDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1340); }
    }

    /// <summary>
    /// FloatProperty: m_fInputHeightScalar
    /// </summary>
    public unsafe float m_fInputHeightScalar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// FloatProperty: m_fInputHeightVelocity
    /// </summary>
    public unsafe float m_fInputHeightVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1348); }
    }

    /// <summary>
    /// FloatProperty: m_fInputSpinVelocity
    /// </summary>
    public unsafe float m_fInputSpinVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }
    }

    /// <summary>
    /// FloatProperty: m_fInputFOVScalar
    /// </summary>
    public unsafe float m_fInputFOVScalar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1356); }
    }

    /// <summary>
    /// FloatProperty: m_fInputFOVVelocity
    /// </summary>
    public unsafe float m_fInputFOVVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }

    /// <summary>
    /// StructProperty: m_vSourceLookAt
    /// </summary>
    public unsafe System.Numerics.Vector3 m_vSourceLookAt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1364); }
    }

    /// <summary>
    /// StructProperty: m_vTargetLookAt
    /// </summary>
    public unsafe System.Numerics.Vector3 m_vTargetLookAt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1376); }
    }

    /// <summary>
    /// StructProperty: m_rSourceRotation
    /// </summary>
    public unsafe BmSDK.Rotator m_rSourceRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 1388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1388); }
    }

    /// <summary>
    /// StructProperty: m_rTargetRotation
    /// </summary>
    public unsafe BmSDK.Rotator m_rTargetRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 1400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1400); }
    }

    /// <summary>
    /// FloatProperty: m_fSourceFOV
    /// </summary>
    public unsafe float m_fSourceFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1412); }
    }

    /// <summary>
    /// FloatProperty: m_fTargetFOV
    /// </summary>
    public unsafe float m_fTargetFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1416); }
    }

    /// <summary>
    /// FloatProperty: m_fSourceDistance
    /// </summary>
    public unsafe float m_fSourceDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1420); }
    }

    /// <summary>
    /// FloatProperty: m_fTargetDistance
    /// </summary>
    public unsafe float m_fTargetDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }
    }

    /// <summary>
    /// FloatProperty: m_fMouseWheelZoom
    /// </summary>
    public unsafe float m_fMouseWheelZoom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1428); }
    }

    /// <summary>
    /// ArrayProperty: m_aLightRigs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RDummyTarget> m_aLightRigs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RDummyTarget>>(Ptr + 1432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1432); }
    }

    /// <summary>
    /// Enum: ShowcaseCameraVantageRequirement
    /// </summary>
    public enum ShowcaseCameraVantageRequirement
    {
        SCVR_NONE = 0,
        SCVR_TRANSITION_OUT = 1,
        SCVR_TRANSITION_IN = 2,
        SCVR_MAX = 3,
    }

    /// <summary>
    /// Enum: ShowcaseCameraMode
    /// </summary>
    public enum ShowcaseCameraMode
    {
        SCM_UNKNOWN = 0,
        SCM_VANTAGE = 1,
        SCM_INSPECT_MANUAL = 2,
        SCM_INSPECT_AUTO = 3,
        SCM_MAX = 4,
    }
}
