#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RExitPoints<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RExitPoints : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RExitPoints", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RExitPoints() { }

    /// <summary>
    /// Constructs a new RExitPoints
    /// </summary>
    public RExitPoints(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RExitPoints Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RExitPoints(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: PerimeterCenter
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PerimeterCenter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// FloatProperty: PerimeterRadius
    /// </summary>
    public unsafe float PerimeterRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// FloatProperty: ViewRange
    /// </summary>
    public unsafe float ViewRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: ExitPoints
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT ExitPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }
}
