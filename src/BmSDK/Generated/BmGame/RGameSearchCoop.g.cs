#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGameSearchCoop<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGameSearchCoop : BmSDK.Engine.OnlineGameSearch, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGameSearchCoop", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGameSearchCoop() { }

    /// <summary>
    /// Constructs a new RGameSearchCoop
    /// </summary>
    public RGameSearchCoop(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGameSearchCoop Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGameSearchCoop(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: MaxSearchResults
    /// </summary>
    public unsafe int MaxSearchResults
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// StructProperty: Query
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Query
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// BoolProperty: bIsLanQuery
    /// </summary>
    public unsafe bool bIsLanQuery
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bUsesArbitration
    /// </summary>
    public unsafe bool bUsesArbitration
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bIsSearchInProgress
    /// </summary>
    public unsafe bool bIsSearchInProgress
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// ClassProperty: GameSettingsClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GameSettingsClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// ArrayProperty: Results
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineGameSearch.NamedProperties> Results
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineGameSearch.NamedProperties>>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// StructProperty: ManualSkillOverride
    /// </summary>
    public unsafe BmSDK.Engine.OnlineGameSearch.NamedProperties ManualSkillOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineGameSearch.NamedProperties>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// ArrayProperty: NamedProperties
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineGameSearch.AdditionalSearchCriteria> NamedProperties
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineGameSearch.AdditionalSearchCriteria>>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// StructProperty: FilterQuery
    /// </summary>
    public unsafe BmSDK.Engine.OnlineGameSearch.AdditionalSearchCriteria FilterQuery
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineGameSearch.AdditionalSearchCriteria>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// StrProperty: AdditionalSearchCriteria
    /// </summary>
    public unsafe BmSDK.FString AdditionalSearchCriteria
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// IntProperty: PingBucketSize
    /// </summary>
    public unsafe int PingBucketSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// IntProperty: NumPingProbes
    /// </summary>
    public unsafe int NumPingProbes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// IntProperty: MaxPingBytes
    /// </summary>
    public unsafe int MaxPingBytes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }
}
