#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMIncapacitatedPawnCounter<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMIncapacitatedPawnCounter : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMIncapacitatedPawnCounter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMIncapacitatedPawnCounter() { }

    /// <summary>
    /// Constructs a new RBMIncapacitatedPawnCounter
    /// </summary>
    public RBMIncapacitatedPawnCounter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMIncapacitatedPawnCounter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMIncapacitatedPawnCounter(nint ptr) : base(ptr) { }

    /// <summary>
    /// ClassProperty: PawnType
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PawnType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }
}
