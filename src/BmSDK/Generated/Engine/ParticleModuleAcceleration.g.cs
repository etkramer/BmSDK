#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleAcceleration<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleAcceleration : BmSDK.Engine.ParticleModuleAccelerationBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleAcceleration", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleAcceleration() { }

    /// <summary>
    /// Constructs a new ParticleModuleAcceleration
    /// </summary>
    public ParticleModuleAcceleration(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleAcceleration Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleAcceleration(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Acceleration
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Acceleration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bApplyOwnerScale
    /// </summary>
    public unsafe bool bApplyOwnerScale
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }
}
