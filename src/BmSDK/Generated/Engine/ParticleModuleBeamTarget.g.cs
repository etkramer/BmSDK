#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleBeamTarget<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleBeamTarget : BmSDK.Engine.ParticleModuleBeamBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleBeamTarget", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleBeamTarget() { }

    /// <summary>
    /// Constructs a new ParticleModuleBeamTarget
    /// </summary>
    public ParticleModuleBeamTarget(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleBeamTarget Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleBeamTarget(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: TargetMethod
    /// </summary>
    public unsafe byte TargetMethod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ByteProperty: TargetTangentMethod
    /// </summary>
    public unsafe byte TargetTangentMethod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 97); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 97); }
    }

    /// <summary>
    /// NameProperty: TargetName
    /// </summary>
    public unsafe BmSDK.FName TargetName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: Target
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleBeamTarget.TargetTangent Target
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleBeamTarget.TargetTangent>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: bTargetAbsolute
    /// </summary>
    public unsafe bool bTargetAbsolute
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bLockTarget
    /// </summary>
    public unsafe bool bLockTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bLockTargetTangent
    /// </summary>
    public unsafe bool bLockTargetTangent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bLockTargetStength
    /// </summary>
    public unsafe bool bLockTargetStength
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// StructProperty: TargetTangent
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleBeamTarget.TargetStrength TargetTangent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleBeamTarget.TargetStrength>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// StructProperty: TargetStrength
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TargetStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// FloatProperty: LockRadius
    /// </summary>
    public unsafe float LockRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }
}
