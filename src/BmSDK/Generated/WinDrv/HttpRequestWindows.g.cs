#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.WinDrv;

/// <summary>
/// Class: HttpRequestWindows<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class HttpRequestWindows : BmSDK.Engine.HttpRequestInterface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "WinDrv.HttpRequestWindows", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal HttpRequestWindows() { }

    /// <summary>
    /// Constructs a new HttpRequestWindows
    /// </summary>
    public HttpRequestWindows(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, HttpRequestWindows Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected HttpRequestWindows(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Request
    /// </summary>
    public unsafe System.IntPtr Request
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StrProperty: RequestVerb
    /// </summary>
    public unsafe BmSDK.FString RequestVerb
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// StructProperty: RequestURL
    /// </summary>
    public unsafe System.IntPtr RequestURL
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ArrayProperty: Payload
    /// </summary>
    public unsafe BmSDK.TArray<byte> Payload
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }
}
