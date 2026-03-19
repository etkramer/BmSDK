#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RFlapsAsset<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RFlapsAsset : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RFlapsAsset", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RFlapsAsset() { }

    /// <summary>
    /// Constructs a new RFlapsAsset
    /// </summary>
    public RFlapsAsset(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RFlapsAsset Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RFlapsAsset(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Owner
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Owner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// StructProperty: BodySetupIndexMap
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BodySetupIndexMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ArrayProperty: BodySetup
    /// </summary>
    public unsafe BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT> BodySetup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ArrayProperty: ConstraintSetup
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT ConstraintSetup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }
}
