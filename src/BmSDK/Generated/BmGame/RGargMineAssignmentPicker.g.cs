#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGargMineAssignmentPicker<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGargMineAssignmentPicker : BmSDK.BmGame.RGroupAssignmentPicker, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGargMineAssignmentPicker", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGargMineAssignmentPicker() { }

    /// <summary>
    /// Constructs a new RGargMineAssignmentPicker
    /// </summary>
    public RGargMineAssignmentPicker(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGargMineAssignmentPicker Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGargMineAssignmentPicker(nint ptr) : base(ptr) { }

    /// <summary>
    /// ComponentProperty: RoomState
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RoomState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ArrayProperty: GargLocSearch
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<System.IntPtr>> GargLocSearch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: GargsAndDestsList
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> GargsAndDestsList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// DelegateProperty: __MineAssignmentFound__Delegate
    /// </summary>
    public unsafe System.IntPtr __MineAssignmentFound__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// DelegateProperty: __MineAssignmentFailed__Delegate
    /// </summary>
    public unsafe System.IntPtr __MineAssignmentFailed__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }
}
