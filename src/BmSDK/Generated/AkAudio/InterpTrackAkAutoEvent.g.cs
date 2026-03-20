#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: InterpTrackAkAutoEvent<br/>
/// (flags = 0)
/// </summary>
public partial class InterpTrackAkAutoEvent : BmSDK.AkAudio.InterpTrackAkEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.InterpTrackAkAutoEvent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InterpTrackAkAutoEvent() { }

    /// <summary>
    /// Constructs a new InterpTrackAkAutoEvent
    /// </summary>
    public InterpTrackAkAutoEvent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InterpTrackAkAutoEvent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InterpTrackAkAutoEvent(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: BaseNameForAutoGeneration
    /// </summary>
    public unsafe BmSDK.FString BaseNameForAutoGeneration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }
}
