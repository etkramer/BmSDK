#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNode_Additive<br/>
/// (size = 232)
/// (flags = 144703634)
/// </summary>
public partial class RAnimNode_Additive : BmSDK.Engine.AnimNodeBlendBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNode_Additive", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNode_Additive() { }

    /// <summary>
    /// Constructs a new RAnimNode_Additive
    /// </summary>
    public RAnimNode_Additive(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNode_Additive Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNode_Additive(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: Weight
    /// </summary>
    public unsafe float Weight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }
}
