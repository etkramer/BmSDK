#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_SetMedicToPrioritiseReviving<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_SetMedicToPrioritiseReviving : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_SetMedicToPrioritiseReviving", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_SetMedicToPrioritiseReviving() { }

    /// <summary>
    /// Constructs a new RSeqAct_SetMedicToPrioritiseReviving
    /// </summary>
    public RSeqAct_SetMedicToPrioritiseReviving(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_SetMedicToPrioritiseReviving Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_SetMedicToPrioritiseReviving(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Medic
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain Medic
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
}
