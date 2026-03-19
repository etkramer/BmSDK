#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGrenadeGrateAssignmentPicker<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGrenadeGrateAssignmentPicker : BmSDK.BmGame.RGroupAssignmentPicker, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGrenadeGrateAssignmentPicker", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGrenadeGrateAssignmentPicker() { }

    /// <summary>
    /// Constructs a new RGrenadeGrateAssignmentPicker
    /// </summary>
    public RGrenadeGrateAssignmentPicker(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGrenadeGrateAssignmentPicker Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGrenadeGrateAssignmentPicker(nint ptr) : base(ptr) { }

    /// <summary>
    /// ComponentProperty: RoomState
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RoomState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ArrayProperty: GrateList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<System.IntPtr>> GrateList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: ThugSearch
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ThugSearch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// DelegateProperty: __GrenadeGrateAssignmentFound__Delegate
    /// </summary>
    public unsafe System.IntPtr __GrenadeGrateAssignmentFound__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// DelegateProperty: __GrenadeGrateAssignmentFailed__Delegate
    /// </summary>
    public unsafe System.IntPtr __GrenadeGrateAssignmentFailed__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }
}
