#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveConfig_FireBatClaw<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSpecialMoveConfig_FireBatClaw : BmSDK.BmGame.RSpecialMoveConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveConfig_FireBatClaw", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_FireBatClaw() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_FireBatClaw
    /// </summary>
    public RSpecialMoveConfig_FireBatClaw(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_FireBatClaw Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_FireBatClaw(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: FireAnim
    /// </summary>
    public unsafe BmSDK.FName FireAnim_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }
    /// <summary>
    /// NameProperty: FireAnim
    /// </summary>
    public unsafe BmSDK.FName FireAnim_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }
    /// <summary>
    /// NameProperty: FireAnim
    /// </summary>
    public unsafe BmSDK.FName FireAnim_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }
    /// <summary>
    /// NameProperty: FireAnim
    /// </summary>
    public unsafe BmSDK.FName FireAnim_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// NameProperty: FireIdle
    /// </summary>
    public unsafe BmSDK.FName FireIdle_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }
    /// <summary>
    /// NameProperty: FireIdle
    /// </summary>
    public unsafe BmSDK.FName FireIdle_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }
    /// <summary>
    /// NameProperty: FireIdle
    /// </summary>
    public unsafe BmSDK.FName FireIdle_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }
    /// <summary>
    /// NameProperty: FireIdle
    /// </summary>
    public unsafe BmSDK.FName FireIdle_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// StructProperty: FireScreenShake
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FireScreenShake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// ObjectProperty: FireControllerShake
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FireControllerShake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }
}
