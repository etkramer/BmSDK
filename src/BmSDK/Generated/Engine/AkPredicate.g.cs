#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkPredicate<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AkPredicate : BmSDK.Engine.AkHash, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkPredicate", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkPredicate() { }

    /// <summary>
    /// Constructs a new AkPredicate
    /// </summary>
    public AkPredicate(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkPredicate Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkPredicate(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: VfTable_AkEvaluate
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VfTable_AkEvaluate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }
}
