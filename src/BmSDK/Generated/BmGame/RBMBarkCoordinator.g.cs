#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBarkCoordinator<br/>
/// (size = 728)
/// (flags = 144703634)
/// </summary>
public partial class RBMBarkCoordinator : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBarkCoordinator", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBarkCoordinator() { }

    /// <summary>
    /// Constructs a new RBMBarkCoordinator
    /// </summary>
    public RBMBarkCoordinator(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBarkCoordinator Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBarkCoordinator(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBarkCoordinator>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBarkCoordinator>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBarkCoordinator>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBarkCoordinator>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBarkCoordinator>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBarkCoordinator>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBarkCoordinator>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: GetLinesMatchingFlags
    /// </summary>
    public unsafe static BmSDK.TArray<BmSDK.BmGame.RBarkConvo> GetLinesMatchingFlags(BmSDK.TArray<BmSDK.BmGame.RBarkConvo> TestLines, BmSDK.BmGame.RBarkValDef.FlagTypeEnum TestType, BmSDK.FName TestValue)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBarkCoordinator.GetLinesMatchingFlags", true);
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLines, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestType, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestValue, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBarkConvo>>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: GetLinesContainingFlags
    /// </summary>
    public unsafe static BmSDK.TArray<BmSDK.BmGame.RBarkConvo> GetLinesContainingFlags(BmSDK.TArray<BmSDK.BmGame.RBarkConvo> TestLines, BmSDK.BmGame.RBarkFlagBase ContextFlags)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBarkCoordinator.GetLinesContainingFlags", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLines, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContextFlags, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBarkConvo>>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: CheckCoverage
    /// </summary>
    public unsafe static bool CheckCoverage(BmSDK.TArray<BmSDK.BmGame.RBarkSet> TestSet, BmSDK.BmGame.RBarkFlagBase BaseQuery, out BmSDK.TArray<BmSDK.BmGame.RBarkFlagBase> FailCases, out BmSDK.TArray<BmSDK.BmGame.RBarkValDef.FlagTypeEnum> MustDefineList)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBarkCoordinator.CheckCoverage", true);
        byte* paramsPtr = stackalloc byte[208];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestSet, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BaseQuery, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        FailCases = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBarkFlagBase>>(paramsPtr + 24);
        MustDefineList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBarkValDef.FlagTypeEnum>>(paramsPtr + 40);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 56);
    }

    /// <summary>
    /// Function: DecreaseDialogueFrequency
    /// </summary>
    public unsafe virtual void DecreaseDialogueFrequency()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBarkCoordinator.DecreaseDialogueFrequency", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetMinRandomBarkTime
    /// </summary>
    public unsafe virtual void SetMinRandomBarkTime(float NewMin)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBarkCoordinator.SetMinRandomBarkTime", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMin, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InstigateRandomBark
    /// </summary>
    public unsafe virtual void InstigateRandomBark()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBarkCoordinator.InstigateRandomBark", true);
        byte* paramsPtr = stackalloc byte[112];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FunctionalityTest
    /// </summary>
    public unsafe static void FunctionalityTest()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBarkCoordinator.FunctionalityTest", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DumpStateToLog
    /// </summary>
    public unsafe virtual void DumpStateToLog()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBarkCoordinator.DumpStateToLog", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PawnDied
    /// </summary>
    public unsafe virtual void PawnDied(BmSDK.BmGame.RPawnVillain DeadPawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBarkCoordinator.PawnDied", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeadPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FreeLock
    /// </summary>
    public unsafe virtual void FreeLock(BmSDK.GameObject ExLockee)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBarkCoordinator.FreeLock", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExLockee, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetLock
    /// </summary>
    public unsafe virtual void SetLock(BmSDK.GameObject NewLockee)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBarkCoordinator.SetLock", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLockee, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DialogueLockedByObjectOfClass
    /// </summary>
    public unsafe virtual bool DialogueLockedByObjectOfClass(BmSDK.Class TestClass)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBarkCoordinator.DialogueLockedByObjectOfClass", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestClass, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: DialogueLockedBySpecificObject
    /// </summary>
    public unsafe virtual bool DialogueLockedBySpecificObject(BmSDK.GameObject Obj)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBarkCoordinator.DialogueLockedBySpecificObject", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Obj, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: DialogueLockedBySpecificEvent
    /// </summary>
    public unsafe virtual bool DialogueLockedBySpecificEvent(BmSDK.BmGame.RAlertEventCoordinatorBase Event)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBarkCoordinator.DialogueLockedBySpecificEvent", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Event, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: AddRegionFlagFromMapString
    /// </summary>
    public unsafe static void AddRegionFlagFromMapString(BmSDK.FString MapStr, out BmSDK.BmGame.RBarkFlagBase ContextFlags)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBarkCoordinator.AddRegionFlagFromMapString", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapStr, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ContextFlags = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkFlagBase>(paramsPtr + 16);
        return;
    }

    /// <summary>
    /// Function: AddLocationFlags
    /// </summary>
    public unsafe virtual void AddLocationFlags(BmSDK.Engine.Actor Subject, out BmSDK.BmGame.RBarkFlagBase ContextFlags)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBarkCoordinator.AddLocationFlags", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Subject, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ContextFlags = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkFlagBase>(paramsPtr + 8);
        return;
    }

    /// <summary>
    /// Function: GetLocationFlag
    /// </summary>
    public unsafe virtual BmSDK.FName GetLocationFlag(BmSDK.Engine.Actor Subject)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBarkCoordinator.GetLocationFlag", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Subject, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: CanPlayBark
    /// </summary>
    public unsafe virtual bool CanPlayBark()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBarkCoordinator.CanPlayBark", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: StopCurrentConversationIfPawnInvolved
    /// </summary>
    public unsafe virtual void StopCurrentConversationIfPawnInvolved(BmSDK.BmGame.RPawnVillain Pawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBarkCoordinator.StopCurrentConversationIfPawnInvolved", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopCurrentConversation
    /// </summary>
    public unsafe virtual void StopCurrentConversation(bool bHardStop = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBarkCoordinator.StopCurrentConversation", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHardStop, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyPawnDestroyed
    /// </summary>
    public unsafe virtual void NotifyPawnDestroyed(BmSDK.BmGame.RPawnVillain Pawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBarkCoordinator.NotifyPawnDestroyed", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartBarkConvo
    /// </summary>
    public unsafe virtual void StartBarkConvo(BmSDK.BmGame.RBarkConvo NewBarkConvo, BmSDK.BmGame.RBarkGroupContext BGC, bool bOrphan = default, System.IntPtr NewBarkFinished = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBarkCoordinator.StartBarkConvo", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBarkConvo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BGC, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOrphan, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBarkFinished, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayBarkConvoForContext
    /// </summary>
    public unsafe virtual bool PlayBarkConvoForContext(BmSDK.TArray<BmSDK.Engine.Actor> OrderedSpeakerList, BmSDK.BmGame.RAlertEventCoordinatorBase NewOwningEvent, BmSDK.BmGame.RBarkFlagBase ContextFlags, BmSDK.BmGame.RBarkGroupContext GroupContext, System.IntPtr NewBarkFinished, bool bOrphan, out BmSDK.BmGame.RBarkFlagBase UsedLineContext, out int bFoundSomethingThatMatchedFlags)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBarkCoordinator.PlayBarkConvoForContext", true);
        byte* paramsPtr = stackalloc byte[84];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OrderedSpeakerList, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwningEvent, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContextFlags, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GroupContext, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBarkFinished, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOrphan, paramsPtr + 56);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        UsedLineContext = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkFlagBase>(paramsPtr + 60);
        bFoundSomethingThatMatchedFlags = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 68);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 72);
    }

    /// <summary>
    /// Function: GetBarkFromFlagsAndSpeakers
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBarkConvo GetBarkFromFlagsAndSpeakers(BmSDK.BmGame.RBarkFlagBase ContextFlags, BmSDK.TArray<BmSDK.Engine.Actor> OrderedSpeakerList, out float Score, out int bFoundSomethingThatMatchedFlags)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBarkCoordinator.GetBarkFromFlagsAndSpeakers", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContextFlags, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OrderedSpeakerList, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Score = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 24);
        bFoundSomethingThatMatchedFlags = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 28);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkConvo>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: PawnPlayBark
    /// </summary>
    public unsafe virtual bool PawnPlayBark(BmSDK.BmGame.RPawnVillain Speaker, BmSDK.BmGame.RBarkFlagBase ContextFlags, BmSDK.BmGame.RBarkGroupContext GroupContext = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBarkCoordinator.PawnPlayBark", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speaker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContextFlags, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GroupContext, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: PawnIsCurrentSpeaker
    /// </summary>
    public unsafe virtual bool PawnIsCurrentSpeaker(BmSDK.BmGame.RPawnVillain TestPawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBarkCoordinator.PawnIsCurrentSpeaker", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: HasBarksToPlay
    /// </summary>
    public unsafe virtual bool HasBarksToPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBarkCoordinator.HasBarksToPlay", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ResetLastSpeechTime
    /// </summary>
    public unsafe virtual void ResetLastSpeechTime()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBarkCoordinator.ResetLastSpeechTime", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DialogueLocked
    /// </summary>
    public unsafe virtual bool DialogueLocked()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBarkCoordinator.DialogueLocked", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: HasRunningBarks
    /// </summary>
    public unsafe virtual bool HasRunningBarks()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBarkCoordinator.HasRunningBarks", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetAllBarksFromAnySpeakersInList
    /// </summary>
    public unsafe static void GetAllBarksFromAnySpeakersInList(BmSDK.TArray<BmSDK.Engine.Actor> SpeakerList, out BmSDK.TArray<BmSDK.BmGame.RBarkSet> OutList)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBarkCoordinator.GetAllBarksFromAnySpeakersInList", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpeakerList, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBarkSet>>(paramsPtr + 16);
        return;
    }

    /// <summary>
    /// Function: GetBarkFromBarksetList
    /// </summary>
    public unsafe static BmSDK.BmGame.RBarkConvo GetBarkFromBarksetList(BmSDK.TArray<BmSDK.BmGame.RBarkSet> BarkSetList, BmSDK.BmGame.RBarkFlagBase ContextFlags, BmSDK.TArray<BmSDK.Engine.Actor> OrderedSpeakers, out float Score, BmSDK.GameObject fallbackConvoParent, out int bFoundSomethingThatMatchedFlags)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBarkCoordinator.GetBarkFromBarksetList", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BarkSetList, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContextFlags, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OrderedSpeakers, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fallbackConvoParent, paramsPtr + 44);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Score = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 40);
        bFoundSomethingThatMatchedFlags = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 52);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkConvo>(paramsPtr + 56);
    }

    /// <summary>
    /// Function: GetBarkConvo
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBarkConvo GetBarkConvo(BmSDK.BmGame.RPawnVillain Barker, BmSDK.BmGame.RBarkFlagBase ContextFlags)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBarkCoordinator.GetBarkConvo", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Barker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContextFlags, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkConvo>(paramsPtr + 16);
    }

    /// <summary>
    /// Struct: FCoverageTestBucket
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FCoverageTestBucket
    {
        /// <summary>
        /// ObjectProperty: Query
        /// </summary>
        public unsafe BmSDK.BmGame.RBarkFlagBase Query
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkFlagBase>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: LineList
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RBarkConvo> LineList
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBarkConvo>>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// ObjectProperty: CurrentConvo
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkConvo CurrentConvo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkConvo>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ObjectProperty: Tannoy
    /// </summary>
    public unsafe BmSDK.BmGame.RJokerTannoy Tannoy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RJokerTannoy>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// FloatProperty: TimeWithoutBark
    /// </summary>
    public unsafe float TimeWithoutBark
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// BoolProperty: bBarksEnabled
    /// </summary>
    public unsafe bool bBarksEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 688) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 688); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 688); }
    }

    /// <summary>
    /// BoolProperty: bRandomBarksEnabled
    /// </summary>
    public unsafe bool bRandomBarksEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 688) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 688); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 688); }
    }

    /// <summary>
    /// BoolProperty: bReactiveBarksOnly
    /// </summary>
    public unsafe bool bReactiveBarksOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 688) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 688); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 688); }
    }

    /// <summary>
    /// BoolProperty: bPreventThugAmbientChatter
    /// </summary>
    public unsafe bool bPreventThugAmbientChatter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 688) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 688); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 688); }
    }

    /// <summary>
    /// BoolProperty: bPredIdleConfigSpeaking
    /// </summary>
    public unsafe bool bPredIdleConfigSpeaking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 688) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 688); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 688); }
    }

    /// <summary>
    /// FloatProperty: MinRandomBarkTime
    /// </summary>
    public unsafe float MinRandomBarkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// FloatProperty: CurrRandomBarkTime
    /// </summary>
    public unsafe float CurrRandomBarkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// FloatProperty: TimeWithoutTannoyBark
    /// </summary>
    public unsafe float TimeWithoutTannoyBark
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// FloatProperty: MinTannoyTime
    /// </summary>
    public unsafe float MinTannoyTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ArrayProperty: LockList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> LockList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// FloatProperty: TimeWithoutLock
    /// </summary>
    public unsafe float TimeWithoutLock
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }
}
