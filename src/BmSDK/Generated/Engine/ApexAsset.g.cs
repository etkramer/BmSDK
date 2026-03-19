#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ApexAsset<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ApexAsset : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ApexAsset", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ApexAsset() { }

    /// <summary>
    /// Constructs a new ApexAsset
    /// </summary>
    public ApexAsset(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ApexAsset Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ApexAsset(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: OriginalApexName
    /// </summary>
    public unsafe BmSDK.FString OriginalApexName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: ApexComponents
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT ApexComponents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: NamedReferences
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> NamedReferences
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// StrProperty: SourceFilePath
    /// </summary>
    public unsafe BmSDK.FString SourceFilePath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// StrProperty: SourceFileTimestamp
    /// </summary>
    public unsafe BmSDK.FString SourceFileTimestamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// StrProperty: SourceAuthor
    /// </summary>
    public unsafe BmSDK.FString SourceAuthor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// StructProperty: MApexAsset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MApexAsset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// ArrayProperty: Materials
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT Materials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }
}
