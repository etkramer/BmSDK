#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: WaveFormBase<br/>
/// (size = 0)
/// (flags = 0)
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
    /// Constructs a new WaveFormBase
    /// </summary>
    public WaveFormBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, WaveFormBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected WaveFormBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: TheWaveForm
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform TheWaveForm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
