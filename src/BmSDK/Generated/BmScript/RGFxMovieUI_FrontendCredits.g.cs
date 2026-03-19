#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieUI_FrontendCredits<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGFxMovieUI_FrontendCredits : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieUI_FrontendCredits", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieUI_FrontendCredits() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_FrontendCredits
    /// </summary>
    public RGFxMovieUI_FrontendCredits(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_FrontendCredits Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_FrontendCredits(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: CreditsSectionOrder
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> CreditsSectionOrder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// BoolProperty: bFrontend
    /// </summary>
    public unsafe bool bFrontend
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1088); }
    }

    /// <summary>
    /// BoolProperty: bSkipable
    /// </summary>
    public unsafe bool bSkipable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1088); }
    }

    /// <summary>
    /// BoolProperty: bShowPromptAtStart
    /// </summary>
    public unsafe bool bShowPromptAtStart
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1088); }
    }

    /// <summary>
    /// BoolProperty: bDoubleSkip
    /// </summary>
    public unsafe bool bDoubleSkip
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1088); }
    }

    /// <summary>
    /// BoolProperty: bShown
    /// </summary>
    public unsafe bool bShown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1088); }
    }

    /// <summary>
    /// BoolProperty: bDone
    /// </summary>
    public unsafe bool bDone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1088); }
    }

    /// <summary>
    /// BoolProperty: bFirstSkipDone
    /// </summary>
    public unsafe bool bFirstSkipDone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1088); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1088); }
    }

    /// <summary>
    /// IntProperty: Counter
    /// </summary>
    public unsafe int Counter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }
}
