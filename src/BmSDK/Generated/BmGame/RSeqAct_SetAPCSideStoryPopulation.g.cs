#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_SetAPCSideStoryPopulation<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_SetAPCSideStoryPopulation : BmSDK.BmGame.RSeqAct_SetRandomPopulationBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_SetAPCSideStoryPopulation", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_SetAPCSideStoryPopulation() { }

    /// <summary>
    /// Constructs a new RSeqAct_SetAPCSideStoryPopulation
    /// </summary>
    public RSeqAct_SetAPCSideStoryPopulation(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_SetAPCSideStoryPopulation Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_SetAPCSideStoryPopulation(nint ptr) : base(ptr) { }

}
