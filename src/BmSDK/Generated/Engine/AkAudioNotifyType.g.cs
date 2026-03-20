#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkAudioNotifyType<br/>
/// (flags = 0)
/// </summary>
public partial class AkAudioNotifyType : BmSDK.Engine.AkHash, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkAudioNotifyType", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkAudioNotifyType() { }

    /// <summary>
    /// Constructs a new AkAudioNotifyType
    /// </summary>
    public AkAudioNotifyType(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkAudioNotifyType Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkAudioNotifyType(nint ptr) : base(ptr) { }

}
