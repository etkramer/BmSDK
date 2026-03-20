#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_ModifyDoor<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_ModifyDoor : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_ModifyDoor", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_ModifyDoor() { }

    /// <summary>
    /// Constructs a new RSeqAct_ModifyDoor
    /// </summary>
    public RSeqAct_ModifyDoor(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_ModifyDoor Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_ModifyDoor(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: SaveGameDescription
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI.FDebugSaveDescription SaveGameDescription
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.FDebugSaveDescription>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ObjectProperty: CustomDoorOpenFront
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CustomDoorOpenFront
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// ObjectProperty: CustomDoorOpenBack
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CustomDoorOpenBack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// ObjectProperty: CustomDoorLockedFront
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CustomDoorLockedFront
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// ObjectProperty: CustomDoorLockedBack
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CustomDoorLockedBack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// ObjectProperty: CustomDoorOpenFrontDual
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CustomDoorOpenFrontDual
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// ObjectProperty: CustomDoorOpenBackDual
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CustomDoorOpenBackDual
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// BoolProperty: bDisableDoorTransition
    /// </summary>
    public unsafe bool bDisableDoorTransition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 436) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 436); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 436); }
    }

    /// <summary>
    /// BoolProperty: bMemoryOnlySave
    /// </summary>
    public unsafe bool bMemoryOnlySave
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 436) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 436); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 436); }
    }

    /// <summary>
    /// BoolProperty: bAllowSaveDuringChase
    /// </summary>
    public unsafe bool bAllowSaveDuringChase
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 436) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 436); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 436); }
    }
}
