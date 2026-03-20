#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: AkAudioSystem<br/>
/// (flags = 0)
/// </summary>
public partial class AkAudioSystem : BmSDK.Subsystem, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.AkAudioSystem", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkAudioSystem() { }

    /// <summary>
    /// Constructs a new AkAudioSystem
    /// </summary>
    public AkAudioSystem(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkAudioSystem Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkAudioSystem(nint ptr) : base(ptr) { }

}
