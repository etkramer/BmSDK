#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMPawnAIAnim<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMPawnAIAnim : BmSDK.BmGame.RPawnCombat, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMPawnAIAnim", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMPawnAIAnim() { }

    /// <summary>
    /// Constructs a new RBMPawnAIAnim
    /// </summary>
    public RBMPawnAIAnim(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMPawnAIAnim Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMPawnAIAnim(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMPawnAIAnim>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMPawnAIAnim>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMPawnAIAnim>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMPawnAIAnim>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMPawnAIAnim>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMPawnAIAnim>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMPawnAIAnim>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// FloatProperty: VertPeripheralVision
    /// </summary>
    public unsafe float VertPeripheralVision
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2976); }
    }

    /// <summary>
    /// BoolProperty: bDisplayName
    /// </summary>
    public unsafe bool bDisplayName
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2980); }
    }

    /// <summary>
    /// BoolProperty: bDisplayState
    /// </summary>
    public unsafe bool bDisplayState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2980); }
    }

    /// <summary>
    /// BoolProperty: IsMassiveInSize
    /// </summary>
    public unsafe bool IsMassiveInSize
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2980); }
    }

    /// <summary>
    /// BoolProperty: bReallyDead
    /// </summary>
    public unsafe bool bReallyDead
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2980); }
    }

    /// <summary>
    /// BoolProperty: ThermalSet
    /// </summary>
    public unsafe bool ThermalSet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2980); }
    }

    /// <summary>
    /// BoolProperty: XRaySet
    /// </summary>
    public unsafe bool XRaySet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2980); }
    }

    /// <summary>
    /// BoolProperty: bDisallowXraySkinDistanceFading
    /// </summary>
    public unsafe bool bDisallowXraySkinDistanceFading
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2980); }
    }

    /// <summary>
    /// BoolProperty: bForceLongRangeXrayFading
    /// </summary>
    public unsafe bool bForceLongRangeXrayFading
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2980); }
    }

    /// <summary>
    /// BoolProperty: bFadeOutXrayForDelete
    /// </summary>
    public unsafe bool bFadeOutXrayForDelete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2980); }
    }

    /// <summary>
    /// BoolProperty: bBypassXrayCheck
    /// </summary>
    public unsafe bool bBypassXrayCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2980); }
    }

    /// <summary>
    /// BoolProperty: bCachedXrayForegroundSetting
    /// </summary>
    public unsafe bool bCachedXrayForegroundSetting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2980); }
    }

    /// <summary>
    /// BoolProperty: bXrayPostbeginInit
    /// </summary>
    public unsafe bool bXrayPostbeginInit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2980); }
    }

    /// <summary>
    /// BoolProperty: bHasDoneInitialXraySetup
    /// </summary>
    public unsafe bool bHasDoneInitialXraySetup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2980); }
    }

    /// <summary>
    /// BoolProperty: bAllowMeshHidingFromXrayAlpha
    /// </summary>
    public unsafe bool bAllowMeshHidingFromXrayAlpha
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2980); }
    }

    /// <summary>
    /// BoolProperty: bOverrideXrayForground
    /// </summary>
    public unsafe bool bOverrideXrayForground
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2980); }
    }

    /// <summary>
    /// BoolProperty: OverrideXrayForgroundSetting
    /// </summary>
    public unsafe bool OverrideXrayForgroundSetting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2980); }
    }

    /// <summary>
    /// BoolProperty: bDontPushRagdollOnDeath
    /// </summary>
    public unsafe bool bDontPushRagdollOnDeath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2980); }
    }

    /// <summary>
    /// BoolProperty: bInOverworld
    /// </summary>
    public unsafe bool bInOverworld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2980); }
    }

    /// <summary>
    /// BoolProperty: bUseXRaySprite
    /// </summary>
    public unsafe bool bUseXRaySprite
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2980); }
    }

    /// <summary>
    /// BoolProperty: bDisableXRaySprite
    /// </summary>
    public unsafe bool bDisableXRaySprite
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2980); }
    }

    /// <summary>
    /// ComponentProperty: XrayLight
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT XrayLight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2984); }
    }

    /// <summary>
    /// FloatProperty: DistToCameraSq
    /// </summary>
    public unsafe float DistToCameraSq
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2992); }
    }

    /// <summary>
    /// FloatProperty: DistToPlayerSq
    /// </summary>
    public unsafe float DistToPlayerSq
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2996); }
    }

    /// <summary>
    /// FloatProperty: MaxXRayFadeDist
    /// </summary>
    public unsafe float MaxXRayFadeDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3000); }
    }

    /// <summary>
    /// ByteProperty: XrayColour
    /// </summary>
    public unsafe byte XrayColour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 3004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3004); }
    }

    /// <summary>
    /// StructProperty: XrayBlueColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT XrayBlueColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3008); }
    }

    /// <summary>
    /// StructProperty: XrayRedColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT XrayRedColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3012); }
    }

    /// <summary>
    /// StructProperty: XrayWhiteColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT XrayWhiteColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3016); }
    }

    /// <summary>
    /// ObjectProperty: XRayDangerMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT XRayDangerMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3020); }
    }

    /// <summary>
    /// ObjectProperty: XRayMedicMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT XRayMedicMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3028); }
    }

    /// <summary>
    /// ObjectProperty: XRayMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT XRayMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3036); }
    }

    /// <summary>
    /// ObjectProperty: XRayMaterialMIC
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAIAnim.XRayBoneMaterialMIC XRayMaterialMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAIAnim.XRayBoneMaterialMIC>(Ptr + 3044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3044); }
    }

    /// <summary>
    /// ObjectProperty: XRayDangerBoneMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT XRayDangerBoneMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3052); }
    }

    /// <summary>
    /// ObjectProperty: XRayMedicBoneMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT XRayMedicBoneMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3060); }
    }

    /// <summary>
    /// ObjectProperty: XRayBoneMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT XRayBoneMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3068); }
    }

    /// <summary>
    /// ObjectProperty: XRayBoneMaterialMIC
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAIAnim.XRayGutsMaterialMIC XRayBoneMaterialMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAIAnim.XRayGutsMaterialMIC>(Ptr + 3076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3076); }
    }

    /// <summary>
    /// ObjectProperty: XRayDangerGutsMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT XRayDangerGutsMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3084); }
    }

    /// <summary>
    /// ObjectProperty: XRayMedicGutsMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT XRayMedicGutsMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3092); }
    }

    /// <summary>
    /// ObjectProperty: XRayGutsMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT XRayGutsMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3100); }
    }

    /// <summary>
    /// ObjectProperty: XRayGutsMaterialMIC
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAIAnim.ThermalMIC XRayGutsMaterialMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAIAnim.ThermalMIC>(Ptr + 3108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3108); }
    }

    /// <summary>
    /// ObjectProperty: XRayInformantBoneMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT XRayInformantBoneMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3116); }
    }

    /// <summary>
    /// ObjectProperty: ThermalMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ThermalMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3124); }
    }

    /// <summary>
    /// ObjectProperty: ThermalMIC
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAIAnim.NWVisionMIC ThermalMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAIAnim.NWVisionMIC>(Ptr + 3132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3132); }
    }

    /// <summary>
    /// ObjectProperty: NWVisionMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT NWVisionMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3140); }
    }

    /// <summary>
    /// ObjectProperty: NWVisionMIC
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAIAnim.ActiveThermalMIC NWVisionMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAIAnim.ActiveThermalMIC>(Ptr + 3148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3148); }
    }

    /// <summary>
    /// ObjectProperty: ActiveThermalMIC
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAIAnim.MultiplayerAuraMIC ActiveThermalMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAIAnim.MultiplayerAuraMIC>(Ptr + 3156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3156); }
    }

    /// <summary>
    /// ObjectProperty: EvidenceInfo
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EvidenceInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3164); }
    }

    /// <summary>
    /// ObjectProperty: PoseConfig_Fundamentals
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PoseConfig_Fundamentals
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3172); }
    }

    /// <summary>
    /// ObjectProperty: XraySkeleton
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT XraySkeleton
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3180); }
    }

    /// <summary>
    /// ObjectProperty: XrayGuts
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT XrayGuts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3188); }
    }

    /// <summary>
    /// ObjectProperty: XrayCharacterSpriteBlue
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT XrayCharacterSpriteBlue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3196); }
    }

    /// <summary>
    /// ObjectProperty: XrayCharacterSpriteRed
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT XrayCharacterSpriteRed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3204); }
    }

    /// <summary>
    /// ObjectProperty: MultiplayerAuraMIC
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAIAnim.SavedXrayAuxiliaryMats MultiplayerAuraMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAIAnim.SavedXrayAuxiliaryMats>(Ptr + 3212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3212); }
    }

    /// <summary>
    /// ObjectProperty: MyLevelForXray
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MyLevelForXray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3220); }
    }

    /// <summary>
    /// ComponentProperty: AuxiliaryMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AuxiliaryMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3228); }
    }

    /// <summary>
    /// ComponentProperty: XrayCharacterSprite
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT XrayCharacterSprite
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3236); }
    }

    /// <summary>
    /// ComponentProperty: GutsMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GutsMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3244); }
    }

    /// <summary>
    /// ComponentProperty: SkeletonMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SkeletonMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3252); }
    }

    /// <summary>
    /// FloatProperty: XRayVisibilityTimer
    /// </summary>
    public unsafe float XRayVisibilityTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3260); }
    }

    /// <summary>
    /// FloatProperty: XRayVisibilityFadeInStartTime
    /// </summary>
    public unsafe float XRayVisibilityFadeInStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3264); }
    }

    /// <summary>
    /// FloatProperty: XRayVisibilityFadeInDuration
    /// </summary>
    public unsafe float XRayVisibilityFadeInDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3268); }
    }

    /// <summary>
    /// FloatProperty: XRayVisibilityMaxDistance
    /// </summary>
    public unsafe float XRayVisibilityMaxDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3272); }
    }

    /// <summary>
    /// FloatProperty: XRayFadeDistAdjustment
    /// </summary>
    public unsafe float XRayFadeDistAdjustment
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3276); }
    }

    /// <summary>
    /// FloatProperty: FirstSkeletonRenderTime
    /// </summary>
    public unsafe float FirstSkeletonRenderTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3280); }
    }

    /// <summary>
    /// IntProperty: HeartBeatType
    /// </summary>
    public unsafe int HeartBeatType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3284); }
    }

    /// <summary>
    /// IntProperty: OverrideHeartBeatType
    /// </summary>
    public unsafe int OverrideHeartBeatType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3288); }
    }

    /// <summary>
    /// ArrayProperty: SavedXrayAuxiliaryMats
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> SavedXrayAuxiliaryMats
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 3292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3292); }
    }

    /// <summary>
    /// ArrayProperty: MultiplayerAuraMeshes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> MultiplayerAuraMeshes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 3308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3308); }
    }

    /// <summary>
    /// NameProperty: OverworldName
    /// </summary>
    public unsafe BmSDK.FName OverworldName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 3324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3324); }
    }

    /// <summary>
    /// NameProperty: OverrideLevelForXrayCheck
    /// </summary>
    public unsafe BmSDK.FName OverrideLevelForXrayCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 3332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3332); }
    }
}
