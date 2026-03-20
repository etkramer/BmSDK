#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_WaitForAllInputs<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_WaitForAllInputs : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_WaitForAllInputs", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_WaitForAllInputs() { }

    /// <summary>
    /// Constructs a new RSeqAct_WaitForAllInputs
    /// </summary>
    public RSeqAct_WaitForAllInputs(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_WaitForAllInputs Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_WaitForAllInputs(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: InputCount
    /// </summary>
    public unsafe int InputCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bTriggerOutputIfSkipped
    /// </summary>
    public unsafe bool bTriggerOutputIfSkipped
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 356); }
    }

    /// <summary>
    /// BoolProperty: Skipped
    /// </summary>
    public unsafe bool Skipped
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 356); }
    }

    /// <summary>
    /// ArrayProperty: InputsActivated
    /// </summary>
    public unsafe BmSDK.TArray<bool> InputsActivated
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<bool>>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }
}
