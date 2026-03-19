#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: AkSDEntityMusicPlaying<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AkSDEntityMusicPlaying : BmSDK.AkAudio.AkSDEntityValue, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.AkSDEntityMusicPlaying", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkSDEntityMusicPlaying() { }

    /// <summary>
    /// Constructs a new AkSDEntityMusicPlaying
    /// </summary>
    public AkSDEntityMusicPlaying(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkSDEntityMusicPlaying Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkSDEntityMusicPlaying(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: ValidName
    /// </summary>
    public unsafe bool ValidName
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 244); }
    }

    /// <summary>
    /// IntProperty: Type
    /// </summary>
    public unsafe int Type
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

}
