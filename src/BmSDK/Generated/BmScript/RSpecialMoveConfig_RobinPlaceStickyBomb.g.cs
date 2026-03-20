#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveConfig_RobinPlaceStickyBomb<br/>
/// (size = 500)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_RobinPlaceStickyBomb : BmSDK.BmGame.RSpecialMoveConfig_RelativeAnimMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveConfig_RobinPlaceStickyBomb", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_RobinPlaceStickyBomb() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_RobinPlaceStickyBomb
    /// </summary>
    public RSpecialMoveConfig_RobinPlaceStickyBomb(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_RobinPlaceStickyBomb Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_RobinPlaceStickyBomb(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: CrouchedAnim
    /// </summary>
    public unsafe BmSDK.FName CrouchedAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// NameProperty: StandingAnim
    /// </summary>
    public unsafe BmSDK.FName StandingAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// ObjectProperty: VictimAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VictimAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// NameProperty: VictimAnim
    /// </summary>
    public unsafe BmSDK.FName VictimAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// StructProperty: RotationOffset
    /// </summary>
    public unsafe BmSDK.Rotator RotationOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }
}
