#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_OverrideDetectiveMaterials<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_OverrideDetectiveMaterials : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_OverrideDetectiveMaterials", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_OverrideDetectiveMaterials() { }

    /// <summary>
    /// Constructs a new RSeqAct_OverrideDetectiveMaterials
    /// </summary>
    public RSeqAct_OverrideDetectiveMaterials(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_OverrideDetectiveMaterials Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_OverrideDetectiveMaterials(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: OverridePawn
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OverridePawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ObjectProperty: XRayNormalMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT XRayNormalMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// ObjectProperty: XRayNormalBoneMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT XRayNormalBoneMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// ObjectProperty: XRayDangerMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT XRayDangerMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// ObjectProperty: XRayDangerBoneMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT XRayDangerBoneMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }
}
