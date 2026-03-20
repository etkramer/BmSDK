#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: AkSDEntityPlayerInCurrentBaseMap<br/>
/// (flags = 0)
/// </summary>
public partial class AkSDEntityPlayerInCurrentBaseMap : BmSDK.AkAudio.AkSDEntityValue, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.AkSDEntityPlayerInCurrentBaseMap", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkSDEntityPlayerInCurrentBaseMap() { }

    /// <summary>
    /// Constructs a new AkSDEntityPlayerInCurrentBaseMap
    /// </summary>
    public AkSDEntityPlayerInCurrentBaseMap(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkSDEntityPlayerInCurrentBaseMap Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkSDEntityPlayerInCurrentBaseMap(nint ptr) : base(ptr) { }

}
