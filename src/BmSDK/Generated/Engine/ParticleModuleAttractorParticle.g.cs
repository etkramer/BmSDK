#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleAttractorParticle<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleAttractorParticle : BmSDK.Engine.ParticleModuleAttractorBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleAttractorParticle", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleAttractorParticle() { }

    /// <summary>
    /// Constructs a new ParticleModuleAttractorParticle
    /// </summary>
    public ParticleModuleAttractorParticle(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleAttractorParticle Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleAttractorParticle(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: EmitterName
    /// </summary>
    public unsafe BmSDK.FName EmitterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// StructProperty: Range
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleAttractorParticle.Strength Range
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleAttractorParticle.Strength>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: bStrengthByDistance
    /// </summary>
    public unsafe bool bStrengthByDistance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 140); }
    }

    /// <summary>
    /// BoolProperty: bAffectBaseVelocity
    /// </summary>
    public unsafe bool bAffectBaseVelocity
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 140); }
    }

    /// <summary>
    /// BoolProperty: bRenewSource
    /// </summary>
    public unsafe bool bRenewSource
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 140); }
    }

    /// <summary>
    /// BoolProperty: bInheritSourceVel
    /// </summary>
    public unsafe bool bInheritSourceVel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 140); }
    }

    /// <summary>
    /// StructProperty: Strength
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Strength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// ByteProperty: SelectionMethod
    /// </summary>
    public unsafe byte SelectionMethod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// IntProperty: LastSelIndex
    /// </summary>
    public unsafe int LastSelIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }
}
