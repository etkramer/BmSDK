#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPresetAimingConfigs<br/>
/// (size = 116)
/// (flags = 134217874)
/// </summary>
public partial class RPresetAimingConfigs : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPresetAimingConfigs", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPresetAimingConfigs() { }

    /// <summary>
    /// Constructs a new RPresetAimingConfigs
    /// </summary>
    public RPresetAimingConfigs(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPresetAimingConfigs Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPresetAimingConfigs(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPresetAimingConfigs>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPresetAimingConfigs>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPresetAimingConfigs>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPresetAimingConfigs>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPresetAimingConfigs>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPresetAimingConfigs>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPresetAimingConfigs>
        => ((GameObject)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ArrayProperty: Presets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAimingConfig> Presets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAimingConfig>>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// ObjectProperty: NoAiming
    /// </summary>
    public unsafe BmSDK.BmGame.RAimingConfig NoAiming
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingConfig>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// ObjectProperty: RelaxedHead
    /// </summary>
    public unsafe BmSDK.BmGame.RAimingConfig RelaxedHead
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingConfig>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// ObjectProperty: RelaxedHeadNoSpine
    /// </summary>
    public unsafe BmSDK.BmGame.RAimingConfig RelaxedHeadNoSpine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingConfig>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// ObjectProperty: RelaxedHeadFullReference
    /// </summary>
    public unsafe BmSDK.BmGame.RAimingConfig RelaxedHeadFullReference
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingConfig>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// ObjectProperty: AlertHead
    /// </summary>
    public unsafe BmSDK.BmGame.RAimingConfig AlertHead
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingConfig>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }

    /// <summary>
    /// ObjectProperty: FullHead
    /// </summary>
    public unsafe BmSDK.BmGame.RAimingConfig FullHead
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingConfig>(Ptr + 76); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }
    }

    /// <summary>
    /// ObjectProperty: GunTwoHanded
    /// </summary>
    public unsafe BmSDK.BmGame.RAimingConfig GunTwoHanded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingConfig>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }

    /// <summary>
    /// ObjectProperty: Combat
    /// </summary>
    public unsafe BmSDK.BmGame.RAimingConfig Combat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingConfig>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: FullSpine
    /// </summary>
    public unsafe BmSDK.BmGame.RAimingConfig FullSpine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingConfig>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// ObjectProperty: Gadget
    /// </summary>
    public unsafe BmSDK.BmGame.RAimingConfig Gadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingConfig>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ObjectProperty: Crouching
    /// </summary>
    public unsafe BmSDK.BmGame.RAimingConfig Crouching
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingConfig>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ObjectProperty: LeftHanded
    /// </summary>
    public unsafe BmSDK.BmGame.RAimingConfig LeftHanded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingConfig>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ObjectProperty: PredPanicPose
    /// </summary>
    public unsafe BmSDK.BmGame.RAimingConfig PredPanicPose
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingConfig>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// ObjectProperty: PredPanicGlancePose
    /// </summary>
    public unsafe BmSDK.BmGame.RAimingConfig PredPanicGlancePose
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingConfig>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ObjectProperty: PredPanicAimingPose
    /// </summary>
    public unsafe BmSDK.BmGame.RAimingConfig PredPanicAimingPose
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingConfig>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// Enum: EPresetAimingConfig
    /// </summary>
    public enum EPresetAimingConfig
    {
        PAC_None = 0,
        PAC_NoAiming = 1,
        PAC_RelaxedHead = 2,
        PAC_RelaxedHeadNoSpine = 3,
        PAC_RelaxedHeadFullReference = 4,
        PAC_AlertHead = 5,
        PAC_FullHead = 6,
        PAC_GunTwoHanded = 7,
        PAC_Combat = 8,
        PAC_FullSpine = 9,
        PAC_Gadget = 10,
        PAC_Crouching = 11,
        PAC_LeftHanded = 12,
        PAC_PredPanicPose = 13,
        PAC_PredPanicGlancePose = 14,
        PAC_PredPanicAimingPose = 15,
        PAC_MAX = 16,
    }
}
