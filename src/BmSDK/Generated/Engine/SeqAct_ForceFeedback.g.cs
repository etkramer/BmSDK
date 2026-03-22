#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqAct_ForceFeedback<br/>
/// (size = 212)
/// (flags = 8210)
/// </summary>
public partial class SeqAct_ForceFeedback : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqAct_ForceFeedback", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_ForceFeedback() { }

    /// <summary>
    /// Constructs a new SeqAct_ForceFeedback
    /// </summary>
    public SeqAct_ForceFeedback(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_ForceFeedback Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_ForceFeedback(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: FFWaveform
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform FFWaveform
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// ClassProperty: PredefinedWaveForm
    /// </summary>
    public unsafe BmSDK.Class PredefinedWaveForm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }
}
