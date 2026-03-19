#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveConfig_HangOnHelicopter<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSpecialMoveConfig_HangOnHelicopter : BmSDK.BmGame.RSpecialMoveConfig_PlaceGooMine, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveConfig_HangOnHelicopter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_HangOnHelicopter() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_HangOnHelicopter
    /// </summary>
    public RSpecialMoveConfig_HangOnHelicopter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_HangOnHelicopter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_HangOnHelicopter(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: GrappleIn
    /// </summary>
    public unsafe BmSDK.FName GrappleIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// NameProperty: HelicopterIdle
    /// </summary>
    public unsafe BmSDK.FName HelicopterIdle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// NameProperty: DropOff
    /// </summary>
    public unsafe BmSDK.FName DropOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// NameProperty: RemoveControlModule
    /// </summary>
    public unsafe BmSDK.FName RemoveControlModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// BoolProperty: CanUseExplosiveGel
    /// </summary>
    public unsafe bool CanUseExplosiveGel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 572); }
    }

    /// <summary>
    /// BoolProperty: OneShotAnim
    /// </summary>
    public unsafe bool OneShotAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 572); }
    }

    /// <summary>
    /// NameProperty: ExplosiveGelIdleAnim
    /// </summary>
    public unsafe BmSDK.FName ExplosiveGelIdleAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// NameProperty: ExplosiveGelIdleInAnim
    /// </summary>
    public unsafe BmSDK.FName ExplosiveGelIdleInAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// NameProperty: ExplosiveGelIdleOutAnim
    /// </summary>
    public unsafe BmSDK.FName ExplosiveGelIdleOutAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// NameProperty: ExplosiveGelSprayAnim
    /// </summary>
    public unsafe BmSDK.FName ExplosiveGelSprayAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// ObjectProperty: GooMineArchetype
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GooMineArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// ObjectProperty: GelDummyAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GelDummyAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// NameProperty: GelDummyAnim
    /// </summary>
    public unsafe BmSDK.FName GelDummyAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// NameProperty: GForceFwdAnim
    /// </summary>
    public unsafe BmSDK.FName GForceFwdAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// NameProperty: GForceLeftAnim
    /// </summary>
    public unsafe BmSDK.FName GForceLeftAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// NameProperty: GForceRightAnim
    /// </summary>
    public unsafe BmSDK.FName GForceRightAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// NameProperty: GForceBackAnim
    /// </summary>
    public unsafe BmSDK.FName GForceBackAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// ArrayProperty: GlideOut
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> GlideOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// NameProperty: RemoveControlModuleCamera
    /// </summary>
    public unsafe BmSDK.FName RemoveControlModuleCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }
}
