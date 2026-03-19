#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DownloadableContentEnumerator<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class DownloadableContentEnumerator : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DownloadableContentEnumerator", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DownloadableContentEnumerator() { }

    /// <summary>
    /// Constructs a new DownloadableContentEnumerator
    /// </summary>
    public DownloadableContentEnumerator(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DownloadableContentEnumerator Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DownloadableContentEnumerator(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: DLCBundles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> DLCBundles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// StrProperty: DLCRootDir
    /// </summary>
    public unsafe BmSDK.FString DLCRootDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: FindDLCDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> FindDLCDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// DelegateProperty: __OnFindDLCComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnFindDLCComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }
}
