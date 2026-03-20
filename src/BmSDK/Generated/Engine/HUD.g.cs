#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: HUD<br/>
/// (flags = 0)
/// </summary>
public partial class HUD : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.HUD", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal HUD() { }

    /// <summary>
    /// Constructs a new HUD
    /// </summary>
    public HUD(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, HUD Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected HUD(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<HUD>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<HUD>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<HUD>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<HUD>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<HUD>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<HUD>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<HUD>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: WhiteColor
    /// </summary>
    public unsafe BmSDK.GameObject.FColor WhiteColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// StructProperty: GreenColor
    /// </summary>
    public unsafe BmSDK.GameObject.FColor GreenColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// StructProperty: RedColor
    /// </summary>
    public unsafe BmSDK.GameObject.FColor RedColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ObjectProperty: PlayerOwner
    /// </summary>
    public unsafe BmSDK.Engine.PlayerController PlayerOwner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerController>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// ObjectProperty: Canvas
    /// </summary>
    public unsafe BmSDK.Engine.Canvas Canvas
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Canvas>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// BoolProperty: bLostFocusPaused
    /// </summary>
    public unsafe bool bLostFocusPaused
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bShowHUD
    /// </summary>
    public unsafe bool bShowHUD
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bShowScores
    /// </summary>
    public unsafe bool bShowScores
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bShowDebugInfo
    /// </summary>
    public unsafe bool bShowDebugInfo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bShowBadConnectionAlert
    /// </summary>
    public unsafe bool bShowBadConnectionAlert
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bShowDirectorInfoDebug
    /// </summary>
    public unsafe bool bShowDirectorInfoDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bShowDirectorInfoHUD
    /// </summary>
    public unsafe bool bShowDirectorInfoHUD
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bMessageBeep
    /// </summary>
    public unsafe bool bMessageBeep
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bShowOverlays
    /// </summary>
    public unsafe bool bShowOverlays
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// FloatProperty: HudCanvasScale
    /// </summary>
    public unsafe float HudCanvasScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ArrayProperty: PostRenderedActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> PostRenderedActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ArrayProperty: ConsoleMessages
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.HUD.FConsoleMessage> ConsoleMessages
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.HUD.FConsoleMessage>>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// StructProperty: ConsoleColor
    /// </summary>
    public unsafe BmSDK.GameObject.FColor ConsoleColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// IntProperty: ConsoleMessageCount
    /// </summary>
    public unsafe int ConsoleMessageCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// IntProperty: ConsoleFontSize
    /// </summary>
    public unsafe int ConsoleFontSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// IntProperty: MessageFontOffset
    /// </summary>
    public unsafe int MessageFontOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// IntProperty: MaxHUDAreaMessageCount
    /// </summary>
    public unsafe int MaxHUDAreaMessageCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// StructProperty: LocalMessages
    /// </summary>
    public unsafe BmSDK.Engine.HUD.FHudLocalizedMessage LocalMessages_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.HUD.FHudLocalizedMessage>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }
    /// <summary>
    /// StructProperty: LocalMessages
    /// </summary>
    public unsafe BmSDK.Engine.HUD.FHudLocalizedMessage LocalMessages_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.HUD.FHudLocalizedMessage>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }
    /// <summary>
    /// StructProperty: LocalMessages
    /// </summary>
    public unsafe BmSDK.Engine.HUD.FHudLocalizedMessage LocalMessages_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.HUD.FHudLocalizedMessage>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }
    /// <summary>
    /// StructProperty: LocalMessages
    /// </summary>
    public unsafe BmSDK.Engine.HUD.FHudLocalizedMessage LocalMessages_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.HUD.FHudLocalizedMessage>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }
    /// <summary>
    /// StructProperty: LocalMessages
    /// </summary>
    public unsafe BmSDK.Engine.HUD.FHudLocalizedMessage LocalMessages_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.HUD.FHudLocalizedMessage>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }
    /// <summary>
    /// StructProperty: LocalMessages
    /// </summary>
    public unsafe BmSDK.Engine.HUD.FHudLocalizedMessage LocalMessages_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.HUD.FHudLocalizedMessage>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }
    /// <summary>
    /// StructProperty: LocalMessages
    /// </summary>
    public unsafe BmSDK.Engine.HUD.FHudLocalizedMessage LocalMessages_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.HUD.FHudLocalizedMessage>(Ptr + 1236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1236); }
    }
    /// <summary>
    /// StructProperty: LocalMessages
    /// </summary>
    public unsafe BmSDK.Engine.HUD.FHudLocalizedMessage LocalMessages_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.HUD.FHudLocalizedMessage>(Ptr + 1316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1316); }
    }

    /// <summary>
    /// FloatProperty: ConsoleMessagePosX
    /// </summary>
    public unsafe float ConsoleMessagePosX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1396); }
    }

    /// <summary>
    /// FloatProperty: ConsoleMessagePosY
    /// </summary>
    public unsafe float ConsoleMessagePosY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1400); }
    }

    /// <summary>
    /// FloatProperty: LastHUDRenderTime
    /// </summary>
    public unsafe float LastHUDRenderTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1404); }
    }

    /// <summary>
    /// FloatProperty: RenderDelta
    /// </summary>
    public unsafe float RenderDelta
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1408); }
    }

    /// <summary>
    /// FloatProperty: SizeX
    /// </summary>
    public unsafe float SizeX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1412); }
    }

    /// <summary>
    /// FloatProperty: SizeY
    /// </summary>
    public unsafe float SizeY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1416); }
    }

    /// <summary>
    /// FloatProperty: CenterX
    /// </summary>
    public unsafe float CenterX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1420); }
    }

    /// <summary>
    /// FloatProperty: CenterY
    /// </summary>
    public unsafe float CenterY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }
    }

    /// <summary>
    /// FloatProperty: RatioX
    /// </summary>
    public unsafe float RatioX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1428); }
    }

    /// <summary>
    /// FloatProperty: RatioY
    /// </summary>
    public unsafe float RatioY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1432); }
    }

    /// <summary>
    /// ArrayProperty: DebugDisplay
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> DebugDisplay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 1436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1436); }
    }

    /// <summary>
    /// ArrayProperty: KismetTextInfo
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.HUD.FKismetDrawTextInfo> KismetTextInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.HUD.FKismetDrawTextInfo>>(Ptr + 1452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1452); }
    }
}
