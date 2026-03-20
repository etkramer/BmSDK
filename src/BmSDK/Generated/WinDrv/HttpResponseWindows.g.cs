#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.WinDrv;

/// <summary>
/// Class: HttpResponseWindows<br/>
/// (flags = 0)
/// </summary>
public partial class HttpResponseWindows : BmSDK.Engine.HttpResponseInterface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "WinDrv.HttpResponseWindows", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal HttpResponseWindows() { }

    /// <summary>
    /// Constructs a new HttpResponseWindows
    /// </summary>
    public HttpResponseWindows(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, HttpResponseWindows Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected HttpResponseWindows(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Response
    /// </summary>
    public unsafe System.IntPtr Response
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: Payload
    /// </summary>
    public unsafe BmSDK.TArray<byte> Payload
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }
}
