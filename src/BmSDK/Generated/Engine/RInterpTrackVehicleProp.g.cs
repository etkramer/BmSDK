#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RInterpTrackVehicleProp<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RInterpTrackVehicleProp : BmSDK.Engine.InterpTrackFloatBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RInterpTrackVehicleProp", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RInterpTrackVehicleProp() { }

    /// <summary>
    /// Constructs a new RInterpTrackVehicleProp
    /// </summary>
    public RInterpTrackVehicleProp(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RInterpTrackVehicleProp Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RInterpTrackVehicleProp(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: ControlProperty
    /// </summary>
    public unsafe BmSDK.Engine.RInterpTrackVehicleProp.EVehiclePropertyForControl ControlProperty
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInterpTrackVehicleProp.EVehiclePropertyForControl>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// Enum: EVehiclePropertyForControl
    /// </summary>
    public enum EVehiclePropertyForControl
    {
        VP_RPM = 0,
        VP_Gear = 1,
        VP_Brake = 2,
        VP_Accelerator = 3,
        VP_Speed = 4,
        VP_Turbo = 5,
        VP_MAX = 6,
    }
}
