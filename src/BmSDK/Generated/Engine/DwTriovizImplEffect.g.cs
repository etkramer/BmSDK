#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DwTriovizImplEffect<br/>
/// (size = 124)
/// (flags = 0)
/// </summary>
public partial class DwTriovizImplEffect : BmSDK.Engine.PostProcessEffect, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DwTriovizImplEffect", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DwTriovizImplEffect() { }

    /// <summary>
    /// Constructs a new DwTriovizImplEffect
    /// </summary>
    public DwTriovizImplEffect(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DwTriovizImplEffect Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DwTriovizImplEffect(nint ptr) : base(ptr) { }

}
