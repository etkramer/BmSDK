#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: PrefabSequenceContainer<br/>
/// (flags = 0)
/// </summary>
public partial class PrefabSequenceContainer : BmSDK.Engine.Sequence, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.PrefabSequenceContainer", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal PrefabSequenceContainer() { }

    /// <summary>
    /// Constructs a new PrefabSequenceContainer
    /// </summary>
    public PrefabSequenceContainer(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, PrefabSequenceContainer Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected PrefabSequenceContainer(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: LogFile
    /// </summary>
    public unsafe System.IntPtr LogFile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// ArrayProperty: SequenceObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SequenceObject> SequenceObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SequenceObject>>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// ArrayProperty: ActiveSequenceOps
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SequenceOp> ActiveSequenceOps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SequenceOp>>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// ArrayProperty: NestedSequences
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Sequence> NestedSequences
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Sequence>>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// ArrayProperty: ActiveNestedSequences
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Sequence> ActiveNestedSequences
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Sequence>>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// ArrayProperty: PendingActiveNestedSequences
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Sequence> PendingActiveNestedSequences
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Sequence>>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// BoolProperty: ActiveNestedSequencesLocked
    /// </summary>
    public unsafe bool ActiveNestedSequencesLocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 412); }
    }

    /// <summary>
    /// BoolProperty: bEnabled
    /// </summary>
    public unsafe bool bEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 412); }
    }

    /// <summary>
    /// ArrayProperty: SequenceEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SequenceEvent> SequenceEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SequenceEvent>>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// ArrayProperty: UnregisteredEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SequenceEvent> UnregisteredEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SequenceEvent>>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// ArrayProperty: DelayedActivatedOps
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Sequence.FActivateOp> DelayedActivatedOps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Sequence.FActivateOp>>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// ArrayProperty: DelayedLatentOps
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SequenceOp> DelayedLatentOps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SequenceOp>>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// ArrayProperty: QueuedActivations
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Sequence.FQueuedActivationInfo> QueuedActivations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Sequence.FQueuedActivationInfo>>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// IntProperty: DefaultViewX
    /// </summary>
    public unsafe int DefaultViewX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// IntProperty: DefaultViewY
    /// </summary>
    public unsafe int DefaultViewY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// FloatProperty: DefaultViewZoom
    /// </summary>
    public unsafe float DefaultViewZoom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// StructProperty: SortKey
    /// </summary>
    public unsafe BmSDK.Engine.Sequence.FSequenceSortKey SortKey
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Sequence.FSequenceSortKey>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }
}
