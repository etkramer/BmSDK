#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleBeamModifier<br/>
/// (size = 160)
/// (flags = 142610578)
/// </summary>
public partial class ParticleModuleBeamModifier : BmSDK.Engine.ParticleModuleBeamBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleBeamModifier", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleBeamModifier() { }

    /// <summary>
    /// Constructs a new ParticleModuleBeamModifier
    /// </summary>
    public ParticleModuleBeamModifier(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleBeamModifier Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleBeamModifier(nint ptr) : base(ptr) { }

    /// <summary>
    /// Struct: FBeamModifierOptions
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial record struct FBeamModifierOptions
    {
        /// <summary>
        /// BoolProperty: bModify
        /// </summary>
        public unsafe bool bModify
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bScale
        /// </summary>
        public unsafe bool bScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bLock
        /// </summary>
        public unsafe bool bLock
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// ByteProperty: ModifierType
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleBeamModifier.BeamModifierType ModifierType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleBeamModifier.BeamModifierType>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// StructProperty: PositionOptions
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleBeamModifier.FBeamModifierOptions PositionOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleBeamModifier.FBeamModifierOptions>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// StructProperty: Position
    /// </summary>
    public unsafe BmSDK.DistributionVector.FRawDistributionVector Position
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionVector.FRawDistributionVector>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// StructProperty: TangentOptions
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleBeamModifier.FBeamModifierOptions TangentOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleBeamModifier.FBeamModifierOptions>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// StructProperty: Tangent
    /// </summary>
    public unsafe BmSDK.DistributionVector.FRawDistributionVector Tangent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionVector.FRawDistributionVector>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bAbsoluteTangent
    /// </summary>
    public unsafe bool bAbsoluteTangent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 124); }
    }

    /// <summary>
    /// StructProperty: StrengthOptions
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleBeamModifier.FBeamModifierOptions StrengthOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleBeamModifier.FBeamModifierOptions>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// StructProperty: Strength
    /// </summary>
    public unsafe BmSDK.DistributionFloat.FRawDistributionFloat Strength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// Enum: BeamModifierType
    /// </summary>
    public enum BeamModifierType
    {
        PEB2MT_Source = 0,
        PEB2MT_Target = 1,
        PEB2MT_MAX = 2,
    }
}
