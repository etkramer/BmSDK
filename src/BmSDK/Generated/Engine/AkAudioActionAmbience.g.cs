#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkAudioActionAmbience<br/>
/// (size = 56)
/// (flags = 134230162)
/// </summary>
public partial class AkAudioActionAmbience : BmSDK.Engine.AkAudioAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkAudioActionAmbience", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkAudioActionAmbience() { }

    /// <summary>
    /// Constructs a new AkAudioActionAmbience
    /// </summary>
    public AkAudioActionAmbience(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkAudioActionAmbience Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkAudioActionAmbience(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: AmbienceEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AmbienceEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }
}
