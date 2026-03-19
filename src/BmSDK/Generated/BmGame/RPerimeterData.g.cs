#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPerimeterData<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RPerimeterData : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPerimeterData", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPerimeterData() { }

    /// <summary>
    /// Constructs a new RPerimeterData
    /// </summary>
    public RPerimeterData(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPerimeterData Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPerimeterData(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: EventCentre
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT EventCentre
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: StandPointList
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT StandPointList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }
}
