#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleLocationEmitter<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleLocationEmitter : BmSDK.Engine.ParticleModuleLocationBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleLocationEmitter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleLocationEmitter() { }

    /// <summary>
    /// Constructs a new ParticleModuleLocationEmitter
    /// </summary>
    public ParticleModuleLocationEmitter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleLocationEmitter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleLocationEmitter(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: EmitterName
    /// </summary>
    public unsafe BmSDK.FName EmitterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ByteProperty: SelectionMethod
    /// </summary>
    public unsafe byte SelectionMethod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: InheritSourceVelocity
    /// </summary>
    public unsafe bool InheritSourceVelocity
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: bInheritSourceRotation
    /// </summary>
    public unsafe bool bInheritSourceRotation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// FloatProperty: InheritSourceVelocityScale
    /// </summary>
    public unsafe float InheritSourceVelocityScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// FloatProperty: InheritSourceRotationScale
    /// </summary>
    public unsafe float InheritSourceRotationScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }
}
