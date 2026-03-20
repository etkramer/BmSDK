#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPersistentData<br/>
/// (size = 3205)
/// (flags = 134217874)
/// </summary>
public partial class RPersistentData : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPersistentData", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPersistentData() { }

    /// <summary>
    /// Constructs a new RPersistentData
    /// </summary>
    public RPersistentData(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPersistentData Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPersistentData(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: LoadDialogue
    /// </summary>
    public unsafe void LoadDialogue()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.LoadDialogue", true);
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: SaveDialogue
    /// </summary>
    public unsafe void SaveDialogue()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SaveDialogue", true);
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: GetObjectiveStyle
    /// </summary>
    public unsafe BmSDK.FString GetObjectiveStyle()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.GetObjectiveStyle", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetCustomFlagsForMapIcon
    /// </summary>
    public unsafe BmSDK.FString GetCustomFlagsForMapIcon(BmSDK.FString IconName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.GetCustomFlagsForMapIcon", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: GetMostWantedIconLocation
    /// </summary>
    public unsafe bool GetMostWantedIconLocation(int SideStoryIndex, BmSDK.FString IconName, out System.Numerics.Vector3 ReturnVector)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.GetMostWantedIconLocation", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SideStoryIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconName, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ReturnVector = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: GetClosestUndiscoveredMapIconIndex
    /// </summary>
    public unsafe int GetClosestUndiscoveredMapIconIndex(int SideStoryIndex, System.Numerics.Vector3 ReferenceVector)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.GetClosestUndiscoveredMapIconIndex", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SideStoryIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReferenceVector, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: SideStoryCountIconsOfDiscoveryState
    /// </summary>
    public unsafe int SideStoryCountIconsOfDiscoveryState(int SideStoryIndex, byte DiscoveryState, bool IncludeRadialMarkers = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SideStoryCountIconsOfDiscoveryState", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SideStoryIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DiscoveryState, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IncludeRadialMarkers, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: SideStoryAnyIconsOfDiscoveryState
    /// </summary>
    public unsafe bool SideStoryAnyIconsOfDiscoveryState(int SideStoryIndex, byte DiscoveryState, bool IncludeRadialMarkers = default, bool CheckPointHack = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SideStoryAnyIconsOfDiscoveryState", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SideStoryIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DiscoveryState, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IncludeRadialMarkers, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckPointHack, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: GetSideStoryMapIconIndex
    /// </summary>
    public unsafe int GetSideStoryMapIconIndex(BmSDK.FString IconName, bool CreateIfNone = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.GetSideStoryMapIconIndex", true);
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CreateIfNone, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: SetSideStoryDiscoveryState
    /// </summary>
    public unsafe bool SetSideStoryDiscoveryState(BmSDK.FString IconName, byte DiscoveryState, int SideStoryIndex, bool bAddToAutoPan)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SetSideStoryDiscoveryState", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DiscoveryState, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SideStoryIndex, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAddToAutoPan, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: GetSideStoryDiscoveryState
    /// </summary>
    public unsafe int GetSideStoryDiscoveryState(BmSDK.FString IconName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.GetSideStoryDiscoveryState", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: DumpStorySynopsis
    /// </summary>
    public unsafe void DumpStorySynopsis()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.DumpStorySynopsis", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetStorySynopsisAsString
    /// </summary>
    public unsafe BmSDK.FString GetStorySynopsisAsString(int Index)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.GetStorySynopsisAsString", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetStorySynopsis
    /// </summary>
    public unsafe void GetStorySynopsis(int Index, out int Chapter, out int ImageId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.GetStorySynopsis", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Chapter = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
        ImageId = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
        return;
    }

    /// <summary>
    /// Function: GetStorySynopsisCount
    /// </summary>
    public unsafe int GetStorySynopsisCount()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.GetStorySynopsisCount", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetStorySynopsis
    /// </summary>
    public unsafe void SetStorySynopsis(int ChapterValue, int ChapterImageValue)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SetStorySynopsis", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChapterValue, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChapterImageValue, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowRaftCancelTutorial
    /// </summary>
    public unsafe bool ShowRaftCancelTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ShowRaftCancelTutorial", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IncrementRaftCancelTutorial
    /// </summary>
    public unsafe void IncrementRaftCancelTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IncrementRaftCancelTutorial", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartRaftCancelTutorial
    /// </summary>
    public unsafe void StartRaftCancelTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.StartRaftCancelTutorial", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartGrappleBoostTutorial
    /// </summary>
    public unsafe void StartGrappleBoostTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.StartGrappleBoostTutorial", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IncrementGrappleBoostTutorial
    /// </summary>
    public unsafe void IncrementGrappleBoostTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IncrementGrappleBoostTutorial", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowGrappleBoostTutorial
    /// </summary>
    public unsafe bool ShowGrappleBoostTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ShowGrappleBoostTutorial", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: StartStealthMoveTutorial
    /// </summary>
    public unsafe void StartStealthMoveTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.StartStealthMoveTutorial", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IncrementStealthMoveTutorialTimer
    /// </summary>
    public unsafe void IncrementStealthMoveTutorialTimer(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IncrementStealthMoveTutorialTimer", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowStealthMoveTutorial
    /// </summary>
    public unsafe bool ShowStealthMoveTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ShowStealthMoveTutorial", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: StartGrapplingTutorial
    /// </summary>
    public unsafe void StartGrapplingTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.StartGrapplingTutorial", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IncrementGrappleTutorial
    /// </summary>
    public unsafe void IncrementGrappleTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IncrementGrappleTutorial", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowGrappleTutorial
    /// </summary>
    public unsafe bool ShowGrappleTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ShowGrappleTutorial", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IncremementBatmobileDriveTutorialTimer
    /// </summary>
    public unsafe void IncremementBatmobileDriveTutorialTimer(float DeltaTime, BmSDK.BmGame.RPersistentData.EBatmobileDriveTutorialStage TutStage)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IncremementBatmobileDriveTutorialTimer", true);
        byte* paramsPtr = stackalloc byte[5];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TutStage, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: GetBatmobileTutorialTime
    /// </summary>
    public unsafe float GetBatmobileTutorialTime(BmSDK.BmGame.RPersistentData.EBatmobileDriveTutorialStage TutStage)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.GetBatmobileTutorialTime", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TutStage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: ShowBatmobileDriveTutorialStage
    /// </summary>
    public unsafe bool ShowBatmobileDriveTutorialStage(BmSDK.BmGame.RPersistentData.EBatmobileDriveTutorialStage TutStage)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ShowBatmobileDriveTutorialStage", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TutStage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: StartBatmobileDriveTutorial
    /// </summary>
    public unsafe void StartBatmobileDriveTutorial(BmSDK.BmGame.RPersistentData.EBatmobileDriveTutorialStage TutStage)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.StartBatmobileDriveTutorial", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TutStage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartGlideBoostTutorial
    /// </summary>
    public unsafe void StartGlideBoostTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.StartGlideBoostTutorial", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartGlidingTutorial
    /// </summary>
    public unsafe void StartGlidingTutorial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.StartGlidingTutorial", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowAnyGlideTutorials
    /// </summary>
    public unsafe bool ShowAnyGlideTutorials()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ShowAnyGlideTutorials", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IncrementPullUpFromDivePrompt
    /// </summary>
    public unsafe void IncrementPullUpFromDivePrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IncrementPullUpFromDivePrompt", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowPullUpFromDivePrompt
    /// </summary>
    public unsafe bool ShowPullUpFromDivePrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ShowPullUpFromDivePrompt", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: NumInformantsSoFarInCh9
    /// </summary>
    public unsafe int NumInformantsSoFarInCh9(BmSDK.BmGame.RGameInfo.EDistrict CityD)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.NumInformantsSoFarInCh9", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CityD, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: NumInformantsSoFar
    /// </summary>
    public unsafe int NumInformantsSoFar(BmSDK.BmGame.RGameInfo.EDistrict CityD)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.NumInformantsSoFar", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CityD, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IncrementGlideDivePrompt
    /// </summary>
    public unsafe void IncrementGlideDivePrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IncrementGlideDivePrompt", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowGlideDivePrompt
    /// </summary>
    public unsafe bool ShowGlideDivePrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ShowGlideDivePrompt", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IncrementGlideSteerPromptUD
    /// </summary>
    public unsafe void IncrementGlideSteerPromptUD()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IncrementGlideSteerPromptUD", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowGlideSteerPromptUD
    /// </summary>
    public unsafe bool ShowGlideSteerPromptUD()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ShowGlideSteerPromptUD", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IncrementGlideSteerPromptLR
    /// </summary>
    public unsafe void IncrementGlideSteerPromptLR()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IncrementGlideSteerPromptLR", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowGlideSteerPromptLR
    /// </summary>
    public unsafe bool ShowGlideSteerPromptLR()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ShowGlideSteerPromptLR", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IncrementGlideTimer
    /// </summary>
    public unsafe void IncrementGlideTimer(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IncrementGlideTimer", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowGlidePrompt
    /// </summary>
    public unsafe bool ShowGlidePrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ShowGlidePrompt", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ClearMapObjectivePanList
    /// </summary>
    public unsafe void ClearMapObjectivePanList()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ClearMapObjectivePanList", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RemoveDynamicMapItemsByChapter
    /// </summary>
    public unsafe void RemoveDynamicMapItemsByChapter(BmSDK.FString ChapterPrefix)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.RemoveDynamicMapItemsByChapter", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChapterPrefix, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RemoveDynamicMapItem
    /// </summary>
    public unsafe void RemoveDynamicMapItem(BmSDK.FString ItemName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.RemoveDynamicMapItem", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddDynamicMapItem
    /// </summary>
    public unsafe void AddDynamicMapItem(BmSDK.FString ItemName, BmSDK.FString ItemType, BmSDK.FString pMap, int X, int Y, int Z)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.AddDynamicMapItem", true);
        byte* paramsPtr = stackalloc byte[76];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemType, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pMap, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Z, paramsPtr + 56);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RemoveTrail
    /// </summary>
    public unsafe void RemoveTrail(BmSDK.FString TrailName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.RemoveTrail", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TrailName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsTrailItem
    /// </summary>
    public unsafe bool IsTrailItem(BmSDK.FString TrailName, BmSDK.FString MapName, int X, int Y, int Z)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IsTrailItem", true);
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TrailName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Z, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 44);
    }

    /// <summary>
    /// Function: AddTrailItem
    /// </summary>
    public unsafe void AddTrailItem(BmSDK.FString TrailName, BmSDK.FString MapName, int X, int Y, int Z)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.AddTrailItem", true);
        byte* paramsPtr = stackalloc byte[140];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TrailName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Z, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FindTrail
    /// </summary>
    public unsafe int FindTrail(BmSDK.FString TrailName, BmSDK.FString MapName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.FindTrail", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TrailName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: SetCustomWaypoint
    /// </summary>
    public unsafe void SetCustomWaypoint(System.Numerics.Vector3 atXYZ, bool bEnabled, bool bInOffsetSpace = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SetCustomWaypoint", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atXYZ, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnabled, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInOffsetSpace, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetCustomTrailWaypoint
    /// </summary>
    public unsafe void SetCustomTrailWaypoint(System.Numerics.Vector3 vec)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SetCustomTrailWaypoint", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vec, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetCustomWaypoint
    /// </summary>
    public unsafe System.Numerics.Vector3 GetCustomWaypoint(bool bInOffsetSpace = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.GetCustomWaypoint", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInOffsetSpace, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SetCustomWaypointEnabled
    /// </summary>
    public unsafe void SetCustomWaypointEnabled(bool bEnabled)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SetCustomWaypointEnabled", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetCustomWaypointEnabled
    /// </summary>
    public unsafe bool GetCustomWaypointEnabled()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.GetCustomWaypointEnabled", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetCustomWaypointTypeName
    /// </summary>
    public unsafe void SetCustomWaypointTypeName(BmSDK.FString NewName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SetCustomWaypointTypeName", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetCustomWaypointTypeName
    /// </summary>
    public unsafe BmSDK.FString GetCustomWaypointTypeName()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.GetCustomWaypointTypeName", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetCustomWaypointName
    /// </summary>
    public unsafe void SetCustomWaypointName(BmSDK.FString NewName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SetCustomWaypointName", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetCustomWaypointName
    /// </summary>
    public unsafe BmSDK.FString GetCustomWaypointName()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.GetCustomWaypointName", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetObjectiveLocation
    /// </summary>
    public unsafe void SetObjectiveLocation(System.Numerics.Vector3 the_location)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SetObjectiveLocation", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_location, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsObjectiveTrackingActive
    /// </summary>
    public unsafe bool IsObjectiveTrackingActive()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IsObjectiveTrackingActive", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetObjectiveTrackingActive
    /// </summary>
    public unsafe void SetObjectiveTrackingActive(bool is_active)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SetObjectiveTrackingActive", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_active, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateButtonBashDDA
    /// </summary>
    public unsafe void UpdateButtonBashDDA(out float TimeAtMinSpeed, out float TimeAtMaxSpeed)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.UpdateButtonBashDDA", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        TimeAtMinSpeed = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
        TimeAtMaxSpeed = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
        return;
    }

    /// <summary>
    /// Function: SixaxisTeethPrompt
    /// </summary>
    public unsafe bool SixaxisTeethPrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SixaxisTeethPrompt", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SixaxisTeethPerformed
    /// </summary>
    public unsafe void SixaxisTeethPerformed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SixaxisTeethPerformed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SixaxisBatarangPrompt
    /// </summary>
    public unsafe bool SixaxisBatarangPrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SixaxisBatarangPrompt", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SixaxisBatarangPerformed
    /// </summary>
    public unsafe void SixaxisBatarangPerformed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SixaxisBatarangPerformed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SixaxisGlidePrompt
    /// </summary>
    public unsafe bool SixaxisGlidePrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SixaxisGlidePrompt", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SixaxisGlidePerformed
    /// </summary>
    public unsafe void SixaxisGlidePerformed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SixaxisGlidePerformed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HangModeDropPrompt
    /// </summary>
    public unsafe bool HangModeDropPrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.HangModeDropPrompt", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: HangModeDropPerformed
    /// </summary>
    public unsafe void HangModeDropPerformed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.HangModeDropPerformed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DropOffGrapplePrompt
    /// </summary>
    public unsafe bool DropOffGrapplePrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.DropOffGrapplePrompt", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: DropOffGrapplePerformed
    /// </summary>
    public unsafe void DropOffGrapplePerformed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.DropOffGrapplePerformed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GlideOffWallPrompt
    /// </summary>
    public unsafe bool GlideOffWallPrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.GlideOffWallPrompt", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GlideOffWallPerformed
    /// </summary>
    public unsafe void GlideOffWallPerformed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.GlideOffWallPerformed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: LineLaunchDropPrompt
    /// </summary>
    public unsafe bool LineLaunchDropPrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.LineLaunchDropPrompt", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: LineLaunchDropPerformed
    /// </summary>
    public unsafe void LineLaunchDropPerformed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.LineLaunchDropPerformed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearAutomaticCombatTutorials
    /// </summary>
    public unsafe void ClearAutomaticCombatTutorials(bool bClearAll = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ClearAutomaticCombatTutorials", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bClearAll, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TutorialActionAchieved
    /// </summary>
    public unsafe void TutorialActionAchieved(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.TutorialActionAchieved", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowLevelTutorials
    /// </summary>
    public unsafe bool ShowLevelTutorials()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ShowLevelTutorials", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetNumActivationsForAction
    /// </summary>
    public unsafe int GetNumActivationsForAction(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.GetNumActivationsForAction", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: ShouldShowTutorial
    /// </summary>
    public unsafe int ShouldShowTutorial(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ShouldShowTutorial", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: ResetTutorialProgress
    /// </summary>
    public unsafe void ResetTutorialProgress(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ResetTutorialProgress", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DesignDeactivateTutorial
    /// </summary>
    public unsafe void DesignDeactivateTutorial(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.DesignDeactivateTutorial", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DesignActivateTutorial
    /// </summary>
    public unsafe void DesignActivateTutorial(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.DesignActivateTutorial", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsTutorialDesignerActive
    /// </summary>
    public unsafe bool IsTutorialDesignerActive(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IsTutorialDesignerActive", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: PlayerStopTutorial
    /// </summary>
    public unsafe void PlayerStopTutorial(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.PlayerStopTutorial", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayerStartTutorial
    /// </summary>
    public unsafe void PlayerStartTutorial(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.PlayerStartTutorial", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsTutorialPlayerActive
    /// </summary>
    public unsafe bool IsTutorialPlayerActive(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IsTutorialPlayerActive", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: AutoDeactivateTutorial
    /// </summary>
    public unsafe void AutoDeactivateTutorial(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.AutoDeactivateTutorial", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AutoActivateTutorial
    /// </summary>
    public unsafe void AutoActivateTutorial(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.AutoActivateTutorial", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsTutorialAutoActive
    /// </summary>
    public unsafe bool IsTutorialAutoActive(BmSDK.BmGame.RPersistentData.ETutorialType NewTut)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IsTutorialAutoActive", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTut, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetMostWantedCompletePercentage
    /// </summary>
    public unsafe float GetMostWantedCompletePercentage(int mw_index)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.GetMostWantedCompletePercentage", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(mw_index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: PadStr
    /// </summary>
    public unsafe BmSDK.FString PadStr(BmSDK.FString InStr, int DesiredLen)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.PadStr", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InStr, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredLen, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: DumpMostWantedData
    /// </summary>
    public unsafe void DumpMostWantedData()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.DumpMostWantedData", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DumpObjectives
    /// </summary>
    public unsafe void DumpObjectives()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.DumpObjectives", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Dump
    /// </summary>
    public unsafe void Dump()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.Dump", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ToTimeStr
    /// </summary>
    public unsafe BmSDK.FString ToTimeStr(float inTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ToTimeStr", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IntArrayToString
    /// </summary>
    public unsafe BmSDK.FString IntArrayToString(BmSDK.TArray<int> Values)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IntArrayToString", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Values, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: ByteArrayToString
    /// </summary>
    public unsafe BmSDK.FString ByteArrayToString(BmSDK.TArray<byte> Values)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ByteArrayToString", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Values, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: ClearActiveMapTrail
    /// </summary>
    public unsafe void ClearActiveMapTrail()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.ClearActiveMapTrail", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsChroniclesOfArkhamSolved
    /// </summary>
    public unsafe bool IsChroniclesOfArkhamSolved()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.IsChroniclesOfArkhamSolved", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetCipherCollectedCount
    /// </summary>
    public unsafe int GetCipherCollectedCount()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.GetCipherCollectedCount", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetChapters
    /// </summary>
    public unsafe void SetChapters(BmSDK.FString ChaptersAsString, BmSDK.BmGame.RFlagManager FlagMan)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SetChapters", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChaptersAsString, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlagMan, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: SetPlayableBatmobile
    /// </summary>
    public unsafe void SetPlayableBatmobile(BmSDK.FName NewBatmobileName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SetPlayableBatmobile", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBatmobileName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: SetPlayableCharacter
    /// </summary>
    public unsafe void SetPlayableCharacter(BmSDK.FName NewCharacterName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPersistentData.SetPlayableCharacter", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewCharacterName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Enum: BluntTraumaTakedowns
    /// </summary>
    public enum BluntTraumaTakedowns
    {
        BluntTrauma_Standing = 0,
        BluntTrauma_TunnelGrate = 1,
        BluntTrauma_SwingDown = 2,
        BluntTrauma_DropToGrab = 3,
        BluntTrauma_GlassAbove = 4,
        BluntTrauma_VantageAbove = 5,
        BluntTrauma_CeilingGrateAbove = 6,
        BluntTrauma_CeilingGrateBelow = 7,
        BluntTrauma_LedgeHang = 8,
        BluntTrauma_WallVent = 9,
        BluntTrauma_WeakWall = 10,
        BluntTrauma_CornerGrab = 11,
        BluntTrauma_GrappleBoost = 12,
        BluntTrauma_LineLauncher = 13,
        BluntTrauma_Environment = 14,
        BluntTrauma_MAX = 15,
    }

    /// <summary>
    /// Struct: FRandomPopulationDefine
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 704)]
    public partial record struct FRandomPopulationDefine
    {
        /// <summary>
        /// ByteProperty: Version
        /// </summary>
        public unsafe byte Version
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: CityDistrict
        /// </summary>
        public unsafe BmSDK.FString CityDistrict
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ByteProperty: bRiotingThugs
        /// </summary>
        public unsafe byte bRiotingThugs
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// ArrayProperty: ScenarioInfos
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FVehicleScenarioInfo> ScenarioInfos
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FVehicleScenarioInfo>>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ArrayProperty: DroneFormationScenarios
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FVehicleScenarioInfo> DroneFormationScenarios
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FVehicleScenarioInfo>>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// ArrayProperty: SideStoryScenarioInfos
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FVehicleScenarioInfo> SideStoryScenarioInfos
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FVehicleScenarioInfo>>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// IntProperty: MaxVehicleScenarios
        /// </summary>
        public unsafe int MaxVehicleScenarios
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }

        /// <summary>
        /// IntProperty: MaxDroneScenarios
        /// </summary>
        public unsafe int MaxDroneScenarios
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }; }
        }

        /// <summary>
        /// IntProperty: MaxHumveeScenarios
        /// </summary>
        public unsafe int MaxHumveeScenarios
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// IntProperty: TotalDronePopulation
        /// </summary>
        public unsafe int TotalDronePopulation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// IntProperty: CurrentDronePopulation
        /// </summary>
        public unsafe int CurrentDronePopulation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }; }
        }

        /// <summary>
        /// IntProperty: TotalHumveePopulation
        /// </summary>
        public unsafe int TotalHumveePopulation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }; }
        }

        /// <summary>
        /// IntProperty: CurrentHumveePopulation
        /// </summary>
        public unsafe int CurrentHumveePopulation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }

        /// <summary>
        /// IntProperty: MaxDroneThreatLevel
        /// </summary>
        public unsafe int MaxDroneThreatLevel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }; }
        }

        /// <summary>
        /// FloatProperty: ChanceThatRioterWillFlee
        /// </summary>
        public unsafe float ChanceThatRioterWillFlee
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 104); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }; }
        }

        /// <summary>
        /// IntProperty: PercChanceWanderersHaveAWeapon
        /// </summary>
        public unsafe int PercChanceWanderersHaveAWeapon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }; }
        }

        /// <summary>
        /// ByteProperty: bPassiveRiotingThugs
        /// </summary>
        public unsafe byte bPassiveRiotingThugs
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 112); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }; }
        }

        /// <summary>
        /// IntProperty: MaxActiveWanderingGroups
        /// </summary>
        public unsafe int MaxActiveWanderingGroups
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }; }
        }

        /// <summary>
        /// IntProperty: NumPawnsPerWanderingGroupMax
        /// </summary>
        public unsafe int NumPawnsPerWanderingGroupMax
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }; }
        }

        /// <summary>
        /// IntProperty: NumPawnsPerWanderingGroupMin
        /// </summary>
        public unsafe int NumPawnsPerWanderingGroupMin
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }; }
        }

        /// <summary>
        /// ByteProperty: bWanderersActive
        /// </summary>
        public unsafe byte bWanderersActive
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 128); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }; }
        }

        /// <summary>
        /// ByteProperty: bIsMilitiaWanderers
        /// </summary>
        public unsafe byte bIsMilitiaWanderers
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 129); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 129); }; }
        }

        /// <summary>
        /// IntProperty: NumWeaponPawnsPerRiotMax
        /// </summary>
        public unsafe int NumWeaponPawnsPerRiotMax
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }; }
        }

        /// <summary>
        /// IntProperty: NumWeaponPawnsPerRiotMin
        /// </summary>
        public unsafe int NumWeaponPawnsPerRiotMin
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }; }
        }

        /// <summary>
        /// ArrayProperty: RiotWeapons
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Class> RiotWeapons
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(Ptr + 140); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }; }
        }

        /// <summary>
        /// ClassProperty: MilitiaRifle
        /// </summary>
        public unsafe BmSDK.Class MilitiaRifle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 156); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }; }
        }

        /// <summary>
        /// StrProperty: Riots_Description
        /// </summary>
        public unsafe BmSDK.FString Riots_Description
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 164); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }; }
        }

        /// <summary>
        /// StrProperty: Riots_ActionName
        /// </summary>
        public unsafe BmSDK.FString Riots_ActionName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 180); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }; }
        }

        /// <summary>
        /// ArrayProperty: Riots_ModifiedByActions
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FString> Riots_ModifiedByActions
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 196); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }; }
        }

        /// <summary>
        /// StrProperty: Vehicles_Description
        /// </summary>
        public unsafe BmSDK.FString Vehicles_Description
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 212); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }; }
        }

        /// <summary>
        /// StrProperty: Vehicles_ActionName
        /// </summary>
        public unsafe BmSDK.FString Vehicles_ActionName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 228); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }; }
        }

        /// <summary>
        /// ArrayProperty: Vehicles_ModifiedByActions
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FString> Vehicles_ModifiedByActions
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 244); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }; }
        }

        /// <summary>
        /// StrProperty: Formations_Description
        /// </summary>
        public unsafe BmSDK.FString Formations_Description
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 260); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }; }
        }

        /// <summary>
        /// StrProperty: Formations_ActionName
        /// </summary>
        public unsafe BmSDK.FString Formations_ActionName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 276); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }; }
        }

        /// <summary>
        /// ArrayProperty: Formations_ModifiedByActions
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FString> Formations_ModifiedByActions
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 292); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }; }
        }

        /// <summary>
        /// ObjectProperty: HeavyTankEncounter
        /// </summary>
        public unsafe BmSDK.BmGame.RSeqAct_VehicleEnemySpawner HeavyTankEncounter
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_VehicleEnemySpawner>(Ptr + 308); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }; }
        }

        /// <summary>
        /// FloatProperty: WarmUpTimer
        /// </summary>
        public unsafe float WarmUpTimer
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 316); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }; }
        }

        /// <summary>
        /// FloatProperty: WarmUpTimerMax
        /// </summary>
        public unsafe float WarmUpTimerMax
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 320); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }; }
        }

        /// <summary>
        /// ByteProperty: Pause_Drones
        /// </summary>
        public unsafe byte Pause_Drones
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 324); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }; }
        }

        /// <summary>
        /// StrProperty: Pause_Drones_Description
        /// </summary>
        public unsafe BmSDK.FString Pause_Drones_Description
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 328); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }; }
        }

        /// <summary>
        /// StrProperty: Pause_Drones_ActionName
        /// </summary>
        public unsafe BmSDK.FString Pause_Drones_ActionName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 344); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }; }
        }

        /// <summary>
        /// ByteProperty: Pause_Humvees
        /// </summary>
        public unsafe byte Pause_Humvees
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 360); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }; }
        }

        /// <summary>
        /// StrProperty: Pause_Humvees_Description
        /// </summary>
        public unsafe BmSDK.FString Pause_Humvees_Description
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 364); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }; }
        }

        /// <summary>
        /// StrProperty: Pause_Humvees_ActionName
        /// </summary>
        public unsafe BmSDK.FString Pause_Humvees_ActionName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 380); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }; }
        }

        /// <summary>
        /// ByteProperty: Pause_ThugCars
        /// </summary>
        public unsafe byte Pause_ThugCars
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 396); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }; }
        }

        /// <summary>
        /// StrProperty: Pause_ThugCars_Description
        /// </summary>
        public unsafe BmSDK.FString Pause_ThugCars_Description
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 400); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }; }
        }

        /// <summary>
        /// StrProperty: Pause_ThugCars_ActionName
        /// </summary>
        public unsafe BmSDK.FString Pause_ThugCars_ActionName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 416); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }; }
        }

        /// <summary>
        /// ByteProperty: Pause_Riots
        /// </summary>
        public unsafe byte Pause_Riots
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 432); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }; }
        }

        /// <summary>
        /// StrProperty: Pause_Riots_Description
        /// </summary>
        public unsafe BmSDK.FString Pause_Riots_Description
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 436); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }; }
        }

        /// <summary>
        /// StrProperty: Pause_Riots_ActionName
        /// </summary>
        public unsafe BmSDK.FString Pause_Riots_ActionName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 452); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }; }
        }

        /// <summary>
        /// ArrayProperty: Pause_Drones_Descriptions
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FString> Pause_Drones_Descriptions
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 468); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }; }
        }

        /// <summary>
        /// ArrayProperty: Pause_Drones_ActionNames
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FString> Pause_Drones_ActionNames
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 484); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }; }
        }

        /// <summary>
        /// ArrayProperty: Pause_Humvees_Descriptions
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FString> Pause_Humvees_Descriptions
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 500); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }; }
        }

        /// <summary>
        /// ArrayProperty: Pause_Humvees_ActionNames
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FString> Pause_Humvees_ActionNames
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 516); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }; }
        }

        /// <summary>
        /// ArrayProperty: Pause_ThugCars_Descriptions
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FString> Pause_ThugCars_Descriptions
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 532); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }; }
        }

        /// <summary>
        /// ArrayProperty: Pause_ThugCars_ActionNames
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FString> Pause_ThugCars_ActionNames
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 548); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }; }
        }

        /// <summary>
        /// ArrayProperty: Pause_Riots_Descriptions
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FString> Pause_Riots_Descriptions
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 564); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }; }
        }

        /// <summary>
        /// ArrayProperty: Pause_Riots_ActionNames
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FString> Pause_Riots_ActionNames
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 580); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }; }
        }

        /// <summary>
        /// ArrayProperty: UniqueRefName
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FString> UniqueRefName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 596); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }; }
        }

        /// <summary>
        /// ByteProperty: DisableExtraCarScenarios
        /// </summary>
        public unsafe byte DisableExtraCarScenarios
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 612); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }; }
        }

        /// <summary>
        /// StrProperty: DisableExtraCarScenarios_Description
        /// </summary>
        public unsafe BmSDK.FString DisableExtraCarScenarios_Description
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 616); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }; }
        }

        /// <summary>
        /// StrProperty: DisableExtraCarScenarios_ActionName
        /// </summary>
        public unsafe BmSDK.FString DisableExtraCarScenarios_ActionName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 632); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }; }
        }

        /// <summary>
        /// ArrayProperty: OverrideThreatLevel
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentData.FOverrideThreatLevelInfo> OverrideThreatLevel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentData.FOverrideThreatLevelInfo>>(Ptr + 648); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }; }
        }

        /// <summary>
        /// ByteProperty: BatmobileUnavailable
        /// </summary>
        public unsafe byte BatmobileUnavailable
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 664); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }; }
        }

        /// <summary>
        /// IntProperty: NumThugsWantToFightFromRiotMin
        /// </summary>
        public unsafe int NumThugsWantToFightFromRiotMin
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }; }
        }

        /// <summary>
        /// IntProperty: NumThugsWantToFightFromRiotMax
        /// </summary>
        public unsafe int NumThugsWantToFightFromRiotMax
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 672); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }; }
        }

        /// <summary>
        /// IntProperty: MaximumNonRiotThugsAllowedToFight
        /// </summary>
        public unsafe int MaximumNonRiotThugsAllowedToFight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 676); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }; }
        }

        /// <summary>
        /// FloatProperty: PostGasRiotSpawnPerc
        /// </summary>
        public unsafe float PostGasRiotSpawnPerc
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 680); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }; }
        }

        /// <summary>
        /// IntProperty: APCsRemaining
        /// </summary>
        public unsafe int APCsRemaining
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 684); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }; }
        }

        /// <summary>
        /// FloatProperty: MilitiaWanderersWarmUpTimer
        /// </summary>
        public unsafe float MilitiaWanderersWarmUpTimer
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 688); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }; }
        }

        /// <summary>
        /// FloatProperty: MilitiaWanderersWarmUpTimerMax
        /// </summary>
        public unsafe float MilitiaWanderersWarmUpTimerMax
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 692); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }; }
        }

        /// <summary>
        /// IntProperty: AdditionalLightDroneThreat
        /// </summary>
        public unsafe int AdditionalLightDroneThreat
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }; }
        }

        /// <summary>
        /// IntProperty: AdditionalHeavyDroneThreat
        /// </summary>
        public unsafe int AdditionalHeavyDroneThreat
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }; }
        }
    }

    /// <summary>
    /// Enum: DynamicPopulation_SideStories
    /// </summary>
    public enum DynamicPopulation_SideStories
    {
        DynamicPopulation_SideStory_Penguin = 0,
        DynamicPopulation_SideStory_APCChase = 1,
        DynamicPopulation_SideStory_MAX = 2,
    }

    /// <summary>
    /// Enum: DynamicPopulation_PopulationDefines_Version
    /// </summary>
    public enum DynamicPopulation_PopulationDefines_Version
    {
        DynamicPopulation_PopulationDefines_Initial = 0,
        DynamicPopulation_PopulationDefines_SideStories = 1,
        DynamicPopulation_PopulationDefines_MilitiaWanderers = 2,
        DynamicPopulation_PopulationDefines_UseabilityHumveesAndFormations = 3,
        DynamicPopulation_PopulationDefines_ThreatLevel = 4,
        DynamicPopulation_PopulationDefines_FixFormations = 5,
        DynamicPopulation_PopulationDefines_FixFormations2 = 6,
        DynamicPopulation_PopulationDefines_PausePopulation = 7,
        DynamicPopulation_PopulationDefines_BatmobileUnavailable = 8,
        DynamicPopulation_PopulationDefines_ThugsFighting = 9,
        DynamicPopulation_PopulationDefines_ThugsFightingMaximums = 10,
        DynamicPopulation_PopulationDefines_GasSpawnPerc = 11,
        DynamicPopulation_PopulationDefines_DisableExtraCars = 12,
        DynamicPopulation_PopulationDefines_APCsPerIsland = 13,
        DynamicPopulation_PopulationDefines_WandererWarmup = 14,
        DynamicPopulation_PopulationDefines_AdditionalThreat = 15,
        DynamicPopulation_PopulationDefines_PausePopulation2 = 16,
        DynamicPopulation_PopulationDefines_MAX = 17,
    }

    /// <summary>
    /// Struct: FAPCSideStoryInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 144)]
    public partial record struct FAPCSideStoryInfo
    {
        /// <summary>
        /// ByteProperty: Version
        /// </summary>
        public unsafe byte Version
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: APCSideStoryScenarios
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FVehicleScenarioInfo> APCSideStoryScenarios
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FVehicleScenarioInfo>>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: APCSideStoryScenarioInfo
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.FVehicleScenarioInfo APCSideStoryScenarioInfo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FVehicleScenarioInfo>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// IntProperty: CurrAPCScenarioID
        /// </summary>
        public unsafe int CurrAPCScenarioID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// FloatProperty: TimeUntilNextAPC
        /// </summary>
        public unsafe float TimeUntilNextAPC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// FloatProperty: TimeUntilNextAPCForWheel
        /// </summary>
        public unsafe float TimeUntilNextAPCForWheel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// FloatProperty: TimeBetweenAPCsWhenSeen
        /// </summary>
        public unsafe float TimeBetweenAPCsWhenSeen
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// FloatProperty: TimeBetweenAPCsWhenSeenForWheel
        /// </summary>
        public unsafe float TimeBetweenAPCsWhenSeenForWheel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// FloatProperty: TimeBetweenAPCsWhenDestroyedForWheel
        /// </summary>
        public unsafe float TimeBetweenAPCsWhenDestroyedForWheel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }

        /// <summary>
        /// FloatProperty: TimeBetweenAPCsWhenDestroyed
        /// </summary>
        public unsafe float TimeBetweenAPCsWhenDestroyed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 76); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }; }
        }

        /// <summary>
        /// StrProperty: APC_Description
        /// </summary>
        public unsafe BmSDK.FString APC_Description
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// StrProperty: APC_ActionName
        /// </summary>
        public unsafe BmSDK.FString APC_ActionName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }

        /// <summary>
        /// ArrayProperty: APC_ModifiedByActions
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FString> APC_ModifiedByActions
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 112); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }; }
        }

        /// <summary>
        /// ObjectProperty: CurrentAPC
        /// </summary>
        public unsafe BmSDK.BmGame.RVehicle CurrentAPC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle>(Ptr + 128); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }; }
        }

        /// <summary>
        /// IntProperty: SpawnDistrict
        /// </summary>
        public unsafe int SpawnDistrict
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }; }
        }

        /// <summary>
        /// BoolProperty: bLastAPCSeen
        /// </summary>
        public unsafe bool bLastAPCSeen
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 140); }; }
        }

        /// <summary>
        /// BoolProperty: bLastAPCDestroyed
        /// </summary>
        public unsafe bool bLastAPCDestroyed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 140); }; }
        }
    }

    /// <summary>
    /// Enum: DynamicPopulation_APCSideStory_Version
    /// </summary>
    public enum DynamicPopulation_APCSideStory_Version
    {
        DynamicPopulation_APCSideStory_Initial = 0,
        DynamicPopulation_APCSideStory_WheelTimer = 1,
        DynamicPopulation_APCSideStory_MAX = 2,
    }

    /// <summary>
    /// Struct: FOverrideThreatLevelInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FOverrideThreatLevelInfo
    {
        /// <summary>
        /// ByteProperty: Version
        /// </summary>
        public unsafe byte Version
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: Description
        /// </summary>
        public unsafe BmSDK.FString Description
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: ThreatLevel
        /// </summary>
        public unsafe int ThreatLevel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Enum: OverrideThreatLevel
    /// </summary>
    public enum OverrideThreatLevel
    {
        OverrideThreatLevel_Initial = 0,
        OverrideThreatLevel_MAX = 1,
    }

    /// <summary>
    /// Struct: FSideStoryMapIconEntry
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 26)]
    public partial record struct FSideStoryMapIconEntry
    {
        /// <summary>
        /// ByteProperty: Version
        /// </summary>
        public unsafe byte Version
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: IconName
        /// </summary>
        public unsafe BmSDK.FString IconName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: SideStoryIndex
        /// </summary>
        public unsafe int SideStoryIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// ByteProperty: bAddToAutoPan
        /// </summary>
        public unsafe byte bAddToAutoPan
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ByteProperty: DiscoveryState
        /// </summary>
        public unsafe byte DiscoveryState
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 25); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 25); }; }
        }
    }

    /// <summary>
    /// Enum: SideStoryMapIcon_Data_Version
    /// </summary>
    public enum SideStoryMapIcon_Data_Version
    {
        SideStoryMapIcon_Data_Version_Initial = 0,
        SideStoryMapIcon_Data_Version_MAX = 1,
    }

    /// <summary>
    /// Struct: FMostWanted_Data
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 148)]
    public partial record struct FMostWanted_Data
    {
        /// <summary>
        /// ByteProperty: Version
        /// </summary>
        public unsafe byte Version
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: Percentage
        /// </summary>
        public unsafe byte Percentage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1); }; }
        }

        /// <summary>
        /// ByteProperty: bLocked
        /// </summary>
        public unsafe byte bLocked
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2); }; }
        }

        /// <summary>
        /// ByteProperty: bIdentityUnknown
        /// </summary>
        public unsafe byte bIdentityUnknown
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 3); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3); }; }
        }

        /// <summary>
        /// ByteProperty: NewFlag
        /// </summary>
        public unsafe byte NewFlag
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ByteProperty: CompleteAnimFlag
        /// </summary>
        public unsafe byte CompleteAnimFlag
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 5); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5); }; }
        }

        /// <summary>
        /// StrProperty: ReferenceName
        /// </summary>
        public unsafe BmSDK.FString ReferenceName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: SynopsisTextId
        /// </summary>
        public unsafe int SynopsisTextId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// IntProperty: ProgressTextId
        /// </summary>
        public unsafe int ProgressTextId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// ArrayProperty: Icons
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentData.FMostWanted_IconData> Icons
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentData.FMostWanted_IconData>>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: LastUpdateTime
        /// </summary>
        public unsafe float LastUpdateTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: LastJokerUpdateTime
        /// </summary>
        public unsafe float LastJokerUpdateTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// StrProperty: VideoProgressName
        /// </summary>
        public unsafe BmSDK.FString VideoProgressName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// StrProperty: JokerVideoProgressName
        /// </summary>
        public unsafe BmSDK.FString JokerVideoProgressName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }

        /// <summary>
        /// StrProperty: PointOfInterestProgressName
        /// </summary>
        public unsafe BmSDK.FString PointOfInterestProgressName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 88); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }; }
        }

        /// <summary>
        /// ObjectProperty: PointOfInterestProgressThought
        /// </summary>
        public unsafe BmSDK.Engine.AkDialogueSpeech PointOfInterestProgressThought
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 104); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }; }
        }

        /// <summary>
        /// ByteProperty: BoardTitleId
        /// </summary>
        public unsafe byte BoardTitleId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 112); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }; }
        }

        /// <summary>
        /// ByteProperty: BoardSynopsisId
        /// </summary>
        public unsafe byte BoardSynopsisId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 113); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 113); }; }
        }

        /// <summary>
        /// ByteProperty: BoardImageId
        /// </summary>
        public unsafe byte BoardImageId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 114); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 114); }; }
        }

        /// <summary>
        /// ByteProperty: BoardTickerId
        /// </summary>
        public unsafe byte BoardTickerId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 115); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 115); }; }
        }

        /// <summary>
        /// StrProperty: FocusTextOverride
        /// </summary>
        public unsafe BmSDK.FString FocusTextOverride
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 116); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }; }
        }

        /// <summary>
        /// ArrayProperty: CustomData
        /// </summary>
        public unsafe BmSDK.TArray<byte> CustomData
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 132); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }; }
        }
    }

    /// <summary>
    /// Enum: MostWanted_Data_Version
    /// </summary>
    public enum MostWanted_Data_Version
    {
        MostWanted_Data_Version_Initial = 0,
        MostWanted_Data_Version_LastUpdateTime = 1,
        MostWanted_Data_Version_GCPDBoard = 2,
        MostWanted_Data_Version_JokerVideoName = 3,
        MostWanted_Data_Version_PointOfInterestProgressThought = 4,
        MostWanted_Data_Version_NewFlag = 5,
        MostWanted_Data_Version_FocusText = 6,
        MostWanted_Data_Version_CustomData = 7,
        MostWanted_Data_Version_JokerLastTime = 8,
        MostWanted_Data_Version_CompleteAnimFlag = 9,
        MostWanted_Data_Version_MAX = 10,
    }

    /// <summary>
    /// Struct: FMostWanted_IconData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial record struct FMostWanted_IconData
    {
        /// <summary>
        /// ByteProperty: Version
        /// </summary>
        public unsafe byte Version
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: bNew
        /// </summary>
        public unsafe byte bNew
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1); }; }
        }

        /// <summary>
        /// ByteProperty: bActive
        /// </summary>
        public unsafe byte bActive
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2); }; }
        }

        /// <summary>
        /// ByteProperty: bDone
        /// </summary>
        public unsafe byte bDone
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 3); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3); }; }
        }

        /// <summary>
        /// FloatProperty: X
        /// </summary>
        public unsafe float X
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: Y
        /// </summary>
        public unsafe float Y
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: Z
        /// </summary>
        public unsafe float Z
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StrProperty: MapName
        /// </summary>
        public unsafe BmSDK.FString MapName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StrProperty: ReferenceName
        /// </summary>
        public unsafe BmSDK.FString ReferenceName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// StrProperty: TypeName
        /// </summary>
        public unsafe BmSDK.FString TypeName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }
    }

    /// <summary>
    /// Enum: MostWanted_IconData_Version
    /// </summary>
    public enum MostWanted_IconData_Version
    {
        MostWanted_IconData_Version_Initial = 0,
        MostWanted_IconData_Version_MAX = 1,
    }

    /// <summary>
    /// Struct: FEvidenceTrail
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public partial record struct FEvidenceTrail
    {
        /// <summary>
        /// ByteProperty: Version
        /// </summary>
        public unsafe byte Version
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: TrailName
        /// </summary>
        public unsafe BmSDK.FString TrailName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StrProperty: Map
        /// </summary>
        public unsafe BmSDK.FString Map
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// ArrayProperty: Items
        /// </summary>
        public unsafe BmSDK.TArray<System.Numerics.Vector3> Items
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }
    }

    /// <summary>
    /// Enum: TrailItems_Version
    /// </summary>
    public enum TrailItems_Version
    {
        EvidenceTrail_Version_Initial = 0,
        EvidenceTrail_Version_MAX = 1,
    }

    /// <summary>
    /// Enum: JokerSickStages
    /// </summary>
    public enum JokerSickStages
    {
        JokerSick_StageSick = 0,
        JokerSick_Stage2 = 1,
        JokerSick_Stage3 = 2,
        JokerSick_Stage4 = 3,
        JokerSick_Stage5 = 4,
        JokerSick_Stage6 = 5,
        JokerSick_StageHealthy = 6,
        JokerSick_MAX = 7,
    }

    /// <summary>
    /// Struct: FBatmobilePassengerSave
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 81)]
    public partial record struct FBatmobilePassengerSave
    {
        /// <summary>
        /// StrProperty: UI_LocalisedName
        /// </summary>
        public unsafe BmSDK.FString UI_LocalisedName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: UI_PortraitName
        /// </summary>
        public unsafe BmSDK.FString UI_PortraitName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StrProperty: PawnPathName
        /// </summary>
        public unsafe BmSDK.FString PawnPathName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// StrProperty: AnimSetPathName
        /// </summary>
        public unsafe BmSDK.FString AnimSetPathName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// StrProperty: AnimName
        /// </summary>
        public unsafe BmSDK.FString AnimName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// ByteProperty: IsVillain
        /// </summary>
        public unsafe byte IsVillain
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }
    }

    /// <summary>
    /// Struct: FTutorialInfoNew
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FTutorialInfoNew
    {
        /// <summary>
        /// ByteProperty: bPlayerActivated
        /// </summary>
        public unsafe byte bPlayerActivated
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: bAutoActivated
        /// </summary>
        public unsafe byte bAutoActivated
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1); }; }
        }

        /// <summary>
        /// ByteProperty: bDesignActivated
        /// </summary>
        public unsafe byte bDesignActivated
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2); }; }
        }

        /// <summary>
        /// IntProperty: ActionsRequired
        /// </summary>
        public unsafe int ActionsRequired
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: TotalAchieved
        /// </summary>
        public unsafe int TotalAchieved
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: Progress
        /// </summary>
        public unsafe int Progress
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FTutorialInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FTutorialInfo
    {
        /// <summary>
        /// ByteProperty: bPlayerActivated
        /// </summary>
        public unsafe byte bPlayerActivated
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: bAutoActivated
        /// </summary>
        public unsafe byte bAutoActivated
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1); }; }
        }

        /// <summary>
        /// IntProperty: ActionsRequired
        /// </summary>
        public unsafe int ActionsRequired
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: TotalAchieved
        /// </summary>
        public unsafe int TotalAchieved
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: Progress
        /// </summary>
        public unsafe int Progress
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Enum: ETutorialType
    /// </summary>
    public enum ETutorialType
    {
        TUT_None = 0,
        TUT_Combat_Strike = 1,
        TUT_Combat_Counter = 2,
        TUT_Combat_BladeComboCounter = 3,
        TUT_Combat_SuperBladeComboCounter = 4,
        TUT_Combat_Beatdown = 5,
        TUT_Combat_AerialAttack = 6,
        TUT_Combat_DirectedAerialAttack = 7,
        TUT_Combat_Rhythm = 8,
        TUT_Combat_Takedown = 9,
        TUT_Combat_DisarmAndDestroy = 10,
        TUT_Combat_GroupStun = 11,
        TUT_Combat_GroupGroundKO = 12,
        TUT_Combat_GroupTrip = 13,
        TUT_Combat_GroupAttack = 14,
        TUT_Combat_SuperStun = 15,
        TUT_Combat_ComboGroundKO = 16,
        TUT_Combat_BatclawSlam = 17,
        TUT_Thug_Knife = 18,
        TUT_Thug_StunStick = 19,
        TUT_Thug_Armoured = 20,
        TUT_Thug_Shield = 21,
        TUT_Thug_Titan = 22,
        TUT_Combat_GroundTakedown = 23,
        TUT_Predator_GroundTakedown = 24,
        TUT_Lunatic_GroundTakedown = 25,
        TUT_ChargingThug = 26,
        TUT_Batmobile_DodgeBoost = 27,
        TUT_Batmobile_ShootMissiles = 28,
        TUT_Batmobile_CallBatmobile = 29,
        TUT_Combat_WeaponGrab = 30,
        TUT_Batmobile_FireMissileLauncher = 31,
        TUT_Batmobile_FireEMP = 32,
        TUT_Batmobile_FireEMPLv2 = 33,
        TUT_Batmobile_FireDroneHacker = 34,
        TUT_Batmobile_FireDroneHackerLv2 = 35,
        TUT_Batmobile_FireDroneHackerLv3 = 36,
        TUT_Thug_MultiStage = 37,
        TUT_Batmobile_FireMissileLauncherLv1 = 38,
        TUT_MedicBuff = 39,
        TUT_Combat_FloorPickup = 40,
        TUT_Combat_QuickREC = 41,
        TUT_Combat_QuickFreeze = 42,
        TUT_Combat_QuickGel = 43,
        TUT_Batmobile_FireMissileLauncherLv3 = 44,
        TUT_Batmobile_FireMissileLauncherLv4 = 45,
        TUT_Glide_GlideAim = 46,
        TUT_Glide_LineLaunchStop = 47,
        TUT_Combat_EnvObjectKO = 48,
        TUT_Combat_SuperComboBatarang = 49,
        TUT_Combat_SuperComboBatclaw = 50,
        TUT_Combat_SuperComboREC = 51,
        TUT_Combat_SuperComboGel = 52,
        TUT_Combat_SuperComboFreeze = 53,
        TUT_Batmobile_SuperEject = 54,
        TUT_Batmobile_DoubleDodge = 55,
        TUT_Upgrade_BatarangWhileGliding = 56,
        TUT_Upgrade_BatclawWhileGliding = 57,
        TUT_Upgrade_ExplosiveGelWhileGliding = 58,
        TUT_Upgrade_FreezeBlastWhileGliding = 59,
        TUT_Upgrade_RECWhileGliding = 60,
        TUT_Combat_ThugGrab = 61,
        TUT_Batmobile_BattleModeZoom = 62,
        TUT_Combat_Evade = 63,
        TUT_Batmobile_AirControl = 64,
        TUT_PursuitModeSideSwipe = 65,
        TUT_MAX = 66,
    }

    /// <summary>
    /// Struct: FBatmobileDriveTutorialSection
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FBatmobileDriveTutorialSection
    {
        /// <summary>
        /// ByteProperty: bActive
        /// </summary>
        public unsafe byte bActive
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Timer
        /// </summary>
        public unsafe float Timer
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: TimeOut
        /// </summary>
        public unsafe float TimeOut
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Enum: EBatmobileDriveTutorialStage
    /// </summary>
    public enum EBatmobileDriveTutorialStage
    {
        EBDTS_None = 0,
        EBDTS_Accelerate = 1,
        EBDTS_Brake = 2,
        EBDTS_TurnOnSpot = 3,
        EBDTS_Drift = 4,
        EBDTS_Boost = 5,
        EBDTS_Eject = 6,
        EBDTS_Donut = 7,
        EBDTS_DriftRechargesBoost = 8,
        EBDTS_ChainGun = 9,
        EBDTS_HeavyCannon = 10,
        EBDTS_BattleModeMove = 11,
        EBDTS_ToggleDrivingCamera = 12,
        EBDTS_MAX = 13,
    }

    /// <summary>
    /// IntProperty: Version
    /// </summary>
    public unsafe int Version
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// IntProperty: SaveCount
    /// </summary>
    public unsafe int SaveCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// StructProperty: PlayerLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 PlayerLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// StructProperty: PlayerRotation
    /// </summary>
    public unsafe BmSDK.Rotator PlayerRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// ByteProperty: StartInBatmobile
    /// </summary>
    public unsafe byte StartInBatmobile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ByteProperty: StartBatmobileFakeRemoteDrive
    /// </summary>
    public unsafe byte StartBatmobileFakeRemoteDrive
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 117); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 117); }
    }

    /// <summary>
    /// ByteProperty: ForceDontStartInBatmobile
    /// </summary>
    public unsafe byte ForceDontStartInBatmobile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 118); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 118); }
    }

    /// <summary>
    /// ByteProperty: ForceStartInBatmobile
    /// </summary>
    public unsafe byte ForceStartInBatmobile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 119); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 119); }
    }

    /// <summary>
    /// ByteProperty: ForceStartBatmobileFakeRemoteDrive
    /// </summary>
    public unsafe byte ForceStartBatmobileFakeRemoteDrive
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// ByteProperty: IsSaveGameStartPoint
    /// </summary>
    public unsafe byte IsSaveGameStartPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 121); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 121); }
    }

    /// <summary>
    /// ByteProperty: InstallChunkRequired
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EInstallChunk InstallChunkRequired
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EInstallChunk>(Ptr + 122); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 122); }
    }

    /// <summary>
    /// ByteProperty: SideStoriesDisabledStreaming
    /// </summary>
    public unsafe byte SideStoriesDisabledStreaming
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 123); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 123); }
    }

    /// <summary>
    /// ByteProperty: SideStoriesDisabled
    /// </summary>
    public unsafe byte SideStoriesDisabled
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ByteProperty: DisableAutoSaves
    /// </summary>
    public unsafe byte DisableAutoSaves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 125); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 125); }
    }

    /// <summary>
    /// ByteProperty: DetectiveModeJammed
    /// </summary>
    public unsafe byte DetectiveModeJammed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 126); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 126); }
    }

    /// <summary>
    /// ByteProperty: ARTraining_RaceWins
    /// </summary>
    public unsafe byte ARTraining_RaceWins
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 127); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 127); }
    }

    /// <summary>
    /// ByteProperty: FullyDisablePlayerMapSelection
    /// </summary>
    public unsafe byte FullyDisablePlayerMapSelection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// ByteProperty: VideoRecordStatus
    /// </summary>
    public unsafe byte VideoRecordStatus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 129); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 129); }
    }

    /// <summary>
    /// ByteProperty: BruceWayneLegChainsBroken
    /// </summary>
    public unsafe byte BruceWayneLegChainsBroken
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 130); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 130); }
    }

    /// <summary>
    /// ByteProperty: GlideTutorialStageGlide
    /// </summary>
    public unsafe byte GlideTutorialStageGlide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 131); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 131); }
    }

    /// <summary>
    /// ByteProperty: GlideTutorialStageSteer
    /// </summary>
    public unsafe byte GlideTutorialStageSteer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ByteProperty: GlideTutorialStageDive
    /// </summary>
    public unsafe byte GlideTutorialStageDive
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 133); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 133); }
    }

    /// <summary>
    /// ByteProperty: HelpPrompt_GlideTutorialStage
    /// </summary>
    public unsafe byte HelpPrompt_GlideTutorialStage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 134); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 134); }
    }

    /// <summary>
    /// ByteProperty: AutoToggleMostWantedActive
    /// </summary>
    public unsafe byte AutoToggleMostWantedActive
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 135); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 135); }
    }

    /// <summary>
    /// ByteProperty: CurrentChapter
    /// </summary>
    public unsafe byte CurrentChapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// ByteProperty: CurrentSubChapter
    /// </summary>
    public unsafe byte CurrentSubChapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 137); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 137); }
    }

    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 138); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 138); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 139); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 139); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 141); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 141); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 142); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 142); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 143); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 143); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 145); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 145); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 146); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 146); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 147); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 147); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 149); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 149); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 150); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 150); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 151); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 151); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 153); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 153); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 154); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 154); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 155); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 155); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 157); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 157); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 158); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 158); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 159); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 159); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 161); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 161); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 162); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 162); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 163); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 163); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 165); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 165); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 166); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 166); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 167); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 167); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 169); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 169); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_32
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 170); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 170); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_33
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 171); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 171); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_34
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_35
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 173); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 173); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_36
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 174); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 174); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_37
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 175); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 175); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_38
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_39
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 177); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 177); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_40
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 178); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 178); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_41
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 179); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 179); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_42
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_43
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 181); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 181); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_44
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 182); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 182); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_45
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 183); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 183); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_46
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_47
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 185); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 185); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_48
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 186); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 186); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_49
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 187); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 187); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_50
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideChapter
    /// </summary>
    public unsafe byte CurrentSideChapter_51
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 189); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 189); }
    }

    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 190); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 190); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 191); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 191); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 193); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 193); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 194); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 194); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 195); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 195); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 197); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 197); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 198); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 198); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 199); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 199); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 201); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 201); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 202); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 202); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 203); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 203); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 205); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 205); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 206); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 206); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 207); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 207); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 209); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 209); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 210); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 210); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 211); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 211); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 213); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 213); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 214); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 214); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 215); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 215); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 217); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 217); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 218); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 218); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 219); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 219); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 221); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 221); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_32
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 222); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 222); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_33
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 223); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 223); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_34
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_35
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 225); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 225); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_36
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 226); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 226); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_37
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 227); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 227); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_38
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_39
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 229); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 229); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_40
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 230); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 230); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_41
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 231); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 231); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_42
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_43
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 233); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 233); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_44
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 234); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 234); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_45
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 235); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 235); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_46
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_47
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 237); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 237); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_48
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 238); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 238); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_49
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 239); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 239); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_50
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }
    /// <summary>
    /// ByteProperty: CurrentSideSubChapter
    /// </summary>
    public unsafe byte CurrentSideSubChapter_51
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 241); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 241); }
    }

    /// <summary>
    /// ByteProperty: CurrentChallengeMode
    /// </summary>
    public unsafe byte CurrentChallengeMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 242); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 242); }
    }

    /// <summary>
    /// ByteProperty: CurrentChallengeSubChapter
    /// </summary>
    public unsafe byte CurrentChallengeSubChapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 243); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 243); }
    }

    /// <summary>
    /// ByteProperty: PrepareChapter
    /// </summary>
    public unsafe byte PrepareChapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// ByteProperty: PrepareSubChapter
    /// </summary>
    public unsafe byte PrepareSubChapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 245); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 245); }
    }

    /// <summary>
    /// ByteProperty: PrepareSideChapter
    /// </summary>
    public unsafe byte PrepareSideChapter_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 246); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 246); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideChapter
    /// </summary>
    public unsafe byte PrepareSideChapter_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 247); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 247); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideChapter
    /// </summary>
    public unsafe byte PrepareSideChapter_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideChapter
    /// </summary>
    public unsafe byte PrepareSideChapter_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 249); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 249); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideChapter
    /// </summary>
    public unsafe byte PrepareSideChapter_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 250); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 250); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideChapter
    /// </summary>
    public unsafe byte PrepareSideChapter_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 251); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 251); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideChapter
    /// </summary>
    public unsafe byte PrepareSideChapter_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideChapter
    /// </summary>
    public unsafe byte PrepareSideChapter_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 253); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 253); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideChapter
    /// </summary>
    public unsafe byte PrepareSideChapter_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 254); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 254); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideChapter
    /// </summary>
    public unsafe byte PrepareSideChapter_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 255); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 255); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideChapter
    /// </summary>
    public unsafe byte PrepareSideChapter_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideChapter
    /// </summary>
    public unsafe byte PrepareSideChapter_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 257); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 257); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideChapter
    /// </summary>
    public unsafe byte PrepareSideChapter_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 258); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 258); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideChapter
    /// </summary>
    public unsafe byte PrepareSideChapter_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 259); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 259); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideChapter
    /// </summary>
    public unsafe byte PrepareSideChapter_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideChapter
    /// </summary>
    public unsafe byte PrepareSideChapter_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 261); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 261); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideChapter
    /// </summary>
    public unsafe byte PrepareSideChapter_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 262); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 262); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideChapter
    /// </summary>
    public unsafe byte PrepareSideChapter_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 263); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 263); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideChapter
    /// </summary>
    public unsafe byte PrepareSideChapter_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideChapter
    /// </summary>
    public unsafe byte PrepareSideChapter_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 265); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 265); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideChapter
    /// </summary>
    public unsafe byte PrepareSideChapter_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 266); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 266); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideChapter
    /// </summary>
    public unsafe byte PrepareSideChapter_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 267); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 267); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideChapter
    /// </summary>
    public unsafe byte PrepareSideChapter_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideChapter
    /// </summary>
    public unsafe byte PrepareSideChapter_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 269); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 269); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideChapter
    /// </summary>
    public unsafe byte PrepareSideChapter_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 270); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 270); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideChapter
    /// </summary>
    public unsafe byte PrepareSideChapter_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 271); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 271); }
    }

    /// <summary>
    /// ByteProperty: PrepareSideSubChapter
    /// </summary>
    public unsafe byte PrepareSideSubChapter_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideSubChapter
    /// </summary>
    public unsafe byte PrepareSideSubChapter_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 273); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 273); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideSubChapter
    /// </summary>
    public unsafe byte PrepareSideSubChapter_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 274); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 274); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideSubChapter
    /// </summary>
    public unsafe byte PrepareSideSubChapter_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 275); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 275); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideSubChapter
    /// </summary>
    public unsafe byte PrepareSideSubChapter_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideSubChapter
    /// </summary>
    public unsafe byte PrepareSideSubChapter_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 277); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 277); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideSubChapter
    /// </summary>
    public unsafe byte PrepareSideSubChapter_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 278); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 278); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideSubChapter
    /// </summary>
    public unsafe byte PrepareSideSubChapter_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 279); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 279); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideSubChapter
    /// </summary>
    public unsafe byte PrepareSideSubChapter_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideSubChapter
    /// </summary>
    public unsafe byte PrepareSideSubChapter_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 281); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 281); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideSubChapter
    /// </summary>
    public unsafe byte PrepareSideSubChapter_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 282); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 282); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideSubChapter
    /// </summary>
    public unsafe byte PrepareSideSubChapter_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 283); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 283); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideSubChapter
    /// </summary>
    public unsafe byte PrepareSideSubChapter_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideSubChapter
    /// </summary>
    public unsafe byte PrepareSideSubChapter_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 285); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 285); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideSubChapter
    /// </summary>
    public unsafe byte PrepareSideSubChapter_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 286); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 286); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideSubChapter
    /// </summary>
    public unsafe byte PrepareSideSubChapter_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 287); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 287); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideSubChapter
    /// </summary>
    public unsafe byte PrepareSideSubChapter_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideSubChapter
    /// </summary>
    public unsafe byte PrepareSideSubChapter_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 289); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 289); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideSubChapter
    /// </summary>
    public unsafe byte PrepareSideSubChapter_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 290); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 290); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideSubChapter
    /// </summary>
    public unsafe byte PrepareSideSubChapter_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 291); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 291); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideSubChapter
    /// </summary>
    public unsafe byte PrepareSideSubChapter_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideSubChapter
    /// </summary>
    public unsafe byte PrepareSideSubChapter_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 293); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 293); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideSubChapter
    /// </summary>
    public unsafe byte PrepareSideSubChapter_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 294); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 294); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideSubChapter
    /// </summary>
    public unsafe byte PrepareSideSubChapter_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 295); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 295); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideSubChapter
    /// </summary>
    public unsafe byte PrepareSideSubChapter_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }
    /// <summary>
    /// ByteProperty: PrepareSideSubChapter
    /// </summary>
    public unsafe byte PrepareSideSubChapter_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 297); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 297); }
    }

    /// <summary>
    /// ByteProperty: PrepareChallengeMode
    /// </summary>
    public unsafe byte PrepareChallengeMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 298); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 298); }
    }

    /// <summary>
    /// ByteProperty: PrepareChallengeSubChapter
    /// </summary>
    public unsafe byte PrepareChallengeSubChapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 299); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 299); }
    }

    /// <summary>
    /// ByteProperty: Bio_LocIndex
    /// </summary>
    public unsafe byte Bio_LocIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// ByteProperty: Bio_PageIndex
    /// </summary>
    public unsafe byte Bio_PageIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 301); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 301); }
    }

    /// <summary>
    /// ByteProperty: Bio_TapeIndex
    /// </summary>
    public unsafe byte Bio_TapeIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 302); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 302); }
    }

    /// <summary>
    /// ByteProperty: Upgrade_CategoryIndex
    /// </summary>
    public unsafe byte Upgrade_CategoryIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 303); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 303); }
    }

    /// <summary>
    /// ByteProperty: Upgrade_ItemIndex
    /// </summary>
    public unsafe byte Upgrade_ItemIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// ByteProperty: Riddler_LocIndex
    /// </summary>
    public unsafe byte Riddler_LocIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 305); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 305); }
    }

    /// <summary>
    /// ByteProperty: Riddler_IndexX
    /// </summary>
    public unsafe byte Riddler_IndexX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 306); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 306); }
    }

    /// <summary>
    /// ByteProperty: Riddler_IndexY
    /// </summary>
    public unsafe byte Riddler_IndexY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 307); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 307); }
    }

    /// <summary>
    /// ByteProperty: Enygma_IndexLeft
    /// </summary>
    public unsafe byte Enygma_IndexLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// ByteProperty: Enygma_IndexRight
    /// </summary>
    public unsafe byte Enygma_IndexRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 309); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 309); }
    }

    /// <summary>
    /// ByteProperty: ChallengeUnlockIndex
    /// </summary>
    public unsafe byte ChallengeUnlockIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 310); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 310); }
    }

    /// <summary>
    /// ByteProperty: bObjectiveTrackerActive
    /// </summary>
    public unsafe byte bObjectiveTrackerActive
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 311); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 311); }
    }

    /// <summary>
    /// ByteProperty: CustomWaypoint_Type
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.ECustomWayPointType CustomWaypoint_Type
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.ECustomWayPointType>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// ByteProperty: CustomWaypoint_NotReached
    /// </summary>
    public unsafe byte CustomWaypoint_NotReached
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 313); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 313); }
    }

    /// <summary>
    /// ByteProperty: CustomWaypoint_SilentWhenReached
    /// </summary>
    public unsafe byte CustomWaypoint_SilentWhenReached
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 314); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 314); }
    }

    /// <summary>
    /// ByteProperty: CheckForRiddlerUnlocks
    /// </summary>
    public unsafe byte CheckForRiddlerUnlocks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 315); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 315); }
    }

    /// <summary>
    /// ByteProperty: ExplainedBatarangRules
    /// </summary>
    public unsafe byte ExplainedBatarangRules
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// ByteProperty: bPlayedFreezeBlastHint
    /// </summary>
    public unsafe byte bPlayedFreezeBlastHint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 317); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 317); }
    }

    /// <summary>
    /// ByteProperty: GrundyQuickGelHappened
    /// </summary>
    public unsafe byte GrundyQuickGelHappened
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 318); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 318); }
    }

    /// <summary>
    /// ByteProperty: GrundyQuickDetonateHappened
    /// </summary>
    public unsafe byte GrundyQuickDetonateHappened
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 319); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 319); }
    }

    /// <summary>
    /// ByteProperty: BatmobileWinchState
    /// </summary>
    public unsafe byte BatmobileWinchState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// ByteProperty: AirshipTutorialStage
    /// </summary>
    public unsafe byte AirshipTutorialStage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 321); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 321); }
    }

    /// <summary>
    /// ByteProperty: JokerSickState
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.JokerSickStages JokerSickState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.JokerSickStages>(Ptr + 322); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 322); }
    }

    /// <summary>
    /// ByteProperty: ApcIntelAvailable
    /// </summary>
    public unsafe byte ApcIntelAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 323); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 323); }
    }

    /// <summary>
    /// ByteProperty: DesignerLowUrgencyModeActive
    /// </summary>
    public unsafe byte DesignerLowUrgencyModeActive
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// ByteProperty: ChapterNineRecurringIntel
    /// </summary>
    public unsafe byte ChapterNineRecurringIntel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 325); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 325); }
    }

    /// <summary>
    /// ByteProperty: PlayedMissileBarrage1stTimeBark
    /// </summary>
    public unsafe byte PlayedMissileBarrage1stTimeBark
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 326); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 326); }
    }

    /// <summary>
    /// ByteProperty: PlayedEMPBurst1stTimeBark
    /// </summary>
    public unsafe byte PlayedEMPBurst1stTimeBark
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 327); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 327); }
    }

    /// <summary>
    /// ByteProperty: PlayedDroneHacker1stTimeBark
    /// </summary>
    public unsafe byte PlayedDroneHacker1stTimeBark
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// ByteProperty: bAKAnnouncedMedicLinePlayed
    /// </summary>
    public unsafe byte bAKAnnouncedMedicLinePlayed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 329); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 329); }
    }

    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 330); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 330); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 331); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 331); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 333); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 333); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 334); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 334); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 335); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 335); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 337); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 337); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 338); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 338); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 339); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 339); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 341); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 341); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 342); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 342); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 343); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 343); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }
    }

    /// <summary>
    /// ByteProperty: bPlayerHasFinishedExtraMinidroneTutorial
    /// </summary>
    public unsafe byte bPlayerHasFinishedExtraMinidroneTutorial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 345); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 345); }
    }

    /// <summary>
    /// StructProperty: LastDoorData
    /// </summary>
    public unsafe System.Numerics.Vector3 LastDoorData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// IntProperty: LastDoorRotation
    /// </summary>
    public unsafe int LastDoorRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// StrProperty: LastDoorRoom
    /// </summary>
    public unsafe BmSDK.FString LastDoorRoom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// ArrayProperty: SeekFreePackagesToLoad
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> SeekFreePackagesToLoad
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// StrProperty: CurrentLevel
    /// </summary>
    public unsafe BmSDK.FString CurrentLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// ArrayProperty: PreloadStreamingLevels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> PreloadStreamingLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// ArrayProperty: PreloadStreamingLevelsLODs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> PreloadStreamingLevelsLODs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// ArrayProperty: FlagNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> FlagNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// ArrayProperty: FlagValues
    /// </summary>
    public unsafe BmSDK.TArray<int> FlagValues
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// IntProperty: StoryDLCImageId
    /// </summary>
    public unsafe int StoryDLCImageId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }

    /// <summary>
    /// IntProperty: SaveGameChapter
    /// </summary>
    public unsafe int SaveGameChapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// IntProperty: SaveGameIndex
    /// </summary>
    public unsafe int SaveGameIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// StrProperty: Description
    /// </summary>
    public unsafe BmSDK.FString Description
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// ArrayProperty: StorySynopsis
    /// </summary>
    public unsafe BmSDK.TArray<int> StorySynopsis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// StrProperty: SideStoriesDisabledBy
    /// </summary>
    public unsafe BmSDK.FString SideStoriesDisabledBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// StrProperty: SideStoriesDisabledReasonConv
    /// </summary>
    public unsafe BmSDK.FString SideStoriesDisabledReasonConv
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// StrProperty: SideObjective
    /// </summary>
    public unsafe BmSDK.FString SideObjective
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// StrProperty: PrimaryObjective
    /// </summary>
    public unsafe BmSDK.FString PrimaryObjective
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// ArrayProperty: ObjectivesIncomplete
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ObjectivesIncomplete
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// ArrayProperty: ObjectivesMapObj
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ObjectivesMapObj
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// ArrayProperty: ObjectivesNewMapObj
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ObjectivesNewMapObj
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// ArrayProperty: MapAutopanList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> MapAutopanList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// ArrayProperty: ObjectivesLowUrgency
    /// </summary>
    public unsafe BmSDK.TArray<byte> ObjectivesLowUrgency
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// IntProperty: ShowRiddlerFlag
    /// </summary>
    public unsafe int ShowRiddlerFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// IntProperty: ShowBioFlag
    /// </summary>
    public unsafe int ShowBioFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// NameProperty: CurrentGadgetName
    /// </summary>
    public unsafe BmSDK.FName CurrentGadgetName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// StrProperty: LastScannedLocMap
    /// </summary>
    public unsafe BmSDK.FString LastScannedLocMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// StructProperty: LastScannedLoc
    /// </summary>
    public unsafe System.Numerics.Vector3 LastScannedLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// StrProperty: LastAmbientSoundCue
    /// </summary>
    public unsafe BmSDK.FString LastAmbientSoundCue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// StrProperty: LastRoomMixBin
    /// </summary>
    public unsafe BmSDK.FString LastRoomMixBin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// IntProperty: PlayerHealth
    /// </summary>
    public unsafe int PlayerHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// IntProperty: BallisticArmour
    /// </summary>
    public unsafe int BallisticArmour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// IntProperty: MeleeArmour
    /// </summary>
    public unsafe int MeleeArmour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// IntProperty: CWBallisticArmour
    /// </summary>
    public unsafe int CWBallisticArmour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// IntProperty: CWMeleeArmour
    /// </summary>
    public unsafe int CWMeleeArmour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// IntProperty: BatmobileHealth
    /// </summary>
    public unsafe int BatmobileHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// FloatProperty: BatmobileEnergy
    /// </summary>
    public unsafe float BatmobileEnergy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// FloatProperty: ButtonBashDDA
    /// </summary>
    public unsafe float ButtonBashDDA
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_Strike
    /// </summary>
    public unsafe int HelpPromptCount_Strike
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_Counter
    /// </summary>
    public unsafe int HelpPromptCount_Counter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_Throw
    /// </summary>
    public unsafe int HelpPromptCount_Throw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_Takedown
    /// </summary>
    public unsafe int HelpPromptCount_Takedown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_GroundTakedown
    /// </summary>
    public unsafe int HelpPromptCount_GroundTakedown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_LunaticGroundTakedown
    /// </summary>
    public unsafe int HelpPromptCount_LunaticGroundTakedown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_PredatorGroundTakedown
    /// </summary>
    public unsafe int HelpPromptCount_PredatorGroundTakedown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_ComboBatarang
    /// </summary>
    public unsafe int HelpPromptCount_ComboBatarang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_LineLauncherDrop
    /// </summary>
    public unsafe int HelpPromptCount_LineLauncherDrop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_HangModeDrop
    /// </summary>
    public unsafe int HelpPromptCount_HangModeDrop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_DropOffGrapple
    /// </summary>
    public unsafe int HelpPromptCount_DropOffGrapple
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_GlideOffWall
    /// </summary>
    public unsafe int HelpPromptCount_GlideOffWall
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_SixaxisGlide
    /// </summary>
    public unsafe int HelpPromptCount_SixaxisGlide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_SixaxisBatarang
    /// </summary>
    public unsafe int HelpPromptCount_SixaxisBatarang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_SixaxisTeeth
    /// </summary>
    public unsafe int HelpPromptCount_SixaxisTeeth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// FloatProperty: HelpPrompt_TimeGliding
    /// </summary>
    public unsafe float HelpPrompt_TimeGliding
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_GlideSteerLR
    /// </summary>
    public unsafe int HelpPromptCount_GlideSteerLR
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_GlideSteerUD
    /// </summary>
    public unsafe int HelpPromptCount_GlideSteerUD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_PullUpFromDive
    /// </summary>
    public unsafe int HelpPromptCount_PullUpFromDive
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_Dive
    /// </summary>
    public unsafe int HelpPromptCount_Dive
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_GrappleInOW
    /// </summary>
    public unsafe int HelpPromptCount_GrappleInOW
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_SlideUnderBarrier
    /// </summary>
    public unsafe int HelpPromptCount_SlideUnderBarrier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_GrappleBoost
    /// </summary>
    public unsafe int HelpPromptCount_GrappleBoost
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// IntProperty: HelpPromptCount_RaftCancel
    /// </summary>
    public unsafe int HelpPromptCount_RaftCancel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// FloatProperty: HelpPromptTimer_SteathMove
    /// </summary>
    public unsafe float HelpPromptTimer_SteathMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// StructProperty: HelpPrompt_BatmobileDriveTutorial
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.FBatmobileDriveTutorialSection HelpPrompt_BatmobileDriveTutorial_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.FBatmobileDriveTutorialSection>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }
    /// <summary>
    /// StructProperty: HelpPrompt_BatmobileDriveTutorial
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.FBatmobileDriveTutorialSection HelpPrompt_BatmobileDriveTutorial_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.FBatmobileDriveTutorialSection>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }
    /// <summary>
    /// StructProperty: HelpPrompt_BatmobileDriveTutorial
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.FBatmobileDriveTutorialSection HelpPrompt_BatmobileDriveTutorial_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.FBatmobileDriveTutorialSection>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }
    /// <summary>
    /// StructProperty: HelpPrompt_BatmobileDriveTutorial
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.FBatmobileDriveTutorialSection HelpPrompt_BatmobileDriveTutorial_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.FBatmobileDriveTutorialSection>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }
    /// <summary>
    /// StructProperty: HelpPrompt_BatmobileDriveTutorial
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.FBatmobileDriveTutorialSection HelpPrompt_BatmobileDriveTutorial_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.FBatmobileDriveTutorialSection>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }
    /// <summary>
    /// StructProperty: HelpPrompt_BatmobileDriveTutorial
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.FBatmobileDriveTutorialSection HelpPrompt_BatmobileDriveTutorial_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.FBatmobileDriveTutorialSection>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }
    /// <summary>
    /// StructProperty: HelpPrompt_BatmobileDriveTutorial
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.FBatmobileDriveTutorialSection HelpPrompt_BatmobileDriveTutorial_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.FBatmobileDriveTutorialSection>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }
    /// <summary>
    /// StructProperty: HelpPrompt_BatmobileDriveTutorial
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.FBatmobileDriveTutorialSection HelpPrompt_BatmobileDriveTutorial_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.FBatmobileDriveTutorialSection>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }
    /// <summary>
    /// StructProperty: HelpPrompt_BatmobileDriveTutorial
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.FBatmobileDriveTutorialSection HelpPrompt_BatmobileDriveTutorial_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.FBatmobileDriveTutorialSection>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }
    /// <summary>
    /// StructProperty: HelpPrompt_BatmobileDriveTutorial
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.FBatmobileDriveTutorialSection HelpPrompt_BatmobileDriveTutorial_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.FBatmobileDriveTutorialSection>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }
    /// <summary>
    /// StructProperty: HelpPrompt_BatmobileDriveTutorial
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.FBatmobileDriveTutorialSection HelpPrompt_BatmobileDriveTutorial_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.FBatmobileDriveTutorialSection>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }
    /// <summary>
    /// StructProperty: HelpPrompt_BatmobileDriveTutorial
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.FBatmobileDriveTutorialSection HelpPrompt_BatmobileDriveTutorial_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.FBatmobileDriveTutorialSection>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }
    /// <summary>
    /// StructProperty: HelpPrompt_BatmobileDriveTutorial
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.FBatmobileDriveTutorialSection HelpPrompt_BatmobileDriveTutorial_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.FBatmobileDriveTutorialSection>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// StrProperty: BatmobileTutorialFlagToSetWhenComplete
    /// </summary>
    public unsafe BmSDK.FString BatmobileTutorialFlagToSetWhenComplete_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }
    /// <summary>
    /// StrProperty: BatmobileTutorialFlagToSetWhenComplete
    /// </summary>
    public unsafe BmSDK.FString BatmobileTutorialFlagToSetWhenComplete_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }
    /// <summary>
    /// StrProperty: BatmobileTutorialFlagToSetWhenComplete
    /// </summary>
    public unsafe BmSDK.FString BatmobileTutorialFlagToSetWhenComplete_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }
    /// <summary>
    /// StrProperty: BatmobileTutorialFlagToSetWhenComplete
    /// </summary>
    public unsafe BmSDK.FString BatmobileTutorialFlagToSetWhenComplete_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }
    /// <summary>
    /// StrProperty: BatmobileTutorialFlagToSetWhenComplete
    /// </summary>
    public unsafe BmSDK.FString BatmobileTutorialFlagToSetWhenComplete_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }
    /// <summary>
    /// StrProperty: BatmobileTutorialFlagToSetWhenComplete
    /// </summary>
    public unsafe BmSDK.FString BatmobileTutorialFlagToSetWhenComplete_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }
    /// <summary>
    /// StrProperty: BatmobileTutorialFlagToSetWhenComplete
    /// </summary>
    public unsafe BmSDK.FString BatmobileTutorialFlagToSetWhenComplete_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }
    /// <summary>
    /// StrProperty: BatmobileTutorialFlagToSetWhenComplete
    /// </summary>
    public unsafe BmSDK.FString BatmobileTutorialFlagToSetWhenComplete_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }
    /// <summary>
    /// StrProperty: BatmobileTutorialFlagToSetWhenComplete
    /// </summary>
    public unsafe BmSDK.FString BatmobileTutorialFlagToSetWhenComplete_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }
    /// <summary>
    /// StrProperty: BatmobileTutorialFlagToSetWhenComplete
    /// </summary>
    public unsafe BmSDK.FString BatmobileTutorialFlagToSetWhenComplete_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1172); }
    }
    /// <summary>
    /// StrProperty: BatmobileTutorialFlagToSetWhenComplete
    /// </summary>
    public unsafe BmSDK.FString BatmobileTutorialFlagToSetWhenComplete_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }
    /// <summary>
    /// StrProperty: BatmobileTutorialFlagToSetWhenComplete
    /// </summary>
    public unsafe BmSDK.FString BatmobileTutorialFlagToSetWhenComplete_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1204); }
    }
    /// <summary>
    /// StrProperty: BatmobileTutorialFlagToSetWhenComplete
    /// </summary>
    public unsafe BmSDK.FString BatmobileTutorialFlagToSetWhenComplete_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1220); }
    }

    /// <summary>
    /// IntProperty: NumTimesEscapeHelpDisplayed
    /// </summary>
    public unsafe int NumTimesEscapeHelpDisplayed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1236); }
    }

    /// <summary>
    /// IntProperty: NumTimesIncendiaryGrenadeHelpDisplayed
    /// </summary>
    public unsafe int NumTimesIncendiaryGrenadeHelpDisplayed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }

    /// <summary>
    /// IntProperty: NumTimesGrateHelpDisplayed
    /// </summary>
    public unsafe int NumTimesGrateHelpDisplayed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1244); }
    }

    /// <summary>
    /// IntProperty: NumTimesGroundTakedownHelpDisplayed
    /// </summary>
    public unsafe int NumTimesGroundTakedownHelpDisplayed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// IntProperty: NumTimesFearTakedownRechargeHelpDisplayed
    /// </summary>
    public unsafe int NumTimesFearTakedownRechargeHelpDisplayed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }

    /// <summary>
    /// FloatProperty: TotalTimePlayed
    /// </summary>
    public unsafe float TotalTimePlayed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// IntProperty: StoryPercentage
    /// </summary>
    public unsafe int StoryPercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1260); }
    }

    /// <summary>
    /// IntProperty: UpgradesIndex
    /// </summary>
    public unsafe int UpgradesIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// IntProperty: MidKnightFall
    /// </summary>
    public unsafe int MidKnightFall
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }

    /// <summary>
    /// IntProperty: BillboardChatterCount
    /// </summary>
    public unsafe int BillboardChatterCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }

    /// <summary>
    /// StrProperty: StoryDialogueLocDirectRef
    /// </summary>
    public unsafe BmSDK.FString StoryDialogueLocDirectRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1276); }
    }

    /// <summary>
    /// IntProperty: PygSearchDialogueIndex
    /// </summary>
    public unsafe int PygSearchDialogueIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1292); }
    }

    /// <summary>
    /// IntProperty: PenguinSuspendDialogueIndex
    /// </summary>
    public unsafe int PenguinSuspendDialogueIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }
    }

    /// <summary>
    /// ArrayProperty: InterrogationIndexes
    /// </summary>
    public unsafe BmSDK.TArray<int> InterrogationIndexes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// IntProperty: RiddlerInterrogationTrackIndex
    /// </summary>
    public unsafe int RiddlerInterrogationTrackIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1316); }
    }

    /// <summary>
    /// IntProperty: RiddlerInterrogationTotal
    /// </summary>
    public unsafe int RiddlerInterrogationTotal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }

    /// <summary>
    /// IntProperty: RiddlerInterrogationFightbackTrackIndex
    /// </summary>
    public unsafe int RiddlerInterrogationFightbackTrackIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }

    /// <summary>
    /// ArrayProperty: NumInterrogationPerDistrict
    /// </summary>
    public unsafe BmSDK.TArray<int> NumInterrogationPerDistrict
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }
    }

    /// <summary>
    /// ArrayProperty: NumInterrogationPerDistrictCh9
    /// </summary>
    public unsafe BmSDK.TArray<int> NumInterrogationPerDistrictCh9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// BoolProperty: bForceNextRiddlerToBeFightback
    /// </summary>
    public unsafe bool bForceNextRiddlerToBeFightback
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1360) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1360); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1360); }
    }

    /// <summary>
    /// BoolProperty: bChapterChangedSinceLastSave
    /// </summary>
    public unsafe bool bChapterChangedSinceLastSave
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1360) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1360); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1360); }
    }

    /// <summary>
    /// ArrayProperty: MapTapeCharactersToBioCharacters
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EBioCharacter> MapTapeCharactersToBioCharacters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EBioCharacter>>(Ptr + 1364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1364); }
    }

    /// <summary>
    /// ArrayProperty: Bio_LocIndexs
    /// </summary>
    public unsafe BmSDK.TArray<int> Bio_LocIndexs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1380); }
    }

    /// <summary>
    /// FloatProperty: Enygma_CooldownTimer
    /// </summary>
    public unsafe float Enygma_CooldownTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1396); }
    }

    /// <summary>
    /// StructProperty: vObjectiveLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 vObjectiveLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1400); }
    }

    /// <summary>
    /// ArrayProperty: CustomWaypoint
    /// </summary>
    public unsafe BmSDK.TArray<float> CustomWaypoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 1412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1412); }
    }

    /// <summary>
    /// StrProperty: CustomWaypointName
    /// </summary>
    public unsafe BmSDK.FString CustomWaypointName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1428); }
    }

    /// <summary>
    /// StrProperty: CustomWaypointTypeName
    /// </summary>
    public unsafe BmSDK.FString CustomWaypointTypeName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1444); }
    }

    /// <summary>
    /// StrProperty: RealWaypointName
    /// </summary>
    public unsafe BmSDK.FString RealWaypointName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1460); }
    }

    /// <summary>
    /// StrProperty: ObjectiveStyle
    /// </summary>
    public unsafe BmSDK.FString ObjectiveStyle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1476); }
    }

    /// <summary>
    /// StrProperty: CustomWaypoint_VisibleFlag
    /// </summary>
    public unsafe BmSDK.FString CustomWaypoint_VisibleFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1492); }
    }

    /// <summary>
    /// StrProperty: CustomWaypoint_DoneFlag
    /// </summary>
    public unsafe BmSDK.FString CustomWaypoint_DoneFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1508); }
    }

    /// <summary>
    /// ArrayProperty: CustomWaypoint_StatesVisible
    /// </summary>
    public unsafe BmSDK.TArray<byte> CustomWaypoint_StatesVisible
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 1524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1524); }
    }

    /// <summary>
    /// NameProperty: PlayableCharacter
    /// </summary>
    public unsafe BmSDK.FName PlayableCharacter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1540); }
    }

    /// <summary>
    /// NameProperty: PlayableBatmobile
    /// </summary>
    public unsafe BmSDK.FName PlayableBatmobile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1548); }
    }

    /// <summary>
    /// ArrayProperty: BullyEncounters_Active
    /// </summary>
    public unsafe BmSDK.TArray<byte> BullyEncounters_Active
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 1556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1556); }
    }

    /// <summary>
    /// ArrayProperty: BullyEncounters_Completed
    /// </summary>
    public unsafe BmSDK.TArray<byte> BullyEncounters_Completed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 1572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1572); }
    }

    /// <summary>
    /// ArrayProperty: BullyEncounters_JackRyder_Active
    /// </summary>
    public unsafe BmSDK.TArray<byte> BullyEncounters_JackRyder_Active
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 1588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1588); }
    }

    /// <summary>
    /// ArrayProperty: BullyEncounters_JackRyder_Completed
    /// </summary>
    public unsafe BmSDK.TArray<byte> BullyEncounters_JackRyder_Completed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 1604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1604); }
    }

    /// <summary>
    /// ArrayProperty: DynamicIcons_Name
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> DynamicIcons_Name
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1620); }
    }

    /// <summary>
    /// ArrayProperty: DynamicIcons_Type
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> DynamicIcons_Type
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1636); }
    }

    /// <summary>
    /// ArrayProperty: DynamicIcons_Map
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> DynamicIcons_Map
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1652); }
    }

    /// <summary>
    /// ArrayProperty: DynamicIcons_X
    /// </summary>
    public unsafe BmSDK.TArray<int> DynamicIcons_X
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1668); }
    }

    /// <summary>
    /// ArrayProperty: DynamicIcons_Y
    /// </summary>
    public unsafe BmSDK.TArray<int> DynamicIcons_Y
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1684); }
    }

    /// <summary>
    /// ArrayProperty: DynamicIcons_Z
    /// </summary>
    public unsafe BmSDK.TArray<int> DynamicIcons_Z
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1700); }
    }

    /// <summary>
    /// ArrayProperty: Music_Names
    /// </summary>
    public unsafe BmSDK.TArray<int> Music_Names
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1716); }
    }

    /// <summary>
    /// ArrayProperty: Music_States
    /// </summary>
    public unsafe BmSDK.TArray<int> Music_States
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1732); }
    }

    /// <summary>
    /// ArrayProperty: Music_ParamNames
    /// </summary>
    public unsafe BmSDK.TArray<int> Music_ParamNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1748); }
    }

    /// <summary>
    /// ArrayProperty: Music_ParamValues
    /// </summary>
    public unsafe BmSDK.TArray<float> Music_ParamValues
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 1764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1764); }
    }

    /// <summary>
    /// IntProperty: RiddlerResonatorAfterCh3Count
    /// </summary>
    public unsafe int RiddlerResonatorAfterCh3Count
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1780); }
    }

    /// <summary>
    /// IntProperty: RiddlerResonatorBeforeCh3Count
    /// </summary>
    public unsafe int RiddlerResonatorBeforeCh3Count
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1784); }
    }

    /// <summary>
    /// IntProperty: NumVanillaGlidesAfterDiveTutorial
    /// </summary>
    public unsafe int NumVanillaGlidesAfterDiveTutorial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1788); }
    }

    /// <summary>
    /// IntProperty: CatwomanCollarIndex
    /// </summary>
    public unsafe int CatwomanCollarIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1792); }
    }

    /// <summary>
    /// ArrayProperty: CraneSavedName
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> CraneSavedName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1796); }
    }

    /// <summary>
    /// ArrayProperty: CraneSavedRotation
    /// </summary>
    public unsafe BmSDK.TArray<int> CraneSavedRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1812); }
    }

    /// <summary>
    /// ArrayProperty: CraneSavedHeight
    /// </summary>
    public unsafe BmSDK.TArray<float> CraneSavedHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 1828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1828); }
    }

    /// <summary>
    /// ArrayProperty: CraneSavedMatineePoint
    /// </summary>
    public unsafe BmSDK.TArray<float> CraneSavedMatineePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 1844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1844); }
    }

    /// <summary>
    /// ArrayProperty: JumpLocations
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> JumpLocations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 1860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1860); }
    }

    /// <summary>
    /// FloatProperty: TotalDriftTime
    /// </summary>
    public unsafe float TotalDriftTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1876); }
    }

    /// <summary>
    /// IntProperty: MilitiaVehiclesRammed
    /// </summary>
    public unsafe int MilitiaVehiclesRammed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1880); }
    }

    /// <summary>
    /// IntProperty: NumCriticalShots
    /// </summary>
    public unsafe int NumCriticalShots
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1884); }
    }

    /// <summary>
    /// IntProperty: BatmanCarTakedowns
    /// </summary>
    public unsafe int BatmanCarTakedowns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1888); }
    }

    /// <summary>
    /// IntProperty: QuickGadgetsUsedInCombat
    /// </summary>
    public unsafe int QuickGadgetsUsedInCombat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1892); }
    }

    /// <summary>
    /// IntProperty: NumFearTakedownsPerformed
    /// </summary>
    public unsafe int NumFearTakedownsPerformed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1896); }
    }

    /// <summary>
    /// ArrayProperty: PredTakedownsPerformed
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction> PredTakedownsPerformed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction>>(Ptr + 1900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1900); }
    }

    /// <summary>
    /// ArrayProperty: TutInfoOld
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentData.FTutorialInfo> TutInfoOld
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentData.FTutorialInfo>>(Ptr + 1916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1916); }
    }

    /// <summary>
    /// ArrayProperty: TutInfo
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentData.FTutorialInfoNew> TutInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentData.FTutorialInfoNew>>(Ptr + 1932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1932); }
    }

    /// <summary>
    /// ArrayProperty: AutomaticCombatTutorials
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentData.ETutorialType> AutomaticCombatTutorials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentData.ETutorialType>>(Ptr + 1948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1948); }
    }

    /// <summary>
    /// ArrayProperty: HighPriorityDesignTutorials
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentData.ETutorialType> HighPriorityDesignTutorials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentData.ETutorialType>>(Ptr + 1964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1964); }
    }

    /// <summary>
    /// IntProperty: NumKnockoutSmashInstructions
    /// </summary>
    public unsafe int NumKnockoutSmashInstructions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1980); }
    }

    /// <summary>
    /// IntProperty: NumGrappleBoostFailHints
    /// </summary>
    public unsafe int NumGrappleBoostFailHints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1984); }
    }

    /// <summary>
    /// IntProperty: NumFearTakedownLostInstructions
    /// </summary>
    public unsafe int NumFearTakedownLostInstructions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1988); }
    }

    /// <summary>
    /// ArrayProperty: informantPriorities__OW_A
    /// </summary>
    public unsafe BmSDK.TArray<int> informantPriorities__OW_A
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1992); }
    }

    /// <summary>
    /// ArrayProperty: informantPriorities__OW_C
    /// </summary>
    public unsafe BmSDK.TArray<int> informantPriorities__OW_C
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2008); }
    }

    /// <summary>
    /// ArrayProperty: informantPriorities__OW_E
    /// </summary>
    public unsafe BmSDK.TArray<int> informantPriorities__OW_E
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2024); }
    }

    /// <summary>
    /// ArrayProperty: informantMaintainPriority__OW_A
    /// </summary>
    public unsafe BmSDK.TArray<int> informantMaintainPriority__OW_A
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2040); }
    }

    /// <summary>
    /// ArrayProperty: informantMaintainPriority__OW_C
    /// </summary>
    public unsafe BmSDK.TArray<int> informantMaintainPriority__OW_C
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2056); }
    }

    /// <summary>
    /// ArrayProperty: informantMaintainPriority__OW_E
    /// </summary>
    public unsafe BmSDK.TArray<int> informantMaintainPriority__OW_E
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2072); }
    }

    /// <summary>
    /// IntProperty: lastChapterSeenByInformantManager
    /// </summary>
    public unsafe int lastChapterSeenByInformantManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2088); }
    }

    /// <summary>
    /// IntProperty: numMaggotsBataranged
    /// </summary>
    public unsafe int numMaggotsBataranged
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2092); }
    }

    /// <summary>
    /// IntProperty: CWEpisodeReplayState
    /// </summary>
    public unsafe int CWEpisodeReplayState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2096); }
    }

    /// <summary>
    /// StructProperty: BatmobileSafePointLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 BatmobileSafePointLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2100); }
    }

    /// <summary>
    /// StructProperty: BatmobileSafePointRotation
    /// </summary>
    public unsafe BmSDK.Rotator BatmobileSafePointRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 2112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2112); }
    }

    /// <summary>
    /// StrProperty: BatmobileSafePointLevel
    /// </summary>
    public unsafe BmSDK.FString BatmobileSafePointLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2124); }
    }

    /// <summary>
    /// ArrayProperty: BatmobileSafePointStreamingLevels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> BatmobileSafePointStreamingLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2140); }
    }

    /// <summary>
    /// ArrayProperty: BatmobileSafePointStreamingLevelsLODs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> BatmobileSafePointStreamingLevelsLODs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2156); }
    }

    /// <summary>
    /// IntProperty: AirshipTutorialCount
    /// </summary>
    public unsafe int AirshipTutorialCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2172); }
    }

    /// <summary>
    /// StructProperty: BatmobilePassengers
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.FBatmobilePassengerSave BatmobilePassengers_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.FBatmobilePassengerSave>(Ptr + 2176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2176); }
    }
    /// <summary>
    /// StructProperty: BatmobilePassengers
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.FBatmobilePassengerSave BatmobilePassengers_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.FBatmobilePassengerSave>(Ptr + 2260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2260); }
    }
    /// <summary>
    /// StructProperty: BatmobilePassengers
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.FBatmobilePassengerSave BatmobilePassengers_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.FBatmobilePassengerSave>(Ptr + 2344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2344); }
    }
    /// <summary>
    /// StructProperty: BatmobilePassengers
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.FBatmobilePassengerSave BatmobilePassengers_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.FBatmobilePassengerSave>(Ptr + 2428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2428); }
    }

    /// <summary>
    /// IntProperty: JokerRooftopChapterDialogueIndex
    /// </summary>
    public unsafe int JokerRooftopChapterDialogueIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2512); }
    }

    /// <summary>
    /// IntProperty: JokerRooftopSideStoryDialogueIndex
    /// </summary>
    public unsafe int JokerRooftopSideStoryDialogueIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2516); }
    }

    /// <summary>
    /// ArrayProperty: JokerRooftopSideStoryDialogueIndexNew
    /// </summary>
    public unsafe BmSDK.TArray<int> JokerRooftopSideStoryDialogueIndexNew
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2520); }
    }

    /// <summary>
    /// FloatProperty: TimeTillNextJokerRooftop
    /// </summary>
    public unsafe float TimeTillNextJokerRooftop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2536); }
    }

    /// <summary>
    /// StrProperty: JokerTimerReason
    /// </summary>
    public unsafe BmSDK.FString JokerTimerReason
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2540); }
    }

    /// <summary>
    /// IntProperty: HarleyMayhemMeter
    /// </summary>
    public unsafe int HarleyMayhemMeter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2556); }
    }

    /// <summary>
    /// IntProperty: Batgirl_Achievement_ThugsDefeated_DuringHack
    /// </summary>
    public unsafe int Batgirl_Achievement_ThugsDefeated_DuringHack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2560); }
    }

    /// <summary>
    /// ArrayProperty: EvidenceTrailsData
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentData.FEvidenceTrail> EvidenceTrailsData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentData.FEvidenceTrail>>(Ptr + 2564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2564); }
    }

    /// <summary>
    /// ArrayProperty: MostWantedData
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentData.FMostWanted_Data> MostWantedData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentData.FMostWanted_Data>>(Ptr + 2580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2580); }
    }

    /// <summary>
    /// ArrayProperty: MostWanted_PygVictimOrder
    /// </summary>
    public unsafe BmSDK.TArray<int> MostWanted_PygVictimOrder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2596); }
    }

    /// <summary>
    /// ArrayProperty: SideStoryMapIcons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentData.FSideStoryMapIconEntry> SideStoryMapIcons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentData.FSideStoryMapIconEntry>>(Ptr + 2612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2612); }
    }

    /// <summary>
    /// StrProperty: SideStoryLastIntelGiven
    /// </summary>
    public unsafe BmSDK.FString SideStoryLastIntelGiven
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2628); }
    }

    /// <summary>
    /// StrProperty: SideStoryIntelState
    /// </summary>
    public unsafe BmSDK.FString SideStoryIntelState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2644); }
    }

    /// <summary>
    /// StrProperty: PenguinIntelState
    /// </summary>
    public unsafe BmSDK.FString PenguinIntelState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2660); }
    }

    /// <summary>
    /// StrProperty: GlobalFlagReqdForNextPenguinIntel
    /// </summary>
    public unsafe BmSDK.FString GlobalFlagReqdForNextPenguinIntel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2676); }
    }

    /// <summary>
    /// FloatProperty: TimeUntilPenguinIntelRefresh
    /// </summary>
    public unsafe float TimeUntilPenguinIntelRefresh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2692); }
    }

    /// <summary>
    /// FloatProperty: TimeUntilChapterNineIntelRefresh
    /// </summary>
    public unsafe float TimeUntilChapterNineIntelRefresh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2696); }
    }

    /// <summary>
    /// FloatProperty: accumulatedTimeInRangeOfHushCar
    /// </summary>
    public unsafe float accumulatedTimeInRangeOfHushCar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2700); }
    }

    /// <summary>
    /// StructProperty: UsedOnceOnlyLine
    /// </summary>
    public unsafe BmSDK.GameObject.FSet_Mirror UsedOnceOnlyLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FSet_Mirror>(Ptr + 2704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2704); }
    }

    /// <summary>
    /// StructProperty: DialogueOnceOnlyEvents
    /// </summary>
    public unsafe BmSDK.GameObject.FSet_Mirror DialogueOnceOnlyEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FSet_Mirror>(Ptr + 2776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2776); }
    }

    /// <summary>
    /// StructProperty: SavedDialoguePlayCounts
    /// </summary>
    public unsafe BmSDK.GameObject.FMap_Mirror SavedDialoguePlayCounts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FMap_Mirror>(Ptr + 2848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2848); }
    }

    /// <summary>
    /// StructProperty: SavedDialogueOnceEverEvents
    /// </summary>
    public unsafe BmSDK.GameObject.FSet_Mirror SavedDialogueOnceEverEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FSet_Mirror>(Ptr + 2920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2920); }
    }

    /// <summary>
    /// IntProperty: NumVehicleTakedowns
    /// </summary>
    public unsafe int NumVehicleTakedowns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2992); }
    }

    /// <summary>
    /// StructProperty: APCInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.FAPCSideStoryInfo APCInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.FAPCSideStoryInfo>(Ptr + 2996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2996); }
    }

    /// <summary>
    /// ArrayProperty: DistrictRandomPopulation
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentData.FRandomPopulationDefine> DistrictRandomPopulation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentData.FRandomPopulationDefine>>(Ptr + 3140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3140); }
    }

    /// <summary>
    /// IntProperty: NumTimesUsedBattleModeAsBrake
    /// </summary>
    public unsafe int NumTimesUsedBattleModeAsBrake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3156); }
    }

    /// <summary>
    /// ByteProperty: MW_DLC_Tutorial
    /// </summary>
    public unsafe byte MW_DLC_Tutorial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 3160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3160); }
    }

    /// <summary>
    /// ByteProperty: AR_DLC_Tutorial
    /// </summary>
    public unsafe byte AR_DLC_Tutorial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 3161); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3161); }
    }

    /// <summary>
    /// ByteProperty: RasTrailMobileWaypointOn
    /// </summary>
    public unsafe byte RasTrailMobileWaypointOn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 3162); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3162); }
    }

    /// <summary>
    /// StructProperty: RasTrailMobileWaypointLoc
    /// </summary>
    public unsafe System.Numerics.Vector3 RasTrailMobileWaypointLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3164); }
    }

    /// <summary>
    /// StructProperty: RasTrailMobileWaypointLastBreadrumbLoc
    /// </summary>
    public unsafe System.Numerics.Vector3 RasTrailMobileWaypointLastBreadrumbLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3176); }
    }

    /// <summary>
    /// ArrayProperty: PersistentLevelNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> PersistentLevelNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 3188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3188); }
    }

    /// <summary>
    /// ByteProperty: bLastVideoChatterTriggerWasScarecrow
    /// </summary>
    public unsafe byte bLastVideoChatterTriggerWasScarecrow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 3204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3204); }
    }

    /// <summary>
    /// Enum: EBatmanChallenge
    /// </summary>
    public enum EBatmanChallenge
    {
        EBatChal_None = 0,
        EBatChal = 1,
        EBatChal_2 = 2,
        EBatChal_3 = 3,
        EBatChal_4 = 4,
        EBatChal_5 = 5,
        EBatChal_6 = 6,
        EBatChal_7 = 7,
        EBatChal_8 = 8,
        EBatChal_9 = 9,
        EBatChal_10 = 10,
        EBatChal_11 = 11,
        EBatChal_12 = 12,
        EBatChal_13 = 13,
        EBatChal_14 = 14,
        EBatChal_15 = 15,
        EBatChal_16 = 16,
        EBatChal_17 = 17,
        EBatChal_18 = 18,
        EBatChal_19 = 19,
        EBatChal_20 = 20,
        EBatChal_21 = 21,
        EBatChal_22 = 22,
        EBatChal_23 = 23,
        EBatChal_24 = 24,
        EBatChal_25 = 25,
        EBatChal_26 = 26,
        EBatChal_27 = 27,
        EBatChal_28 = 28,
        EBatChal_29 = 29,
        EBatChal_30 = 30,
        EBatChal_31 = 31,
        EBatChal_32 = 32,
        EBatChal_33 = 33,
        EBatChal_34 = 34,
        EBatChal_35 = 35,
        EBatChal_36 = 36,
        EBatChal_37 = 37,
        EBatChal_38 = 38,
        EBatChal_39 = 39,
        EBatChal_40 = 40,
        EBatChal_41 = 41,
        EBatChal_42 = 42,
        EBatChal_43 = 43,
        EBatChal_44 = 44,
        EBatChal_45 = 45,
        EBatChal_MAX = 46,
    }

    /// <summary>
    /// Enum: EProgressLocations
    /// </summary>
    public enum EProgressLocations
    {
        EPL_Unknown = 0,
        EPL_GCPD = 1,
        EPL_Museum = 2,
        EPL_WonderTower = 3,
        EPL_Processing = 4,
        EPL_SteelWorks = 5,
        EPL_PrisonerEntrance = 6,
        EPL_Hotel = 7,
        EPL_Courthouse = 8,
        EPL_WonderCity = 9,
        EPL_Theatre = 10,
        EPL_IcebergLounge = 11,
        EPL_Warehouse = 12,
        EPL_Sewers = 13,
        EPL_Church = 14,
        EPL_ParkRow = 15,
        EPL_CrimeAlley = 16,
        EPL_ClockTower = 17,
        EPL_BatCave = 18,
        EPL_GothamCity = 19,
        EPL_ZsaszWarehouse = 20,
        EPL_MAX = 21,
    }

    /// <summary>
    /// Enum: ECustomWayPointType
    /// </summary>
    public enum ECustomWayPointType
    {
        CustomWayType_Proximity = 0,
        CustomWayType_MapObj = 1,
        CustomWayType_Riddler = 2,
        CustomWayType_SideStory = 3,
        CustomWayType_Challenge = 4,
        CustomWayType_MAX = 5,
    }

    /// <summary>
    /// Enum: EShowcaseVehicle
    /// </summary>
    public enum EShowcaseVehicle
    {
        ShowcaseVehicle_None = 0,
        Showcase_Batwing = 1,
        Showcase_BatPod = 2,
        Showcase_Batmobile = 3,
        Showcase_BatmobilePrototype = 4,
        Showcase_BatmobileMk2 = 5,
        Showcase_Batmobile1966 = 6,
        Showcase_BatmobileJokerfied = 7,
        Showcase_APC = 8,
        Showcase_APCMissileLauncher = 9,
        Showcase_Humvee = 10,
        Showcase_Excavator = 11,
        Showcase_Chinook = 12,
        Showcase_RedHoodAttackChopper = 13,
        Showcase_LightTank = 14,
        Showcase_LightTankArmor = 15,
        Showcase_LightTankMissile = 16,
        Showcase_LightTankDoubleBarrel = 17,
        Showcase_HeavyTank = 18,
        Showcase_CommanderTank = 19,
        Showcase_AirborneDrone = 20,
        Showcase_MiniPredatorDrone = 21,
        Showcase_PredatorDrone = 22,
        Showcase_RedHoodRelayDrone = 23,
        Showcase_MissileLauncher = 24,
        Showcase_Radar = 25,
        Showcase_PoliceCar = 26,
        Showcase_SWATVan = 27,
        Showcase_PoliceHelicopter = 28,
        Showcase_FireEngine = 29,
        Showcase_Ambulance = 30,
        Showcase_Taxi = 31,
        Showcase_Estate = 32,
        Showcase_CoupeCar = 33,
        Showcase_PickupTruck = 34,
        Showcase_RefrigerationVan = 35,
        Showcase_DumpsterTruck = 36,
        Showcase_Limo = 37,
        Showcase_SchoolBus = 38,
        EShowcaseVehicle_MAX = 39,
    }

    /// <summary>
    /// Enum: EShowcaseCharacter
    /// </summary>
    public enum EShowcaseCharacter
    {
        ShowcaseCharacter_None = 0,
        Showcase_AaronCash = 1,
        Showcase_AceWorker = 2,
        Showcase_Alfred = 3,
        Showcase_ArkhamKnight = 4,
        Showcase_AKRedhood = 5,
        Showcase_AKMilitia = 6,
        Showcase_AKCombatExpert = 7,
        Showcase_AKDetectiveModeInvis = 8,
        Showcase_AKMiniGun = 9,
        Showcase_AKMultiWeapon = 10,
        Showcase_Azrael = 11,
        Showcase_BatmanMk2 = 12,
        Showcase_Batman = 13,
        Showcase_Unmasked = 14,
        Showcase_BlackfireCult = 15,
        Showcase_Catwoman = 16,
        Showcase_Civilian = 17,
        Showcase_DeaconBlackfire = 18,
        Showcase_Deathstroke = 19,
        Showcase_Demon = 20,
        Showcase_Dollotron = 21,
        Showcase_Father = 22,
        Showcase_Firefly = 23,
        Showcase_Fireman = 24,
        Showcase_GCPDMale = 25,
        Showcase_GCPDFemale = 26,
        Showcase_Gordon = 27,
        Showcase_HarleyArmored = 28,
        Showcase_HarleyMinigun = 29,
        Showcase_HarleyQuinn = 30,
        Showcase_Hush = 31,
        Showcase_JackRyder = 32,
        Showcase_Joker = 33,
        Showcase_JokerBoxer = 34,
        Showcase_JokerEntertainer = 35,
        Showcase_JokerExecutive = 36,
        Showcase_JokerSick = 37,
        Showcase_JokerTeacher = 38,
        Showcase_JokerYoung = 39,
        Showcase_KirkLangstrom = 40,
        Showcase_LuciusFox = 41,
        Showcase_ManBat = 42,
        Showcase_Monkey = 43,
        Showcase_Nightwing = 44,
        Showcase_Oracle = 45,
        Showcase_Paramedic = 46,
        Showcase_Penguin = 47,
        Showcase_PenguinArmored = 48,
        Showcase_PenguinThug = 49,
        Showcase_PoisonIvy = 50,
        Showcase_Pyg = 51,
        Showcase_Reporter = 52,
        Showcase_Riddler = 53,
        Showcase_RiddlerMech = 54,
        Showcase_RiddlerRobot = 55,
        Showcase_Rioter = 56,
        Showcase_Robin = 57,
        Showcase_Scarecrow = 58,
        Showcase_SimonStagg = 59,
        Showcase_StaggScientist = 60,
        Showcase_TwoFace = 61,
        Showcase_TwoFaceThug = 62,
        Showcase_VickyVale = 63,
        Showcase_Waitress = 64,
        Showcase_YoungJasonTodd = 65,
        Showcase_CheckpointCommander = 66,
        Showcase_HarleyThug = 67,
        Showcase_BatmanPristine = 68,
        Showcase_DLCMadHatter = 69,
        Showcase_DLCMr_Freeze = 70,
        Showcase_DLCNora = 71,
        Showcase_DLCRas_Al_Ghul = 72,
        Showcase_DLCNyssa_Raatko = 73,
        Showcase_DLCLOA_Loyalists = 74,
        Showcase_DLCLOA_Rebels = 75,
        Showcase_DLCLOA_Thugs = 76,
        Showcase_DLCKillerCroc = 77,
        Showcase_DLCPrison_Guards = 78,
        Showcase_DLCPrisoners = 79,
        Showcase_DLCBatmanComplete = 80,
        EShowcaseCharacter_MAX = 81,
    }

    /// <summary>
    /// Enum: EConceptArt
    /// </summary>
    public enum EConceptArt
    {
        ConceptArt_None = 0,
        ConceptArt_Ace01 = 1,
        ConceptArt_Ace03 = 2,
        ConceptArt_Ace04 = 3,
        ConceptArt_Ace05 = 4,
        ConceptArt_Ace06 = 5,
        ConceptArt_Ace07 = 6,
        ConceptArt_Ace10 = 7,
        ConceptArt_Bank02 = 8,
        ConceptArt_Bank03 = 9,
        ConceptArt_CityX10 = 10,
        ConceptArt_CityX11 = 11,
        ConceptArt_CityX12 = 12,
        ConceptArt_CityX2 = 13,
        ConceptArt_CityX3 = 14,
        ConceptArt_CityX4 = 15,
        ConceptArt_CityX5 = 16,
        ConceptArt_CityX6 = 17,
        ConceptArt_CityX7 = 18,
        ConceptArt_CityX8 = 19,
        ConceptArt_CityX9 = 20,
        ConceptArt_CityX = 21,
        ConceptArt_CityY2 = 22,
        ConceptArt_CityY3 = 23,
        ConceptArt_CityY4 = 24,
        ConceptArt_CityY = 25,
        ConceptArt_CityZ2 = 26,
        ConceptArt_CityZ3 = 27,
        ConceptArt_CityZ = 28,
        ConceptArt_Clocktower01 = 29,
        ConceptArt_Clocktower02 = 30,
        ConceptArt_FeargasBatman = 31,
        ConceptArt_GCPD01 = 32,
        ConceptArt_Hideout01 = 33,
        ConceptArt_Hideout02 = 34,
        ConceptArt_Hideout03 = 35,
        ConceptArt_Hideout04 = 36,
        ConceptArt_Hideout05 = 37,
        ConceptArt_Hideout06 = 38,
        ConceptArt_Hideout07 = 39,
        ConceptArt_Ivy01 = 40,
        ConceptArt_Ivy02 = 41,
        ConceptArt_Jokerboss01 = 42,
        ConceptArt_Jokerboss02 = 43,
        ConceptArt_Jokerboss03 = 44,
        ConceptArt_Movie01 = 45,
        ConceptArt_Movie02 = 46,
        ConceptArt_Movie04 = 47,
        ConceptArt_Movie06 = 48,
        ConceptArt_Movie07 = 49,
        ConceptArt_Penguin01 = 50,
        ConceptArt_Pyg01 = 51,
        ConceptArt_Riddler01 = 52,
        ConceptArt_Riddler03 = 53,
        ConceptArt_Riddler04 = 54,
        ConceptArt_Stagg01 = 55,
        ConceptArt_Stagg02 = 56,
        ConceptArt_Stagg03 = 57,
        ConceptArt_Stagg04 = 58,
        ConceptArt_WayneOffice01 = 59,
        ConceptArt_WayneManor01 = 60,
        ConceptArt_DLC_RacetrackBurton01 = 61,
        ConceptArt_DLC_RacetrackClassic01 = 62,
        ConceptArt_DLC_RacetrackTumbler01 = 63,
        ConceptArt_DLC_RacetrackWaynetech01 = 64,
        ConceptArt_MAX = 65,
    }

    /// <summary>
    /// Enum: ECM_MedalType
    /// </summary>
    public enum ECM_MedalType
    {
        ECM_Medal_None = 0,
        ECM_Medal_Bronze = 1,
        ECM_Medal_Silver = 2,
        ECM_Medal_Gold = 3,
        ECM_Medal_MAX = 4,
    }

    /// <summary>
    /// Enum: PDVersion
    /// </summary>
    public enum PDVersion
    {
        PDVer_Initial = 0,
        PDVer_XPLevel = 1,
        PDVer_PercentageCompleted = 2,
        PDVer_StoryPercentage = 3,
        PDVer_UpgradesBought = 4,
        PDVer_ExtraProfileStrings = 5,
        PDVer_LevelsLoadedNotVisible = 6,
        PDVer_NextLevel = 7,
        PDVer_StoreButtonBashMod = 8,
        PDVer_MovedChallengeDataToOptions = 9,
        PDVer_CharacterViewer = 10,
        PDVer_MapKeyFlags = 11,
        PDVer_RemovedChallengeArrays = 12,
        PDVer_MovedNewArrays = 13,
        PDVer_CombatMovePrompts = 14,
        PDVer_UpgradesNew = 15,
        PDVer_LunaticGroundPrompt = 16,
        PDVer_ComboBatarangPrompt = 17,
        PDVer_LineLaunchPrompt = 18,
        PDVer_MovedExtraStrings = 19,
        PDVer_NewObjectivesList = 20,
        PDVer_PredatorGroundPrompt = 21,
        PDVer_UpgradesIndex = 22,
        PDVer_GrateTutorial = 23,
        PDVer_HangDropTutorial = 24,
        PDVer_TapesCollected = 25,
        PDVer_RemoveRiddlerSecretsTotal = 26,
        PDVer_LastDoorVector = 27,
        PDVer_MoveBiosAgain = 28,
        PDVer_SavedRoom = 29,
        PDVer_SixaxisTutorial = 30,
        PDVer_Mixbin = 31,
        PDVer_DetectiveJamming = 32,
        PDVer_InterrogationArrays = 33,
        PDVer_RadioStations = 34,
        PDVer_StreamingLevels = 35,
        PDVer_PickupCount = 36,
        PDVer_ObjectiveTracking = 37,
        PDVer_AddedPlayableChar = 38,
        PDVer_AddedRadioAudioStates = 39,
        PDVer_AddedCharacterProgress = 40,
        PDVer_RiddlerData = 41,
        PDVer_CustomWaypoint = 42,
        PDVer_GalleryUnlocks = 43,
        PDVer_BackScreen = 44,
        PDVer_DroneTrails = 45,
        PDVer_PoisonedHealthBar = 46,
        PDVer_ProgressNameUnknown = 47,
        PDVer_ProgressPercentage = 48,
        PDVer_ProgressTextIds = 49,
        PDVer_ZsaszPhones = 50,
        PDVer_RiddlerData2 = 51,
        PDVer_PlayOnceRadioStations = 52,
        PDVer_AddedTrailItems = 53,
        PDVer_OWTutorials = 54,
        PDVer_GrappleBoostTutorial = 55,
        PDVer_PickupReveals = 56,
        PDVer_Zsasz_NewRingingPhone = 57,
        PDVer_Tutorial = 58,
        PDVer_WaypointNames = 59,
        PDVer_TrackingCams = 60,
        PDVer_UpgradeVars = 61,
        PDVer_CatwomanJewellery = 62,
        PDVer_PoisonFaceLevel = 63,
        PDVer_Music = 64,
        PDVer_EnygmaData = 65,
        PDVer_DynamicMapIcons1 = 66,
        PDVer_Armour = 67,
        PDVer_StorySynopsisState = 68,
        PDVer_CatwomanEpisodes = 69,
        PDVer_BullyEncounters = 70,
        PDVer_ReplayInfo = 71,
        PDVer_MovedStuff1 = 72,
        PDVer_BruceWayneLegChains = 73,
        PDVer_ZsaszPhones2 = 74,
        PDVer_StealthTutorial = 75,
        PDVer_MusicParams = 76,
        PDVer_Chapter = 77,
        PDVer_JokerBalloons = 78,
        PDVer_ExplainedBatarangRules = 79,
        PDVer_DropOffGrapplePrompt = 80,
        PDVer_SeekFreePackages = 81,
        PDVer_BreakablePenguins = 82,
        PDVer_RiddlerData3 = 83,
        PDVer_RiddlerData4 = 84,
        PDVer_GroundTakedownTutorial = 85,
        PDVer_CityStories = 86,
        PDVer_ChallengeUnlockIndex = 87,
        PDVer_CantThrowFromFreezePlatform = 88,
        PDVer_MovedCityStories = 89,
        PDVer_ARTraining_RaceWins = 90,
        PDVer_CW_UpgradesBought = 91,
        PDVer_BullyEncounters_JackRyder = 92,
        PDVer_EnygmaData1 = 93,
        PDVer_PickupReveals2 = 94,
        PDVer_RiddlerResonator = 95,
        PDVer_KOSmashInstructions = 96,
        PDVer_GlideOffWallPrompt = 97,
        PDVer_MapUserMarkerExtension = 98,
        PDVer_GrappleBoostHints = 99,
        PDVer_WaypointTypeName = 100,
        PDVer_InformantManager = 101,
        PDVer_BrokenHarleyHeadTally = 102,
        PDVer_BatChallengeData = 103,
        PDVer_BrokenCameras = 104,
        PDVer_CheckForRiddlerUnlocks = 105,
        PDVer_GrundyHelpText = 106,
        PDVer_RadioStationOverrides = 107,
        PDVer_BrokenDemonSealTally = 108,
        PDVer_SideObjective = 109,
        PDVer_CWPicks = 110,
        PDVer_CWArmour = 111,
        PDVer_RemoveDroneTrails = 112,
        PDVer_SecuROMCheckData = 113,
        PDVer_GrundyMaggots = 114,
        PDVer_RiddlerRows = 115,
        PDVer_BioIndexChange = 116,
        PDVer_RaftCancel = 117,
        PDVer_TrackNumVanillaGlides = 118,
        PDVer_EliminatedReplayVars = 119,
        PDVer_FakeZsaszPhoneForMap = 120,
        PDVer_DesignTriggeredTutorials = 121,
        PDVer_InterrogationTutorial = 122,
        PDVer_ZsaszFakeMapPhone2 = 123,
        PDVer_MovedStuffForNGPShare = 124,
        PDVer_MovedStuffForNGPShare2 = 125,
        PDVer_StoryDLC = 126,
        PDVer_CustomReached = 127,
        PDVer_ProgressLastStatusUpdated = 128,
        PDVer_CWEpisodeReplay = 129,
        PDVer_StreamingImprovements = 130,
        PDVer_ForensicsCleanup = 131,
        PDVer_RadioStationCleanup = 132,
        PDVer_Batmobile = 133,
        PDVer_CurrentChallengeMode = 134,
        PDVer_RemoveOldHealthBarStuff = 135,
        PDVer_AddedIconZ = 136,
        PDVer_BatmobileForensics = 137,
        PDVer_RemoveBatmobileForensics = 138,
        PDVer_CatCollar = 139,
        PDVer_MapUserMarkerExtension2 = 140,
        PDVer_RemovedBm2SideStoryArrays = 141,
        PDVer_AirshipTutorial = 142,
        PDVer_BatmobileWinchState = 143,
        PDVer_AddedMostWantedData = 144,
        PDVer_AddedLowUrgency = 145,
        PDVer_FlagValues = 146,
        PDVer_RemoveCurrentChallengeMode = 147,
        PDVer_BatmobileTutorials = 148,
        PDVer_PygVictims = 149,
        PDVer_IncendiaryTutorial = 150,
        PDVer_DynamicPopulation = 151,
        PDVer_AddedMapAutopanList = 152,
        PDVer_DynamicPopulation_PauseState = 153,
        PDVer_HushProgress = 154,
        PDVer_BatmobilePassengers = 155,
        PDVer_NewInterrogationIndexes = 156,
        PDVer_CraneSaves = 157,
        PDVer_TotalRiddler = 158,
        PDVer_JokerSick = 159,
        PDVer_ChangedToTrailStructs = 160,
        PDVer_JokerRooftopDialogue = 161,
        PDVer_ZsaszPhonesRemoved = 162,
        PDVer_APCSideStory = 163,
        PDVer_BatmobileLevel = 164,
        PDVer_InstallChunkRequired = 165,
        PDVer_UpdatedDriveTutorial = 166,
        PDVer_StorySynopsisBm3 = 167,
        PDVer_AKAnnouncedMedicLinePlayed = 168,
        PDVer_PlayableBatmobile = 169,
        PDVer_JokerRooftopDialogue2 = 170,
        PDVer_RiddlerData5 = 171,
        PDVer_UpgradeVars2 = 172,
        PDVer_HarleyMayhemMeter = 173,
        PDVer_AutoToggleMostWantedBool = 174,
        PDVer_SideStoriesDisabled = 175,
        PDVer_NewDroneCommanderFlags = 176,
        PDVer_OnceOnlyDialogue = 177,
        PDVer_StoryProgressIDs = 178,
        PDVer_ToggleDrivingCamera = 179,
        PDVer_SideStoryMapIcons = 180,
        PDVer_DynamicBrakeTutorial = 181,
        PDVer_IntelSystem = 182,
        PDVer_AwardIntelPoints = 183,
        PDVer_ObjectiveStyle = 184,
        PDVer_ChapterNineRecurringIntel = 185,
        PDVer_StoryProgressDialogue = 186,
        PDVer_AvoidRepeatingIntel = 187,
        PDVer_PenguinIntelExpanded = 188,
        PDVer_BatmobileHealth = 189,
        PDVer_MidKnightFallPoint = 190,
        PDVer_BillboardChatterCount = 191,
        PDVer_VehicleTakedowns = 192,
        PDVer_DisableAutoSaves = 193,
        PDVer_FixNameSerialisation = 194,
        PDVer_SideStoriesDisabledBy = 195,
        PDVer_BatgirlDLCAchievement = 196,
        PDVer_MovedHeaderData = 197,
        PDVer_InformantNumbers = 198,
        PDVer_SideStoriesDisabledStreaming = 199,
        PDVer_AchievementTracking = 200,
        PDVer_BatmobilePassengers2 = 201,
        PDVer_BatmobileFakeRemote = 202,
        PDVer_BluntTraumaAchievement = 203,
        PDVer_BluntTraumaAchievementV2 = 204,
        PDVer_JokerRooftopDialogue3 = 205,
        PDVer_ExtraMinidroneTutorialCompleted = 206,
        PDVer_TotalRiddler2 = 207,
        PDVer_FullyDisablePlayerMapSelection = 208,
        PDVer_VideoRecordStatus = 209,
        PDVer_DLCSideStories = 210,
        PDVer_BatmobilePassengers3 = 211,
        PDVer_InstallChunkHack = 212,
        PDVer_BatmobileEnergy = 213,
        PDVer_MostWantedAudioIndices = 214,
        PDVer_KnightmareFearTakedownPenalty = 215,
        PDVer_DialogueOnceOnlyEvents = 216,
        PDVer_SavedDialoguePlayCounts = 217,
        PDVer_SavedDialogueOnceEverEvents = 218,
        PDVer_RemoveUsedOnceOnlyLine = 219,
        PDVer_MWAR_DLC_Tutorial = 220,
        PDVer_DLC_Ras_MobileWaypoint = 221,
        PDVer_DLC_Ras_MobileWaypoint2 = 222,
        PDVer_MAX = 223,
    }
}
