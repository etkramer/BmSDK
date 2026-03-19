#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RRbStealthTakeDownStage_WaitForBatmanBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RRbStealthTakeDownStage_WaitForBatmanBase : BmSDK.BmGame.RStealthTakeDownStage, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RRbStealthTakeDownStage_WaitForBatmanBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RRbStealthTakeDownStage_WaitForBatmanBase() { }

    /// <summary>
    /// Constructs a new RRbStealthTakeDownStage_WaitForBatmanBase
    /// </summary>
    public RRbStealthTakeDownStage_WaitForBatmanBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RRbStealthTakeDownStage_WaitForBatmanBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRbStealthTakeDownStage_WaitForBatmanBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_WaitForBatmanBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_WaitForBatmanBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_WaitForBatmanBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_WaitForBatmanBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_WaitForBatmanBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_WaitForBatmanBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_WaitForBatmanBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// BoolProperty: bBatmanStartedGlideKick
    /// </summary>
    public unsafe bool bBatmanStartedGlideKick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1664); }
    }

    /// <summary>
    /// ByteProperty: GlideKickTakedownStage
    /// </summary>
    public unsafe byte GlideKickTakedownStage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1668); }
    }

    /// <summary>
    /// ByteProperty: Stage
    /// </summary>
    public unsafe byte Stage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1669); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1669); }
    }

    /// <summary>
    /// NameProperty: TurnLeftAnim
    /// </summary>
    public unsafe BmSDK.FName TurnLeftAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1672); }
    }

    /// <summary>
    /// NameProperty: TurnRightAnim
    /// </summary>
    public unsafe BmSDK.FName TurnRightAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1680); }
    }
}
