#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_HasVillainRecently<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_HasVillainRecently : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_HasVillainRecently", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_HasVillainRecently() { }

    /// <summary>
    /// Constructs a new RSeqAct_HasVillainRecently
    /// </summary>
    public RSeqAct_HasVillainRecently(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_HasVillainRecently Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_HasVillainRecently(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: ActionToCheck
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_HasVillainRecently.RecencyCheckableActions ActionToCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_HasVillainRecently.RecencyCheckableActions>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ArrayProperty: villains
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnVillain> villains
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnVillain>>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// FloatProperty: timeSinceActionPerformed
    /// </summary>
    public unsafe float timeSinceActionPerformed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// Enum: RecencyCheckableActions
    /// </summary>
    public enum RecencyCheckableActions
    {
        eRCA_BeenHitByFlashbang = 0,
        eRCA_BeenRevivingSomeone = 1,
        eRCA_BeenStartledByPlayer = 2,
        eRCA_HitByElectroBlastStrong = 3,
        eRCA_BeenFollowingVoiceSynthOrder = 4,
        eRCA_HitByRoundTheBackarang = 5,
        eRCA_BeenInGunJamReaction = 6,
        eRCA_MAX = 7,
    }
}
