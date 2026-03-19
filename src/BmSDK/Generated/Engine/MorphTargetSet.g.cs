#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MorphTargetSet<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MorphTargetSet : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MorphTargetSet", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MorphTargetSet() { }

    /// <summary>
    /// Constructs a new MorphTargetSet
    /// </summary>
    public MorphTargetSet(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MorphTargetSet Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MorphTargetSet(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: Targets
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT Targets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: BaseSkelMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BaseSkelMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: RawWedgePointIndices
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RawWedgePointIndices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }
}
