#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ForceFieldShapeSphere<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ForceFieldShapeSphere : BmSDK.Engine.ForceFieldShape, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ForceFieldShapeSphere", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ForceFieldShapeSphere() { }

    /// <summary>
    /// Constructs a new ForceFieldShapeSphere
    /// </summary>
    public ForceFieldShapeSphere(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ForceFieldShapeSphere Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ForceFieldShapeSphere(nint ptr) : base(ptr) { }

    /// <summary>
    /// ComponentProperty: Shape
    /// </summary>
    public unsafe BmSDK.Engine.DrawSphereComponent Shape
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DrawSphereComponent>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
