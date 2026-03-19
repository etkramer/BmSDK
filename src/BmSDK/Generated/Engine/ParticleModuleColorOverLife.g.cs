#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleColorOverLife<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleColorOverLife : BmSDK.Engine.ParticleModuleColorBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleColorOverLife", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleColorOverLife() { }

    /// <summary>
    /// Constructs a new ParticleModuleColorOverLife
    /// </summary>
    public ParticleModuleColorOverLife(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleColorOverLife Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleColorOverLife(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: ColorOverLife
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleColorOverLife.AlphaOverLife ColorOverLife
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleColorOverLife.AlphaOverLife>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// StructProperty: AlphaOverLife
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AlphaOverLife
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bClampAlpha
    /// </summary>
    public unsafe bool bClampAlpha
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 196); }
    }
}
