#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleSimNPC<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RVehicleSimNPC : BmSDK.Engine.SVehicleSimBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleSimNPC", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleSimNPC() { }

    /// <summary>
    /// Constructs a new RVehicleSimNPC
    /// </summary>
    public RVehicleSimNPC(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleSimNPC Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleSimNPC(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: DisabledByEMP
    /// </summary>
    public unsafe bool DisabledByEMP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 196); }
    }

    /// <summary>
    /// BoolProperty: DisabledByDroneDisruptor
    /// </summary>
    public unsafe bool DisabledByDroneDisruptor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 196); }
    }
}
