#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: PlatformInterfaceWebResponse<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class PlatformInterfaceWebResponse : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.PlatformInterfaceWebResponse", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal PlatformInterfaceWebResponse() { }

    /// <summary>
    /// Constructs a new PlatformInterfaceWebResponse
    /// </summary>
    public PlatformInterfaceWebResponse(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, PlatformInterfaceWebResponse Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected PlatformInterfaceWebResponse(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: OriginalURL
    /// </summary>
    public unsafe BmSDK.FString OriginalURL
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// IntProperty: ResponseCode
    /// </summary>
    public unsafe int ResponseCode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// IntProperty: Tag
    /// </summary>
    public unsafe int Tag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// StructProperty: Headers
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Headers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// StrProperty: StringResponse
    /// </summary>
    public unsafe BmSDK.FString StringResponse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// ArrayProperty: BinaryResponse
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT BinaryResponse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }
}
