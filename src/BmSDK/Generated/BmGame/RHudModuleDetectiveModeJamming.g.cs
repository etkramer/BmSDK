#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudModuleDetectiveModeJamming<br/>
/// (flags = 0)
/// </summary>
public partial class RHudModuleDetectiveModeJamming : BmSDK.BmGame.RHudModule, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHudModuleDetectiveModeJamming", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RHudModuleDetectiveModeJamming() { }

    /// <summary>
    /// Constructs a new RHudModuleDetectiveModeJamming
    /// </summary>
    public RHudModuleDetectiveModeJamming(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHudModuleDetectiveModeJamming Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHudModuleDetectiveModeJamming(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: CachedFunction_SetJammingLevel
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetJammingLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// FloatProperty: CachedCompromiseLevel
    /// </summary>
    public unsafe float CachedCompromiseLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// ByteProperty: CachedShowWarning
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieModularHud.EDetectiveModeDetectorStates CachedShowWarning
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieModularHud.EDetectiveModeDetectorStates>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// FloatProperty: CurrentDisplayValue
    /// </summary>
    public unsafe float CurrentDisplayValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: CachedIsJammedValue
    /// </summary>
    public unsafe bool CachedIsJammedValue
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }
}
