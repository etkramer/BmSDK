#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieUI_Stats<br/>
/// (flags = 0)
/// </summary>
public partial class RGFxMovieUI_Stats : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieUI_Stats", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieUI_Stats() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_Stats
    /// </summary>
    public RGFxMovieUI_Stats(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_Stats Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_Stats(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: ContentPath
    /// </summary>
    public unsafe BmSDK.FString ContentPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: bPlusUnlocked
    /// </summary>
    public unsafe bool bPlusUnlocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1088); }
    }

    /// <summary>
    /// IntProperty: PageId
    /// </summary>
    public unsafe int PageId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// IntProperty: TotalTrophies
    /// </summary>
    public unsafe int TotalTrophies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// IntProperty: UpgradePointsTotal
    /// </summary>
    public unsafe int UpgradePointsTotal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// IntProperty: UpgradePointsTotalBatman
    /// </summary>
    public unsafe int UpgradePointsTotalBatman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// IntProperty: UpgradePointsTotalCatwoman
    /// </summary>
    public unsafe int UpgradePointsTotalCatwoman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }
}
