#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCornerWallMarkerBase<br/>
/// (flags = 0)
/// </summary>
public partial class RCornerWallMarkerBase : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCornerWallMarkerBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCornerWallMarkerBase() { }

    /// <summary>
    /// Constructs a new RCornerWallMarkerBase
    /// </summary>
    public RCornerWallMarkerBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCornerWallMarkerBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCornerWallMarkerBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCornerWallMarkerBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCornerWallMarkerBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCornerWallMarkerBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCornerWallMarkerBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCornerWallMarkerBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCornerWallMarkerBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCornerWallMarkerBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ComponentProperty: SpriteComponentDisabled
    /// </summary>
    public unsafe BmSDK.Engine.SpriteComponent SpriteComponentDisabled
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SpriteComponent>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ComponentProperty: SpriteComponentBatman
    /// </summary>
    public unsafe BmSDK.Engine.SpriteComponent SpriteComponentBatman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SpriteComponent>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ComponentProperty: ArrowComponent
    /// </summary>
    public unsafe BmSDK.Engine.ArrowComponent ArrowComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ArrowComponent>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// BoolProperty: bUsable
    /// </summary>
    public unsafe bool bUsable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 692); }
    }

    /// <summary>
    /// BoolProperty: BatmanCanUse
    /// </summary>
    public unsafe bool BatmanCanUse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 692); }
    }

    /// <summary>
    /// BoolProperty: VisibleToAI
    /// </summary>
    public unsafe bool VisibleToAI
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 692); }
    }

    /// <summary>
    /// BoolProperty: PotentiallyVisibleToAI
    /// </summary>
    public unsafe bool PotentiallyVisibleToAI
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 692); }
    }

    /// <summary>
    /// BoolProperty: EscapePoint
    /// </summary>
    public unsafe bool EscapePoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 692); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 692); }
    }

    /// <summary>
    /// StructProperty: WallPos
    /// </summary>
    public unsafe System.Numerics.Vector3 WallPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// ObjectProperty: OwningCorner
    /// </summary>
    public unsafe BmSDK.BmGame.RCornerPointBase OwningCorner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCornerPointBase>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ComponentProperty: InteractionList
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent InteractionList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ArrayProperty: PlayerCornerLinks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCornerWallMarkerBase> PlayerCornerLinks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCornerWallMarkerBase>>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// FloatProperty: ClosestEnemyDist
    /// </summary>
    public unsafe float ClosestEnemyDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ByteProperty: CurrentState
    /// </summary>
    public unsafe BmSDK.BmGame.RCornerWallMarkerBase.CornerState CurrentState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCornerWallMarkerBase.CornerState>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// ByteProperty: BatmanCornerType
    /// </summary>
    public unsafe BmSDK.BmGame.REnvironmentCheckTicker.BatmanCoverCorners BatmanCornerType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentCheckTicker.BatmanCoverCorners>(Ptr + 745); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 745); }
    }

    /// <summary>
    /// StructProperty: BatmanCoverPosition
    /// </summary>
    public unsafe System.Numerics.Vector3 BatmanCoverPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// FloatProperty: BatmanLROffset
    /// </summary>
    public unsafe float BatmanLROffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }
}
