#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RActorFactoryBreakableProp<br/>
/// (size = 204)
/// (flags = 8401430)
/// </summary>
public partial class RActorFactoryBreakableProp : BmSDK.BmGame.RActorFactoryBreakablePropStatic, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RActorFactoryBreakableProp", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RActorFactoryBreakableProp() { }

    /// <summary>
    /// Constructs a new RActorFactoryBreakableProp
    /// </summary>
    public RActorFactoryBreakableProp(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RActorFactoryBreakableProp Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RActorFactoryBreakableProp(nint ptr) : base(ptr) { }

}
