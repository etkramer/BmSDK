#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: OnlineCustomContentRequest<br/>
/// (flags = 0)
/// </summary>
public partial class OnlineCustomContentRequest : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.OnlineCustomContentRequest", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal OnlineCustomContentRequest() { }

    /// <summary>
    /// Constructs a new OnlineCustomContentRequest
    /// </summary>
    public OnlineCustomContentRequest(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, OnlineCustomContentRequest Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected OnlineCustomContentRequest(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: ContentName
    /// </summary>
    public unsafe BmSDK.FString ContentName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// StrProperty: CustomId
    /// </summary>
    public unsafe BmSDK.FString CustomId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// DelegateProperty: RequestCustomContentCompleteDelegate
    /// </summary>
    public unsafe System.IntPtr RequestCustomContentCompleteDelegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// DelegateProperty: __OnRequestCustomContentComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnRequestCustomContentComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }
}
