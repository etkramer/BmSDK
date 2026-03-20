#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: HttpFactory<br/>
/// (flags = 0)
/// </summary>
public partial class HttpFactory : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.HttpFactory", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal HttpFactory() { }

    /// <summary>
    /// Constructs a new HttpFactory
    /// </summary>
    public HttpFactory(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, HttpFactory Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected HttpFactory(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: CreateRequest
    /// </summary>
    public unsafe static BmSDK.Engine.HttpRequestInterface CreateRequest()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.HttpFactory.CreateRequest", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.HttpRequestInterface>(paramsPtr + 0);
    }

    /// <summary>
    /// StrProperty: HttpRequestClassName
    /// </summary>
    public unsafe BmSDK.FString HttpRequestClassName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
