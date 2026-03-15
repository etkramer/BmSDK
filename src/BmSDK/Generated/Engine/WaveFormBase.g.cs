#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: WaveFormBase<br/>
/// (size = 48)
/// (flags = 134217875)
/// </summary>
public partial class WaveFormBase : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.WaveFormBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal WaveFormBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected WaveFormBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: TheWaveForm
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform TheWaveForm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }
}
