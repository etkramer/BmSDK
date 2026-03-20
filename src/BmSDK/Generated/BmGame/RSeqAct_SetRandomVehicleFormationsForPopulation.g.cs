#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_SetRandomVehicleFormationsForPopulation<br/>
/// (size = 604)
/// (flags = 8210)
/// </summary>
public partial class RSeqAct_SetRandomVehicleFormationsForPopulation : BmSDK.BmGame.RSeqAct_SetRandomPopulationBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_SetRandomVehicleFormationsForPopulation", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_SetRandomVehicleFormationsForPopulation() { }

    /// <summary>
    /// Constructs a new RSeqAct_SetRandomVehicleFormationsForPopulation
    /// </summary>
    public RSeqAct_SetRandomVehicleFormationsForPopulation(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_SetRandomVehicleFormationsForPopulation Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_SetRandomVehicleFormationsForPopulation(nint ptr) : base(ptr) { }

}
