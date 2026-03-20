#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_PredatorSniper<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_PredatorSniper : BmSDK.BmGame.RBMBehaviour_ActionQueue, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_PredatorSniper", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_PredatorSniper() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_PredatorSniper
    /// </summary>
    public RBMBehaviour_PredatorSniper(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_PredatorSniper Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_PredatorSniper(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: SniperPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RSniperPoint SniperPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSniperPoint>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// ObjectProperty: CurrSniperPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RSniperPoint CurrSniperPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSniperPoint>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }
}
