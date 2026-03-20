#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveConfig_SmokeBombGrapple<br/>
/// (flags = 0)
/// </summary>
public partial class RSpecialMoveConfig_SmokeBombGrapple : BmSDK.BmGame.RSpecialMoveConfig_FireGrapple, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveConfig_SmokeBombGrapple", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_SmokeBombGrapple() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_SmokeBombGrapple
    /// </summary>
    public RSpecialMoveConfig_SmokeBombGrapple(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_SmokeBombGrapple Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_SmokeBombGrapple(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: SmokeTimer
    /// </summary>
    public unsafe float SmokeTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// NameProperty: SmokeBombTransitionName
    /// </summary>
    public unsafe BmSDK.FName SmokeBombTransitionName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// BoolProperty: PlayGrapple
    /// </summary>
    public unsafe bool PlayGrapple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 524) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 524); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 524); }
    }
}
