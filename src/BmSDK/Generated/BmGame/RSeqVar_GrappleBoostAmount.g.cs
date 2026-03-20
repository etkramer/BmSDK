#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqVar_GrappleBoostAmount<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqVar_GrappleBoostAmount : BmSDK.Engine.SeqVar_Float, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqVar_GrappleBoostAmount", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqVar_GrappleBoostAmount() { }

    /// <summary>
    /// Constructs a new RSeqVar_GrappleBoostAmount
    /// </summary>
    public RSeqVar_GrappleBoostAmount(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqVar_GrappleBoostAmount Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqVar_GrappleBoostAmount(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: BoostAmount
    /// </summary>
    public unsafe float BoostAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }
}
