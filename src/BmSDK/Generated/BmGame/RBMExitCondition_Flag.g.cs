#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMExitCondition_Flag<br/>
/// (flags = 0)
/// </summary>
public partial class RBMExitCondition_Flag : BmSDK.BmGame.RBMExitCondition, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMExitCondition_Flag", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMExitCondition_Flag() { }

    /// <summary>
    /// Constructs a new RBMExitCondition_Flag
    /// </summary>
    public RBMExitCondition_Flag(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMExitCondition_Flag Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMExitCondition_Flag(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bExitWhenTrue
    /// </summary>
    public unsafe bool bExitWhenTrue
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }
    }
}
