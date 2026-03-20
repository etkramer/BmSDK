#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPulleyRenderingComponent<br/>
/// (flags = 0)
/// </summary>
public partial class RPulleyRenderingComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPulleyRenderingComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPulleyRenderingComponent() { }

    /// <summary>
    /// Constructs a new RPulleyRenderingComponent
    /// </summary>
    public RPulleyRenderingComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPulleyRenderingComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPulleyRenderingComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Material
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface Material
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }
}
