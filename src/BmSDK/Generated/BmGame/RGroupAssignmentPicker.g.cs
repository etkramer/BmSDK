#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGroupAssignmentPicker<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGroupAssignmentPicker : BmSDK.StateObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGroupAssignmentPicker", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGroupAssignmentPicker() { }

    /// <summary>
    /// Constructs a new RGroupAssignmentPicker
    /// </summary>
    public RGroupAssignmentPicker(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGroupAssignmentPicker Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGroupAssignmentPicker(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: StateFrame
    /// </summary>
    public unsafe System.IntPtr StateFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
