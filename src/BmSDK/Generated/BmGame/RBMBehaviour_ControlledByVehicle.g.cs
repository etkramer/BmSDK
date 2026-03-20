#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_ControlledByVehicle<br/>
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_ControlledByVehicle : BmSDK.BmGame.RBMBehaviour_Controlled, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_ControlledByVehicle", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_ControlledByVehicle() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_ControlledByVehicle
    /// </summary>
    public RBMBehaviour_ControlledByVehicle(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_ControlledByVehicle Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_ControlledByVehicle(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bAllowBasingOnVehicles
    /// </summary>
    public unsafe bool bAllowBasingOnVehicles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 588); }
    }

    /// <summary>
    /// BoolProperty: bStopDialogueOnActivate
    /// </summary>
    public unsafe bool bStopDialogueOnActivate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 588); }
    }
}
