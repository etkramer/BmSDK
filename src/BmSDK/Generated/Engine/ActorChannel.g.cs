#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ActorChannel<br/>
/// (size = 180)
/// (flags = 268435592)
/// </summary>
public partial class ActorChannel : BmSDK.Engine.Channel, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ActorChannel", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ActorChannel() { }

    /// <summary>
    /// Constructs a new ActorChannel
    /// </summary>
    public ActorChannel(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ActorChannel Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ActorChannel(nint ptr) : base(ptr) { }

}
