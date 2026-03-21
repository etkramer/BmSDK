#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleTypeDataBeam<br/>
/// (size = 212)
/// (flags = 142618770)
/// </summary>
public partial class ParticleModuleTypeDataBeam : BmSDK.Engine.ParticleModuleTypeDataBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleTypeDataBeam", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleTypeDataBeam() { }

    /// <summary>
    /// Constructs a new ParticleModuleTypeDataBeam
    /// </summary>
    public ParticleModuleTypeDataBeam(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleTypeDataBeam Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleTypeDataBeam(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ParticleModuleTypeDataBeam>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleTypeDataBeam>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ParticleModuleTypeDataBeam>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleTypeDataBeam>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleTypeDataBeam>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ParticleModuleTypeDataBeam>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleTypeDataBeam>
        => ((GameObject)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Enum: EBeamEndPointMethod
    /// </summary>
    public enum EBeamEndPointMethod
    {
        PEBEPM_Calculated = 0,
        PEBEPM_Distribution = 1,
        PEBEPM_Distribution_Constant = 2,
        PEBEPM_MAX = 3,
    }

    /// <summary>
    /// ByteProperty: BeamMethod
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleTypeDataBeam.EBeamMethod BeamMethod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleTypeDataBeam.EBeamMethod>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// ByteProperty: EndPointMethod
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleTypeDataBeam.EBeamEndPointMethod EndPointMethod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleTypeDataBeam.EBeamEndPointMethod>(Ptr + 57); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 57); }
    }

    /// <summary>
    /// StructProperty: Distance
    /// </summary>
    public unsafe BmSDK.DistributionFloat.FRawDistributionFloat Distance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// StructProperty: EndPoint
    /// </summary>
    public unsafe BmSDK.DistributionVector.FRawDistributionVector EndPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionVector.FRawDistributionVector>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// IntProperty: TessellationFactor
    /// </summary>
    public unsafe int TessellationFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// StructProperty: EmitterStrength
    /// </summary>
    public unsafe BmSDK.DistributionFloat.FRawDistributionFloat EmitterStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// StructProperty: TargetStrength
    /// </summary>
    public unsafe BmSDK.DistributionFloat.FRawDistributionFloat TargetStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// StructProperty: EndPointDirection
    /// </summary>
    public unsafe BmSDK.DistributionVector.FRawDistributionVector EndPointDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionVector.FRawDistributionVector>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// IntProperty: TextureTile
    /// </summary>
    public unsafe int TextureTile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// BoolProperty: RenderGeometry
    /// </summary>
    public unsafe bool RenderGeometry
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 208); }
    }

    /// <summary>
    /// BoolProperty: RenderDirectLine
    /// </summary>
    public unsafe bool RenderDirectLine
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 208); }
    }

    /// <summary>
    /// BoolProperty: RenderLines
    /// </summary>
    public unsafe bool RenderLines
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 208); }
    }

    /// <summary>
    /// BoolProperty: RenderTessellation
    /// </summary>
    public unsafe bool RenderTessellation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 208); }
    }

    /// <summary>
    /// Enum: EBeamMethod
    /// </summary>
    public enum EBeamMethod
    {
        PEBM_Distance = 0,
        PEBM_EndPoints = 1,
        PEBM_EndPoints_Interpolated = 2,
        PEBM_UserSet_EndPoints = 3,
        PEBM_UserSet_EndPoints_Interpolated = 4,
        PEBM_MAX = 5,
    }
}
