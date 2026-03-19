#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RAnimNotify_SoundInterruptable<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RAnimNotify_SoundInterruptable : BmSDK.Engine.RAnimNotify_SoundBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RAnimNotify_SoundInterruptable", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNotify_SoundInterruptable() { }

    /// <summary>
    /// Constructs a new RAnimNotify_SoundInterruptable
    /// </summary>
    public RAnimNotify_SoundInterruptable(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotify_SoundInterruptable Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_SoundInterruptable(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: EventName
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EventName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// StrProperty: CookedAndBackUpEventName
    /// </summary>
    public unsafe BmSDK.FString CookedAndBackUpEventName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: bOnlyWhenBackwards
    /// </summary>
    public unsafe bool bOnlyWhenBackwards
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreIfActorHidden
    /// </summary>
    public unsafe bool bIgnoreIfActorHidden
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreIfActorDead
    /// </summary>
    public unsafe bool bIgnoreIfActorDead
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: SkipLargeTimeDifferences
    /// </summary>
    public unsafe bool SkipLargeTimeDifferences
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: TwoDimensional
    /// </summary>
    public unsafe bool TwoDimensional
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: bLongSingleShot
    /// </summary>
    public unsafe bool bLongSingleShot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: bTempMute
    /// </summary>
    public unsafe bool bTempMute
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// ArrayProperty: CharacterFilters
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT CharacterFilters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }
}
