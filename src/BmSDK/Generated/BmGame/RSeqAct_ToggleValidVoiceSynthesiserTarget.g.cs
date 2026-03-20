#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_ToggleValidVoiceSynthesiserTarget<br/>
/// (size = 352)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_ToggleValidVoiceSynthesiserTarget : BmSDK.Engine.SeqAct_Toggle, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_ToggleValidVoiceSynthesiserTarget", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_ToggleValidVoiceSynthesiserTarget() { }

    /// <summary>
    /// Constructs a new RSeqAct_ToggleValidVoiceSynthesiserTarget
    /// </summary>
    public RSeqAct_ToggleValidVoiceSynthesiserTarget(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_ToggleValidVoiceSynthesiserTarget Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_ToggleValidVoiceSynthesiserTarget(nint ptr) : base(ptr) { }

}
