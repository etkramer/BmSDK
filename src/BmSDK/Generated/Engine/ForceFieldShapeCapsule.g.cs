#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ForceFieldShapeCapsule<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ForceFieldShapeCapsule : BmSDK.Engine.ForceFieldShape, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ForceFieldShapeCapsule", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ForceFieldShapeCapsule() { }

    /// <summary>
    /// Constructs a new ForceFieldShapeCapsule
    /// </summary>
    public ForceFieldShapeCapsule(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ForceFieldShapeCapsule Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ForceFieldShapeCapsule(nint ptr) : base(ptr) { }

    /// <summary>
    /// ComponentProperty: Shape
    /// </summary>
    public unsafe BmSDK.Engine.DrawCapsuleComponent Shape
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DrawCapsuleComponent>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
