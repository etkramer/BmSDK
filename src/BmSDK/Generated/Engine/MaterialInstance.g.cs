#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialInstance<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MaterialInstance : BmSDK.Engine.MaterialInterface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialInstance", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialInstance() { }

    /// <summary>
    /// Constructs a new MaterialInstance
    /// </summary>
    public MaterialInstance(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialInstance Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialInstance(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Parent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Parent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ObjectProperty: PhysMaterialMask
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PhysMaterialMask
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ObjectProperty: BlackPhysicalMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BlackPhysicalMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ObjectProperty: WhitePhysicalMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WhitePhysicalMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// IntProperty: PhysMaterialMaskUVChannel
    /// </summary>
    public unsafe int PhysMaterialMaskUVChannel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: OverrideDecalPriority
    /// </summary>
    public unsafe bool OverrideDecalPriority
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bHasStaticPermutationResource
    /// </summary>
    public unsafe bool bHasStaticPermutationResource
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bStaticPermutationDirty
    /// </summary>
    public unsafe bool bStaticPermutationDirty
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: ReentrantFlag
    /// </summary>
    public unsafe bool ReentrantFlag
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bNeedsMaterialFlattening
    /// </summary>
    public unsafe bool bNeedsMaterialFlattening
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// ByteProperty: DecalPriority
    /// </summary>
    public unsafe byte DecalPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// StructProperty: StaticParameters
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StaticParameters_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }
    /// <summary>
    /// StructProperty: StaticParameters
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StaticParameters_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// StructProperty: StaticPermutationResources
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StaticPermutationResources_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }
    /// <summary>
    /// StructProperty: StaticPermutationResources
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StaticPermutationResources_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// StructProperty: Resources
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Resources_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }
    /// <summary>
    /// StructProperty: Resources
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Resources_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }
    /// <summary>
    /// StructProperty: Resources
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Resources_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// ArrayProperty: ReferencedTextures
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> ReferencedTextures
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }

    /// <summary>
    /// ArrayProperty: ReferencedTextureGuids
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ReferencedTextureGuids
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// StructProperty: ParentLightingGuid
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ParentLightingGuid
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// StrProperty: SourceTimestamp
    /// </summary>
    public unsafe BmSDK.FString SourceTimestamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// StrProperty: SourceAuthor
    /// </summary>
    public unsafe BmSDK.FString SourceAuthor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }
}
