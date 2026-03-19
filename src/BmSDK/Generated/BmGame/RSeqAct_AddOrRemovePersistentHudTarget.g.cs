#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_AddOrRemovePersistentHudTarget<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_AddOrRemovePersistentHudTarget : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_AddOrRemovePersistentHudTarget", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_AddOrRemovePersistentHudTarget() { }

    /// <summary>
    /// Constructs a new RSeqAct_AddOrRemovePersistentHudTarget
    /// </summary>
    public RSeqAct_AddOrRemovePersistentHudTarget(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_AddOrRemovePersistentHudTarget Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_AddOrRemovePersistentHudTarget(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: HudTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> HudTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ArrayProperty: LinkedActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> LinkedActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// StrProperty: AnimNameForAdd
    /// </summary>
    public unsafe BmSDK.FString AnimNameForAdd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// BoolProperty: ClampOnscreen
    /// </summary>
    public unsafe bool ClampOnscreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 400); }
    }

    /// <summary>
    /// BoolProperty: ShowDistance
    /// </summary>
    public unsafe bool ShowDistance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 400); }
    }

    /// <summary>
    /// BoolProperty: PositionAboveTarget
    /// </summary>
    public unsafe bool PositionAboveTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 400); }
    }

    /// <summary>
    /// BoolProperty: ActorsCanMove
    /// </summary>
    public unsafe bool ActorsCanMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 400); }
    }

    /// <summary>
    /// BoolProperty: SuppressDuringRemoteControl
    /// </summary>
    public unsafe bool SuppressDuringRemoteControl
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 400); }
    }

    /// <summary>
    /// BoolProperty: FadeDuringCombat
    /// </summary>
    public unsafe bool FadeDuringCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 400); }
    }

    /// <summary>
    /// StrProperty: OptionalFocusString
    /// </summary>
    public unsafe BmSDK.FString OptionalFocusString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// StrProperty: MapRefName
    /// </summary>
    public unsafe BmSDK.FString MapRefName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// StrProperty: MapTypeName
    /// </summary>
    public unsafe BmSDK.FString MapTypeName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }
}
