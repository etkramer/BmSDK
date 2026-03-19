#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkNegatedFact<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AkNegatedFact : BmSDK.Engine.AkPredicate, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkNegatedFact", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkNegatedFact() { }

    /// <summary>
    /// Constructs a new AkNegatedFact
    /// </summary>
    public AkNegatedFact(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkNegatedFact Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkNegatedFact(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: FactToNegate
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FactToNegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bScaledNegation
    /// </summary>
    public unsafe bool bScaledNegation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }
}
