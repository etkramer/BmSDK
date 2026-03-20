#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ForceFieldShapeBox<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ForceFieldShapeBox : BmSDK.Engine.ForceFieldShape, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ForceFieldShapeBox", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ForceFieldShapeBox() { }

    /// <summary>
    /// Constructs a new ForceFieldShapeBox
    /// </summary>
    public ForceFieldShapeBox(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ForceFieldShapeBox Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ForceFieldShapeBox(nint ptr) : base(ptr) { }

    /// <summary>
    /// ComponentProperty: Shape
    /// </summary>
    public unsafe BmSDK.Engine.DrawBoxComponent Shape
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DrawBoxComponent>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
