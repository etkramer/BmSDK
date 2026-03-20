#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_CornerActionTest<br/>
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_CornerActionTest : BmSDK.BmGame.RBMBehaviour_ActionQueue, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_CornerActionTest", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_CornerActionTest() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_CornerActionTest
    /// </summary>
    public RBMBehaviour_CornerActionTest(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_CornerActionTest Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_CornerActionTest(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: DestCorner
    /// </summary>
    public unsafe BmSDK.BmGame.RCornerWallMarker DestCorner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCornerWallMarker>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// ObjectProperty: OutTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RDummyTarget OutTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDummyTarget>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// ObjectProperty: OutCorner
    /// </summary>
    public unsafe BmSDK.BmGame.RCornerWallMarker OutCorner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCornerWallMarker>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// BoolProperty: bAggressiveExit
    /// </summary>
    public unsafe bool bAggressiveExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 612); }
    }

    /// <summary>
    /// ByteProperty: Dir
    /// </summary>
    public unsafe BmSDK.BmGame.RCornerPointBase.AmbushDir Dir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCornerPointBase.AmbushDir>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }
}
