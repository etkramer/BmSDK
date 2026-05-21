#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBmStealthTakedownStage_LRLedgeTakedownSuccess<br/>
/// (size = 1724)
/// (flags = 10485778)
/// </summary>
public partial class RBmStealthTakedownStage_LRLedgeTakedownSuccess : BmSDK.BmGame.RStealthTakeDownStage_GrabFromCrouch2, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBmStealthTakedownStage_LRLedgeTakedownSuccess", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBmStealthTakedownStage_LRLedgeTakedownSuccess.
    /// </summary>
    public static RBmStealthTakedownStage_LRLedgeTakedownSuccess DefaultObject => (RBmStealthTakedownStage_LRLedgeTakedownSuccess)StaticClass().DefaultObject;

    internal RBmStealthTakedownStage_LRLedgeTakedownSuccess() { }

    /// <summary>
    /// Constructs a new RBmStealthTakedownStage_LRLedgeTakedownSuccess
    /// </summary>
    public RBmStealthTakedownStage_LRLedgeTakedownSuccess(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBmStealthTakedownStage_LRLedgeTakedownSuccess(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBmStealthTakedownStage_LRLedgeTakedownSuccess>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBmStealthTakedownStage_LRLedgeTakedownSuccess>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBmStealthTakedownStage_LRLedgeTakedownSuccess>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBmStealthTakedownStage_LRLedgeTakedownSuccess>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBmStealthTakedownStage_LRLedgeTakedownSuccess>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBmStealthTakedownStage_LRLedgeTakedownSuccess>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBmStealthTakedownStage_LRLedgeTakedownSuccess>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBmStealthTakedownStage_LRLedgeTakedownSuccess>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: GotoStageEx
    /// </summary>
    public unsafe override void GotoStageEx(BmSDK.BmGame.RGameInfo.EStealthTakeDownStages NextStageClass, bool bClientRequest = default, BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator EscapeLoc = default, bool bEscapeTakedown = default, bool bNextStageIsFearTakedown = default, bool bNextStageIsKnockoutSmash = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBmStealthTakedownStage_LRLedgeTakedownSuccess.GotoStageEx", true);
        byte* paramsPtr = stackalloc byte[152];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextStageClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bClientRequest, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EscapeLoc, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEscapeTakedown, paramsPtr + 140);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNextStageIsFearTakedown, paramsPtr + 144);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNextStageIsKnockoutSmash, paramsPtr + 148);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
