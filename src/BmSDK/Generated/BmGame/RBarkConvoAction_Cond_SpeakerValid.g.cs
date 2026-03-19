#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBarkConvoAction_Cond_SpeakerValid<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBarkConvoAction_Cond_SpeakerValid : BmSDK.BmGame.RBarkConvoActionCond, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBarkConvoAction_Cond_SpeakerValid", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBarkConvoAction_Cond_SpeakerValid() { }

    /// <summary>
    /// Constructs a new RBarkConvoAction_Cond_SpeakerValid
    /// </summary>
    public RBarkConvoAction_Cond_SpeakerValid(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBarkConvoAction_Cond_SpeakerValid Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBarkConvoAction_Cond_SpeakerValid(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: PawnRef
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PawnRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }
}
