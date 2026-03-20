#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ApexShapeBox<br/>
/// (flags = 0)
/// </summary>
public partial class ApexShapeBox : BmSDK.Engine.ApexShape, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ApexShapeBox", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ApexShapeBox() { }

    /// <summary>
    /// Constructs a new ApexShapeBox
    /// </summary>
    public ApexShapeBox(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ApexShapeBox Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ApexShapeBox(nint ptr) : base(ptr) { }

    /// <summary>
    /// ComponentProperty: Shape
    /// </summary>
    public unsafe BmSDK.Engine.DrawBoxComponent Shape
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DrawBoxComponent>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
