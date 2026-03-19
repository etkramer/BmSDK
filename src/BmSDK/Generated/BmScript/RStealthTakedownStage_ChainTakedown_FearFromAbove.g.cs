#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RStealthTakedownStage_ChainTakedown_FearFromAbove<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RStealthTakedownStage_ChainTakedown_FearFromAbove : BmSDK.BmGame.RStealthTakeDownStage, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RStealthTakedownStage_ChainTakedown_FearFromAbove", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RStealthTakedownStage_ChainTakedown_FearFromAbove() { }

    /// <summary>
    /// Constructs a new RStealthTakedownStage_ChainTakedown_FearFromAbove
    /// </summary>
    public RStealthTakedownStage_ChainTakedown_FearFromAbove(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RStealthTakedownStage_ChainTakedown_FearFromAbove Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RStealthTakedownStage_ChainTakedown_FearFromAbove(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_FearFromAbove>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_FearFromAbove>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_FearFromAbove>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_FearFromAbove>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_FearFromAbove>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_FearFromAbove>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_FearFromAbove>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ByteProperty: TakedownFeatureType
    /// </summary>
    public unsafe byte TakedownFeatureType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1664); }
    }

    /// <summary>
    /// ByteProperty: OnSpotNextStage
    /// </summary>
    public unsafe byte OnSpotNextStage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1665); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1665); }
    }

    /// <summary>
    /// ArrayProperty: PlayerAnimationsByType
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RStealthTakeDownStage.VictimTransitions>>> PlayerAnimationsByType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RStealthTakeDownStage.VictimTransitions>>>>(Ptr + 1668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1668); }
    }

    /// <summary>
    /// ArrayProperty: PlayerOnSpotAnimationsByType
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RStealthTakeDownStage.VictimTransitions>> PlayerOnSpotAnimationsByType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RStealthTakeDownStage.VictimTransitions>>>(Ptr + 1684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1684); }
    }

    /// <summary>
    /// NameProperty: VictimFrontAnimation
    /// </summary>
    public unsafe BmSDK.FName VictimFrontAnimation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1700); }
    }

    /// <summary>
    /// NameProperty: VictimBackAnimation
    /// </summary>
    public unsafe BmSDK.FName VictimBackAnimation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1708); }
    }
}
