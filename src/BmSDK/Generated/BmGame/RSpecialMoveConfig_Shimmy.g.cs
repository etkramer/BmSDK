#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveConfig_Shimmy<br/>
/// (size = 388)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_Shimmy : BmSDK.BmGame.RSpecialMoveConfig_RelativeAnimMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveConfig_Shimmy", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_Shimmy() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_Shimmy
    /// </summary>
    public RSpecialMoveConfig_Shimmy(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_Shimmy Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_Shimmy(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: ShimmyStartAnimName
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> ShimmyStartAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// ArrayProperty: ShimmyStopAnimName
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> ShimmyStopAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// FloatProperty: MaxAnimOverrideTime
    /// </summary>
    public unsafe float MaxAnimOverrideTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// FloatProperty: FasterMoveAnimTimeOffset
    /// </summary>
    public unsafe float FasterMoveAnimTimeOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// ByteProperty: ShimmyDir
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig_Shimmy.EShimmyDir ShimmyDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig_Shimmy.EShimmyDir>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// BoolProperty: bValidShimmyOverride
    /// </summary>
    public unsafe bool bValidShimmyOverride
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 384); }
    }

    /// <summary>
    /// Enum: EShimmyDir
    /// </summary>
    public enum EShimmyDir
    {
        SD_NoShimmy = 0,
        SD_ShimmyLeft = 1,
        SD_ShimmyRight = 2,
        SD_MAX = 3,
    }
}
