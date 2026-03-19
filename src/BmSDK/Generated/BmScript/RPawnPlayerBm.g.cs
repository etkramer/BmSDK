#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RPawnPlayerBm<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RPawnPlayerBm : BmSDK.BmGame.RPawnPlayerBmBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RPawnPlayerBm", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnPlayerBm() { }

    /// <summary>
    /// Constructs a new RPawnPlayerBm
    /// </summary>
    public RPawnPlayerBm(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnPlayerBm Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnPlayerBm(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBm>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBm>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBm>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBm>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBm>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBm>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBm>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// FloatProperty: OverrideWalkSpeed
    /// </summary>
    public unsafe float OverrideWalkSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10252); }
    }

    /// <summary>
    /// FloatProperty: OverrideRunSpeed
    /// </summary>
    public unsafe float OverrideRunSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10256); }
    }

    /// <summary>
    /// FloatProperty: OverrideStealthSpeed
    /// </summary>
    public unsafe float OverrideStealthSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10260); }
    }

    /// <summary>
    /// BoolProperty: bTempDebugReAddDefaultInventory
    /// </summary>
    public unsafe bool bTempDebugReAddDefaultInventory
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10264); }
    }

    /// <summary>
    /// BoolProperty: TurningFingersOn
    /// </summary>
    public unsafe bool TurningFingersOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10264); }
    }

    /// <summary>
    /// BoolProperty: TurningFingersOff
    /// </summary>
    public unsafe bool TurningFingersOff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10264); }
    }

    /// <summary>
    /// BoolProperty: bFingersAttached
    /// </summary>
    public unsafe bool bFingersAttached
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10264); }
    }

    /// <summary>
    /// BoolProperty: bSwitchCharInXRay
    /// </summary>
    public unsafe bool bSwitchCharInXRay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10264); }
    }

    /// <summary>
    /// BoolProperty: bRadioModeEyes
    /// </summary>
    public unsafe bool bRadioModeEyes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10264); }
    }

    /// <summary>
    /// BoolProperty: bInvestigateModeEyes
    /// </summary>
    public unsafe bool bInvestigateModeEyes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10264); }
    }

    /// <summary>
    /// FloatProperty: CloakingDuration
    /// </summary>
    public unsafe float CloakingDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10268); }
    }

    /// <summary>
    /// FloatProperty: CloakingBlend
    /// </summary>
    public unsafe float CloakingBlend
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10272); }
    }

    /// <summary>
    /// ObjectProperty: FaceMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FaceMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10276); }
    }

    /// <summary>
    /// ObjectProperty: CloakingMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CloakingMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10284); }
    }

    /// <summary>
    /// ComponentProperty: FingersMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FingersMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10292); }
    }

    /// <summary>
    /// ComponentProperty: CloakingAuraCapeMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CloakingAuraCapeMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10300); }
    }

    /// <summary>
    /// ComponentProperty: CloakingAuraSecondaryMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CloakingAuraSecondaryMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10308); }
    }

    /// <summary>
    /// ComponentProperty: CloakingAuraMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CloakingAuraMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10316); }
    }

    /// <summary>
    /// ClassProperty: IceSphereClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT IceSphereClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10324); }
    }

    /// <summary>
    /// ArrayProperty: IceSpheres
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnPlayerBmBase.DemonSafeObjects> IceSpheres
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnPlayerBmBase.DemonSafeObjects>>(Ptr + 10332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10332); }
    }

    /// <summary>
    /// IntProperty: MaxIceSpheres
    /// </summary>
    public unsafe int MaxIceSpheres
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10348); }
    }

    /// <summary>
    /// FloatProperty: CurrentFingerTime
    /// </summary>
    public unsafe float CurrentFingerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10352); }
    }

    /// <summary>
    /// FloatProperty: RadioEyeLevel
    /// </summary>
    public unsafe float RadioEyeLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10356); }
    }
}
