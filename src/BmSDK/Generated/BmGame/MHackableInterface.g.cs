#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MHackableInterface<br/>
/// (flags = 0)
/// </summary>
public partial class MHackableInterface : BmSDK.Interface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MHackableInterface", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MHackableInterface() { }

    /// <summary>
    /// Constructs a new MHackableInterface
    /// </summary>
    public MHackableInterface(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MHackableInterface Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MHackableInterface(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: SpawnPreviewSubroutine
    /// </summary>
    public unsafe void SpawnPreviewSubroutine(BmSDK.BmGame.MHackableInterface.EHackSubroutineType HackType, BmSDK.Class SubroutineClass)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableInterface.SpawnPreviewSubroutine", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HackType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineClass, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DisableSubroutineType
    /// </summary>
    public unsafe void DisableSubroutineType(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType, bool NewIsDisable)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableInterface.DisableSubroutineType", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewIsDisable, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetSubroutineNameAndDescriptionModifiedByKismet
    /// </summary>
    public unsafe void SetSubroutineNameAndDescriptionModifiedByKismet(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType, BmSDK.FString NewSubroutineName, BmSDK.FString NewSubroutineDescription)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableInterface.SetSubroutineNameAndDescriptionModifiedByKismet", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSubroutineName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSubroutineDescription, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CreateHackMaskMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent CreateHackMaskMesh()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableInterface.CreateHackMaskMesh", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetInHackableMode
    /// </summary>
    public unsafe void SetInHackableMode(bool On, bool bForce)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableInterface.SetInHackableMode", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForce, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyOnHack
    /// </summary>
    public unsafe void NotifyOnHack(BmSDK.Engine.Actor HackedObject, BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableInterface.NotifyOnHack", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HackedObject, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetAffectedActors
    /// </summary>
    public unsafe void GetAffectedActors(BmSDK.BmGame.MHackableInterface.EHackSubroutineType HackType, BmSDK.Class SubroutineClass, out BmSDK.TArray<BmSDK.Engine.Actor> AffectedActors)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableInterface.GetAffectedActors", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HackType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineClass, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        AffectedActors = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(paramsPtr + 12);
        return;
    }

    /// <summary>
    /// Function: GetPossibleSubroutineTypes
    /// </summary>
    public unsafe void GetPossibleSubroutineTypes(out BmSDK.TArray<BmSDK.BmGame.MHackableInterface.EHackSubroutineType> PossibleTypes)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableInterface.GetPossibleSubroutineTypes", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PossibleTypes = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MHackableInterface.EHackSubroutineType>>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: OnToggle
    /// </summary>
    public unsafe void OnToggle(BmSDK.Engine.SeqAct_Toggle Action)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableInterface.OnToggle", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetSubroutineDefinitionForType
    /// </summary>
    public unsafe BmSDK.BmGame.MHackableInterface.FSubroutineDefinition GetSubroutineDefinitionForType(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableInterface.GetSubroutineDefinitionForType", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHackableInterface.FSubroutineDefinition>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetPreviewSubroutine
    /// </summary>
    public unsafe BmSDK.BmGame.MHackSubroutine GetPreviewSubroutine()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableInterface.GetPreviewSubroutine", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHackSubroutine>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetCurrentSubroutine
    /// </summary>
    public unsafe BmSDK.BmGame.MHackSubroutine GetCurrentSubroutine()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableInterface.GetCurrentSubroutine", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHackSubroutine>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetCurrentSubroutineType
    /// </summary>
    public unsafe BmSDK.BmGame.MHackableInterface.EHackSubroutineType GetCurrentSubroutineType()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableInterface.GetCurrentSubroutineType", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHackableInterface.EHackSubroutineType>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetHackableState
    /// </summary>
    public unsafe BmSDK.BmGame.MHackableInterface.EHackableObjectState GetHackableState()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableInterface.GetHackableState", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHackableInterface.EHackableObjectState>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetDisplayTargetLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 GetDisplayTargetLocation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableInterface.GetDisplayTargetLocation", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetSubroutineDescription
    /// </summary>
    public unsafe BmSDK.FString GetSubroutineDescription(BmSDK.BmGame.MHackableInterface.FSubroutineDefinition Definition)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableInterface.GetSubroutineDescription", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Definition, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 72);
    }

    /// <summary>
    /// Function: GetSubroutineName
    /// </summary>
    public unsafe BmSDK.FString GetSubroutineName(BmSDK.BmGame.MHackableInterface.FSubroutineDefinition Definition)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableInterface.GetSubroutineName", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Definition, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 72);
    }

    /// <summary>
    /// Function: GetNumberOfSubroutineTypes
    /// </summary>
    public unsafe int GetNumberOfSubroutineTypes()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableInterface.GetNumberOfSubroutineTypes", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: TriggerCancelEvent
    /// </summary>
    public unsafe bool TriggerCancelEvent(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableInterface.TriggerCancelEvent", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: TriggerCompleteEvent
    /// </summary>
    public unsafe bool TriggerCompleteEvent(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableInterface.TriggerCompleteEvent", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: TriggerEvent
    /// </summary>
    public unsafe bool TriggerEvent(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableInterface.TriggerEvent", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: NeedToDisplayNumberOfTargets
    /// </summary>
    public unsafe bool NeedToDisplayNumberOfTargets()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableInterface.NeedToDisplayNumberOfTargets", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsSubroutineTypeDisable
    /// </summary>
    public unsafe bool IsSubroutineTypeDisable(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableInterface.IsSubroutineTypeDisable", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsObjectEnable
    /// </summary>
    public unsafe bool IsObjectEnable()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableInterface.IsObjectEnable", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanBeExecuted
    /// </summary>
    public unsafe bool CanBeExecuted()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableInterface.CanBeExecuted", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanInterrupt
    /// </summary>
    public unsafe bool CanInterrupt(BmSDK.BmGame.MHackableInterface.EHackSubroutineType HackType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableInterface.CanInterrupt", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HackType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: ExecuteSubroutine
    /// </summary>
    public unsafe bool ExecuteSubroutine(BmSDK.BmGame.MHackableInterface.EHackSubroutineType HackType, BmSDK.Class SubroutineClass)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableInterface.ExecuteSubroutine", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HackType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineClass, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Struct: FSubroutineDefinition
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
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
