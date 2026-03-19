#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: InterpTrackAnimControl<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class InterpTrackAnimControl : BmSDK.Engine.InterpTrackFloatBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.InterpTrackAnimControl", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InterpTrackAnimControl() { }

    /// <summary>
    /// Constructs a new InterpTrackAnimControl
    /// </summary>
    public InterpTrackAnimControl(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InterpTrackAnimControl Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InterpTrackAnimControl(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: AnimSets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.InterpTrack.SubTracks>> AnimSets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.InterpTrack.SubTracks>>>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// NameProperty: SlotName
    /// </summary>
    public unsafe BmSDK.FName SlotName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// ArrayProperty: AnimSeqs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.InterpTrack.SubTracks> AnimSeqs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.InterpTrack.SubTracks>>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: bEnableRootMotion
    /// </summary>
    public unsafe bool bEnableRootMotion
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 296); }
    }

    /// <summary>
    /// BoolProperty: bEnableAutomaticTeleports
    /// </summary>
    public unsafe bool bEnableAutomaticTeleports
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 296); }
    }

    /// <summary>
    /// BoolProperty: bAllowOverrideFromFORCEMATINEEANIMFromURL
    /// </summary>
    public unsafe bool bAllowOverrideFromFORCEMATINEEANIMFromURL
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 296); }
    }

    /// <summary>
    /// BoolProperty: bSkipAnimNotifiers
    /// </summary>
    public unsafe bool bSkipAnimNotifiers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 296); }
    }

    /// <summary>
    /// BoolProperty: bStopDialogueOnStop
    /// </summary>
    public unsafe bool bStopDialogueOnStop
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 296); }
    }

    /// <summary>
    /// BoolProperty: bStopDialogueOnSkip
    /// </summary>
    public unsafe bool bStopDialogueOnSkip
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 296); }
    }

    /// <summary>
    /// BoolProperty: bStopDialogueOnJump
    /// </summary>
    public unsafe bool bStopDialogueOnJump
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 296); }
    }
}
