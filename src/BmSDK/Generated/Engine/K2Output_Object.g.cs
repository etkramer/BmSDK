#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: K2Output_Object<br/>
/// (size = 80)
/// (flags = 134217874)
/// </summary>
public partial class K2Output_Object : BmSDK.Engine.K2Output, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.K2Output_Object", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal K2Output_Object() { }

    /// <summary>
    /// Constructs a new K2Output_Object
    /// </summary>
    public K2Output_Object(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, K2Output_Object Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected K2Output_Object(nint ptr) : base(ptr) { }

    /// <summary>
    /// ClassProperty: ObjClass
    /// </summary>
    public unsafe BmSDK.Class ObjClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 76); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }
    }
}
