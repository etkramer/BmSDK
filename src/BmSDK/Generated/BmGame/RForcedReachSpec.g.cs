#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RForcedReachSpec<br/>
/// (flags = 0)
/// </summary>
public partial class RForcedReachSpec : BmSDK.BmGame.RReachSpec, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RForcedReachSpec", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RForcedReachSpec() { }

    /// <summary>
    /// Constructs a new RForcedReachSpec
    /// </summary>
    public RForcedReachSpec(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RForcedReachSpec Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RForcedReachSpec(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: PathBlockers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> PathBlockers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }
}
