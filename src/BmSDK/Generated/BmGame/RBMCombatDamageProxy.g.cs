#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMCombatDamageProxy<br/>
/// (size = 504)
/// (flags = 142606482)
/// </summary>
public partial class RBMCombatDamageProxy : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMCombatDamageProxy", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMCombatDamageProxy() { }

    /// <summary>
    /// Constructs a new RBMCombatDamageProxy
    /// </summary>
    public RBMCombatDamageProxy(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMCombatDamageProxy Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMCombatDamageProxy(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatDamageProxy>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatDamageProxy>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatDamageProxy>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatDamageProxy>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatDamageProxy>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMCombatDamageProxy>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMCombatDamageProxy>
        => ((GameObject)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMCombatDamageProxy.Destroyed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CombatTouch
    /// </summary>
    public unsafe virtual bool CombatTouch(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMCombatDamageProxy.CombatTouch", true);
        byte* paramsPtr = stackalloc byte[116];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: Touch
    /// </summary>
    public unsafe override void Touch(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMCombatDamageProxy.Touch", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetDamageDirection
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetDamageDirection()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMCombatDamageProxy.GetDamageDirection", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: Deactivate
    /// </summary>
    public unsafe virtual void Deactivate()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMCombatDamageProxy.Deactivate", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DeactivateDelayed
    /// </summary>
    public unsafe virtual void DeactivateDelayed(float Delay)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMCombatDamageProxy.DeactivateDelayed", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Delay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ActivateOnSocket
    /// </summary>
    public unsafe virtual void ActivateOnSocket(float NewRadius, BmSDK.Engine.SkeletalMeshComponent NewMesh, BmSDK.FName NewSocketName, float NewActiveTime = default, System.Numerics.Vector3 NewCylinderProjection = default, bool bHasCollision = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMCombatDamageProxy.ActivateOnSocket", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRadius, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMesh, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSocketName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewActiveTime, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCylinderProjection, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHasCollision, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Activate
    /// </summary>
    public unsafe virtual void Activate(float NewRadius, BmSDK.FName NewBoneName, float NewActiveTime = default, System.Numerics.Vector3 NewCylinderProjection = default, bool bHasCollision = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMCombatDamageProxy.Activate", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRadius, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBoneName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewActiveTime, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCylinderProjection, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHasCollision, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMCombatDamageProxy.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: DamageDirectionType
    /// </summary>
    public enum DamageDirectionType
    {
        DD_Parallel = 0,
        DD_Perpendicular = 1,
        DD_Velocity = 2,
        DD_MAX = 3,
    }

    /// <summary>
    /// ObjectProperty: ParentCombatPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat ParentCombatPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// BoolProperty: bActive
    /// </summary>
    public unsafe bool bActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 432); }
    }

    /// <summary>
    /// BoolProperty: bMultipleHits
    /// </summary>
    public unsafe bool bMultipleHits
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 432); }
    }

    /// <summary>
    /// ComponentProperty: AttachMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent AttachMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

    /// <summary>
    /// NameProperty: BoneName
    /// </summary>
    public unsafe BmSDK.FName BoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// NameProperty: SocketName
    /// </summary>
    public unsafe BmSDK.FName SocketName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// FloatProperty: Radius
    /// </summary>
    public unsafe float Radius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// StructProperty: CylinderProjection
    /// </summary>
    public unsafe System.Numerics.Vector3 CylinderProjection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// FloatProperty: ActiveTime
    /// </summary>
    public unsafe float ActiveTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// ComponentProperty: DamageCylinder
    /// </summary>
    public unsafe BmSDK.Engine.CylinderComponent DamageCylinder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CylinderComponent>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }

    /// <summary>
    /// IntProperty: TouchingIdx
    /// </summary>
    public unsafe int TouchingIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// ObjectProperty: fractureRumble
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform fractureRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// ByteProperty: DDType
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatDamageProxy.DamageDirectionType DDType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatDamageProxy.DamageDirectionType>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// ArrayProperty: LocationHistory
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> LocationHistory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }
}
