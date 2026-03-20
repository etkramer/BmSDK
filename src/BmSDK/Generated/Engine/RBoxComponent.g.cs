#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RBoxComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBoxComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RBoxComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBoxComponent() { }

    /// <summary>
    /// Constructs a new RBoxComponent
    /// </summary>
    public RBoxComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBoxComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBoxComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: BoxColor
    /// </summary>
    public unsafe BmSDK.GameObject.FColor BoxColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// StructProperty: KBox
    /// </summary>
    public unsafe BmSDK.Engine.KMeshProps.FKBoxElem KBox
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.KMeshProps.FKBoxElem>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }
}
