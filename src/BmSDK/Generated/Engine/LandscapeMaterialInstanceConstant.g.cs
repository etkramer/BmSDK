#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: LandscapeMaterialInstanceConstant<br/>
/// (flags = 0)
/// </summary>
public partial class LandscapeMaterialInstanceConstant : BmSDK.Engine.MaterialInstanceConstant, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.LandscapeMaterialInstanceConstant", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal LandscapeMaterialInstanceConstant() { }

    /// <summary>
    /// Constructs a new LandscapeMaterialInstanceConstant
    /// </summary>
    public LandscapeMaterialInstanceConstant(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, LandscapeMaterialInstanceConstant Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected LandscapeMaterialInstanceConstant(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bIsLayerThumbnail
    /// </summary>
    public unsafe bool bIsLayerThumbnail
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// IntProperty: DataWeightmapIndex
    /// </summary>
    public unsafe int DataWeightmapIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// IntProperty: DataWeightmapSize
    /// </summary>
    public unsafe int DataWeightmapSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }
}
