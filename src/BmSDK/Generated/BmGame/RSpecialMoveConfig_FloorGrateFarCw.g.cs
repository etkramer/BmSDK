#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveConfig_FloorGrateFarCw<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSpecialMoveConfig_FloorGrateFarCw : BmSDK.BmGame.RSpecialMoveConfig_FloorGrateFar, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveConfig_FloorGrateFarCw", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_FloorGrateFarCw() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_FloorGrateFarCw
    /// </summary>
    public RSpecialMoveConfig_FloorGrateFarCw(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_FloorGrateFarCw Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_FloorGrateFarCw(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: JumpAnimName
    /// </summary>
    public unsafe BmSDK.FName JumpAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// NameProperty: EnterGrateAnimName
    /// </summary>
    public unsafe BmSDK.FName EnterGrateAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// NameProperty: Jump180AnimName
    /// </summary>
    public unsafe BmSDK.FName Jump180AnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// NameProperty: EnterGrate180AnimName
    /// </summary>
    public unsafe BmSDK.FName EnterGrate180AnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// FloatProperty: JumpDistanceToGrate
    /// </summary>
    public unsafe float JumpDistanceToGrate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }
}
