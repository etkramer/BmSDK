#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMExitConditionCombiner<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMExitConditionCombiner : BmSDK.BmGame.RBMExitCondition, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMExitConditionCombiner", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMExitConditionCombiner() { }

    /// <summary>
    /// Constructs a new RBMExitConditionCombiner
    /// </summary>
    public RBMExitConditionCombiner(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMExitConditionCombiner Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMExitConditionCombiner(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: NumExitConditions
    /// </summary>
    public unsafe int NumExitConditions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// BoolProperty: bAllMustBeActiveInSameFrame
    /// </summary>
    public unsafe bool bAllMustBeActiveInSameFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 448) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 448); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 448); }
    }

    /// <summary>
    /// BoolProperty: bMustActivateInOrder
    /// </summary>
    public unsafe bool bMustActivateInOrder
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 448) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 448); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 448); }
    }

    /// <summary>
    /// ArrayProperty: ExitConditionsTriggered
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>> ExitConditionsTriggered
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }
}
