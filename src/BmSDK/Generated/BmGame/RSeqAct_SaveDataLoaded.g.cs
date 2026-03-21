#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_SaveDataLoaded<br/>
/// (size = 204)
/// (flags = 134226066)
/// </summary>
public partial class RSeqAct_SaveDataLoaded : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_SaveDataLoaded", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_SaveDataLoaded() { }

    /// <summary>
    /// Constructs a new RSeqAct_SaveDataLoaded
    /// </summary>
    public RSeqAct_SaveDataLoaded(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_SaveDataLoaded Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_SaveDataLoaded(nint ptr) : base(ptr) { }

}
