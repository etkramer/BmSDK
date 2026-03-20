#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ApexShape<br/>
/// (size = 84)
/// (flags = 0)
/// </summary>
public partial class ApexShape : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ApexShape", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ApexShape() { }

    /// <summary>
    /// Constructs a new ApexShape
    /// </summary>
    public ApexShape(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ApexShape Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ApexShape(nint ptr) : base(ptr) { }

}
