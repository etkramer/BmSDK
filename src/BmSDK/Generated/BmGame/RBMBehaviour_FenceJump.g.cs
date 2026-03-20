#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_FenceJump<br/>
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_FenceJump : BmSDK.BmGame.RBMBehaviour, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_FenceJump", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_FenceJump() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_FenceJump
    /// </summary>
    public RBMBehaviour_FenceJump(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_FenceJump Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_FenceJump(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: JumpType
    /// </summary>
    public unsafe int JumpType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// StructProperty: JumpDirection
    /// </summary>
    public unsafe System.Numerics.Vector3 JumpDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// StructProperty: JumpLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 JumpLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// StructProperty: JumpAnim
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId JumpAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// BoolProperty: bCheckPawnsBelow
    /// </summary>
    public unsafe bool bCheckPawnsBelow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 620) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 620); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 620); }
    }

    /// <summary>
    /// ObjectProperty: InstigaterHandle
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationHandle InstigaterHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// ObjectProperty: InstigaterNode
    /// </summary>
    public unsafe BmSDK.Engine.PathNode InstigaterNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PathNode>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// ObjectProperty: InstigatorDestrubleProp
    /// </summary>
    public unsafe BmSDK.BmGame.RDestructibleProp InstigatorDestrubleProp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDestructibleProp>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// ObjectProperty: InstigatorVehicle
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle InstigatorVehicle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }
}
