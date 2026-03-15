#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkEvent<br/>
/// (size = 60)
/// (flags = 134217874)
/// </summary>
public partial class AkEvent : BmSDK.Engine.AkAssetPrep, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkEvent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkEvent() { }

    /// <summary>
    /// Constructs a new AkEvent
    /// </summary>
    public AkEvent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkEvent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkEvent(nint ptr) : base(ptr) { }

}
