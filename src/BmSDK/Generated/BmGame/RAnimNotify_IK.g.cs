#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RAnimNotify_IK<br/>
/// (size = 45)
/// (flags = 134230163)
/// </summary>
public partial class RAnimNotify_IK : BmSDK.Engine.AnimNotify, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNotify_IK", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNotify_IK() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_IK(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: Hand
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNotify_IK.EIKHand Hand
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNotify_IK.EIKHand>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// Enum: EIKHand
    /// </summary>
    public enum EIKHand
    {
        IKH_Left = 0,
        IKH_Right = 1,
        IKH_MAX = 2,
    }
}
