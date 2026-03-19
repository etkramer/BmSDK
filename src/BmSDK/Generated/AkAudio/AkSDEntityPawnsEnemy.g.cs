#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: AkSDEntityPawnsEnemy<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AkSDEntityPawnsEnemy : BmSDK.AkAudio.AkSDEntityPawns, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.AkSDEntityPawnsEnemy", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkSDEntityPawnsEnemy() { }

    /// <summary>
    /// Constructs a new AkSDEntityPawnsEnemy
    /// </summary>
    public AkSDEntityPawnsEnemy(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkSDEntityPawnsEnemy Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkSDEntityPawnsEnemy(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: PawnList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> PawnList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }
}
