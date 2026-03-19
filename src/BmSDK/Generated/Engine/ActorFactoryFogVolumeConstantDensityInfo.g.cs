#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ActorFactoryFogVolumeConstantDensityInfo<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ActorFactoryFogVolumeConstantDensityInfo : BmSDK.Engine.ActorFactory, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ActorFactoryFogVolumeConstantDensityInfo", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ActorFactoryFogVolumeConstantDensityInfo() { }

    /// <summary>
    /// Constructs a new ActorFactoryFogVolumeConstantDensityInfo
    /// </summary>
    public ActorFactoryFogVolumeConstantDensityInfo(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ActorFactoryFogVolumeConstantDensityInfo Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ActorFactoryFogVolumeConstantDensityInfo(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: SelectedMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SelectedMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// BoolProperty: bNothingSelected
    /// </summary>
    public unsafe bool bNothingSelected
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 152); }
    }
}
