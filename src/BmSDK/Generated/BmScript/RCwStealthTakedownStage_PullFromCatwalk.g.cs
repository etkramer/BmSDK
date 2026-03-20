#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCwStealthTakedownStage_PullFromCatwalk<br/>
/// (size = 1692)
/// (flags = 10485778)
/// </summary>
public partial class RCwStealthTakedownStage_PullFromCatwalk : BmSDK.BmGame.RStealthTakeDownStage, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCwStealthTakedownStage_PullFromCatwalk", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCwStealthTakedownStage_PullFromCatwalk() { }

    /// <summary>
    /// Constructs a new RCwStealthTakedownStage_PullFromCatwalk
    /// </summary>
    public RCwStealthTakedownStage_PullFromCatwalk(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCwStealthTakedownStage_PullFromCatwalk Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCwStealthTakedownStage_PullFromCatwalk(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCwStealthTakedownStage_PullFromCatwalk>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwStealthTakedownStage_PullFromCatwalk>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCwStealthTakedownStage_PullFromCatwalk>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwStealthTakedownStage_PullFromCatwalk>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwStealthTakedownStage_PullFromCatwalk>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCwStealthTakedownStage_PullFromCatwalk>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwStealthTakedownStage_PullFromCatwalk>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: PlaySpecialCameraAnim
    /// </summary>
    public unsafe bool PlaySpecialCameraAnim(BmSDK.FName AnimName, bool bCamMirrored, bool CameraCollision = default, float FOV = default, BmSDK.Engine.AnimSet CustomAnimSet = default, float BlendTime = default, bool bBlendCameraBackToPlayerCameraWhenFinished = default, bool bUseBatmanAsCameraCollisionTargetInsteadOfVictim = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwStealthTakedownStage_PullFromCatwalk.PlaySpecialCameraAnim", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCamMirrored, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraCollision, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FOV, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomAnimSet, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendTime, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBlendCameraBackToPlayerCameraWhenFinished, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseBatmanAsCameraCollisionTargetInsteadOfVictim, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 40);
    }

    /// <summary>
    /// Function: ResetCamera
    /// </summary>
    public unsafe void ResetCamera()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwStealthTakedownStage_PullFromCatwalk.ResetCamera", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetFinishState
    /// </summary>
    public unsafe BmSDK.FName GetFinishState()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwStealthTakedownStage_PullFromCatwalk.GetFinishState", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwStealthTakedownStage_PullFromCatwalk.Tick", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Begin
    /// </summary>
    public unsafe void Begin()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwStealthTakedownStage_PullFromCatwalk.Begin", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetReferencePosition
    /// </summary>
    public unsafe void GetReferencePosition(out System.Numerics.Vector3 ReferencePosition, out BmSDK.Rotator ReferenceRotation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwStealthTakedownStage_PullFromCatwalk.GetReferencePosition", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ReferencePosition = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        ReferenceRotation = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 12);
        return;
    }

    /// <summary>
    /// StructProperty: FeaturePos
    /// </summary>
    public unsafe System.Numerics.Vector3 FeaturePos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1664); }
    }

    /// <summary>
    /// NameProperty: VictimRightAnimName
    /// </summary>
    public unsafe BmSDK.FName VictimRightAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1676); }
    }

    /// <summary>
    /// NameProperty: RailingMoveAnimName
    /// </summary>
    public unsafe BmSDK.FName RailingMoveAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1684); }
    }
}
