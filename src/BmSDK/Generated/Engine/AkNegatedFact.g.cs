#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkNegatedFact<br/>
/// (size = 112)
/// (flags = 134217874)
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
    public unsafe BmSDK.Engine.AkPredicate FactToNegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkPredicate>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bScaledNegation
    /// </summary>
    public unsafe bool bScaledNegation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }
}
