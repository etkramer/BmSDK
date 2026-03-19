#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleBeamModifier<br/>
/// (size = 0)
/// (flags = 0)
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
    /// ByteProperty: ModifierType
    /// </summary>
    public unsafe byte ModifierType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// StructProperty: PositionOptions
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PositionOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: Position
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleBeamModifier.Tangent Position
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleBeamModifier.Tangent>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// StructProperty: TangentOptions
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TangentOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// StructProperty: Tangent
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleBeamModifier.Strength Tangent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleBeamModifier.Strength>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bAbsoluteTangent
    /// </summary>
    public unsafe bool bAbsoluteTangent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 236) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 236); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 236); }
    }

    /// <summary>
    /// StructProperty: StrengthOptions
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StrengthOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// StructProperty: Strength
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Strength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
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
