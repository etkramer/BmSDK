#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: NxForceFieldGeneric<br/>
/// (size = 940)
/// (flags = 144704146)
/// </summary>
public partial class NxForceFieldGeneric : BmSDK.Engine.NxForceField, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.NxForceFieldGeneric", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as NxForceFieldGeneric.
    /// </summary>
    public static NxForceFieldGeneric DefaultObject => (NxForceFieldGeneric)StaticClass().DefaultObject;

    internal NxForceFieldGeneric() { }

    /// <summary>
    /// Constructs a new NxForceFieldGeneric
    /// </summary>
    public NxForceFieldGeneric(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected NxForceFieldGeneric(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<NxForceFieldGeneric>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NxForceFieldGeneric>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<NxForceFieldGeneric>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NxForceFieldGeneric>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NxForceFieldGeneric>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NxForceFieldGeneric>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<NxForceFieldGeneric>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NxForceFieldGeneric>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: DoInitRBPhys
    /// </summary>
    public unsafe override void DoInitRBPhys()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.NxForceFieldGeneric.DoInitRBPhys", true);
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Enum: FFG_ForceFieldCoordinates
    /// </summary>
    public enum FFG_ForceFieldCoordinates : byte
    {
        FFG_CARTESIAN = 0,
        FFG_SPHERICAL = 1,
        FFG_CYLINDRICAL = 2,
        FFG_TOROIDAL = 3,
        FFG_MAX = 4,
    }

    /// <summary>
    /// ObjectProperty: Shape
    /// </summary>
    public unsafe BmSDK.Engine.ForceFieldShape Shape
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFieldShape>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// ComponentProperty: DrawComponent
    /// </summary>
    public unsafe BmSDK.Engine.ActorComponent DrawComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ActorComponent>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// FloatProperty: RoughExtentX
    /// </summary>
    public unsafe float RoughExtentX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// FloatProperty: RoughExtentY
    /// </summary>
    public unsafe float RoughExtentY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// FloatProperty: RoughExtentZ
    /// </summary>
    public unsafe float RoughExtentZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// ByteProperty: Coordinates
    /// </summary>
    public unsafe BmSDK.Engine.NxForceFieldGeneric.FFG_ForceFieldCoordinates Coordinates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.NxForceFieldGeneric.FFG_ForceFieldCoordinates>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// StructProperty: Constant
    /// </summary>
    public unsafe ref System.Numerics.Vector3 Constant
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 784);

    /// <summary>
    /// StructProperty: PositionMultiplierX
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PositionMultiplierX
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 796);

    /// <summary>
    /// StructProperty: PositionMultiplierY
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PositionMultiplierY
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 808);

    /// <summary>
    /// StructProperty: PositionMultiplierZ
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PositionMultiplierZ
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 820);

    /// <summary>
    /// StructProperty: PositionTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PositionTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 832);

    /// <summary>
    /// StructProperty: VelocityMultiplierX
    /// </summary>
    public unsafe ref System.Numerics.Vector3 VelocityMultiplierX
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 844);

    /// <summary>
    /// StructProperty: VelocityMultiplierY
    /// </summary>
    public unsafe ref System.Numerics.Vector3 VelocityMultiplierY
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 856);

    /// <summary>
    /// StructProperty: VelocityMultiplierZ
    /// </summary>
    public unsafe ref System.Numerics.Vector3 VelocityMultiplierZ
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 868);

    /// <summary>
    /// StructProperty: VelocityTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 VelocityTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 880);

    /// <summary>
    /// StructProperty: Noise
    /// </summary>
    public unsafe ref System.Numerics.Vector3 Noise
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 892);

    /// <summary>
    /// StructProperty: FalloffLinear
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FalloffLinear
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 904);

    /// <summary>
    /// StructProperty: FalloffQuadratic
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FalloffQuadratic
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 916);

    /// <summary>
    /// FloatProperty: TorusRadius
    /// </summary>
    public unsafe float TorusRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// StructProperty: LinearKernel
    /// </summary>
    public unsafe System.IntPtr LinearKernel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }
}
