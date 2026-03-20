#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RStealthTakedownStage_ChainTakedown_Loop<br/>
/// (flags = 0)
/// </summary>
public partial class RStealthTakedownStage_ChainTakedown_Loop : BmSDK.BmGame.RStealthTakedownStage_ChainTakedown_Base, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RStealthTakedownStage_ChainTakedown_Loop", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RStealthTakedownStage_ChainTakedown_Loop() { }

    /// <summary>
    /// Constructs a new RStealthTakedownStage_ChainTakedown_Loop
    /// </summary>
    public RStealthTakedownStage_ChainTakedown_Loop(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RStealthTakedownStage_ChainTakedown_Loop Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RStealthTakedownStage_ChainTakedown_Loop(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_Loop>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_Loop>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_Loop>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_Loop>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_Loop>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_Loop>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_ChainTakedown_Loop>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// FloatProperty: fDistanceThresholdForFarAnimation
    /// </summary>
    public unsafe float fDistanceThresholdForFarAnimation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1844); }
    }

    /// <summary>
    /// Enum: AttackApproachDirectionChainTakedownLoopVersion
    /// </summary>
    public enum AttackApproachDirectionChainTakedownLoopVersion
    {
        AAPCTLV_MiddleHit_Back_Close = 0,
        AAPCTLV_MiddleHit_Front_Close = 1,
        AAPCTLV_MiddleHit_Left_Close = 2,
        AAPCTLV_MiddleHit_Right_Close = 3,
        AAPCTLV_MiddleHit_Back_Far = 4,
        AAPCTLV_MiddleHit_Front_Far = 5,
        AAPCTLV_MiddleHit_Left_Far = 6,
        AAPCTLV_MiddleHit_Right_Far = 7,
        AAPCTLV_LastHit_Back_Close = 8,
        AAPCTLV_LastHit_Front_Close = 9,
        AAPCTLV_LastHit_Left_Close = 10,
        AAPCTLV_LastHit_Right_Close = 11,
        AAPCTLV_LastHit_Back_Far = 12,
        AAPCTLV_LastHit_Front_Far = 13,
        AAPCTLV_LastHit_Left_Far = 14,
        AAPCTLV_LastHit_Right_Far = 15,
        AAPCTLV_MAX = 16,
    }
}
