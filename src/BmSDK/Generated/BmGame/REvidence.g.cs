#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: REvidence<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class REvidence : BmSDK.BmGame.RConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.REvidence", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal REvidence() { }

    /// <summary>
    /// Constructs a new REvidence
    /// </summary>
    public REvidence(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, REvidence Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected REvidence(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: EvidenceInternalName
    /// </summary>
    public unsafe BmSDK.FString EvidenceInternalName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// StrProperty: OptionalTrailName
    /// </summary>
    public unsafe BmSDK.FString OptionalTrailName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ObjectProperty: RevealedParticleTemplate
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RevealedParticleTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ObjectProperty: ScannerModeParticleTemplate
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ScannerModeParticleTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ObjectProperty: EvidenceDetail
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EvidenceDetail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// NameProperty: RevealedParameterName
    /// </summary>
    public unsafe BmSDK.FName RevealedParameterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// BoolProperty: DoNotRotateParticleFx
    /// </summary>
    public unsafe bool DoNotRotateParticleFx
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 148); }
    }

    /// <summary>
    /// BoolProperty: bDrawInForegroundAndInFrontOfPostProcessWhenInXrayMode
    /// </summary>
    public unsafe bool bDrawInForegroundAndInFrontOfPostProcessWhenInXrayMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 148); }
    }

    /// <summary>
    /// BoolProperty: bDrawInFrontOfPostProcessWhenInXrayMode
    /// </summary>
    public unsafe bool bDrawInFrontOfPostProcessWhenInXrayMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 148); }
    }

    /// <summary>
    /// FloatProperty: ParticleScale
    /// </summary>
    public unsafe float ParticleScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }
}
