#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RStealthTakeDownStage_GlassWallAttack<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RStealthTakeDownStage_GlassWallAttack : BmSDK.BmGame.RStealthTakeDownStage, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RStealthTakeDownStage_GlassWallAttack", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RStealthTakeDownStage_GlassWallAttack() { }

    /// <summary>
    /// Constructs a new RStealthTakeDownStage_GlassWallAttack
    /// </summary>
    public RStealthTakeDownStage_GlassWallAttack(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RStealthTakeDownStage_GlassWallAttack Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RStealthTakeDownStage_GlassWallAttack(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_GlassWallAttack>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_GlassWallAttack>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_GlassWallAttack>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_GlassWallAttack>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_GlassWallAttack>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_GlassWallAttack>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_GlassWallAttack>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: StartLoc
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StartLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1664); }
    }

    /// <summary>
    /// ObjectProperty: Player
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Player
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1796); }
    }

    /// <summary>
    /// ObjectProperty: PlayerController
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1804); }
    }

    /// <summary>
    /// ObjectProperty: destructibleWall
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT destructibleWall
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1812); }
    }

    /// <summary>
    /// ObjectProperty: WindowSmashSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WindowSmashSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1820); }
    }

    /// <summary>
    /// BoolProperty: bOldWallSuppressFullAIEvent
    /// </summary>
    public unsafe bool bOldWallSuppressFullAIEvent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1828) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1828); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1828); }
    }

    /// <summary>
    /// BoolProperty: bPlayingCamera
    /// </summary>
    public unsafe bool bPlayingCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1828) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1828); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1828); }
    }

    /// <summary>
    /// BoolProperty: bGlassSmashed
    /// </summary>
    public unsafe bool bGlassSmashed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1828) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1828); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1828); }
    }

    /// <summary>
    /// BoolProperty: bNormalWallSmashed
    /// </summary>
    public unsafe bool bNormalWallSmashed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1828) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1828); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1828); }
    }

    /// <summary>
    /// StructProperty: StartPlayerPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StartPlayerPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1832); }
    }

    /// <summary>
    /// StructProperty: StartVictimPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StartVictimPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1844); }
    }

    /// <summary>
    /// StructProperty: CameraRootLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CameraRootLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1856); }
    }

    /// <summary>
    /// IntProperty: CameraPhase
    /// </summary>
    public unsafe int CameraPhase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1868); }
    }

    /// <summary>
    /// ArrayProperty: WallAttackStageInfos
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RStealthTakeDownStage.StageAnim> WallAttackStageInfos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RStealthTakeDownStage.StageAnim>>(Ptr + 1872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1872); }
    }

    /// <summary>
    /// StructProperty: WallAttackStage
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage.StageAnim WallAttackStage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage.StageAnim>(Ptr + 1888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1888); }
    }
}
