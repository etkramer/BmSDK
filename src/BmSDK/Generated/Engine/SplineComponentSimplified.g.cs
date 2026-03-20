#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SplineComponentSimplified<br/>
/// (flags = 0)
/// </summary>
public partial class SplineComponentSimplified : BmSDK.Engine.SplineComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SplineComponentSimplified", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SplineComponentSimplified() { }

    /// <summary>
    /// Constructs a new SplineComponentSimplified
    /// </summary>
    public SplineComponentSimplified(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SplineComponentSimplified Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SplineComponentSimplified(nint ptr) : base(ptr) { }

}
