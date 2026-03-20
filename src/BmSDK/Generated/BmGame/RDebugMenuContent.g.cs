#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDebugMenuContent<br/>
/// (flags = 0)
/// </summary>
public partial class RDebugMenuContent : BmSDK.BmGame.RDebugMenu, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDebugMenuContent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDebugMenuContent() { }

    /// <summary>
    /// Constructs a new RDebugMenuContent
    /// </summary>
    public RDebugMenuContent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDebugMenuContent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDebugMenuContent(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDebugMenuContent>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDebugMenuContent>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDebugMenuContent>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDebugMenuContent>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDebugMenuContent>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDebugMenuContent>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDebugMenuContent>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: DoBackscreenMenu
    /// </summary>
    public unsafe void DoBackscreenMenu(BmSDK.BmGame.RPlayerController RPC, out BmSDK.BmGame.RPersistentDebugData.FBackscreenDebugData Debug_BackscreenDebugData)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.DoBackscreenMenu", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Debug_BackscreenDebugData = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentDebugData.FBackscreenDebugData>(paramsPtr + 8);
        return;
    }

    /// <summary>
    /// Function: MostWantedReCalc
    /// </summary>
    public unsafe void MostWantedReCalc(BmSDK.BmGame.RPlayerController RPC, out BmSDK.TArray<BmSDK.BmGame.RPersistentDebugData.FMostWantedDebugMenuData> Debug_MostWantedData, BmSDK.BmGame.RPersistentDebugData.MostWantedDebugMenuE Entry, int Index)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.MostWantedReCalc", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Entry, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Debug_MostWantedData = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentDebugData.FMostWantedDebugMenuData>>(paramsPtr + 8);
        return;
    }

    /// <summary>
    /// Function: BespokeProperties
    /// </summary>
    public unsafe void BespokeProperties(BmSDK.BmGame.RPlayerController RPC, out BmSDK.TArray<BmSDK.BmGame.RPersistentDebugData.FMostWantedDebugMenuData> Debug_MostWantedData, BmSDK.BmGame.RPersistentDebugData.MostWantedDebugMenuE Entry, int Index)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.BespokeProperties", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Entry, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Debug_MostWantedData = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentDebugData.FMostWantedDebugMenuData>>(paramsPtr + 8);
        return;
    }

    /// <summary>
    /// Function: MenuMostWanted
    /// </summary>
    public unsafe void MenuMostWanted(BmSDK.BmGame.RPlayerController RPC, out BmSDK.TArray<BmSDK.BmGame.RPersistentDebugData.FMostWantedDebugMenuData> Debug_MostWantedData, BmSDK.BmGame.RPersistentDebugData.MostWantedDebugMenuE Entry)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.MenuMostWanted", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Entry, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Debug_MostWantedData = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentDebugData.FMostWantedDebugMenuData>>(paramsPtr + 8);
        return;
    }

    /// <summary>
    /// Function: MenuMostWantedUnlockItem
    /// </summary>
    public unsafe void MenuMostWantedUnlockItem(BmSDK.BmGame.RPlayerController RPC, out BmSDK.TArray<BmSDK.BmGame.RPersistentDebugData.FMostWantedDebugMenuData> Debug_MostWantedData, BmSDK.BmGame.RPersistentDebugData.MostWantedDebugMenuE Entry)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.MenuMostWantedUnlockItem", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Entry, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Debug_MostWantedData = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentDebugData.FMostWantedDebugMenuData>>(paramsPtr + 8);
        return;
    }

    /// <summary>
    /// Function: MenuMostWantedCollapseAll
    /// </summary>
    public unsafe void MenuMostWantedCollapseAll(out BmSDK.TArray<BmSDK.BmGame.RPersistentDebugData.FMostWantedDebugMenuData> Debug_MostWantedData)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.MenuMostWantedCollapseAll", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Debug_MostWantedData = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentDebugData.FMostWantedDebugMenuData>>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: DoMostWantedMenu
    /// </summary>
    public unsafe void DoMostWantedMenu(BmSDK.BmGame.RPlayerController RPC, out BmSDK.TArray<BmSDK.BmGame.RPersistentDebugData.FMostWantedDebugMenuData> Debug_MostWantedData)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.DoMostWantedMenu", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Debug_MostWantedData = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentDebugData.FMostWantedDebugMenuData>>(paramsPtr + 8);
        return;
    }

    /// <summary>
    /// Function: ModifyBaseProperties
    /// </summary>
    public unsafe bool ModifyBaseProperties(int Index)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.ModifyBaseProperties", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: FindOrAddMission
    /// </summary>
    public unsafe int FindOrAddMission(BmSDK.BmGame.RPlayerController RPC, BmSDK.FString MissionName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.FindOrAddMission", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MissionName, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: RItemFlag
    /// </summary>
    public unsafe bool RItemFlag(BmSDK.FString DisplayString, BmSDK.FString FlagName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.RItemFlag", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DisplayString, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlagName, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: GivePlayerWeapon
    /// </summary>
    public unsafe void GivePlayerWeapon()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.GivePlayerWeapon", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetTakedownObjects
    /// </summary>
    public unsafe void ResetTakedownObjects()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.ResetTakedownObjects", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateDebrisMaxHeightComponent
    /// </summary>
    public unsafe void UpdateDebrisMaxHeightComponent()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.UpdateDebrisMaxHeightComponent", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DettachDebrisMaxHeightStaticMeshComponentFromPlayer
    /// </summary>
    public unsafe void DettachDebrisMaxHeightStaticMeshComponentFromPlayer()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.DettachDebrisMaxHeightStaticMeshComponentFromPlayer", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AttachDebrisMaxHeightStaticMeshComponentToPlayer
    /// </summary>
    public unsafe void AttachDebrisMaxHeightStaticMeshComponentToPlayer()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.AttachDebrisMaxHeightStaticMeshComponentToPlayer", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnMenuClosed
    /// </summary>
    public unsafe void OnMenuClosed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.OnMenuClosed", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnMenuOpened
    /// </summary>
    public unsafe void OnMenuOpened()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.OnMenuOpened", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowVersionInfo
    /// </summary>
    public unsafe void ShowVersionInfo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.ShowVersionInfo", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowSoloEventInfo
    /// </summary>
    public unsafe void ShowSoloEventInfo(BmSDK.BmGame.RAlertEventCoordinatorSolo AEC, int IndentDepth = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.ShowSoloEventInfo", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AEC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IndentDepth, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowEventInfo
    /// </summary>
    public unsafe void ShowEventInfo(BmSDK.BmGame.RAlertEventCoordinatorBase AEC, int IndentDepth = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.ShowEventInfo", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AEC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IndentDepth, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoDifficultyProgressionMenu
    /// </summary>
    public unsafe void DoDifficultyProgressionMenu()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.DoDifficultyProgressionMenu", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoVehiclesMenu
    /// </summary>
    public unsafe void DoVehiclesMenu()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.DoVehiclesMenu", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoVehiclePhysicsMenu
    /// </summary>
    public unsafe void DoVehiclePhysicsMenu()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.DoVehiclePhysicsMenu", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoVehicleDifficultyMenu
    /// </summary>
    public unsafe void DoVehicleDifficultyMenu()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.DoVehicleDifficultyMenu", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoBatmobileHandlingSwitch
    /// </summary>
    public unsafe void DoBatmobileHandlingSwitch()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.DoBatmobileHandlingSwitch", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoGadgetsMenu
    /// </summary>
    public unsafe void DoGadgetsMenu()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.DoGadgetsMenu", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoBatgirlDebugMenu
    /// </summary>
    public unsafe void DoBatgirlDebugMenu()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.DoBatgirlDebugMenu", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoHarleyDebugMenu
    /// </summary>
    public unsafe void DoHarleyDebugMenu()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.DoHarleyDebugMenu", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoBossMenu
    /// </summary>
    public unsafe void DoBossMenu()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.DoBossMenu", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ItemGadget
    /// </summary>
    public unsafe bool ItemGadget(BmSDK.FString GadgetName, BmSDK.BmGame.RInventoryGadget Gadget, BmSDK.Class GadgetClass)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.ItemGadget", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GadgetName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Gadget, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GadgetClass, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: AddApexClothMenu
    /// </summary>
    public unsafe void AddApexClothMenu()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.AddApexClothMenu", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddDestructiblesMenu
    /// </summary>
    public unsafe void AddDestructiblesMenu()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.AddDestructiblesMenu", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoMenuItems
    /// </summary>
    public unsafe void DoMenuItems()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.DoMenuItems", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoTableOfContentMenu
    /// </summary>
    public unsafe void DoTableOfContentMenu()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.DoTableOfContentMenu", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetLevelVisible
    /// </summary>
    public unsafe void SetLevelVisible(BmSDK.FString LevelName, BmSDK.FString LevelType, bool bVisible)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.SetLevelVisible", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LevelName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LevelType, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoCapeMenuItems
    /// </summary>
    public unsafe void DoCapeMenuItems(BmSDK.Engine.Actor BatmanActor, bool bCapeEnableOnly = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.DoCapeMenuItems", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatmanActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCapeEnableOnly, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoCapeDebugStateChangeMenu
    /// </summary>
    public unsafe void DoCapeDebugStateChangeMenu(BmSDK.BmGame.RCapeComponent CapeComponent)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.DoCapeDebugStateChangeMenu", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CapeComponent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetCapeComponentFromActor
    /// </summary>
    public unsafe BmSDK.BmGame.RCapeComponent GetCapeComponentFromActor(BmSDK.Engine.Actor BatmanActor)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.GetCapeComponentFromActor", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatmanActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCapeComponent>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: DoAiThoughtsMenu
    /// </summary>
    public unsafe void DoAiThoughtsMenu()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.DoAiThoughtsMenu", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoBatmanStrikeListMenu
    /// </summary>
    public unsafe void DoBatmanStrikeListMenu()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.DoBatmanStrikeListMenu", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoVehicleEnemyMenu
    /// </summary>
    public unsafe bool DoVehicleEnemyMenu()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.DoVehicleEnemyMenu", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: DoTakedownTestMenu
    /// </summary>
    public unsafe void DoTakedownTestMenu()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.DoTakedownTestMenu", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoRandomPopulationMenu
    /// </summary>
    public unsafe void DoRandomPopulationMenu()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.DoRandomPopulationMenu", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoPSCMenu
    /// </summary>
    public unsafe void DoPSCMenu(bool NoTitle = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.DoPSCMenu", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NoTitle, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoPerCharacterTypeAudioItems
    /// </summary>
    public unsafe void DoPerCharacterTypeAudioItems(out BmSDK.BmGame.RPersistentDebugData.FPerCharacterTypeAnimDebug Options, BmSDK.FString CharacterName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.DoPerCharacterTypeAudioItems", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterName, paramsPtr + 48);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Options = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentDebugData.FPerCharacterTypeAnimDebug>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: DoCinematicAnimItems
    /// </summary>
    public unsafe void DoCinematicAnimItems(out BmSDK.BmGame.RPersistentDebugData.FCinematicAnimDebug Options)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.DoCinematicAnimItems", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Options = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentDebugData.FCinematicAnimDebug>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: DoVehicleAnimItems
    /// </summary>
    public unsafe void DoVehicleAnimItems(out BmSDK.BmGame.RPersistentDebugData.FVehicleAnimDebug Options, BmSDK.FString MenuName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.DoVehicleAnimItems", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MenuName, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Options = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentDebugData.FVehicleAnimDebug>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: DoPerCharacterTypeAnimItems
    /// </summary>
    public unsafe void DoPerCharacterTypeAnimItems(out BmSDK.BmGame.RPersistentDebugData.FPerCharacterTypeAnimDebug Options, BmSDK.FString CharacterName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.DoPerCharacterTypeAnimItems", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CharacterName, paramsPtr + 48);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Options = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentDebugData.FPerCharacterTypeAnimDebug>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDebugMenuContent.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: EPopulationType
    /// </summary>
    public enum EPopulationType
    {
        POPTYPE_All = 0,
        POPTYPE_Vehicles = 1,
        POPTYPE_Formations = 2,
        POPTYPE_Riots = 3,
        POPTYPE_MAX = 4,
    }

    /// <summary>
    /// ObjectProperty: GameInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo GameInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// ComponentProperty: DebrisMaxHeightStaticMeshComponent
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent DebrisMaxHeightStaticMeshComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// ComponentProperty: AudioComponent
    /// </summary>
    public unsafe BmSDK.Engine.AudioComponent AudioComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AudioComponent>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: ConsoleEventsOpen
    /// </summary>
    public unsafe bool ConsoleEventsOpen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: bStatUnit
    /// </summary>
    public unsafe bool bStatUnit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: bEnableSharedCapeOptions
    /// </summary>
    public unsafe bool bEnableSharedCapeOptions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: RopeOptions
    /// </summary>
    public unsafe bool RopeOptions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: PhysicsOptions
    /// </summary>
    public unsafe bool PhysicsOptions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: DepthBiasOptions
    /// </summary>
    public unsafe bool DepthBiasOptions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: OceanBuoyancyOptions
    /// </summary>
    public unsafe bool OceanBuoyancyOptions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: bDebrisMaxHeightStaticMeshComponentAttached
    /// </summary>
    public unsafe bool bDebrisMaxHeightStaticMeshComponentAttached
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: bShowCurrentDistrictScenarios
    /// </summary>
    public unsafe bool bShowCurrentDistrictScenarios
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// ArrayProperty: ConsoleEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ConsoleEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ArrayProperty: ConsoleEventDescs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ConsoleEventDescs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// IntProperty: ConsoleEventIndex
    /// </summary>
    public unsafe int ConsoleEventIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// ArrayProperty: LevelStreamingTypes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> LevelStreamingTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// IntProperty: AngleAudioComponent
    /// </summary>
    public unsafe int AngleAudioComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// IntProperty: LevelStreamingOptions
    /// </summary>
    public unsafe int LevelStreamingOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// IntProperty: CurrDebugCapeStateChangeSetting
    /// </summary>
    public unsafe int CurrDebugCapeStateChangeSetting
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// IntProperty: VehEncounterType
    /// </summary>
    public unsafe int VehEncounterType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// IntProperty: PrevDrawDestructiblesMode
    /// </summary>
    public unsafe int PrevDrawDestructiblesMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// ArrayProperty: CachedPopulationActions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SequenceObject> CachedPopulationActions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SequenceObject>>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// ArrayProperty: PopulationTypes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> PopulationTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// IntProperty: PopTypeIdx
    /// </summary>
    public unsafe int PopTypeIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// FloatProperty: PopulationWarmUpTime
    /// </summary>
    public unsafe float PopulationWarmUpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }
}
