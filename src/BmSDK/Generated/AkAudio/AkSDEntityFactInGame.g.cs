#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: AkSDEntityFactInGame<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AkSDEntityFactInGame : BmSDK.AkAudio.AkSDEntityFact, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.AkSDEntityFactInGame", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkSDEntityFactInGame() { }

    /// <summary>
    /// Constructs a new AkSDEntityFactInGame
    /// </summary>
    public AkSDEntityFactInGame(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkSDEntityFactInGame Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkSDEntityFactInGame(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: FactToCheck
    /// </summary>
    public unsafe BmSDK.FString FactToCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// BoolProperty: ResetFactIfTrue
    /// </summary>
    public unsafe bool ResetFactIfTrue
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }
}
