#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleCollision<br/>
/// (size = 376)
/// (flags = 142610578)
/// </summary>
public partial class ParticleModuleCollision : BmSDK.Engine.ParticleModuleCollisionBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleCollision", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as ParticleModuleCollision.
    /// </summary>
    public static ParticleModuleCollision DefaultObject => (ParticleModuleCollision)StaticClass().DefaultObject;

    internal ParticleModuleCollision() { }

    /// <summary>
    /// Constructs a new ParticleModuleCollision
    /// </summary>
    public ParticleModuleCollision(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleCollision Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleCollision(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ParticleModuleCollision>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleCollision>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ParticleModuleCollision>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleCollision>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleCollision>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleCollision>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ParticleModuleCollision>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleCollision>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Struct: FParticleAttractorCollisionAction
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FParticleAttractorCollisionAction
    {
        /// <summary>
        /// ByteProperty: Type
        /// </summary>
        public unsafe BmSDK.Engine.ParticleModuleCollision.ParticleAttractorActionType Type
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleCollision.ParticleAttractorActionType>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: EventName
        /// </summary>
        public unsafe BmSDK.FString EventName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Enum: ParticleAttractorActionType
    /// </summary>
    public enum ParticleAttractorActionType : byte
    {
        PAAT_None = 0,
        PAAT_Destroy = 1,
        PAAT_Freeze = 2,
        PAAT_Event = 3,
        PAAT_MAX = 4,
    }

    /// <summary>
    /// StructProperty: DampingFactor
    /// </summary>
    public unsafe ref BmSDK.DistributionVector.FRawDistributionVector DampingFactor
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionVector.FRawDistributionVector>(Ptr + 96);

    /// <summary>
    /// StructProperty: DampingFactorRotation
    /// </summary>
    public unsafe ref BmSDK.DistributionVector.FRawDistributionVector DampingFactorRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionVector.FRawDistributionVector>(Ptr + 160);

    /// <summary>
    /// StructProperty: MaxCollisions
    /// </summary>
    public unsafe ref BmSDK.DistributionFloat.FRawDistributionFloat MaxCollisions
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 224);

    /// <summary>
    /// ByteProperty: CollisionCompletionOption
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleCollisionBase.EParticleCollisionComplete CollisionCompletionOption
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleCollisionBase.EParticleCollisionComplete>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bApplyPhysics
    /// </summary>
    public unsafe bool bApplyPhysics
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bForceCollideZeroExtent
    /// </summary>
    public unsafe bool bForceCollideZeroExtent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bPawnsDoNotDecrementCount
    /// </summary>
    public unsafe bool bPawnsDoNotDecrementCount
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bOnlyVerticalNormalsDecrementCount
    /// </summary>
    public unsafe bool bOnlyVerticalNormalsDecrementCount
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bDropDetail
    /// </summary>
    public unsafe bool bDropDetail
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bCollideOnlyIfVisible
    /// </summary>
    public unsafe bool bCollideOnlyIfVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bCollideWithWorld
    /// </summary>
    public unsafe bool bCollideWithWorld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bCollideWithWorldAttractors
    /// </summary>
    public unsafe bool bCollideWithWorldAttractors
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// ObjectProperty: SoundOnCollision
    /// </summary>
    public unsafe BmSDK.Engine.SoundCue SoundOnCollision
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SoundCue>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// StructProperty: ParticleMass
    /// </summary>
    public unsafe ref BmSDK.DistributionFloat.FRawDistributionFloat ParticleMass
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 276);

    /// <summary>
    /// FloatProperty: DirScalar
    /// </summary>
    public unsafe float DirScalar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// FloatProperty: VerticalFudgeFactor
    /// </summary>
    public unsafe float VerticalFudgeFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// StructProperty: DelayAmount
    /// </summary>
    public unsafe ref BmSDK.DistributionFloat.FRawDistributionFloat DelayAmount
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 320);

    /// <summary>
    /// FloatProperty: MaxCollisionDistance
    /// </summary>
    public unsafe float MaxCollisionDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// ArrayProperty: ParticleAttractorCollisionActions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ParticleModuleCollision.FParticleAttractorCollisionAction> ParticleAttractorCollisionActions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ParticleModuleCollision.FParticleAttractorCollisionAction>>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }
}
