#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveConfig_RelativeAnimWithAlignment<br/>
/// (size = 360)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_RelativeAnimWithAlignment : BmSDK.BmGame.RSpecialMoveConfig_RelativeAnimMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveConfig_RelativeAnimWithAlignment", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_RelativeAnimWithAlignment() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_RelativeAnimWithAlignment
    /// </summary>
    public RSpecialMoveConfig_RelativeAnimWithAlignment(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_RelativeAnimWithAlignment Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_RelativeAnimWithAlignment(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: StartMovementStance
    /// </summary>
    public unsafe BmSDK.FName StartMovementStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// FloatProperty: AnimationStartRadius
    /// </summary>
    public unsafe float AnimationStartRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }
}
