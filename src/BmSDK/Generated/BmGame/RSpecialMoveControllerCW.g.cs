#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveControllerCW<br/>
/// (flags = 0)
/// </summary>
public partial class RSpecialMoveControllerCW : BmSDK.BmGame.RSpecialMoveController, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveControllerCW", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveControllerCW() { }

    /// <summary>
    /// Constructs a new RSpecialMoveControllerCW
    /// </summary>
    public RSpecialMoveControllerCW(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveControllerCW Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveControllerCW(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: SpecialMoves
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.REnvironmentSpecialMoveWrapper> SpecialMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.REnvironmentSpecialMoveWrapper>>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// BoolProperty: bSimpleController
    /// </summary>
    public unsafe bool bSimpleController
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }
}
