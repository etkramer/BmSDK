#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: AkSDEntityCountEnemyPawnsInVolume<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AkSDEntityCountEnemyPawnsInVolume : BmSDK.AkAudio.AkSDEntityCountPawnsInVolume, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.AkSDEntityCountEnemyPawnsInVolume", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkSDEntityCountEnemyPawnsInVolume() { }

    /// <summary>
    /// Constructs a new AkSDEntityCountEnemyPawnsInVolume
    /// </summary>
    public AkSDEntityCountEnemyPawnsInVolume(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkSDEntityCountEnemyPawnsInVolume Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkSDEntityCountEnemyPawnsInVolume(nint ptr) : base(ptr) { }

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
