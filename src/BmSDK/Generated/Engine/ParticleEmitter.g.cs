#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleEmitter<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleEmitter : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleEmitter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleEmitter() { }

    /// <summary>
    /// Constructs a new ParticleEmitter
    /// </summary>
    public ParticleEmitter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleEmitter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleEmitter(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: EmitterName
    /// </summary>
    public unsafe BmSDK.FName EmitterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// FloatProperty: NearScaleDistance
    /// </summary>
    public unsafe float NearScaleDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// IntProperty: SubUVDataOffset
    /// </summary>
    public unsafe int SubUVDataOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ByteProperty: EmitterRenderMode
    /// </summary>
    public unsafe byte EmitterRenderMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ByteProperty: SharedEmitterInstanceCount
    /// </summary>
    public unsafe byte SharedEmitterInstanceCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 101); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 101); }
    }

    /// <summary>
    /// StructProperty: EmitterEditorColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT EmitterEditorColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// ArrayProperty: LODLevels
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT LODLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: ConvertedModules
    /// </summary>
    public unsafe bool ConvertedModules
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 124); }
    }

    /// <summary>
    /// BoolProperty: bCollapsed
    /// </summary>
    public unsafe bool bCollapsed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 124); }
    }

    /// <summary>
    /// BoolProperty: bIsSoloing
    /// </summary>
    public unsafe bool bIsSoloing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 124); }
    }

    /// <summary>
    /// BoolProperty: bCookedOut
    /// </summary>
    public unsafe bool bCookedOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 124); }
    }

    /// <summary>
    /// IntProperty: PeakActiveParticles
    /// </summary>
    public unsafe int PeakActiveParticles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// IntProperty: InitialAllocationCount
    /// </summary>
    public unsafe int InitialAllocationCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// FloatProperty: MediumDetailSpawnRateScale
    /// </summary>
    public unsafe float MediumDetailSpawnRateScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// ArrayProperty: SharedEmitterInstances
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT SharedEmitterInstances
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }
}
