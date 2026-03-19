#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_AnyButtonSkips<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_AnyButtonSkips : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_AnyButtonSkips", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_AnyButtonSkips() { }

    /// <summary>
    /// Constructs a new RSeqAct_AnyButtonSkips
    /// </summary>
    public RSeqAct_AnyButtonSkips(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_AnyButtonSkips Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_AnyButtonSkips(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bOnlyAandBButton
    /// </summary>
    public unsafe bool bOnlyAandBButton
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bOnlyAandYButton
    /// </summary>
    public unsafe bool bOnlyAandYButton
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bIncludeSticks
    /// </summary>
    public unsafe bool bIncludeSticks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bOnlySticks
    /// </summary>
    public unsafe bool bOnlySticks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bIncludeTriggers
    /// </summary>
    public unsafe bool bIncludeTriggers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bNewVersion
    /// </summary>
    public unsafe bool bNewVersion
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bNewCheckA
    /// </summary>
    public unsafe bool bNewCheckA
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bNewCheckB
    /// </summary>
    public unsafe bool bNewCheckB
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bNewCheckX
    /// </summary>
    public unsafe bool bNewCheckX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bNewCheckY
    /// </summary>
    public unsafe bool bNewCheckY
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bNewCheckLT
    /// </summary>
    public unsafe bool bNewCheckLT
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bNewCheckRT
    /// </summary>
    public unsafe bool bNewCheckRT
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bNewCheckLS
    /// </summary>
    public unsafe bool bNewCheckLS
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bNewCheckRS
    /// </summary>
    public unsafe bool bNewCheckRS
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bNewCheckRB
    /// </summary>
    public unsafe bool bNewCheckRB
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bNewCheckLB
    /// </summary>
    public unsafe bool bNewCheckLB
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }
}
