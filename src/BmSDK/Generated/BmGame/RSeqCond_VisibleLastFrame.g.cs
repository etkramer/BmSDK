#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqCond_VisibleLastFrame<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqCond_VisibleLastFrame : BmSDK.Engine.SequenceCondition, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqCond_VisibleLastFrame", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqCond_VisibleLastFrame() { }

    /// <summary>
    /// Constructs a new RSeqCond_VisibleLastFrame
    /// </summary>
    public RSeqCond_VisibleLastFrame(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqCond_VisibleLastFrame Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqCond_VisibleLastFrame(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bIsActivated
    /// </summary>
    public unsafe bool bIsActivated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 224); }
    }

    /// <summary>
    /// BoolProperty: bIsCurrentDebuggerOp
    /// </summary>
    public unsafe bool bIsCurrentDebuggerOp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 224); }
    }

    /// <summary>
    /// BoolProperty: bKeepRenamedOutputLinks
    /// </summary>
    public unsafe bool bKeepRenamedOutputLinks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 224); }
    }

    /// <summary>
    /// BoolProperty: bActive
    /// </summary>
    public unsafe bool bActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 224); }
    }

    /// <summary>
    /// BoolProperty: bLatentExecution
    /// </summary>
    public unsafe bool bLatentExecution
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 224); }
    }

    /// <summary>
    /// BoolProperty: bStripInputLinkDesc
    /// </summary>
    public unsafe bool bStripInputLinkDesc
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 224); }
    }

    /// <summary>
    /// BoolProperty: bStripOutputLinkDesc
    /// </summary>
    public unsafe bool bStripOutputLinkDesc
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 224); }
    }

    /// <summary>
    /// BoolProperty: bAutoActivateOutputLinks
    /// </summary>
    public unsafe bool bAutoActivateOutputLinks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 224); }
    }

    /// <summary>
    /// BoolProperty: bDontStripEmptyVarLinks
    /// </summary>
    public unsafe bool bDontStripEmptyVarLinks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 224); }
    }

    /// <summary>
    /// BoolProperty: bHaveMovingVarConnector
    /// </summary>
    public unsafe bool bHaveMovingVarConnector
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 224); }
    }

    /// <summary>
    /// BoolProperty: bHaveMovingInputConnector
    /// </summary>
    public unsafe bool bHaveMovingInputConnector
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 224); }
    }

    /// <summary>
    /// BoolProperty: bHaveMovingOutputConnector
    /// </summary>
    public unsafe bool bHaveMovingOutputConnector
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 224); }
    }

    /// <summary>
    /// BoolProperty: bPendingVarConnectorRecalc
    /// </summary>
    public unsafe bool bPendingVarConnectorRecalc
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 224); }
    }

    /// <summary>
    /// BoolProperty: bPendingInputConnectorRecalc
    /// </summary>
    public unsafe bool bPendingInputConnectorRecalc
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 224); }
    }

    /// <summary>
    /// BoolProperty: bPendingOutputConnectorRecalc
    /// </summary>
    public unsafe bool bPendingOutputConnectorRecalc
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 224); }
    }

    /// <summary>
    /// BoolProperty: bIsBreakpointSet
    /// </summary>
    public unsafe bool bIsBreakpointSet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 224); }
    }

    /// <summary>
    /// BoolProperty: bIsHiddenBreakpointSet
    /// </summary>
    public unsafe bool bIsHiddenBreakpointSet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 224); }
    }

    /// <summary>
    /// FloatProperty: PIEActivationTime
    /// </summary>
    public unsafe float PIEActivationTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// ObjectProperty: ActivatorSeqOp
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ActivatorSeqOp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }

    /// <summary>
    /// IntProperty: LastActivatedInputLink
    /// </summary>
    public unsafe int LastActivatedInputLink
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// IntProperty: LastActivatedOutputLink
    /// </summary>
    public unsafe int LastActivatedOutputLink
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// IntProperty: FrameTag
    /// </summary>
    public unsafe int FrameTag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// ArrayProperty: InputLinks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>> InputLinks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// ArrayProperty: OutputLinks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> OutputLinks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// ArrayProperty: VariableLinks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> VariableLinks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// ArrayProperty: EventLinks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> EventLinks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// IntProperty: ActivateCount
    /// </summary>
    public unsafe int ActivateCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// IntProperty: SearchTag
    /// </summary>
    public unsafe int SearchTag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }
}
