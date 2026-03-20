#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: AkSDEntityPlayerDetectiveMode<br/>
/// (flags = 0)
/// </summary>
public partial class AkSDEntityPlayerDetectiveMode : BmSDK.AkAudio.AkSDEntityPlayerBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.AkSDEntityPlayerDetectiveMode", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkSDEntityPlayerDetectiveMode() { }

    /// <summary>
    /// Constructs a new AkSDEntityPlayerDetectiveMode
    /// </summary>
    public AkSDEntityPlayerDetectiveMode(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkSDEntityPlayerDetectiveMode Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkSDEntityPlayerDetectiveMode(nint ptr) : base(ptr) { }

}
