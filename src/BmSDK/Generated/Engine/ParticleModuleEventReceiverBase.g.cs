#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleEventReceiverBase<br/>
/// (size = 108)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleEventReceiverBase : BmSDK.Engine.ParticleModuleEventBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleEventReceiverBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleEventReceiverBase() { }

    /// <summary>
    /// Constructs a new ParticleModuleEventReceiverBase
    /// </summary>
    public ParticleModuleEventReceiverBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleEventReceiverBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleEventReceiverBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: EventGeneratorType
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent.EParticleEventType EventGeneratorType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent.EParticleEventType>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// NameProperty: EventName
    /// </summary>
    public unsafe BmSDK.FName EventName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }
}
