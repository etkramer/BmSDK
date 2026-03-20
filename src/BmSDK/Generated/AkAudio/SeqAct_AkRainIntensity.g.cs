#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: SeqAct_AkRainIntensity<br/>
/// (size = 364)
/// (flags = 134226066)
/// </summary>
public partial class SeqAct_AkRainIntensity : BmSDK.AkAudio.SeqAct_AkBaseSimple, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.SeqAct_AkRainIntensity", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_AkRainIntensity() { }

    /// <summary>
    /// Constructs a new SeqAct_AkRainIntensity
    /// </summary>
    public SeqAct_AkRainIntensity(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_AkRainIntensity Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_AkRainIntensity(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: RainIntensity
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkRainIntensity.EAkRainIntensitySetting RainIntensity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkRainIntensity.EAkRainIntensitySetting>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ObjectProperty: RainBed
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent RainBed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// Enum: EAkRainIntensitySetting
    /// </summary>
    public enum EAkRainIntensitySetting
    {
        AK_RAIN_INTENSITY_SETTING_NONE = 0,
        AK_RAIN_INTENSITY_SETTING_LIGHT = 1,
        AK_RAIN_INTENSITY_SETTING_MODERATE = 2,
        AK_RAIN_INTENSITY_SETTING_HEAVY = 3,
        AK_RAIN_INTENSITY_SETTING_MAX = 4,
    }
}
