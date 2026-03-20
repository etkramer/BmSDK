#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ApexShapeSphere<br/>
/// (flags = 0)
/// </summary>
public partial class ApexShapeSphere : BmSDK.Engine.ApexShape, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ApexShapeSphere", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ApexShapeSphere() { }

    /// <summary>
    /// Constructs a new ApexShapeSphere
    /// </summary>
    public ApexShapeSphere(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ApexShapeSphere Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ApexShapeSphere(nint ptr) : base(ptr) { }

    /// <summary>
    /// ComponentProperty: Shape
    /// </summary>
    public unsafe BmSDK.Engine.DrawSphereComponent Shape
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DrawSphereComponent>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
