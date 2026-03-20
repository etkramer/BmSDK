#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_SetRandomVehiclePopulation<br/>
/// (size = 604)
/// (flags = 8210)
/// </summary>
public partial class RSeqAct_SetRandomVehiclePopulation : BmSDK.BmGame.RSeqAct_SetRandomPopulationBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_SetRandomVehiclePopulation", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_SetRandomVehiclePopulation() { }

    /// <summary>
    /// Constructs a new RSeqAct_SetRandomVehiclePopulation
    /// </summary>
    public RSeqAct_SetRandomVehiclePopulation(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_SetRandomVehiclePopulation Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_SetRandomVehiclePopulation(nint ptr) : base(ptr) { }

}
