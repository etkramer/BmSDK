#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudModuleGadgetSelect<br/>
/// (flags = 0)
/// </summary>
public partial class RHudModuleGadgetSelect : BmSDK.BmGame.RHudModule, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHudModuleGadgetSelect", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RHudModuleGadgetSelect() { }

    /// <summary>
    /// Constructs a new RHudModuleGadgetSelect
    /// </summary>
    public RHudModuleGadgetSelect(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHudModuleGadgetSelect Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHudModuleGadgetSelect(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: Cached_SetVisualGadget
    /// </summary>
    public unsafe BmSDK.FString Cached_SetVisualGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// StrProperty: Cached_ShowFailedGadget
    /// </summary>
    public unsafe BmSDK.FString Cached_ShowFailedGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// StrProperty: Cached_ShowRequiredGadget
    /// </summary>
    public unsafe BmSDK.FString Cached_ShowRequiredGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// StrProperty: Cached_ShowExplosiveGelCount
    /// </summary>
    public unsafe BmSDK.FString Cached_ShowExplosiveGelCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// StrProperty: Cached_SetGadgetParam
    /// </summary>
    public unsafe BmSDK.FString Cached_SetGadgetParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// IntProperty: ExplosiveGelCount
    /// </summary>
    public unsafe int ExplosiveGelCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileMovieInfo
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie BatmobileMovieInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// BoolProperty: InBatmobileMode
    /// </summary>
    public unsafe bool InBatmobileMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 332) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 332); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 332); }
    }

    /// <summary>
    /// BoolProperty: bMasterLock
    /// </summary>
    public unsafe bool bMasterLock
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 332) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 332); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 332); }
    }

    /// <summary>
    /// BoolProperty: bHighlightOn
    /// </summary>
    public unsafe bool bHighlightOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 332) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 332); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 332); }
    }

    /// <summary>
    /// IntProperty: HighlightGadget
    /// </summary>
    public unsafe int HighlightGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }
}
