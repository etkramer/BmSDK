#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: K2Input_Float<br/>
/// (size = 72)
/// (flags = 134217874)
/// </summary>
public partial class K2Input_Float : BmSDK.Engine.K2Input, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.K2Input_Float", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal K2Input_Float() { }

    /// <summary>
    /// Constructs a new K2Input_Float
    /// </summary>
    public K2Input_Float(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, K2Input_Float Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected K2Input_Float(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: DefaultFloat
    /// </summary>
    public unsafe float DefaultFloat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }
}
