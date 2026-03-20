#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: AkSDEntityMusicState<br/>
/// (size = 284)
/// (flags = 0)
/// </summary>
public partial class AkSDEntityMusicState : BmSDK.AkAudio.AkSDEntitySymbol, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.AkSDEntityMusicState", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkSDEntityMusicState() { }

    /// <summary>
    /// Constructs a new AkSDEntityMusicState
    /// </summary>
    public AkSDEntityMusicState(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkSDEntityMusicState Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkSDEntityMusicState(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: StateToReturn
    /// </summary>
    public unsafe BmSDK.FString StateToReturn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }
}
