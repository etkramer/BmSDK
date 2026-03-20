#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_BeingEatenByPlant<br/>
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_BeingEatenByPlant : BmSDK.BmGame.RBMBehaviour_ActionQueue, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_BeingEatenByPlant", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_BeingEatenByPlant() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_BeingEatenByPlant
    /// </summary>
    public RBMBehaviour_BeingEatenByPlant(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_BeingEatenByPlant Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_BeingEatenByPlant(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bExitWhenAnimFinished
    /// </summary>
    public unsafe bool bExitWhenAnimFinished
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 588); }
    }

    /// <summary>
    /// BoolProperty: bOriginalPredVision
    /// </summary>
    public unsafe bool bOriginalPredVision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 588); }
    }

    /// <summary>
    /// ObjectProperty: Plant
    /// </summary>
    public unsafe BmSDK.BmGame.RThugEatingPlantBase Plant
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RThugEatingPlantBase>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }
}
