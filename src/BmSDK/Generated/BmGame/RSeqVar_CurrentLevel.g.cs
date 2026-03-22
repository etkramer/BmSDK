#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqVar_CurrentLevel<br/>
/// (size = 140)
/// (flags = 134217874)
/// </summary>
public partial class RSeqVar_CurrentLevel : BmSDK.Engine.SeqVar_String, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqVar_CurrentLevel", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqVar_CurrentLevel() { }

    /// <summary>
    /// Constructs a new RSeqVar_CurrentLevel
    /// </summary>
    public RSeqVar_CurrentLevel(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqVar_CurrentLevel Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqVar_CurrentLevel(nint ptr) : base(ptr) { }

}
