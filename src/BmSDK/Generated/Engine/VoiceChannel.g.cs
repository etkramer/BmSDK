#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: VoiceChannel<br/>
/// (size = 100)
/// (flags = 268435592)
/// </summary>
public partial class VoiceChannel : BmSDK.Engine.Channel, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.VoiceChannel", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal VoiceChannel() { }

    /// <summary>
    /// Constructs a new VoiceChannel
    /// </summary>
    public VoiceChannel(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, VoiceChannel Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected VoiceChannel(nint ptr) : base(ptr) { }

}
