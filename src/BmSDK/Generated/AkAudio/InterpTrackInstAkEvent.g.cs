#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: InterpTrackInstAkEvent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class InterpTrackInstAkEvent : BmSDK.Engine.InterpTrackInst, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.InterpTrackInstAkEvent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InterpTrackInstAkEvent() { }

    /// <summary>
    /// Constructs a new InterpTrackInstAkEvent
    /// </summary>
    public InterpTrackInstAkEvent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InterpTrackInstAkEvent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InterpTrackInstAkEvent(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: LastUpdatePosition
    /// </summary>
    public unsafe float LastUpdatePosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: PlayingHandles
    /// </summary>
    public unsafe BmSDK.TArray<NEED_UPDATE_OBJECTPROPERTY_LAYOUT> PlayingHandles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// BoolProperty: BanksLoaded
    /// </summary>
    public unsafe bool BanksLoaded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// ObjectProperty: TrackAudible
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TrackAudible
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }
}
