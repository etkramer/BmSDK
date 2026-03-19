#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK;

/// <summary>
/// Class: StateObject<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class StateObject : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Core.StateObject", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal StateObject() { }

    /// <summary>
    /// Constructs a new StateObject
    /// </summary>
    public StateObject(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, StateObject Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected StateObject(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: StateFrame
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StateFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
