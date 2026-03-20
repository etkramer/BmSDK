#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBarkConvo<br/>
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
    public unsafe BmSDK.BmGame.RBarkFlagBase FlagBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkFlagBase>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ObjectProperty: Root
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkConvoAction Root
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkConvoAction>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ObjectProperty: Current
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkConvoAction Current
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkConvoAction>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ObjectProperty: SpeakingThug
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain SpeakingThug
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ObjectProperty: InputFlags
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkFlagBase InputFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkFlagBase>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ObjectProperty: GroupContext
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkGroupContext GroupContext
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkGroupContext>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ObjectProperty: AEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAlertEventCoordinatorBase AEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAlertEventCoordinatorBase>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ArrayProperty: ParentBarkSets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ParentBarkSets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ArrayProperty: AllNodes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBarkConvoNode> AllNodes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBarkConvoNode>>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// ArrayProperty: OrderedSpeakerList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> OrderedSpeakerList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// BoolProperty: bActive
    /// </summary>
    public unsafe bool bActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 212); }
    }

    /// <summary>
    /// BoolProperty: bNeverOverRadio
    /// </summary>
    public unsafe bool bNeverOverRadio
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 212); }
    }

    /// <summary>
    /// BoolProperty: bOrphanIfStopped
    /// </summary>
    public unsafe bool bOrphanIfStopped
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 212); }
    }

    /// <summary>
    /// BoolProperty: bLogAssignment
    /// </summary>
    public unsafe bool bLogAssignment
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 212); }
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
    public unsafe BmSDK.TArray<BmSDK.FName> FlagsUsedByFlagTypePawnRefs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// ArrayProperty: MinimalSpeakerList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBarkConvo.FVoicePawnRef> MinimalSpeakerList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBarkConvo.FVoicePawnRef>>(Ptr + 236); }
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
