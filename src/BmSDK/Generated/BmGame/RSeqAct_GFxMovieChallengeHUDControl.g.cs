#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_GFxMovieChallengeHUDControl<br/>
/// (size = 228)
/// (flags = 8210)
/// </summary>
public partial class RSeqAct_GFxMovieChallengeHUDControl : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_GFxMovieChallengeHUDControl", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RSeqAct_GFxMovieChallengeHUDControl.
    /// </summary>
    public static RSeqAct_GFxMovieChallengeHUDControl DefaultObject => (RSeqAct_GFxMovieChallengeHUDControl)StaticClass().DefaultObject;

    internal RSeqAct_GFxMovieChallengeHUDControl() { }

    /// <summary>
    /// Constructs a new RSeqAct_GFxMovieChallengeHUDControl
    /// </summary>
    public RSeqAct_GFxMovieChallengeHUDControl(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_GFxMovieChallengeHUDControl Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_GFxMovieChallengeHUDControl(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_GFxMovieChallengeHUDControl>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_GFxMovieChallengeHUDControl>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_GFxMovieChallengeHUDControl>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_GFxMovieChallengeHUDControl>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_GFxMovieChallengeHUDControl>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_GFxMovieChallengeHUDControl>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSeqAct_GFxMovieChallengeHUDControl>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSeqAct_GFxMovieChallengeHUDControl>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: Activated
    /// </summary>
    public unsafe override void Activated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqAct_GFxMovieChallengeHUDControl:Activated", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ByteProperty: TheAction
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_GFxMovieChallengeHUDControl.ChallengeHUDControl TheAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_GFxMovieChallengeHUDControl.ChallengeHUDControl>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// BoolProperty: bKismetControlsShowHide
    /// </summary>
    public unsafe bool bKismetControlsShowHide
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 208); }
    }

    /// <summary>
    /// IntProperty: ItemId
    /// </summary>
    public unsafe int ItemId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// StrProperty: ItemName
    /// </summary>
    public unsafe BmSDK.FString ItemName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }

    /// <summary>
    /// Enum: ChallengeHUDControl
    /// </summary>
    public enum ChallengeHUDControl
    {
        ChallengeHUDControl_KismetControlsHideShow = 0,
        ChallengeHUDControl_Show = 1,
        ChallengeHUDControl_Hide = 2,
        ChallengeHUDControl_Close = 3,
        ChallengeHUDControl_ShowItem = 4,
        ChallengeHUDControl_HideItem = 5,
        ChallengeHUDControl_AddPredatorItem = 6,
        ChallengeHUDControl_TickPredatorItem = 7,
        ChallengeHUDControl_Intro = 8,
        ChallengeHUDControl_Clear = 9,
        ChallengeHUDControl_Wave = 10,
        ChallengeHUDControl_TriggerFinalWavePrompt = 11,
        ChallengeHUDControl_PredatorWin = 12,
        ChallengeHUDControl_Lose = 13,
        ChallengeHUDControl_H2HCombatComplete = 14,
        ChallengeHUDControl_MAX = 15,
    }
}
