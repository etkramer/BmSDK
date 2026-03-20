#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: MHackableInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface MHackableInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: SpawnPreviewSubroutine
    /// </summary>
    public unsafe void SpawnPreviewSubroutine(BmSDK.BmGame.MHackableInterface.EHackSubroutineType HackType, BmSDK.Class SubroutineClass);

    /// <summary>
    /// Function: DisableSubroutineType
    /// </summary>
    public unsafe void DisableSubroutineType(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType, bool NewIsDisable);

    /// <summary>
    /// Function: SetSubroutineNameAndDescriptionModifiedByKismet
    /// </summary>
    public unsafe void SetSubroutineNameAndDescriptionModifiedByKismet(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType, BmSDK.FString NewSubroutineName, BmSDK.FString NewSubroutineDescription);

    /// <summary>
    /// Function: CreateHackMaskMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent CreateHackMaskMesh();

    /// <summary>
    /// Function: SetInHackableMode
    /// </summary>
    public unsafe void SetInHackableMode(bool On, bool bForce);

    /// <summary>
    /// Function: NotifyOnHack
    /// </summary>
    public unsafe void NotifyOnHack(BmSDK.Engine.Actor HackedObject, BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType);

    /// <summary>
    /// Function: GetAffectedActors
    /// </summary>
    public unsafe void GetAffectedActors(BmSDK.BmGame.MHackableInterface.EHackSubroutineType HackType, BmSDK.Class SubroutineClass, out BmSDK.TArray<BmSDK.Engine.Actor> AffectedActors);

    /// <summary>
    /// Function: GetPossibleSubroutineTypes
    /// </summary>
    public unsafe void GetPossibleSubroutineTypes(out BmSDK.TArray<BmSDK.BmGame.MHackableInterface.EHackSubroutineType> PossibleTypes);

    /// <summary>
    /// Function: OnToggle
    /// </summary>
    public unsafe void OnToggle(BmSDK.Engine.SeqAct_Toggle Action);

    /// <summary>
    /// Function: GetSubroutineDefinitionForType
    /// </summary>
    public unsafe BmSDK.BmGame.MHackableInterface.FSubroutineDefinition GetSubroutineDefinitionForType(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType);

    /// <summary>
    /// Function: GetPreviewSubroutine
    /// </summary>
    public unsafe BmSDK.BmGame.MHackSubroutine GetPreviewSubroutine();

    /// <summary>
    /// Function: GetCurrentSubroutine
    /// </summary>
    public unsafe BmSDK.BmGame.MHackSubroutine GetCurrentSubroutine();

    /// <summary>
    /// Function: GetCurrentSubroutineType
    /// </summary>
    public unsafe BmSDK.BmGame.MHackableInterface.EHackSubroutineType GetCurrentSubroutineType();

    /// <summary>
    /// Function: GetHackableState
    /// </summary>
    public unsafe BmSDK.BmGame.MHackableInterface.EHackableObjectState GetHackableState();

    /// <summary>
    /// Function: GetDisplayTargetLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 GetDisplayTargetLocation();

    /// <summary>
    /// Function: GetSubroutineDescription
    /// </summary>
    public unsafe BmSDK.FString GetSubroutineDescription(BmSDK.BmGame.MHackableInterface.FSubroutineDefinition Definition);

    /// <summary>
    /// Function: GetSubroutineName
    /// </summary>
    public unsafe BmSDK.FString GetSubroutineName(BmSDK.BmGame.MHackableInterface.FSubroutineDefinition Definition);

    /// <summary>
    /// Function: GetNumberOfSubroutineTypes
    /// </summary>
    public unsafe int GetNumberOfSubroutineTypes();

    /// <summary>
    /// Function: TriggerCancelEvent
    /// </summary>
    public unsafe bool TriggerCancelEvent(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType);

    /// <summary>
    /// Function: TriggerCompleteEvent
    /// </summary>
    public unsafe bool TriggerCompleteEvent(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType);

    /// <summary>
    /// Function: TriggerEvent
    /// </summary>
    public unsafe bool TriggerEvent(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType);

    /// <summary>
    /// Function: NeedToDisplayNumberOfTargets
    /// </summary>
    public unsafe bool NeedToDisplayNumberOfTargets();

    /// <summary>
    /// Function: IsSubroutineTypeDisable
    /// </summary>
    public unsafe bool IsSubroutineTypeDisable(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType);

    /// <summary>
    /// Function: IsObjectEnable
    /// </summary>
    public unsafe bool IsObjectEnable();

    /// <summary>
    /// Function: CanBeExecuted
    /// </summary>
    public unsafe bool CanBeExecuted();

    /// <summary>
    /// Function: CanInterrupt
    /// </summary>
    public unsafe bool CanInterrupt(BmSDK.BmGame.MHackableInterface.EHackSubroutineType HackType);

    /// <summary>
    /// Function: ExecuteSubroutine
    /// </summary>
    public unsafe bool ExecuteSubroutine(BmSDK.BmGame.MHackableInterface.EHackSubroutineType HackType, BmSDK.Class SubroutineClass);

    /// <summary>
    /// Struct: FSubroutineDefinition
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial record struct FSubroutineDefinition
    {
        /// <summary>
        /// ByteProperty: SubroutineType
        /// </summary>
        public unsafe BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHackableInterface.EHackSubroutineType>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: SubroutineContext
        /// </summary>
        public unsafe BmSDK.BmGame.MHackSubroutineContext SubroutineContext
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHackSubroutineContext>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StrProperty: SubroutineLocalizedId
        /// </summary>
        public unsafe BmSDK.FString SubroutineLocalizedId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StrProperty: SubroutineDescriptionLocalizedId
        /// </summary>
        public unsafe BmSDK.FString SubroutineDescriptionLocalizedId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// ByteProperty: SubroutineIcon
        /// </summary>
        public unsafe BmSDK.BmGame.MHackableInterface.EHackSubroutineIcon SubroutineIcon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHackableInterface.EHackSubroutineIcon>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// ArrayProperty: SubroutineAffectedActors
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.Actor> SubroutineAffectedActors
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// ObjectProperty: SubroutineLookAtActor
        /// </summary>
        public unsafe BmSDK.Engine.Actor SubroutineLookAtActor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }
    }

    /// <summary>
    /// Enum: EHackSubroutineIcon
    /// </summary>
    public enum EHackSubroutineIcon
    {
        HACKICON_None = 0,
        HACKICON_Generic_Attract = 1,
        HACKICON_Generic_Takedown = 2,
        HACKICON_Generic_Scare = 3,
        HACKICON_Generic_Blind = 4,
        HACKICON_Generic_Control = 5,
        HACKICON_Generic_Door = 6,
        HACKICON_Generic_Deactivate = 7,
        HACKICON_Generic_Activate = 8,
        HACKICON_MAX = 9,
    }

    /// <summary>
    /// Enum: EHackableObjectState
    /// </summary>
    public enum EHackableObjectState
    {
        HOS_Unavailable = 0,
        HOS_Running = 1,
        HOS_Available = 2,
        HOS_MAX = 3,
    }

    /// <summary>
    /// Enum: EHackSubroutineType
    /// </summary>
    public enum EHackSubroutineType
    {
        HACKTYPE_None = 0,
        HACKTYPE_Toggle = 1,
        HACKTYPE_Control = 2,
        HACKTYPE_Takedown = 3,
        HACKTYPE_Attract = 4,
        HACKTYPE_Scare = 5,
        HACKTYPE_Trap = 6,
        HACKTYPE_Blind = 7,
        HACKTYPE_MAX = 8,
    }
}
