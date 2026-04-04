#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudExtensionInvestigate<br/>
/// (size = 268)
/// (flags = 18)
/// </summary>
public partial class RHudExtensionInvestigate : BmSDK.BmGame.RHudExtension, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHudExtensionInvestigate", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RHudExtensionInvestigate.
    /// </summary>
    public static RHudExtensionInvestigate DefaultObject => (RHudExtensionInvestigate)StaticClass().DefaultObject;

    internal RHudExtensionInvestigate() { }

    /// <summary>
    /// Constructs a new RHudExtensionInvestigate
    /// </summary>
    public RHudExtensionInvestigate(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHudExtensionInvestigate Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHudExtensionInvestigate(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudExtensionInvestigate>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudExtensionInvestigate>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudExtensionInvestigate>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudExtensionInvestigate>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudExtensionInvestigate>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudExtensionInvestigate>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHudExtensionInvestigate>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHudExtensionInvestigate>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: ScanComplete
    /// </summary>
    public unsafe virtual void ScanComplete()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudExtensionInvestigate:ScanComplete", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HideGadgetHUD
    /// </summary>
    public unsafe virtual void HideGadgetHUD(bool bHide)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudExtensionInvestigate:HideGadgetHUD", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHide, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetPrompt
    /// </summary>
    public unsafe virtual void SetPrompt(BmSDK.BmGame.RHudExtensionInvestigate.ScannerPrompt ScanID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudExtensionInvestigate:SetPrompt", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScanID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetEvidenceDetail
    /// </summary>
    public unsafe virtual void SetEvidenceDetail(BmSDK.FString _CurrentEvidenceDetailString)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudExtensionInvestigate:SetEvidenceDetail", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_CurrentEvidenceDetailString, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetContentsType
    /// </summary>
    public unsafe virtual void SetContentsType(BmSDK.FString contents_type)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudExtensionInvestigate:SetContentsType", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(contents_type, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetContentsVisible
    /// </summary>
    public unsafe virtual void SetContentsVisible(bool bVisible)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudExtensionInvestigate:SetContentsVisible", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: MarkGrundyDrumBeat
    /// </summary>
    public unsafe virtual void MarkGrundyDrumBeat()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudExtensionInvestigate:MarkGrundyDrumBeat", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetScannerVisible
    /// </summary>
    public unsafe virtual void SetScannerVisible(bool bVisible)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudExtensionInvestigate:SetScannerVisible", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopScanning
    /// </summary>
    public unsafe virtual void StopScanning()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudExtensionInvestigate:StopScanning", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartScanning
    /// </summary>
    public unsafe virtual void StartScanning()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudExtensionInvestigate:StartScanning", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetSmokePercentageInternal
    /// </summary>
    public unsafe virtual void SetSmokePercentageInternal(int SmokePercentage)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudExtensionInvestigate:SetSmokePercentageInternal", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SmokePercentage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetSmokePercentage
    /// </summary>
    public unsafe virtual void SetSmokePercentage(int SmokePercentage)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudExtensionInvestigate:SetSmokePercentage", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SmokePercentage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetScannerCursor
    /// </summary>
    public unsafe virtual void SetScannerCursor(float X, float Y, BmSDK.FString EvidenceName, bool bNewItem, bool bScanned, bool bUnscannable, int NotFullyVisible, BmSDK.FString MessageTitle, BmSDK.FString Message)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudExtensionInvestigate:SetScannerCursor", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EvidenceName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewItem, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bScanned, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUnscannable, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NotFullyVisible, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MessageTitle, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 48);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetScannerCursorNone
    /// </summary>
    public unsafe virtual void SetScannerCursorNone()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudExtensionInvestigate:SetScannerCursorNone", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetNPCCountString
    /// </summary>
    public unsafe virtual void SetNPCCountString(int Total, BmSDK.FString Str)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudExtensionInvestigate:SetNPCCountString", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Total, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Str, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetNPCInfoCursor
    /// </summary>
    public unsafe virtual void SetNPCInfoCursor(float X, float Y, BmSDK.FString actorName, int NpcType, int HeartBeatType, int WeaponType, bool bIsArmoured)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudExtensionInvestigate:SetNPCInfoCursor", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(actorName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NpcType, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HeartBeatType, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponType, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsArmoured, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetNPCInfoCursorNone
    /// </summary>
    public unsafe virtual void SetNPCInfoCursorNone()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudExtensionInvestigate:SetNPCInfoCursorNone", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetInfoCursor
    /// </summary>
    public unsafe virtual void SetInfoCursor(float X, float Y, BmSDK.FString actorName, BmSDK.FString Title, BmSDK.FString Message, bool bWarningColour)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudExtensionInvestigate:SetInfoCursor", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(actorName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Message, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWarningColour, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetInfoCursorNone
    /// </summary>
    public unsafe virtual void SetInfoCursorNone()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudExtensionInvestigate:SetInfoCursorNone", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetEvidenceCursor
    /// </summary>
    public unsafe virtual void SetEvidenceCursor(float X, float Y, BmSDK.FString EvidenceName, BmSDK.FString actorName, bool bScanned, bool bShowLine)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudExtensionInvestigate:SetEvidenceCursor", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EvidenceName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(actorName, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bScanned, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShowLine, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetEvidenceCursorNone
    /// </summary>
    public unsafe virtual void SetEvidenceCursorNone()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudExtensionInvestigate:SetEvidenceCursorNone", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CloseCurrentCursor
    /// </summary>
    public unsafe virtual void CloseCurrentCursor()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudExtensionInvestigate:CloseCurrentCursor", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CloseCurrentCursorUnless
    /// </summary>
    public unsafe virtual void CloseCurrentCursorUnless(BmSDK.BmGame.RHudExtensionInvestigate.EvidenceDisplayType type_exception)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudExtensionInvestigate:CloseCurrentCursorUnless", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(type_exception, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SwitchToMode
    /// </summary>
    public unsafe virtual void SwitchToMode(int Mode, bool bInDesiredMode, BmSDK.FString TrailName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudExtensionInvestigate:SwitchToMode", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mode, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInDesiredMode, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TrailName, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateNPCCounts
    /// </summary>
    public unsafe virtual void UpdateNPCCounts(int Armed, int UnArmed)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudExtensionInvestigate:UpdateNPCCounts", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Armed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnArmed, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetScreenDepth
    /// </summary>
    public unsafe virtual void SetScreenDepth(float inDepth)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudExtensionInvestigate:SetScreenDepth", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inDepth, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Close
    /// </summary>
    public unsafe override void Close()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudExtensionInvestigate:Close", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override bool Init(BmSDK.BmGame.RPlayerController _RPC, BmSDK.FString _ExtensionName, BmSDK.FString _ExtensionPath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudExtensionInvestigate:Init", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionPath, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    /// <summary>
    /// ByteProperty: CurrentDisplayType
    /// </summary>
    public unsafe BmSDK.BmGame.RHudExtensionInvestigate.EvidenceDisplayType CurrentDisplayType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudExtensionInvestigate.EvidenceDisplayType>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ByteProperty: CurrentScannerPromptVal
    /// </summary>
    public unsafe BmSDK.BmGame.RHudExtensionInvestigate.ScannerPrompt CurrentScannerPromptVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudExtensionInvestigate.ScannerPrompt>(Ptr + 133); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 133); }
    }

    /// <summary>
    /// ObjectProperty: ScannerEventSFX
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ScannerEventSFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// ObjectProperty: ScanModeEventSFX
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ScanModeEventSFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// IntProperty: NPC_Armed
    /// </summary>
    public unsafe int NPC_Armed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// IntProperty: NPC_UnArmed
    /// </summary>
    public unsafe int NPC_UnArmed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// StrProperty: DisplayedContentsTypeString
    /// </summary>
    public unsafe BmSDK.FString DisplayedContentsTypeString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// StrProperty: CurrentEvidenceDetailString
    /// </summary>
    public unsafe BmSDK.FString CurrentEvidenceDetailString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// StrProperty: LoadedContentsTypeString
    /// </summary>
    public unsafe BmSDK.FString LoadedContentsTypeString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// ObjectProperty: MovieInfo
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie MovieInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetEvidenceCursor
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetEvidenceCursor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetInfoCursor
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetInfoCursor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetNPCInfoCursor
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetNPCInfoCursor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetScannerCursor
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetScannerCursor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetSmokePercentage
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetSmokePercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// StrProperty: CachedVariable_MasterDepth
    /// </summary>
    public unsafe BmSDK.FString CachedVariable_MasterDepth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// FloatProperty: CurrentRendererDepth
    /// </summary>
    public unsafe float CurrentRendererDepth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// Enum: EvidenceDisplayType
    /// </summary>
    public enum EvidenceDisplayType
    {
        EEDT_None = 0,
        EEDT_NPC = 1,
        EEDT_Info = 2,
        EEDT_Evidence = 3,
        EEDT_MAX = 4,
    }

    /// <summary>
    /// Enum: ENPCType
    /// </summary>
    public enum ENPCType
    {
        ENPCType_None = 0,
        ENPCType_Thug = 1,
        ENPCType_Guard = 2,
        ENPCType_Lunatic = 3,
        ENPCType_Henchman = 4,
        ENPCType_Undead = 5,
        ENPCType_ThugJammer = 6,
        ENPCType_ThugMines = 7,
        ENPCType_ThugThermalVision = 8,
        ENPCType_BossMrFreeze = 9,
        ENPCType_BossGrundy = 10,
        ENPCType_BossClayface = 11,
        ENPCType_BossClayfaceDrone = 12,
        ENPCType_BossPenguin = 13,
        ENPCType_BossPenguinIceberg = 14,
        ENPCType_FrozenNora = 15,
        ENPCType_TwoFace = 16,
        ENPCType_Robot = 17,
        ENPCType_MAX = 18,
    }

    /// <summary>
    /// Enum: EHeartBeatType
    /// </summary>
    public enum EHeartBeatType
    {
        EHeartBeatType_Fine = 0,
        EHeartBeatType_Nervous = 1,
        EHeartBeatType_Terrified = 2,
        EHeartBeatType_Unconscious = 3,
        EHeartBeatType_Crazy = 4,
        EHeartBeatType_Undead = 5,
        EHeartBeatType_Injured = 6,
        EHeartBeatType_Frozen = 7,
        EHeartBeatType_MrFreezeWithoutSuit = 8,
        EHeartBeatType_MrFreezeNormal = 9,
        EHeartBeatType_RobotDead = 10,
        EHeartBeatType_RobotDormant = 11,
        EHeartBeatType_RobotActive = 12,
        EHeartBeatType_Agitated = 13,
        EHeartBeatType_GrundyDead = 14,
        EHeartBeatType_GrundyNormal = 15,
        EHeartBeatType_GrundyOnFire = 16,
        EHeartBeatType_Unknown = 17,
        EHeartBeatType_MAX = 18,
    }

    /// <summary>
    /// Enum: ScannerPrompt
    /// </summary>
    public enum ScannerPrompt
    {
        ScannerPrompt_None = 0,
        ScannerPrompt_PressAndHoldToScan = 1,
        ScannerPrompt_PressAToClose = 2,
        ScannerPrompt_MAX = 3,
    }
}
