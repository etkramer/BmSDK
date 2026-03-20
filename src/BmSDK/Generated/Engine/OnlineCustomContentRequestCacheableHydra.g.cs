#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: OnlineCustomContentRequestCacheableHydra<br/>
/// (flags = 0)
/// </summary>
public partial class OnlineCustomContentRequestCacheableHydra : BmSDK.Engine.OnlineCustomContentRequestHydra, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.OnlineCustomContentRequestCacheableHydra", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal OnlineCustomContentRequestCacheableHydra() { }

    /// <summary>
    /// Constructs a new OnlineCustomContentRequestCacheableHydra
    /// </summary>
    public OnlineCustomContentRequestCacheableHydra(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, OnlineCustomContentRequestCacheableHydra Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected OnlineCustomContentRequestCacheableHydra(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: Subfolder
    /// </summary>
    public unsafe BmSDK.FString Subfolder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bCacheLoadComplete
    /// </summary>
    public unsafe bool bCacheLoadComplete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 184) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 184); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 184); }
    }

    /// <summary>
    /// BoolProperty: bCacheLoadSuccessful
    /// </summary>
    public unsafe bool bCacheLoadSuccessful
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 184) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 184); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 184); }
    }

    /// <summary>
    /// BoolProperty: bCacheLoadIntact
    /// </summary>
    public unsafe bool bCacheLoadIntact
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 184) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 184); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 184); }
    }

    /// <summary>
    /// BoolProperty: bMarkForCorruption
    /// </summary>
    public unsafe bool bMarkForCorruption
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 184) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 184); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 184); }
    }

    /// <summary>
    /// IntProperty: Crc32
    /// </summary>
    public unsafe int Crc32
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }
}
