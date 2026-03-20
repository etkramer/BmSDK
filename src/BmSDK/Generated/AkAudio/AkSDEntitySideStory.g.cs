#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: AkSDEntitySideStory<br/>
/// (size = 268)
/// (flags = 0)
/// </summary>
public partial class AkSDEntitySideStory : BmSDK.AkAudio.AkSDEntitySymbol, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.AkSDEntitySideStory", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkSDEntitySideStory() { }

    /// <summary>
    /// Constructs a new AkSDEntitySideStory
    /// </summary>
    public AkSDEntitySideStory(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkSDEntitySideStory Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkSDEntitySideStory(nint ptr) : base(ptr) { }

}
