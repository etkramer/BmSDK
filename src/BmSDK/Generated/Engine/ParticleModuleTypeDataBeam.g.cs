#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleTypeDataBeam<br/>
/// (size = 0)
/// (flags = 0)
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

    /// <summary>
    /// ByteProperty: BeamMethod
    /// </summary>
    public unsafe byte BeamMethod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ByteProperty: EndPointMethod
    /// </summary>
    public unsafe byte EndPointMethod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 97); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 97); }
    }

    /// <summary>
    /// StructProperty: Distance
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleTypeDataBeam.EndPoint Distance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleTypeDataBeam.EndPoint>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: EndPoint
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleTypeDataBeam.EmitterStrength EndPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleTypeDataBeam.EmitterStrength>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// IntProperty: TessellationFactor
    /// </summary>
    public unsafe int TessellationFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// StructProperty: EmitterStrength
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleTypeDataBeam.TargetStrength EmitterStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleTypeDataBeam.TargetStrength>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// StructProperty: TargetStrength
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleTypeDataBeam.EndPointDirection TargetStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleTypeDataBeam.EndPointDirection>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// StructProperty: EndPointDirection
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT EndPointDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// IntProperty: TextureTile
    /// </summary>
    public unsafe int TextureTile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// BoolProperty: RenderGeometry
    /// </summary>
    public unsafe bool RenderGeometry
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 344) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 344); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 344); }
    }

    /// <summary>
    /// BoolProperty: RenderDirectLine
    /// </summary>
    public unsafe bool RenderDirectLine
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 344) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 344); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 344); }
    }

    /// <summary>
    /// BoolProperty: RenderLines
    /// </summary>
    public unsafe bool RenderLines
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 344) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 344); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 344); }
    }

    /// <summary>
    /// BoolProperty: RenderTessellation
    /// </summary>
    public unsafe bool RenderTessellation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 344) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 344); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 344); }
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
