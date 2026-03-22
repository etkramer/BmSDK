#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkAudioActionAltitude<br/>
/// (size = 80)
/// (flags = 134230162)
/// </summary>
public partial class AkAudioActionAltitude : BmSDK.Engine.AkAudioAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkAudioActionAltitude", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkAudioActionAltitude() { }

    /// <summary>
    /// Constructs a new AkAudioActionAltitude
    /// </summary>
    public AkAudioActionAltitude(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkAudioActionAltitude Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkAudioActionAltitude(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: AltitudeFollowListener
    /// </summary>
    public unsafe BmSDK.Engine.AkWwise.EListenerID AltitudeFollowListener
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkWwise.EListenerID>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }

    /// <summary>
    /// ObjectProperty: AltitudeParameter
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName AltitudeParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// FloatProperty: Highest
    /// </summary>
    public unsafe float Highest
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// FloatProperty: Lowest
    /// </summary>
    public unsafe float Lowest
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// FloatProperty: AltitudeParameterCurrent
    /// </summary>
    public unsafe float AltitudeParameterCurrent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// StructProperty: AltitudeParameterLastUpdate
    /// </summary>
    public unsafe double AltitudeParameterLastUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<double>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }
}
