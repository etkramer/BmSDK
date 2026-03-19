#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RParticleModuleTypeDataDecal<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RParticleModuleTypeDataDecal : BmSDK.Engine.ParticleModuleTypeDataBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RParticleModuleTypeDataDecal", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RParticleModuleTypeDataDecal() { }

    /// <summary>
    /// Constructs a new RParticleModuleTypeDataDecal
    /// </summary>
    public RParticleModuleTypeDataDecal(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RParticleModuleTypeDataDecal Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RParticleModuleTypeDataDecal(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Material
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Material
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// StructProperty: InitialRotation
    /// </summary>
    public unsafe BmSDK.Engine.RParticleModuleTypeDataDecal.InitialPerInstanceRandomOverride InitialRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RParticleModuleTypeDataDecal.InitialPerInstanceRandomOverride>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// StructProperty: InitialPerInstanceRandomOverride
    /// </summary>
    public unsafe BmSDK.Engine.RParticleModuleTypeDataDecal.UpdatingPerInstanceRandomOverride InitialPerInstanceRandomOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RParticleModuleTypeDataDecal.UpdatingPerInstanceRandomOverride>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// StructProperty: UpdatingPerInstanceRandomOverride
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT UpdatingPerInstanceRandomOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// StructProperty: UVTopLeft
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT UVTopLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// StructProperty: UVBottomRight
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT UVBottomRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// IntProperty: Priority
    /// </summary>
    public unsafe int Priority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// BoolProperty: UseGlobalPool
    /// </summary>
    public unsafe bool UseGlobalPool
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: StaticDecal
    /// </summary>
    public unsafe bool StaticDecal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// FloatProperty: BurstSpawnChance
    /// </summary>
    public unsafe float BurstSpawnChance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }
}
