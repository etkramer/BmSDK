#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: NxGenericForceFieldBrush<br/>
/// (size = 964)
/// (flags = 144704146)
/// </summary>
public partial class NxGenericForceFieldBrush : BmSDK.Engine.Volume, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.NxGenericForceFieldBrush", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as NxGenericForceFieldBrush.
    /// </summary>
    public static NxGenericForceFieldBrush DefaultObject => (NxGenericForceFieldBrush)StaticClass().DefaultObject;

    internal NxGenericForceFieldBrush() { }

    /// <summary>
    /// Constructs a new NxGenericForceFieldBrush
    /// </summary>
    public NxGenericForceFieldBrush(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected NxGenericForceFieldBrush(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<NxGenericForceFieldBrush>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NxGenericForceFieldBrush>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<NxGenericForceFieldBrush>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NxGenericForceFieldBrush>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NxGenericForceFieldBrush>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NxGenericForceFieldBrush>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<NxGenericForceFieldBrush>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NxGenericForceFieldBrush>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: StopsProjectile
    /// </summary>
    public unsafe override bool StopsProjectile(BmSDK.Engine.Projectile P, BmSDK.Engine.PrimitiveComponent HitComponent = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.NxGenericForceFieldBrush.StopsProjectile", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitComponent, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.NxGenericForceFieldBrush.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// IntProperty: ExcludeChannel
    /// </summary>
    public unsafe int ExcludeChannel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// StructProperty: CollideWithChannels
    /// </summary>
    public unsafe ref BmSDK.Engine.PrimitiveComponent.FRBCollisionChannelContainer CollideWithChannels
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.PrimitiveComponent.FRBCollisionChannelContainer>(Ptr + 744);

    /// <summary>
    /// ByteProperty: RBChannel
    /// </summary>
    public unsafe BmSDK.Engine.PrimitiveComponent.ERBCollisionChannel RBChannel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent.ERBCollisionChannel>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ByteProperty: Coordinates
    /// </summary>
    public unsafe BmSDK.Engine.NxGenericForceFieldBrush.FFB_ForceFieldCoordinates Coordinates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.NxGenericForceFieldBrush.FFB_ForceFieldCoordinates>(Ptr + 749); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 749); }
    }

    /// <summary>
    /// StructProperty: Constant
    /// </summary>
    public unsafe ref System.Numerics.Vector3 Constant
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 752);

    /// <summary>
    /// StructProperty: PositionMultiplierX
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PositionMultiplierX
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 764);

    /// <summary>
    /// StructProperty: PositionMultiplierY
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PositionMultiplierY
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 776);

    /// <summary>
    /// StructProperty: PositionMultiplierZ
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PositionMultiplierZ
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 788);

    /// <summary>
    /// StructProperty: PositionTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PositionTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 800);

    /// <summary>
    /// StructProperty: VelocityMultiplierX
    /// </summary>
    public unsafe ref System.Numerics.Vector3 VelocityMultiplierX
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 812);

    /// <summary>
    /// StructProperty: VelocityMultiplierY
    /// </summary>
    public unsafe ref System.Numerics.Vector3 VelocityMultiplierY
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 824);

    /// <summary>
    /// StructProperty: VelocityMultiplierZ
    /// </summary>
    public unsafe ref System.Numerics.Vector3 VelocityMultiplierZ
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 836);

    /// <summary>
    /// StructProperty: VelocityTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 VelocityTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 848);

    /// <summary>
    /// StructProperty: Noise
    /// </summary>
    public unsafe ref System.Numerics.Vector3 Noise
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 860);

    /// <summary>
    /// StructProperty: FalloffLinear
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FalloffLinear
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 872);

    /// <summary>
    /// StructProperty: FalloffQuadratic
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FalloffQuadratic
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 884);

    /// <summary>
    /// FloatProperty: TorusRadius
    /// </summary>
    public unsafe float TorusRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// StructProperty: ForceField
    /// </summary>
    public unsafe System.IntPtr ForceField
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// ArrayProperty: ConvexMeshes
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ConvexMeshes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// ArrayProperty: ExclusionShapes
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ExclusionShapes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// ArrayProperty: ExclusionShapePoses
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ExclusionShapePoses
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// StructProperty: LinearKernel
    /// </summary>
    public unsafe System.IntPtr LinearKernel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// Enum: FFB_ForceFieldCoordinates
    /// </summary>
    public enum FFB_ForceFieldCoordinates : byte
    {
        FFB_CARTESIAN = 0,
        FFB_SPHERICAL = 1,
        FFB_CYLINDRICAL = 2,
        FFB_TOROIDAL = 3,
        FFB_MAX = 4,
    }
}
