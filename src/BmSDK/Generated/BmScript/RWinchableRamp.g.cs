#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RWinchableRamp<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RWinchableRamp : BmSDK.BmGame.RWinchableWallBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RWinchableRamp", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RWinchableRamp() { }

    /// <summary>
    /// Constructs a new RWinchableRamp
    /// </summary>
    public RWinchableRamp(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RWinchableRamp Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RWinchableRamp(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RWinchableRamp>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RWinchableRamp>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RWinchableRamp>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RWinchableRamp>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RWinchableRamp>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RWinchableRamp>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RWinchableRamp>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ComponentProperty: MeshCompRamp
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MeshCompRamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ComponentProperty: MeshCompHook
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MeshCompHook
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// ComponentProperty: MeshCompDownHook
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MeshCompDownHook
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ObjectProperty: MatineeAction
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MatineeAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// ObjectProperty: MatineeStaticMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MatineeStaticMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ObjectProperty: MatineeSkelMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MatineeSkelMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// ObjectProperty: BreakMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BreakMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// ObjectProperty: StartFallingSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT StartFallingSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// ObjectProperty: FallingCrashSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FallingCrashSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// ObjectProperty: RampAnimSeq
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RampAnimSeq
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// ObjectProperty: HookAnimSeq
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HookAnimSeq
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// ObjectProperty: DownHookAnimSeq
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DownHookAnimSeq
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ObjectProperty: PreventCrushBatmanVolume
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PreventCrushBatmanVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// FloatProperty: DamageMin
    /// </summary>
    public unsafe float DamageMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// FloatProperty: MinWinchRange
    /// </summary>
    public unsafe float MinWinchRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// NameProperty: RampLowToMidAnimName
    /// </summary>
    public unsafe BmSDK.FName RampLowToMidAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// NameProperty: RampMidToHighAnimName
    /// </summary>
    public unsafe BmSDK.FName RampMidToHighAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// NameProperty: BreakMaterialParamName
    /// </summary>
    public unsafe BmSDK.FName BreakMaterialParamName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// IntProperty: BreakMaterialIndex
    /// </summary>
    public unsafe int BreakMaterialIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// FloatProperty: FallingCrashSoundVelThreshold
    /// </summary>
    public unsafe float FallingCrashSoundVelThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// BoolProperty: UpperStage
    /// </summary>
    public unsafe bool UpperStage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: AllowFalling
    /// </summary>
    public unsafe bool AllowFalling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: IsFalling
    /// </summary>
    public unsafe bool IsFalling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: CanPullDown
    /// </summary>
    public unsafe bool CanPullDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: PullingDown
    /// </summary>
    public unsafe bool PullingDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: AllowLowering
    /// </summary>
    public unsafe bool AllowLowering
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: CannotBeBroken
    /// </summary>
    public unsafe bool CannotBeBroken
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 932); }
    }

    /// <summary>
    /// FloatProperty: FallRate
    /// </summary>
    public unsafe float FallRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// FloatProperty: FallAccel
    /// </summary>
    public unsafe float FallAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// FloatProperty: FallingVel
    /// </summary>
    public unsafe float FallingVel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// ByteProperty: InitialTick
    /// </summary>
    public unsafe byte InitialTick
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// FloatProperty: InitialPosition
    /// </summary>
    public unsafe float InitialPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// FloatProperty: InteractEventPosition
    /// </summary>
    public unsafe float InteractEventPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }
}
