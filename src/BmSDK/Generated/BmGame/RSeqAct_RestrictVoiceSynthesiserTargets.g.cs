#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_RestrictVoiceSynthesiserTargets<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_RestrictVoiceSynthesiserTargets : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_RestrictVoiceSynthesiserTargets", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_RestrictVoiceSynthesiserTargets() { }

    /// <summary>
    /// Constructs a new RSeqAct_RestrictVoiceSynthesiserTargets
    /// </summary>
    public RSeqAct_RestrictVoiceSynthesiserTargets(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_RestrictVoiceSynthesiserTargets Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_RestrictVoiceSynthesiserTargets(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: AllowedTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> AllowedTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ArrayProperty: BlockedTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> BlockedTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// BoolProperty: bAllowPathingToReachableFloor
    /// </summary>
    public unsafe bool bAllowPathingToReachableFloor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 384); }
    }
}
