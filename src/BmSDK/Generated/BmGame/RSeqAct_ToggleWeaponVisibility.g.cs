#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_ToggleWeaponVisibility<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_ToggleWeaponVisibility : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_ToggleWeaponVisibility", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_ToggleWeaponVisibility() { }

    /// <summary>
    /// Constructs a new RSeqAct_ToggleWeaponVisibility
    /// </summary>
    public RSeqAct_ToggleWeaponVisibility(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_ToggleWeaponVisibility Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_ToggleWeaponVisibility(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: NPC
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT NPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
}
