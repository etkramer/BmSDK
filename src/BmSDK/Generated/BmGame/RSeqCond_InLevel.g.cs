#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqCond_InLevel<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqCond_InLevel : BmSDK.Engine.SequenceCondition, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqCond_InLevel", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqCond_InLevel() { }

    /// <summary>
    /// Constructs a new RSeqCond_InLevel
    /// </summary>
    public RSeqCond_InLevel(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqCond_InLevel Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqCond_InLevel(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: ValidLevels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> ValidLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// StrProperty: PersistentMap
    /// </summary>
    public unsafe BmSDK.FString PersistentMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// BoolProperty: bTrackRemoteControlledBatarang
    /// </summary>
    public unsafe bool bTrackRemoteControlledBatarang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 356); }
    }
}
