#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSentryKitAssignmentPicker<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSentryKitAssignmentPicker : BmSDK.BmGame.RGroupAssignmentPicker, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSentryKitAssignmentPicker", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSentryKitAssignmentPicker() { }

    /// <summary>
    /// Constructs a new RSentryKitAssignmentPicker
    /// </summary>
    public RSentryKitAssignmentPicker(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSentryKitAssignmentPicker Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSentryKitAssignmentPicker(nint ptr) : base(ptr) { }

    /// <summary>
    /// ComponentProperty: RoomState
    /// </summary>
    public unsafe BmSDK.BmGame.RBMRoomAIState RoomState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMRoomAIState>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ObjectProperty: TargetPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RSentryGunPlacementPoint TargetPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSentryGunPlacementPoint>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: SentryKitList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RLootSourceBase> SentryKitList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RLootSourceBase>>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ArrayProperty: DestSearch
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSentryKitAssignmentPicker.FMultiDestPathFindInfo> DestSearch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSentryKitAssignmentPicker.FMultiDestPathFindInfo>>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// DelegateProperty: __SentryKitAssignmentFound__Delegate
    /// </summary>
    public unsafe System.IntPtr __SentryKitAssignmentFound__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// DelegateProperty: __SentryKitAssignmentFailed__Delegate
    /// </summary>
    public unsafe System.IntPtr __SentryKitAssignmentFailed__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }
}
