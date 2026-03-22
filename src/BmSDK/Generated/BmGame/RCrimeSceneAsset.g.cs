#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCrimeSceneAsset<br/>
/// (size = 88)
/// (flags = 134226066)
/// </summary>
public partial class RCrimeSceneAsset : BmSDK.BmGame.RConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCrimeSceneAsset", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCrimeSceneAsset() { }

    /// <summary>
    /// Constructs a new RCrimeSceneAsset
    /// </summary>
    public RCrimeSceneAsset(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCrimeSceneAsset Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCrimeSceneAsset(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: CrimeSceneName
    /// </summary>
    public unsafe BmSDK.FName CrimeSceneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// NameProperty: OptionalCasefileName
    /// </summary>
    public unsafe BmSDK.FName OptionalCasefileName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: DoNotEnterScanMode
    /// </summary>
    public unsafe bool DoNotEnterScanMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// ObjectProperty: EvidenceOverride
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie EvidenceOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// StrProperty: EvidenceOverrideAsString
    /// </summary>
    public unsafe BmSDK.FString EvidenceOverrideAsString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// IntProperty: FireEventWhenPartiallyComplete
    /// </summary>
    public unsafe int FireEventWhenPartiallyComplete
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }

    /// <summary>
    /// IntProperty: LockPlayerControlWhenPartiallyComplete
    /// </summary>
    public unsafe int LockPlayerControlWhenPartiallyComplete
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
