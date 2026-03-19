#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleSizeMultiplyLife<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleSizeMultiplyLife : BmSDK.Engine.ParticleModuleSizeBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleSizeMultiplyLife", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleSizeMultiplyLife() { }

    /// <summary>
    /// Constructs a new ParticleModuleSizeMultiplyLife
    /// </summary>
    public ParticleModuleSizeMultiplyLife(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleSizeMultiplyLife Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleSizeMultiplyLife(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: LifeMultiplier
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LifeMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: MultiplyX
    /// </summary>
    public unsafe bool MultiplyX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: MultiplyY
    /// </summary>
    public unsafe bool MultiplyY
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: MultiplyZ
    /// </summary>
    public unsafe bool MultiplyZ
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }
}
