#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RLevelTransitionDoubleDoors<br/>
/// (flags = 0)
/// </summary>
public partial class RLevelTransitionDoubleDoors : BmSDK.BmGame.RLevelTransitionDoorBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RLevelTransitionDoubleDoors", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RLevelTransitionDoubleDoors() { }

    /// <summary>
    /// Constructs a new RLevelTransitionDoubleDoors
    /// </summary>
    public RLevelTransitionDoubleDoors(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RLevelTransitionDoubleDoors Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RLevelTransitionDoubleDoors(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RLevelTransitionDoubleDoors>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLevelTransitionDoubleDoors>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RLevelTransitionDoubleDoors>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLevelTransitionDoubleDoors>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLevelTransitionDoubleDoors>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RLevelTransitionDoubleDoors>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLevelTransitionDoubleDoors>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// BoolProperty: DoorLocked
    /// </summary>
    public unsafe bool DoorLocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 760); }
    }

    /// <summary>
    /// BoolProperty: ShowLockedText
    /// </summary>
    public unsafe bool ShowLockedText
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 760); }
    }

    /// <summary>
    /// BoolProperty: bOpenedByKismet
    /// </summary>
    public unsafe bool bOpenedByKismet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 760); }
    }

    /// <summary>
    /// BoolProperty: bClosingByKismet
    /// </summary>
    public unsafe bool bClosingByKismet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 760); }
    }

    /// <summary>
    /// BoolProperty: bCanUse
    /// </summary>
    public unsafe bool bCanUse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 760); }
    }

    /// <summary>
    /// BoolProperty: bDisableDoorTransition
    /// </summary>
    public unsafe bool bDisableDoorTransition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 760); }
    }

    /// <summary>
    /// BoolProperty: bPlayerNearAfterUsingDuringGlobalLock
    /// </summary>
    public unsafe bool bPlayerNearAfterUsingDuringGlobalLock
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 760); }
    }

    /// <summary>
    /// BoolProperty: ShowClearTheAreaText
    /// </summary>
    public unsafe bool ShowClearTheAreaText
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 760); }
    }

    /// <summary>
    /// BoolProperty: ForceLockedPromptAfterUse
    /// </summary>
    public unsafe bool ForceLockedPromptAfterUse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 760); }
    }

    /// <summary>
    /// BoolProperty: LockedWhenSideStoriesDisabled
    /// </summary>
    public unsafe bool LockedWhenSideStoriesDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 760); }
    }

    /// <summary>
    /// BoolProperty: bUsedLockedMesh
    /// </summary>
    public unsafe bool bUsedLockedMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 760); }
    }

    /// <summary>
    /// BoolProperty: bCollisionCheckForUsage
    /// </summary>
    public unsafe bool bCollisionCheckForUsage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 760); }
    }

    /// <summary>
    /// BoolProperty: bInvestigateAutoKnowsLocked
    /// </summary>
    public unsafe bool bInvestigateAutoKnowsLocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 760); }
    }

    /// <summary>
    /// BoolProperty: ShowPadlock
    /// </summary>
    public unsafe bool ShowPadlock
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 760); }
    }

    /// <summary>
    /// BoolProperty: bUsableByBatman
    /// </summary>
    public unsafe bool bUsableByBatman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 760); }
    }

    /// <summary>
    /// BoolProperty: bUsableByRobin
    /// </summary>
    public unsafe bool bUsableByRobin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 760); }
    }

    /// <summary>
    /// BoolProperty: bUsableByCatwoman
    /// </summary>
    public unsafe bool bUsableByCatwoman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 760); }
    }

    /// <summary>
    /// BoolProperty: bAffectedByAutomaticCombatLock
    /// </summary>
    public unsafe bool bAffectedByAutomaticCombatLock
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 760); }
    }

    /// <summary>
    /// BoolProperty: bIsMagneticDoor
    /// </summary>
    public unsafe bool bIsMagneticDoor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 760); }
    }

    /// <summary>
    /// BoolProperty: bDisableUntilGiveGadget
    /// </summary>
    public unsafe bool bDisableUntilGiveGadget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 760); }
    }

    /// <summary>
    /// ObjectProperty: DoorDefinition
    /// </summary>
    public unsafe BmSDK.BmGame.RDoorDefinition DoorDefinition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDoorDefinition>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ObjectProperty: CustomDoorOpenFront
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CustomDoorOpenFront
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ObjectProperty: CustomDoorOpenBack
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CustomDoorOpenBack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ObjectProperty: CustomDoorLockedFront
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CustomDoorLockedFront
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ObjectProperty: CustomDoorLockedBack
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CustomDoorLockedBack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// ObjectProperty: CustomDoorOpenFrontDual
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CustomDoorOpenFrontDual
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ObjectProperty: CustomDoorOpenBackDual
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CustomDoorOpenBackDual
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// ObjectProperty: DoorLockedMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant DoorLockedMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ObjectProperty: XrayMat
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant XrayMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// ComponentProperty: LockedBarsMeshDD
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent LockedBarsMeshDD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// ComponentProperty: LockedBarsMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent LockedBarsMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// ComponentProperty: InvestigationMesh2
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent InvestigationMesh2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// ComponentProperty: InvestigationMesh1
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent InvestigationMesh1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// ComponentProperty: DoorBlocker
    /// </summary>
    public unsafe BmSDK.Engine.RAggGeomCollisionComponent DoorBlocker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAggGeomCollisionComponent>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// ComponentProperty: MeshDD
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent MeshDD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ComponentProperty: Mesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent Mesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// StrProperty: ClearTheAreaText
    /// </summary>
    public unsafe BmSDK.FString ClearTheAreaText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// FloatProperty: LockedBarsAlpha
    /// </summary>
    public unsafe float LockedBarsAlpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// StrProperty: OpenDoorText
    /// </summary>
    public unsafe BmSDK.FString OpenDoorText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// StrProperty: LockedDoorText
    /// </summary>
    public unsafe BmSDK.FString LockedDoorText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// ArrayProperty: InvestigateNamePresets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> InvestigateNamePresets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// ArrayProperty: OldMaterials
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInterface> OldMaterials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInterface>>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// ArrayProperty: SaveGameDescriptionsRedDirection
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameRI.FDebugSaveDescription> SaveGameDescriptionsRedDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameRI.FDebugSaveDescription>>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// ArrayProperty: SaveGameDescriptionsGreenDirection
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameRI.FDebugSaveDescription> SaveGameDescriptionsGreenDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameRI.FDebugSaveDescription>>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// ByteProperty: CombatLockSides
    /// </summary>
    public unsafe BmSDK.BmGame.RLevelTransitionDoorBase.ECombatLockSides CombatLockSides
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLevelTransitionDoorBase.ECombatLockSides>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }
}
