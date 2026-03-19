#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RStealthTakedownStage_ChainTakedown_WeakWall<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RStealthTakedownStage_ChainTakedown_WeakWall : BmSDK.BmGame.RStealthTakedownStage_ChainTakedown_Base, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RStealthTakedownStage_ChainTakedown_WeakWall", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RStealthTakedownStage_ChainTakedown_WeakWall() { }

    /// <summary>
    /// Constructs a new RStealthTakedownStage_ChainTakedown_WeakWall
    /// </summary>
    public RStealthTakedownStage_ChainTakedown_WeakWall(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RStealthTakedownStage_ChainTakedown_WeakWall Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RStealthTakedownStage_ChainTakedown_WeakWall(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_WeakWall>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_WeakWall>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_WeakWall>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_WeakWall>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_WeakWall>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_WeakWall>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_WeakWall>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: Player
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Player
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1844); }
    }

    /// <summary>
    /// ObjectProperty: PlayerController
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1852); }
    }

    /// <summary>
    /// ObjectProperty: destructibleWall
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT destructibleWall
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1860); }
    }

    /// <summary>
    /// ObjectProperty: WindowSmashSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WindowSmashSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1868); }
    }

    /// <summary>
    /// BoolProperty: bOldWallSuppressFullAIEvent
    /// </summary>
    public unsafe bool bOldWallSuppressFullAIEvent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1876) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1876); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1876); }
    }

    /// <summary>
    /// BoolProperty: bGlassSmashed
    /// </summary>
    public unsafe bool bGlassSmashed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1876) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1876); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1876); }
    }

    /// <summary>
    /// BoolProperty: bNormalWallSmashed
    /// </summary>
    public unsafe bool bNormalWallSmashed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1876) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1876); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1876); }
    }

    /// <summary>
    /// StructProperty: StartPlayerPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StartPlayerPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1880); }
    }

    /// <summary>
    /// StructProperty: StartVictimPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StartVictimPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1892); }
    }

    /// <summary>
    /// StructProperty: CameraRootLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CameraRootLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1904); }
    }

    /// <summary>
    /// ArrayProperty: WallAttackStageInfos
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RStealthTakeDownStage.StageAnim> WallAttackStageInfos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RStealthTakeDownStage.StageAnim>>(Ptr + 1916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1916); }
    }

    /// <summary>
    /// StructProperty: WallAttackStage
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage.StageAnim WallAttackStage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage.StageAnim>(Ptr + 1932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1932); }
    }
}
