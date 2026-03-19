#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkEvent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AkEvent : BmSDK.Engine.AkAsset, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkEvent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkEvent() { }

    /// <summary>
    /// Constructs a new AkEvent
    /// </summary>
    public AkEvent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkEvent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkEvent(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: MaxAttenuation
    /// </summary>
    public unsafe float MaxAttenuation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// IntProperty: MinZeroLatencyPrefetch
    /// </summary>
    public unsafe int MinZeroLatencyPrefetch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// ByteProperty: DurationType
    /// </summary>
    public unsafe byte DurationType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// Enum: EAkEventDurationType
    /// </summary>
    public enum EAkEventDurationType
    {
        AK_EVENT_DURATION_UNKNOWN = 0,
        AK_EVENT_DURATION_ONE_SHOT = 1,
        AK_EVENT_DURATION_INFINITE = 2,
        AK_EVENT_DURATION_MAX = 3,
    }
}
