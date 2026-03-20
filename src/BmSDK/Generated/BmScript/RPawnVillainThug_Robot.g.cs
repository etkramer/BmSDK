#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RPawnVillainThug_Robot<br/>
/// (flags = 0)
/// </summary>
public partial class RPawnVillainThug_Robot : BmSDK.BmGame.RPawnVillainThug, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RPawnVillainThug_Robot", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnVillainThug_Robot() { }

    /// <summary>
    /// Constructs a new RPawnVillainThug_Robot
    /// </summary>
    public RPawnVillainThug_Robot(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnVillainThug_Robot Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnVillainThug_Robot(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThug_Robot>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThug_Robot>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThug_Robot>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThug_Robot>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThug_Robot>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThug_Robot>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThug_Robot>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: EyeGlowMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant EyeGlowMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 6696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6696); }
    }

    /// <summary>
    /// ObjectProperty: PfxReviveEmitter
    /// </summary>
    public unsafe BmSDK.Engine.Emitter PfxReviveEmitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Emitter>(Ptr + 6704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6704); }
    }

    /// <summary>
    /// ComponentProperty: HitFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent HitFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6712); }
    }

    /// <summary>
    /// ComponentProperty: StomachLight
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent StomachLight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 6720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6720); }
    }

    /// <summary>
    /// FloatProperty: PowerUpVal
    /// </summary>
    public unsafe float PowerUpVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6728); }
    }

    /// <summary>
    /// BoolProperty: bPoweringUp
    /// </summary>
    public unsafe bool bPoweringUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6732) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6732); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6732); }
    }

    /// <summary>
    /// BoolProperty: bLightsOff
    /// </summary>
    public unsafe bool bLightsOff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6732) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6732); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6732); }
    }

    /// <summary>
    /// BoolProperty: bLightsOffPermanently
    /// </summary>
    public unsafe bool bLightsOffPermanently
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6732) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6732); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6732); }
    }

    /// <summary>
    /// FloatProperty: StomachLightBrightnessMul
    /// </summary>
    public unsafe float StomachLightBrightnessMul
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6736); }
    }

    /// <summary>
    /// FloatProperty: DestStomachLightBrightnessMul
    /// </summary>
    public unsafe float DestStomachLightBrightnessMul
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6740); }
    }

    /// <summary>
    /// FloatProperty: ShowColourChangeTime
    /// </summary>
    public unsafe float ShowColourChangeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6744); }
    }

    /// <summary>
    /// FloatProperty: ToggleTime
    /// </summary>
    public unsafe float ToggleTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6748); }
    }

    /// <summary>
    /// NameProperty: PrevOnlyCanBeHitBy
    /// </summary>
    public unsafe BmSDK.FName PrevOnlyCanBeHitBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6752); }
    }

    /// <summary>
    /// FloatProperty: InvincibleTime
    /// </summary>
    public unsafe float InvincibleTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6760); }
    }

    /// <summary>
    /// ByteProperty: LightCol
    /// </summary>
    public unsafe BmSDK.BmScript.RPawnVillainThug_Robot.ELightCol LightCol
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RPawnVillainThug_Robot.ELightCol>(Ptr + 6764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6764); }
    }
}
