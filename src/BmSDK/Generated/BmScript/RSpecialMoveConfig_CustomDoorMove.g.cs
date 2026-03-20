#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveConfig_CustomDoorMove<br/>
/// (size = 492)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_CustomDoorMove : BmSDK.BmGame.RSpecialMoveConfig_RelativeAnimMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveConfig_CustomDoorMove", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_CustomDoorMove() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_CustomDoorMove
    /// </summary>
    public RSpecialMoveConfig_CustomDoorMove(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_CustomDoorMove Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_CustomDoorMove(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: DoorAnimName
    /// </summary>
    public unsafe BmSDK.FName DoorAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// ObjectProperty: DoorAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet DoorAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// ObjectProperty: OtherPlayerAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet OtherPlayerAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// NameProperty: OtherPlayerAnimName
    /// </summary>
    public unsafe BmSDK.FName OtherPlayerAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bPlayDoorAnimOnWrongDoor
    /// </summary>
    public unsafe bool bPlayDoorAnimOnWrongDoor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 488); }
    }
}
