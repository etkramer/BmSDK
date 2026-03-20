#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_BaseballBatNoRagdoll<br/>
/// (flags = 0)
/// </summary>
public partial class RDmgType_BaseballBatNoRagdoll : BmSDK.BmGame.RDmgType_Strike, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_BaseballBatNoRagdoll", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_BaseballBatNoRagdoll() { }

    /// <summary>
    /// Constructs a new RDmgType_BaseballBatNoRagdoll
    /// </summary>
    public RDmgType_BaseballBatNoRagdoll(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_BaseballBatNoRagdoll Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_BaseballBatNoRagdoll(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bAddScore
    /// </summary>
    public unsafe bool bAddScore
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 216); }
    }

    /// <summary>
    /// BoolProperty: bCanSlowMo
    /// </summary>
    public unsafe bool bCanSlowMo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 216); }
    }

    /// <summary>
    /// BoolProperty: bIncCombo
    /// </summary>
    public unsafe bool bIncCombo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 216); }
    }

    /// <summary>
    /// BoolProperty: bAdvanceToFreeFlow
    /// </summary>
    public unsafe bool bAdvanceToFreeFlow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 216); }
    }

    /// <summary>
    /// BoolProperty: bEnableMotionBlur
    /// </summary>
    public unsafe bool bEnableMotionBlur
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 216); }
    }

    /// <summary>
    /// BoolProperty: bCanBreakDestructables
    /// </summary>
    public unsafe bool bCanBreakDestructables
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 216); }
    }

    /// <summary>
    /// IntProperty: StrikeDamage
    /// </summary>
    public unsafe int StrikeDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// FloatProperty: StrainAmount
    /// </summary>
    public unsafe float StrainAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// ByteProperty: StrikeStrength
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.StrikeStrength StrikeStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.StrikeStrength>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// ByteProperty: StrikeRange
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.StrikeRange StrikeRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.StrikeRange>(Ptr + 229); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 229); }
    }

    /// <summary>
    /// FloatProperty: PreferredTargetDist
    /// </summary>
    public unsafe float PreferredTargetDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }
}
