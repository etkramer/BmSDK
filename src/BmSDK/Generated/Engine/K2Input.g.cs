#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: K2Input<br/>
/// (size = 68)
/// (flags = 134217874)
/// </summary>
public partial class K2Input : BmSDK.Engine.K2Connector, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.K2Input", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal K2Input() { }

    /// <summary>
    /// Constructs a new K2Input
    /// </summary>
    public K2Input(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, K2Input Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected K2Input(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: FromOutput
    /// </summary>
    public unsafe BmSDK.Engine.K2Output FromOutput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.K2Output>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }
}
