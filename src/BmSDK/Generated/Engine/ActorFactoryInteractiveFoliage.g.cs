#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ActorFactoryInteractiveFoliage<br/>
/// (size = 108)
/// (flags = 134230166)
/// </summary>
public partial class ActorFactoryInteractiveFoliage : BmSDK.Engine.ActorFactoryStaticMesh, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ActorFactoryInteractiveFoliage", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ActorFactoryInteractiveFoliage() { }

    /// <summary>
    /// Constructs a new ActorFactoryInteractiveFoliage
    /// </summary>
    public ActorFactoryInteractiveFoliage(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ActorFactoryInteractiveFoliage Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ActorFactoryInteractiveFoliage(nint ptr) : base(ptr) { }

}
