#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleEventReceiverSpawn<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleEventReceiverSpawn : BmSDK.Engine.ParticleModuleEventReceiverBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleEventReceiverSpawn", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleEventReceiverSpawn() { }

    /// <summary>
    /// Constructs a new ParticleModuleEventReceiverSpawn
    /// </summary>
    public ParticleModuleEventReceiverSpawn(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleEventReceiverSpawn Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleEventReceiverSpawn(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: SpawnCount
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleEventReceiverSpawn.InheritVelocityScale SpawnCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleEventReceiverSpawn.InheritVelocityScale>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: bUseParticleTime
    /// </summary>
    public unsafe bool bUseParticleTime
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 144); }
    }

    /// <summary>
    /// BoolProperty: bUsePSysLocation
    /// </summary>
    public unsafe bool bUsePSysLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 144); }
    }

    /// <summary>
    /// BoolProperty: bInheritVelocity
    /// </summary>
    public unsafe bool bInheritVelocity
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 144); }
    }

    /// <summary>
    /// StructProperty: InheritVelocityScale
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT InheritVelocityScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }
}
