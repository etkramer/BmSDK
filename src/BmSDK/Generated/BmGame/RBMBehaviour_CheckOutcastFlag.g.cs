#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_CheckOutcastFlag<br/>
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_CheckOutcastFlag : BmSDK.BmGame.RBMBehaviour, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_CheckOutcastFlag", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_CheckOutcastFlag() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_CheckOutcastFlag
    /// </summary>
    public RBMBehaviour_CheckOutcastFlag(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_CheckOutcastFlag Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_CheckOutcastFlag(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: StoredFlagName
    /// </summary>
    public unsafe BmSDK.FString StoredFlagName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }
}
