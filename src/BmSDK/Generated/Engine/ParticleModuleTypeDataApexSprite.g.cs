#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleTypeDataApexSprite<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleTypeDataApexSprite : BmSDK.Engine.ParticleModuleTypeDataApex, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleTypeDataApexSprite", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleTypeDataApexSprite() { }

    /// <summary>
    /// Constructs a new ParticleModuleTypeDataApexSprite
    /// </summary>
    public ParticleModuleTypeDataApexSprite(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleTypeDataApexSprite Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleTypeDataApexSprite(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: ApexIOFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ApexIOFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ObjectProperty: ApexEmitter
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ApexEmitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// ArrayProperty: Materials
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>> Materials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// ArrayProperty: Meshes
    /// </summary>
    public unsafe BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT> Meshes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: SubUVBlend
    /// </summary>
    public unsafe bool SubUVBlend
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 144); }
    }

    /// <summary>
    /// IntProperty: SubUVStart
    /// </summary>
    public unsafe int SubUVStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// IntProperty: SubUVCount
    /// </summary>
    public unsafe int SubUVCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// IntProperty: SubImagesHorizontal
    /// </summary>
    public unsafe int SubImagesHorizontal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// IntProperty: SubImagesVertical
    /// </summary>
    public unsafe int SubImagesVertical
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// StructProperty: ApexCustomParamHandler
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ApexCustomParamHandler
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ArrayProperty: ApexLODAssets
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT ApexLODAssets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }
}
