#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RAnimNotify_SoundInterruptable<br/>
/// (flags = 0)
/// </summary>
public partial class RAnimNotify_SoundInterruptable : BmSDK.Engine.RAnimNotify_SoundBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RAnimNotify_SoundInterruptable", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNotify_SoundInterruptable() { }

    /// <summary>
    /// Constructs a new RAnimNotify_SoundInterruptable
    /// </summary>
    public RAnimNotify_SoundInterruptable(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotify_SoundInterruptable Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_SoundInterruptable(nint ptr) : base(ptr) { }

}
