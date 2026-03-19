#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MeshComponentFactory<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MeshComponentFactory : BmSDK.Engine.PrimitiveComponentFactory, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MeshComponentFactory", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MeshComponentFactory() { }

    /// <summary>
    /// Constructs a new MeshComponentFactory
    /// </summary>
    public MeshComponentFactory(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MeshComponentFactory Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MeshComponentFactory(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: Materials
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT Materials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }
}
