#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_ExplodeFractureWall<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_ExplodeFractureWall : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_ExplodeFractureWall", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_ExplodeFractureWall() { }

    /// <summary>
    /// Constructs a new RSeqAct_ExplodeFractureWall
    /// </summary>
    public RSeqAct_ExplodeFractureWall(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_ExplodeFractureWall Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_ExplodeFractureWall(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: ExplodeVelocity
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ExplodeVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bIncludeSupportChunks
    /// </summary>
    public unsafe bool bIncludeSupportChunks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 364) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 364); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 364); }
    }

    /// <summary>
    /// BoolProperty: bWantPhysChunksAndParticles
    /// </summary>
    public unsafe bool bWantPhysChunksAndParticles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 364) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 364); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 364); }
    }
}
