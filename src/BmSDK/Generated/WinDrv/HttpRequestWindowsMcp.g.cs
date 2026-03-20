#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.WinDrv;

/// <summary>
/// Class: HttpRequestWindowsMcp<br/>
/// (size = 180)
/// (flags = 18)
/// </summary>
public partial class HttpRequestWindowsMcp : BmSDK.WinDrv.HttpRequestWindows, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "WinDrv.HttpRequestWindowsMcp", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal HttpRequestWindowsMcp() { }

    /// <summary>
    /// Constructs a new HttpRequestWindowsMcp
    /// </summary>
    public HttpRequestWindowsMcp(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, HttpRequestWindowsMcp Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected HttpRequestWindowsMcp(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: ProcessRequest
    /// </summary>
    public unsafe override bool ProcessRequest()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "WinDrv.HttpRequestWindowsMcp.ProcessRequest", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// StrProperty: AppID
    /// </summary>
    public unsafe BmSDK.FString AppID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// StrProperty: AppSecret
    /// </summary>
    public unsafe BmSDK.FString AppSecret
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }
}
