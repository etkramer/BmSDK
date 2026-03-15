#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: K2GraphBase<br/>
/// (size = 56)
/// (flags = 134217874)
/// </summary>
public partial class K2GraphBase : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.K2GraphBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal K2GraphBase() { }

    /// <summary>
    /// Constructs a new K2GraphBase
    /// </summary>
    public K2GraphBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, K2GraphBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected K2GraphBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: Nodes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.K2NodeBase> Nodes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.K2NodeBase>>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }
}
