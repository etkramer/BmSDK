#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieHUD<br/>
/// (size = 536)
/// (flags = 18)
/// </summary>
public partial class RGFxMovieHUD : BmSDK.BmGame.RGFxMovie, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieHUD", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieHUD() { }

    /// <summary>
    /// Constructs a new RGFxMovieHUD
    /// </summary>
    public RGFxMovieHUD(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieHUD Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieHUD(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieHUD>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieHUD>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieHUD>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieHUD>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieHUD>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieHUD>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieHUD>
        => ((GameObject)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: ShowCredits
    /// </summary>
    public unsafe virtual void ShowCredits(float Delay, BmSDK.TArray<BmSDK.FString> CreditList)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieHUD.ShowCredits", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Delay, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CreditList, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowCreditsAS
    /// </summary>
    public unsafe virtual void ShowCreditsAS(float Delay)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieHUD.ShowCreditsAS", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Delay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ObjectivesPromptCallback
    /// </summary>
    public unsafe virtual BmSDK.FString ObjectivesPromptCallback(BmSDK.FString KeyType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieHUD.ObjectivesPromptCallback", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KeyType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: ShowRiddle
    /// </summary>
    public unsafe virtual void ShowRiddle(bool bShow, BmSDK.FString RiddleText)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieHUD.ShowRiddle", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RiddleText, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetZoomMode
    /// </summary>
    public unsafe virtual void SetZoomMode(bool bEnabled, float HeadAngle)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieHUD.SetZoomMode", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnabled, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HeadAngle, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowCritical
    /// </summary>
    public unsafe virtual void ShowCritical()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieHUD.ShowCritical", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetCombo
    /// </summary>
    public unsafe virtual void SetCombo(int Value, bool bPowerUp)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieHUD.SetCombo", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPowerUp, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowLevelUp
    /// </summary>
    public unsafe virtual void ShowLevelUp(bool bShow)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieHUD.ShowLevelUp", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowLevelUpTrigger
    /// </summary>
    public unsafe virtual void ShowLevelUpTrigger(bool bShow)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieHUD.ShowLevelUpTrigger", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowXPBar
    /// </summary>
    public unsafe virtual void ShowXPBar(bool bShow)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieHUD.ShowXPBar", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetXPBarTarget
    /// </summary>
    public unsafe virtual void SetXPBarTarget(int Current, int Maximum)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieHUD.SetXPBarTarget", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Current, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Maximum, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetXPBarCurrent
    /// </summary>
    public unsafe virtual void SetXPBarCurrent(int Current, int Maximum)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieHUD.SetXPBarCurrent", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Current, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Maximum, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowHealthBar
    /// </summary>
    public unsafe virtual void ShowHealthBar(bool bShow)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieHUD.ShowHealthBar", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetHealthBar
    /// </summary>
    public unsafe virtual void SetHealthBar(int Current, int Maximum)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieHUD.SetHealthBar", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Current, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Maximum, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InitHealthBar
    /// </summary>
    public unsafe virtual void InitHealthBar(int Current, int Maximum)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieHUD.InitHealthBar", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Current, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Maximum, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: QueueXPMessage
    /// </summary>
    public unsafe virtual void QueueXPMessage(BmSDK.FString Title, BmSDK.FString Message, float HoldDuration)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieHUD.QueueXPMessage", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HoldDuration, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: MarkXPBarAsFull
    /// </summary>
    public unsafe virtual void MarkXPBarAsFull(bool bIsFull)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieHUD.MarkXPBarAsFull", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsFull, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.Engine.LocalPlayer LocPlay = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieHUD.Init", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: ObjIcon
    /// </summary>
    public enum ObjIcon
    {
        OI_Arrow = 0,
        OI_Ticked = 1,
        OI_Unlocked = 2,
        OI_SideStory = 3,
        OI_SideStoryTick = 4,
        OI_PointOfInterest = 5,
        OI_ARTraining = 6,
        OI_Waypoint = 7,
        OI_Switchpoint = 8,
        OI_MAX = 9,
    }

    /// <summary>
    /// Enum: JustifyText
    /// </summary>
    public enum JustifyText
    {
        JT_Left = 0,
        JT_Center = 1,
        JT_Right = 2,
        JT_Align = 3,
        JT_MAX = 4,
    }

    /// <summary>
    /// ObjectProperty: ObjectivesEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ObjectivesEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// ObjectProperty: FadeEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FadeEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// ObjectProperty: HUDEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent HUDEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// BoolProperty: bSurpressLevelupSound
    /// </summary>
    public unsafe bool bSurpressLevelupSound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 508); }
    }

    /// <summary>
    /// BoolProperty: bXPBarFull
    /// </summary>
    public unsafe bool bXPBarFull
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 508); }
    }

    /// <summary>
    /// BoolProperty: Anytime_bVisible
    /// </summary>
    public unsafe bool Anytime_bVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 508); }
    }

    /// <summary>
    /// BoolProperty: Anytime_bRestart
    /// </summary>
    public unsafe bool Anytime_bRestart
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 508); }
    }

    /// <summary>
    /// BoolProperty: bUseSplitScreenPrompts
    /// </summary>
    public unsafe bool bUseSplitScreenPrompts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 508); }
    }

    /// <summary>
    /// FloatProperty: Anytime_X
    /// </summary>
    public unsafe float Anytime_X
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// FloatProperty: Anytime_Y
    /// </summary>
    public unsafe float Anytime_Y
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// FloatProperty: Anytime_Depth
    /// </summary>
    public unsafe float Anytime_Depth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// StrProperty: Anytime_AnimName
    /// </summary>
    public unsafe BmSDK.FString Anytime_AnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }
}
