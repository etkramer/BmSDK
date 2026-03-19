#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNotify_SimultaneousCounterHit<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RAnimNotify_SimultaneousCounterHit : BmSDK.Engine.AnimNotify, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNotify_SimultaneousCounterHit", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNotify_SimultaneousCounterHit() { }

    /// <summary>
    /// Constructs a new RAnimNotify_SimultaneousCounterHit
    /// </summary>
    public RAnimNotify_SimultaneousCounterHit(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotify_SimultaneousCounterHit Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_SimultaneousCounterHit(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: SimultaneousCounterInfo
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SimultaneousCounterInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
