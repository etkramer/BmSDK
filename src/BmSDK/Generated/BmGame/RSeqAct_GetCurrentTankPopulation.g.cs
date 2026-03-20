#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_GetCurrentTankPopulation<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_GetCurrentTankPopulation : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_GetCurrentTankPopulation", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_GetCurrentTankPopulation() { }

    /// <summary>
    /// Constructs a new RSeqAct_GetCurrentTankPopulation
    /// </summary>
    public RSeqAct_GetCurrentTankPopulation(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_GetCurrentTankPopulation Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_GetCurrentTankPopulation(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: NumTanks
    /// </summary>
    public unsafe int NumTanks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
}
