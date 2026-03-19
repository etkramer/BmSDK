#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: AkSDEntityPlayerVehicleSpeed<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AkSDEntityPlayerVehicleSpeed : BmSDK.AkAudio.AkSDEntityPlayerBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.AkSDEntityPlayerVehicleSpeed", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkSDEntityPlayerVehicleSpeed() { }

    /// <summary>
    /// Constructs a new AkSDEntityPlayerVehicleSpeed
    /// </summary>
    public AkSDEntityPlayerVehicleSpeed(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkSDEntityPlayerVehicleSpeed Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkSDEntityPlayerVehicleSpeed(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: Speed
    /// </summary>
    public unsafe float Speed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }
}
