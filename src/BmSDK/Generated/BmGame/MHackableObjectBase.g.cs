#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MHackableObjectBase<br/>
/// (flags = 0)
/// </summary>
public partial class MHackableObjectBase : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MHackableObjectBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MHackableObjectBase() { }

    /// <summary>
    /// Constructs a new MHackableObjectBase
    /// </summary>
    public MHackableObjectBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MHackableObjectBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MHackableObjectBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MHackableObjectBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MHackableObjectBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MHackableObjectBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MHackableObjectBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MHackableObjectBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MHackableObjectBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MHackableObjectBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: OnToggle
    /// </summary>
    public unsafe void OnToggle(BmSDK.Engine.SeqAct_Toggle Action)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.OnToggle", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.Tick", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerCompleteEvent
    /// </summary>
    public unsafe bool TriggerCompleteEvent(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.TriggerCompleteEvent", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: CreateHackMaskMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent CreateHackMaskMesh()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.CreateHackMaskMesh", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ChangeHighlightType
    /// </summary>
    public unsafe void ChangeHighlightType(BmSDK.BmGame.MHackableInterface.EHackableObjectState newHighlightType, bool bForce = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.ChangeHighlightType", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(newHighlightType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForce, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetSubroutineDescription
    /// </summary>
    public unsafe BmSDK.FString GetSubroutineDescription(BmSDK.BmGame.MHackableInterface.FSubroutineDefinition Definition)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.GetSubroutineDescription", true);
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
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.GetSubroutineName", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Definition, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 72);
    }

    /// <summary>
    /// Function: IsSubroutineTypeDisable
    /// </summary>
    public unsafe bool IsSubroutineTypeDisable(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.IsSubroutineTypeDisable", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SetSubroutineNameAndDescriptionModifiedByKismet
    /// </summary>
    public unsafe void SetSubroutineNameAndDescriptionModifiedByKismet(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType, BmSDK.FString NewSubroutineName, BmSDK.FString NewSubroutineDescription)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.SetSubroutineNameAndDescriptionModifiedByKismet", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSubroutineName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSubroutineDescription, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DisableSubroutineType
    /// </summary>
    public unsafe void DisableSubroutineType(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType, bool NewIsDisable)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.DisableSubroutineType", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewIsDisable, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsObjectEnable
    /// </summary>
    public unsafe bool IsObjectEnable()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.IsObjectEnable", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetInHackableMode
    /// </summary>
    public unsafe void SetInHackableMode(bool On, bool bForce)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.SetInHackableMode", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForce, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetHackableState
    /// </summary>
    public unsafe BmSDK.BmGame.MHackableInterface.EHackableObjectState GetHackableState()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.GetHackableState", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHackableInterface.EHackableObjectState>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetDisplayTargetLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 GetDisplayTargetLocation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.GetDisplayTargetLocation", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetSubroutineDefinitionForType
    /// </summary>
    public unsafe BmSDK.BmGame.MHackableInterface.FSubroutineDefinition GetSubroutineDefinitionForType(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.GetSubroutineDefinitionForType", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHackableInterface.FSubroutineDefinition>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetNumberOfSubroutineTypes
    /// </summary>
    public unsafe int GetNumberOfSubroutineTypes()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.GetNumberOfSubroutineTypes", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: NotifyOnHack
    /// </summary>
    public unsafe void NotifyOnHack(BmSDK.Engine.Actor HackedObject, BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.NotifyOnHack", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HackedObject, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerCancelEvent
    /// </summary>
    public unsafe bool TriggerCancelEvent(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.TriggerCancelEvent", true);
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
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.TriggerEvent", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetOutputIndexForEvent
    /// </summary>
    public unsafe int GetOutputIndexForEvent(BmSDK.BmGame.MHackableInterface.EHackSubroutineType SubroutineType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.GetOutputIndexForEvent", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: NeedToDisplayNumberOfTargets
    /// </summary>
    public unsafe bool NeedToDisplayNumberOfTargets()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.NeedToDisplayNumberOfTargets", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanBeExecuted
    /// </summary>
    public unsafe bool CanBeExecuted()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.CanBeExecuted", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanInterrupt
    /// </summary>
    public unsafe bool CanInterrupt(BmSDK.BmGame.MHackableInterface.EHackSubroutineType HackType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.CanInterrupt", true);
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
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.ExecuteSubroutine", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HackType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineClass, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: SpawnSubroutine
    /// </summary>
    public unsafe void SpawnSubroutine(BmSDK.BmGame.MHackableInterface.EHackSubroutineType HackType, BmSDK.Class SubroutineClass)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.SpawnSubroutine", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HackType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineClass, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnPreviewSubroutine
    /// </summary>
    public unsafe void SpawnPreviewSubroutine(BmSDK.BmGame.MHackableInterface.EHackSubroutineType HackType, BmSDK.Class SubroutineClass)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.SpawnPreviewSubroutine", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HackType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SubroutineClass, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetAffectedActors
    /// </summary>
    public unsafe void GetAffectedActors(BmSDK.BmGame.MHackableInterface.EHackSubroutineType HackType, BmSDK.Class SubroutineClass, out BmSDK.TArray<BmSDK.Engine.Actor> AffectedActors)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.GetAffectedActors", true);
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
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.GetPossibleSubroutineTypes", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        PossibleTypes = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MHackableInterface.EHackSubroutineType>>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: GetCurrentSubroutineType
    /// </summary>
    public unsafe BmSDK.BmGame.MHackableInterface.EHackSubroutineType GetCurrentSubroutineType()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.GetCurrentSubroutineType", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHackableInterface.EHackSubroutineType>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetPreviewSubroutine
    /// </summary>
    public unsafe BmSDK.BmGame.MHackSubroutine GetPreviewSubroutine()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.GetPreviewSubroutine", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHackSubroutine>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetCurrentSubroutine
    /// </summary>
    public unsafe BmSDK.BmGame.MHackSubroutine GetCurrentSubroutine()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.GetCurrentSubroutine", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHackSubroutine>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetInXrayMode
    /// </summary>
    public unsafe void SetInXrayMode(bool On, bool bForceOff)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.SetInXrayMode", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOff, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CreateXrayMaskMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent CreateXrayMaskMesh()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.CreateXrayMaskMesh", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: UpdateStateMesh
    /// </summary>
    public unsafe void UpdateStateMesh()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.UpdateStateMesh", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CreateHighlightMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent CreateHighlightMesh()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.CreateHighlightMesh", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetupHighlightMaterial
    /// </summary>
    public unsafe void SetupHighlightMaterial()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHackableObjectBase.SetupHighlightMaterial", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ComponentProperty: StaticMeshComponent
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent StaticMeshComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ObjectProperty: HackingViewMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface HackingViewMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ObjectProperty: DetectiveModeMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface DetectiveModeMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ObjectProperty: DisableStateStaticMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMesh DisableStateStaticMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMesh>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// ObjectProperty: CurrentSubroutine
    /// </summary>
    public unsafe BmSDK.BmGame.MHackSubroutine CurrentSubroutine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHackSubroutine>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ObjectProperty: PreviewSubroutine
    /// </summary>
    public unsafe BmSDK.BmGame.MHackSubroutine PreviewSubroutine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHackSubroutine>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ObjectProperty: HighlightMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstance HighlightMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstance>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ObjectProperty: HighlightMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant HighlightMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ObjectProperty: EnableStateStaticMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMesh EnableStateStaticMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMesh>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ComponentProperty: HighlightStaticMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent HighlightStaticMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ComponentProperty: XRayMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent XRayMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ComponentProperty: DLCXtraMaskMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent DLCXtraMaskMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ComponentProperty: Interactions
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent Interactions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ArrayProperty: SupportedSubroutines
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MHackableInterface.FSubroutineDefinition> SupportedSubroutines
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MHackableInterface.FSubroutineDefinition>>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// StructProperty: TargetPositionOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 TargetPositionOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// InterfaceProperty: NotifyObjectOnHack
    /// </summary>
    public unsafe BmSDK.BmGame.MHackableInterface NotifyObjectOnHack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHackableInterface>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// IntProperty: EnableAfterHackCount
    /// </summary>
    public unsafe int EnableAfterHackCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// ByteProperty: CurrentHighlightType
    /// </summary>
    public unsafe BmSDK.BmGame.MHackableInterface.EHackableObjectState CurrentHighlightType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHackableInterface.EHackableObjectState>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ByteProperty: SubroutinesTypeDisabled
    /// </summary>
    public unsafe byte SubroutinesTypeDisabled_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 821); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 821); }
    }
    /// <summary>
    /// ByteProperty: SubroutinesTypeDisabled
    /// </summary>
    public unsafe byte SubroutinesTypeDisabled_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 822); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 822); }
    }
    /// <summary>
    /// ByteProperty: SubroutinesTypeDisabled
    /// </summary>
    public unsafe byte SubroutinesTypeDisabled_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 823); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 823); }
    }
    /// <summary>
    /// ByteProperty: SubroutinesTypeDisabled
    /// </summary>
    public unsafe byte SubroutinesTypeDisabled_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }
    /// <summary>
    /// ByteProperty: SubroutinesTypeDisabled
    /// </summary>
    public unsafe byte SubroutinesTypeDisabled_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 825); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 825); }
    }
    /// <summary>
    /// ByteProperty: SubroutinesTypeDisabled
    /// </summary>
    public unsafe byte SubroutinesTypeDisabled_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 826); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 826); }
    }
    /// <summary>
    /// ByteProperty: SubroutinesTypeDisabled
    /// </summary>
    public unsafe byte SubroutinesTypeDisabled_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 827); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 827); }
    }
    /// <summary>
    /// ByteProperty: SubroutinesTypeDisabled
    /// </summary>
    public unsafe byte SubroutinesTypeDisabled_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// IntProperty: RoomHackedCount
    /// </summary>
    public unsafe int RoomHackedCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// BoolProperty: bEnabled
    /// </summary>
    public unsafe bool bEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 836); }
    }

    /// <summary>
    /// BoolProperty: bHacked
    /// </summary>
    public unsafe bool bHacked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 836); }
    }

    /// <summary>
    /// BoolProperty: bUsingEnableStateMesh
    /// </summary>
    public unsafe bool bUsingEnableStateMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 836); }
    }

    /// <summary>
    /// StrProperty: SubroutinesNameModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesNameModifiedByKismet_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }
    /// <summary>
    /// StrProperty: SubroutinesNameModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesNameModifiedByKismet_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }
    /// <summary>
    /// StrProperty: SubroutinesNameModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesNameModifiedByKismet_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }
    /// <summary>
    /// StrProperty: SubroutinesNameModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesNameModifiedByKismet_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }
    /// <summary>
    /// StrProperty: SubroutinesNameModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesNameModifiedByKismet_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }
    /// <summary>
    /// StrProperty: SubroutinesNameModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesNameModifiedByKismet_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }
    /// <summary>
    /// StrProperty: SubroutinesNameModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesNameModifiedByKismet_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }
    /// <summary>
    /// StrProperty: SubroutinesNameModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesNameModifiedByKismet_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// StrProperty: SubroutinesDescriptionModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesDescriptionModifiedByKismet_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }
    /// <summary>
    /// StrProperty: SubroutinesDescriptionModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesDescriptionModifiedByKismet_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }
    /// <summary>
    /// StrProperty: SubroutinesDescriptionModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesDescriptionModifiedByKismet_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }
    /// <summary>
    /// StrProperty: SubroutinesDescriptionModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesDescriptionModifiedByKismet_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }
    /// <summary>
    /// StrProperty: SubroutinesDescriptionModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesDescriptionModifiedByKismet_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }
    /// <summary>
    /// StrProperty: SubroutinesDescriptionModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesDescriptionModifiedByKismet_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }
    /// <summary>
    /// StrProperty: SubroutinesDescriptionModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesDescriptionModifiedByKismet_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }
    /// <summary>
    /// StrProperty: SubroutinesDescriptionModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesDescriptionModifiedByKismet_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }
}
