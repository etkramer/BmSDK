#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudModuleHackingMode<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RHudModuleHackingMode : BmSDK.BmGame.RHudModule, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHudModuleHackingMode", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RHudModuleHackingMode() { }

    /// <summary>
    /// Constructs a new RHudModuleHackingMode
    /// </summary>
    public RHudModuleHackingMode(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHudModuleHackingMode Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHudModuleHackingMode(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: RPC
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: ModularHudMovie
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ModularHudMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ObjectProperty: GfxParentMovie
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GfxParentMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ObjectProperty: MovieInfo
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MovieInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// StrProperty: ExtensionName
    /// </summary>
    public unsafe BmSDK.FString ExtensionName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// StrProperty: ExtensionPath
    /// </summary>
    public unsafe BmSDK.FString ExtensionPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// BoolProperty: bReadyToCallFunctions
    /// </summary>
    public unsafe bool bReadyToCallFunctions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 148); }
    }

    /// <summary>
    /// BoolProperty: bFlashInitialised
    /// </summary>
    public unsafe bool bFlashInitialised
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 148); }
    }

    /// <summary>
    /// BoolProperty: bAdvanceModularHudMovieWhenCreated
    /// </summary>
    public unsafe bool bAdvanceModularHudMovieWhenCreated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 148); }
    }

    /// <summary>
    /// BoolProperty: CanBeTinted
    /// </summary>
    public unsafe bool CanBeTinted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 148); }
    }

    /// <summary>
    /// BoolProperty: IsDisposable
    /// </summary>
    public unsafe bool IsDisposable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 148); }
    }

    /// <summary>
    /// IntProperty: bWidescreenAdjust
    /// </summary>
    public unsafe int bWidescreenAdjust
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// StrProperty: LocalRootString
    /// </summary>
    public unsafe BmSDK.FString LocalRootString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_Show
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_Show
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_Hide
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_Hide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_RequestQuit
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_RequestQuit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetVisible
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetVisible
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// IntProperty: ModulePriority
    /// </summary>
    public unsafe int ModulePriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }
}
