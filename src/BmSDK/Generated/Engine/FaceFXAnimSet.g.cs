#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: FaceFXAnimSet<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class FaceFXAnimSet : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.FaceFXAnimSet", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal FaceFXAnimSet() { }

    /// <summary>
    /// Constructs a new FaceFXAnimSet
    /// </summary>
    public FaceFXAnimSet(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, FaceFXAnimSet Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected FaceFXAnimSet(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: DefaultFaceFXAsset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DefaultFaceFXAsset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// StructProperty: InternalFaceFXAnimSet
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT InternalFaceFXAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ArrayProperty: RawFaceFXAnimSetBytes
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT RawFaceFXAnimSetBytes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: RawFaceFXMiniSessionBytes
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT RawFaceFXMiniSessionBytes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ArrayProperty: ReferencedSoundCues
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT ReferencedSoundCues
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// IntProperty: NumLoadErrors
    /// </summary>
    public unsafe int NumLoadErrors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }
}
