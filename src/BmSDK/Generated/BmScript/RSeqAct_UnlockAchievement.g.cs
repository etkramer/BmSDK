#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_UnlockAchievement<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_UnlockAchievement : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_UnlockAchievement", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_UnlockAchievement() { }

    /// <summary>
    /// Constructs a new RSeqAct_UnlockAchievement
    /// </summary>
    public RSeqAct_UnlockAchievement(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_UnlockAchievement Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_UnlockAchievement(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: AchievementId
    /// </summary>
    public unsafe byte AchievementId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// IntProperty: Value
    /// </summary>
    public unsafe int Value
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }
}
