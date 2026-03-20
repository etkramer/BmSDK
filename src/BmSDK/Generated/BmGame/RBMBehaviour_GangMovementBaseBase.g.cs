#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_GangMovementBaseBase<br/>
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_GangMovementBaseBase : BmSDK.BmGame.RBMBehaviour_MoveToBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_GangMovementBaseBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_GangMovementBaseBase() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_GangMovementBaseBase
    /// </summary>
    public RBMBehaviour_GangMovementBaseBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_GangMovementBaseBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_GangMovementBaseBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: AnimSprint
    /// </summary>
    public unsafe BmSDK.FName AnimSprint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// NameProperty: AnimRun
    /// </summary>
    public unsafe BmSDK.FName AnimRun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// NameProperty: AnimFleeRun
    /// </summary>
    public unsafe BmSDK.FName AnimFleeRun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// NameProperty: AnimWalk
    /// </summary>
    public unsafe BmSDK.FName AnimWalk
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// NameProperty: AnimSlowWalk
    /// </summary>
    public unsafe BmSDK.FName AnimSlowWalk
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// ObjectProperty: RunVariantAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet RunVariantAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// ObjectProperty: walkVariantAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet walkVariantAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// ObjectProperty: PushOffAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PushOffAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ObjectProperty: MilitiaRunVariantAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet MilitiaRunVariantAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// ObjectProperty: MilitiaWalkVariantAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet MilitiaWalkVariantAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// ObjectProperty: MilitiaPushOffAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet MilitiaPushOffAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// ArrayProperty: ExtraMovementAnimSets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> ExtraMovementAnimSets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// ArrayProperty: MilitiaExtraMovementAnimSets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> MilitiaExtraMovementAnimSets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// BoolProperty: bCanUseWeaponConfigPool
    /// </summary>
    public unsafe bool bCanUseWeaponConfigPool
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }
    }
}
