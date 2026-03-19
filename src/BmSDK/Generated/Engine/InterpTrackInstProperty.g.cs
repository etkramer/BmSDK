#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: InterpTrackInstProperty<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class InterpTrackInstProperty : BmSDK.Engine.InterpTrackInst, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.InterpTrackInstProperty", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InterpTrackInstProperty() { }

    /// <summary>
    /// Constructs a new InterpTrackInstProperty
    /// </summary>
    public InterpTrackInstProperty(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InterpTrackInstProperty Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InterpTrackInstProperty(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: PropertyUpdateCallback
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PropertyUpdateCallback
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: PropertyOuterObjectInst
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PropertyOuterObjectInst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }
}
