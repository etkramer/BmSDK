#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqVar_RandomVector<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqVar_RandomVector : BmSDK.Engine.SeqVar_Vector, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqVar_RandomVector", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqVar_RandomVector() { }

    /// <summary>
    /// Constructs a new RSeqVar_RandomVector
    /// </summary>
    public RSeqVar_RandomVector(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqVar_RandomVector Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqVar_RandomVector(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Min
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Min
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// StructProperty: Max
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Max
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }
}
