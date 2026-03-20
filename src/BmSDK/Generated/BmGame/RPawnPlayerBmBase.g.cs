#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnPlayerBmBase<br/>
/// (flags = 0)
/// </summary>
public partial class RPawnPlayerBmBase : BmSDK.BmGame.RPawnPlayer, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnPlayerBmBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnPlayerBmBase() { }

    /// <summary>
    /// Constructs a new RPawnPlayerBmBase
    /// </summary>
    public RPawnPlayerBmBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnPlayerBmBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnPlayerBmBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBmBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBmBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBmBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBmBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBmBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBmBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerBmBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// BoolProperty: bUseDamageMeshes
    /// </summary>
    public unsafe bool bUseDamageMeshes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10032) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10032); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10032); }
    }

    /// <summary>
    /// BoolProperty: DemonTrialsVulnerable
    /// </summary>
    public unsafe bool DemonTrialsVulnerable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10032) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10032); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10032); }
    }

    /// <summary>
    /// BoolProperty: bGauntletLightRunning
    /// </summary>
    public unsafe bool bGauntletLightRunning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10032) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10032); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10032); }
    }

    /// <summary>
    /// ComponentProperty: CapeSkeletalMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent CapeSkeletalMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 10036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10036); }
    }

    /// <summary>
    /// ComponentProperty: CapeComponent
    /// </summary>
    public unsafe BmSDK.BmGame.RCapeComponent CapeComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCapeComponent>(Ptr + 10044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10044); }
    }

    /// <summary>
    /// ComponentProperty: CapeRenderingComponent
    /// </summary>
    public unsafe BmSDK.BmGame.RCapeRenderingComponent CapeRenderingComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCapeRenderingComponent>(Ptr + 10052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10052); }
    }

    /// <summary>
    /// ObjectProperty: EyesMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant EyesMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 10060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10060); }
    }

    /// <summary>
    /// ObjectProperty: EyesMaterial2
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant EyesMaterial2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 10068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10068); }
    }

    /// <summary>
    /// ObjectProperty: EyeLashMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant EyeLashMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 10076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10076); }
    }

    /// <summary>
    /// ObjectProperty: GlideDirectionalDirectionNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeBlendDirectional GlideDirectionalDirectionNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeBlendDirectional>(Ptr + 10084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10084); }
    }

    /// <summary>
    /// ObjectProperty: GlideDirectionalStrengthNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeBlend GlideDirectionalStrengthNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeBlend>(Ptr + 10092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10092); }
    }

    /// <summary>
    /// ObjectProperty: GlideRetractBlendNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeBlend GlideRetractBlendNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeBlend>(Ptr + 10100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10100); }
    }

    /// <summary>
    /// ObjectProperty: GlideBaseNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNode GlideBaseNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNode>(Ptr + 10108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10108); }
    }

    /// <summary>
    /// ObjectProperty: GlideRetractBlendMixer
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeBlendPerBone GlideRetractBlendMixer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeBlendPerBone>(Ptr + 10116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10116); }
    }

    /// <summary>
    /// ObjectProperty: GlideFlutterStrengthNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeBlend GlideFlutterStrengthNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeBlend>(Ptr + 10124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10124); }
    }

    /// <summary>
    /// ObjectProperty: CapeWaterSprayEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem CapeWaterSprayEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 10132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10132); }
    }

    /// <summary>
    /// ObjectProperty: PlacedBombOnDownedEnemy
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain PlacedBombOnDownedEnemy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 10140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10140); }
    }

    /// <summary>
    /// ObjectProperty: JustShieldBlockedShotFrom
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat JustShieldBlockedShotFrom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(Ptr + 10148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10148); }
    }

    /// <summary>
    /// ObjectProperty: BarrelRollRight
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig BarrelRollRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 10156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10156); }
    }

    /// <summary>
    /// ObjectProperty: BarrelRollLeft
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig BarrelRollLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 10164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10164); }
    }

    /// <summary>
    /// ObjectProperty: CapeXrayMatInstConst
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant CapeXrayMatInstConst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 10172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10172); }
    }

    /// <summary>
    /// ComponentProperty: GauntletLight
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent GauntletLight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 10180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10180); }
    }

    /// <summary>
    /// ComponentProperty: RightWingTipTrail
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent RightWingTipTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 10188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10188); }
    }

    /// <summary>
    /// ComponentProperty: LeftWingTipTrail
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent LeftWingTipTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 10196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10196); }
    }

    /// <summary>
    /// StructProperty: EyeGlowColour
    /// </summary>
    public unsafe BmSDK.GameObject.FLinearColor EyeGlowColour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FLinearColor>(Ptr + 10204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10204); }
    }

    /// <summary>
    /// FloatProperty: DivePullUpAnimStrength
    /// </summary>
    public unsafe float DivePullUpAnimStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10220); }
    }

    /// <summary>
    /// ArrayProperty: DemonSafeObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> DemonSafeObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 10224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10224); }
    }

    /// <summary>
    /// FloatProperty: CurrentPoisonFaceLevel
    /// </summary>
    public unsafe float CurrentPoisonFaceLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10240); }
    }

    /// <summary>
    /// FloatProperty: PoisonFaceLevelBlendTime
    /// </summary>
    public unsafe float PoisonFaceLevelBlendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10244); }
    }

    /// <summary>
    /// FloatProperty: GauntletLightTimer
    /// </summary>
    public unsafe float GauntletLightTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10248); }
    }
}
