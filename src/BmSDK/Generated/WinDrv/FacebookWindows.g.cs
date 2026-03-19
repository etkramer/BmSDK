#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.WinDrv;

/// <summary>
/// Class: FacebookWindows<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class FacebookWindows : BmSDK.Engine.FacebookIntegration, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "WinDrv.FacebookWindows", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal FacebookWindows() { }

    /// <summary>
    /// Constructs a new FacebookWindows
    /// </summary>
    public FacebookWindows(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, FacebookWindows Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected FacebookWindows(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: VfTable_FTickableObject
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VfTable_FTickableObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// StructProperty: ChildProcHandle
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ChildProcHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }
}
