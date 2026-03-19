#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleSizeScale<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleSizeScale : BmSDK.Engine.ParticleModuleSizeBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleSizeScale", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleSizeScale() { }

    /// <summary>
    /// Constructs a new ParticleModuleSizeScale
    /// </summary>
    public ParticleModuleSizeScale(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleSizeScale Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleSizeScale(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: SizeScale
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SizeScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: EnableX
    /// </summary>
    public unsafe bool EnableX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: EnableY
    /// </summary>
    public unsafe bool EnableY
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: EnableZ
    /// </summary>
    public unsafe bool EnableZ
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }
}
