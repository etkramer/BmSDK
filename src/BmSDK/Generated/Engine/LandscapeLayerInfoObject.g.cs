#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: LandscapeLayerInfoObject<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class LandscapeLayerInfoObject : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.LandscapeLayerInfoObject", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal LandscapeLayerInfoObject() { }

    /// <summary>
    /// Constructs a new LandscapeLayerInfoObject
    /// </summary>
    public LandscapeLayerInfoObject(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, LandscapeLayerInfoObject Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected LandscapeLayerInfoObject(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: LayerName
    /// </summary>
    public unsafe BmSDK.FName LayerName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: PhysMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PhysMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// FloatProperty: Hardness
    /// </summary>
    public unsafe float Hardness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bNoWeightBlend
    /// </summary>
    public unsafe bool bNoWeightBlend
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }
}
