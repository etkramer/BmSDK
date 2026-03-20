#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNode_FilterList<br/>
/// (flags = 0)
/// </summary>
public partial class RAnimNode_FilterList : BmSDK.Engine.AnimNodeBlendBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNode_FilterList", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNode_FilterList() { }

    /// <summary>
    /// Constructs a new RAnimNode_FilterList
    /// </summary>
    public RAnimNode_FilterList(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNode_FilterList Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNode_FilterList(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: ChildFilterInBone
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> ChildFilterInBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// BoolProperty: bUseBaseAnimWhenNotRendered
    /// </summary>
    public unsafe bool bUseBaseAnimWhenNotRendered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 320); }
    }

    /// <summary>
    /// ArrayProperty: ChildFilterInBoneIndices
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAnimNode_FilterList.FFilterChildBones> ChildFilterInBoneIndices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAnimNode_FilterList.FFilterChildBones>>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }
}
