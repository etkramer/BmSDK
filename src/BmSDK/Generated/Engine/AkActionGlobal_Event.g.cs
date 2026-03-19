#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkActionGlobal_Event<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AkActionGlobal_Event : BmSDK.Engine.AkActionGlobal, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkActionGlobal_Event", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkActionGlobal_Event() { }

    /// <summary>
    /// Constructs a new AkActionGlobal_Event
    /// </summary>
    public AkActionGlobal_Event(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkActionGlobal_Event Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkActionGlobal_Event(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: GlobalEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GlobalEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ByteProperty: GlobalSource
    /// </summary>
    public unsafe byte GlobalSource
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// BoolProperty: bUseSharedSource
    /// </summary>
    public unsafe bool bUseSharedSource
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bPlaying
    /// </summary>
    public unsafe bool bPlaying
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// Enum: EGlobalEventType
    /// </summary>
    public enum EGlobalEventType
    {
        AK_GLOBAL_EVENT_SFX = 0,
        AK_GLOBAL_EVENT_MUSIC = 1,
        AK_GLOBAL_EVENT_DIALOGUE = 2,
        AK_GLOBAL_EVENT_AMBIENCE = 3,
        AK_GLOBAL_EVENT_WEATHER = 4,
        AK_GLOBAL_EVENT_UI = 5,
        AK_GLOBAL_EVENT_HUD = 6,
        AK_GLOBAL_EVENT_KISMET = 7,
        AK_GLOBAL_EVENT_MOVIE = 8,
        AK_GLOBAL_EVENT_MATINEE = 9,
        AK_GLOBAL_EVENT_PHYSICS = 10,
        AK_GLOBAL_EVENT_ENVIRONMENT = 11,
        AK_GLOBAL_EVENT_PAD = 12,
        AK_GLOBAL_EVENT_FLASH = 13,
        AK_GLOBAL_EVENT_MAX = 14,
    }
}
