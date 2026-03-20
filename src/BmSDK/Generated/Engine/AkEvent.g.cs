#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkEvent<br/>
/// (size = 109)
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
    /// Function: IsAudibleAt
    /// </summary>
    public unsafe bool IsAudibleAt(float distanceUU, bool resultIfUnknown)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AkEvent.IsAudibleAt", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(distanceUU, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(resultIfUnknown, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

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
    public unsafe BmSDK.Engine.AkEvent.EAkEventDurationType DurationType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent.EAkEventDurationType>(Ptr + 108); }
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
