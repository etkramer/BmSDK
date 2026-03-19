#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleTrailSource<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleTrailSource : BmSDK.Engine.ParticleModuleTrailBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleTrailSource", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleTrailSource() { }

    /// <summary>
    /// Constructs a new ParticleModuleTrailSource
    /// </summary>
    public ParticleModuleTrailSource(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleTrailSource Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleTrailSource(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: SourceMethod
    /// </summary>
    public unsafe byte SourceMethod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ByteProperty: SelectionMethod
    /// </summary>
    public unsafe byte SelectionMethod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 97); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 97); }
    }

    /// <summary>
    /// NameProperty: SourceName
    /// </summary>
    public unsafe BmSDK.FName SourceName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: SourceStrength
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleTrailSource.SourceOffsetDefaults SourceStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleTrailSource.SourceOffsetDefaults>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: bLockSourceStength
    /// </summary>
    public unsafe bool bLockSourceStength
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 144); }
    }

    /// <summary>
    /// BoolProperty: bInheritRotation
    /// </summary>
    public unsafe bool bInheritRotation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 144); }
    }

    /// <summary>
    /// IntProperty: SourceOffsetCount
    /// </summary>
    public unsafe int SourceOffsetCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ArrayProperty: SourceOffsetDefaults
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT SourceOffsetDefaults
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// Enum: ETrail2SourceMethod
    /// </summary>
    public enum ETrail2SourceMethod
    {
        PET2SRCM_Default = 0,
        PET2SRCM_Particle = 1,
        PET2SRCM_Actor = 2,
        PET2SRCM_MAX = 3,
    }
}
