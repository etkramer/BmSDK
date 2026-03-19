#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBarkConvo<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBarkConvo : BmSDK.Engine.AkHash, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBarkConvo", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBarkConvo() { }

    /// <summary>
    /// Constructs a new RBarkConvo
    /// </summary>
    public RBarkConvo(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBarkConvo Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBarkConvo(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: RawBarkFlags
    /// </summary>
    public unsafe BmSDK.FString RawBarkFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ObjectProperty: FlagBase
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FlagBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ObjectProperty: Root
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkConvo.ParentBarkSets Root
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkConvo.ParentBarkSets>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ObjectProperty: Current
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Current
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ObjectProperty: SpeakingThug
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SpeakingThug
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ObjectProperty: InputFlags
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT InputFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ObjectProperty: GroupContext
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GroupContext
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ObjectProperty: AEC
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ArrayProperty: ParentBarkSets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>>> ParentBarkSets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>>>>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ArrayProperty: AllNodes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>> AllNodes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>>>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// ArrayProperty: OrderedSpeakerList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>> OrderedSpeakerList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// BoolProperty: bActive
    /// </summary>
    public unsafe bool bActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 212); }
    }

    /// <summary>
    /// BoolProperty: bNeverOverRadio
    /// </summary>
    public unsafe bool bNeverOverRadio
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 212); }
    }

    /// <summary>
    /// BoolProperty: bOrphanIfStopped
    /// </summary>
    public unsafe bool bOrphanIfStopped
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 212); }
    }

    /// <summary>
    /// BoolProperty: bLogAssignment
    /// </summary>
    public unsafe bool bLogAssignment
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 212); }
    }

    /// <summary>
    /// IntProperty: SearchID
    /// </summary>
    public unsafe int SearchID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }

    /// <summary>
    /// ArrayProperty: FlagsUsedByFlagTypePawnRefs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<System.IntPtr>> FlagsUsedByFlagTypePawnRefs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// ArrayProperty: MinimalSpeakerList
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> MinimalSpeakerList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// DelegateProperty: __BarkFinished__Delegate
    /// </summary>
    public unsafe System.IntPtr __BarkFinished__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }
}
