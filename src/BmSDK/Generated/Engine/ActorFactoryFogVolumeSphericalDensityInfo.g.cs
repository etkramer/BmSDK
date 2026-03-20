#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ActorFactoryFogVolumeSphericalDensityInfo<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ActorFactoryFogVolumeSphericalDensityInfo : BmSDK.Engine.ActorFactoryFogVolumeConstantDensityInfo, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ActorFactoryFogVolumeSphericalDensityInfo", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ActorFactoryFogVolumeSphericalDensityInfo() { }

    /// <summary>
    /// Constructs a new ActorFactoryFogVolumeSphericalDensityInfo
    /// </summary>
    public ActorFactoryFogVolumeSphericalDensityInfo(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ActorFactoryFogVolumeSphericalDensityInfo Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ActorFactoryFogVolumeSphericalDensityInfo(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: SelectedMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface SelectedMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// BoolProperty: bNothingSelected
    /// </summary>
    public unsafe bool bNothingSelected
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 152); }
    }
}
