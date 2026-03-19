#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MorphNodeWeight<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MorphNodeWeight : BmSDK.Engine.MorphNodeWeightBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MorphNodeWeight", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MorphNodeWeight() { }

    /// <summary>
    /// Constructs a new MorphNodeWeight
    /// </summary>
    public MorphNodeWeight(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MorphNodeWeight Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MorphNodeWeight(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: NodeWeight
    /// </summary>
    public unsafe float NodeWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }
}
