#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_SetMedicRevivesRemaining<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_SetMedicRevivesRemaining : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_SetMedicRevivesRemaining", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_SetMedicRevivesRemaining() { }

    /// <summary>
    /// Constructs a new RSeqAct_SetMedicRevivesRemaining
    /// </summary>
    public RSeqAct_SetMedicRevivesRemaining(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_SetMedicRevivesRemaining Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_SetMedicRevivesRemaining(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: NumberOfMedicRevives
    /// </summary>
    public unsafe int NumberOfMedicRevives
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ObjectProperty: Medic
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Medic
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }
}
