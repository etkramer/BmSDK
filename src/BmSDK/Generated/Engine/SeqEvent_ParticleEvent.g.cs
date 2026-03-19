#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqEvent_ParticleEvent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SeqEvent_ParticleEvent : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqEvent_ParticleEvent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqEvent_ParticleEvent() { }

    /// <summary>
    /// Constructs a new SeqEvent_ParticleEvent
    /// </summary>
    public SeqEvent_ParticleEvent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqEvent_ParticleEvent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqEvent_ParticleEvent(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: EventType
    /// </summary>
    public unsafe byte EventType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// StructProperty: EventPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT EventPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// FloatProperty: EventEmitterTime
    /// </summary>
    public unsafe float EventEmitterTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// StructProperty: EventVelocity
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT EventVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// FloatProperty: EventParticleTime
    /// </summary>
    public unsafe float EventParticleTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// StructProperty: EventNormal
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT EventNormal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// BoolProperty: UseRelfectedImpactVector
    /// </summary>
    public unsafe bool UseRelfectedImpactVector
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }
    }

    /// <summary>
    /// Enum: EParticleEventOutputType
    /// </summary>
    public enum EParticleEventOutputType
    {
        ePARTICLEOUT_Spawn = 0,
        ePARTICLEOUT_Death = 1,
        ePARTICLEOUT_Collision = 2,
        ePARTICLEOUT_AttractorCollision = 3,
        ePARTICLEOUT_Kismet = 4,
        ePARTICLEOUT_MAX = 5,
    }
}
