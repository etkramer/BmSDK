#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: AkSDEntityCountFriendlyPawnsInVolume<br/>
/// (flags = 0)
/// </summary>
public partial class AkSDEntityCountFriendlyPawnsInVolume : BmSDK.AkAudio.AkSDEntityCountPawnsInVolume, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.AkSDEntityCountFriendlyPawnsInVolume", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkSDEntityCountFriendlyPawnsInVolume() { }

    /// <summary>
    /// Constructs a new AkSDEntityCountFriendlyPawnsInVolume
    /// </summary>
    public AkSDEntityCountFriendlyPawnsInVolume(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkSDEntityCountFriendlyPawnsInVolume Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkSDEntityCountFriendlyPawnsInVolume(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Volume
    /// </summary>
    public unsafe BmSDK.Engine.Volume Volume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Volume>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// StrProperty: VolumeName
    /// </summary>
    public unsafe BmSDK.FString VolumeName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }
}
