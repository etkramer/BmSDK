#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleColorScaleOverLife<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleColorScaleOverLife : BmSDK.Engine.ParticleModuleColorBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleColorScaleOverLife", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleColorScaleOverLife() { }

    /// <summary>
    /// Constructs a new ParticleModuleColorScaleOverLife
    /// </summary>
    public ParticleModuleColorScaleOverLife(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleColorScaleOverLife Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleColorScaleOverLife(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: ColorScaleOverLife
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleColorScaleOverLife.AlphaScaleOverLife ColorScaleOverLife
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleColorScaleOverLife.AlphaScaleOverLife>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// StructProperty: AlphaScaleOverLife
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AlphaScaleOverLife
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bEmitterTime
    /// </summary>
    public unsafe bool bEmitterTime
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 196); }
    }
}
