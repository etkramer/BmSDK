#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: InventoryManager<br/>
/// (size = 456)
/// (flags = 142606482)
/// </summary>
public partial class InventoryManager : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.InventoryManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as InventoryManager.
    /// </summary>
    public static InventoryManager DefaultObject => (InventoryManager)StaticClass().DefaultObject;

    internal InventoryManager() { }

    /// <summary>
    /// Constructs a new InventoryManager
    /// </summary>
    public InventoryManager(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InventoryManager Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InventoryManager(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<InventoryManager>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<InventoryManager>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<InventoryManager>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<InventoryManager>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<InventoryManager>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<InventoryManager>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<InventoryManager>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<InventoryManager>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: UpdateController
    /// </summary>
    public unsafe virtual void UpdateController()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.InventoryManager.UpdateController", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClientWeaponSet
    /// </summary>
    public unsafe virtual void ClientWeaponSet(BmSDK.Engine.Weapon NewWeapon, bool bOptionalSet, bool bDoNotActivate = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.InventoryManager.ClientWeaponSet", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeapon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOptionalSet, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoNotActivate, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ChangedWeapon
    /// </summary>
    public unsafe virtual void ChangedWeapon()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.InventoryManager.ChangedWeapon", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearPendingWeapon
    /// </summary>
    public unsafe virtual void ClearPendingWeapon()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.InventoryManager.ClearPendingWeapon", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CancelWeaponChange
    /// </summary>
    public unsafe virtual bool CancelWeaponChange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.InventoryManager.CancelWeaponChange", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetPendingWeapon
    /// </summary>
    public unsafe virtual void SetPendingWeapon(BmSDK.Engine.Weapon DesiredWeapon, BmSDK.FName MovementStance, BmSDK.FName WeaponStance)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.InventoryManager.SetPendingWeapon", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredWeapon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InternalSetCurrentWeapon
    /// </summary>
    public unsafe void InternalSetCurrentWeapon(BmSDK.Engine.Weapon DesiredWeapon, BmSDK.FName MovementStance = default, BmSDK.FName WeaponStance = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.InventoryManager.InternalSetCurrentWeapon", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredWeapon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ServerSetCurrentWeapon
    /// </summary>
    public unsafe virtual void ServerSetCurrentWeapon(BmSDK.Engine.Weapon DesiredWeapon, BmSDK.FName MovementStance = default, BmSDK.FName WeaponStance = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.InventoryManager.ServerSetCurrentWeapon", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredWeapon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetCurrentWeapon
    /// </summary>
    public unsafe virtual void SetCurrentWeapon(BmSDK.Engine.Weapon DesiredWeapon, BmSDK.FName MovementStance = default, BmSDK.FName WeaponStance = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.InventoryManager.SetCurrentWeapon", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredWeapon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NextWeapon
    /// </summary>
    public unsafe virtual void NextWeapon()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.InventoryManager.NextWeapon", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PrevWeapon
    /// </summary>
    public unsafe virtual void PrevWeapon()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.InventoryManager.PrevWeapon", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SwitchToBestWeapon
    /// </summary>
    public unsafe virtual void SwitchToBestWeapon(bool bForceADifferentWeapon = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.InventoryManager.SwitchToBestWeapon", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceADifferentWeapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetBestWeapon
    /// </summary>
    public unsafe virtual BmSDK.Engine.Weapon GetBestWeapon(bool bForceADifferentWeapon = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.InventoryManager.GetBestWeapon", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceADifferentWeapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Weapon>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetWeaponRatingFor
    /// </summary>
    public unsafe virtual float GetWeaponRatingFor(BmSDK.Engine.Weapon W)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.InventoryManager.GetWeaponRatingFor", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(W, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: DrawHUD
    /// </summary>
    public unsafe virtual void DrawHUD(BmSDK.Engine.HUD H)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.InventoryManager.DrawHUD", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(H, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OwnerDied
    /// </summary>
    public unsafe virtual void OwnerDied()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.InventoryManager.OwnerDied", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DiscardInventory
    /// </summary>
    public unsafe virtual void DiscardInventory()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.InventoryManager.DiscardInventory", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RemoveFromInventory
    /// </summary>
    public unsafe virtual void RemoveFromInventory(BmSDK.Engine.Inventory ItemToRemove)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.InventoryManager.RemoveFromInventory", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemToRemove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddInventory
    /// </summary>
    public unsafe virtual bool AddInventory(BmSDK.Engine.Inventory NewItem, bool bDoNotActivate = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.InventoryManager.AddInventory", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewItem, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoNotActivate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: CreateInventory
    /// </summary>
    public unsafe virtual BmSDK.Engine.Inventory CreateInventory(BmSDK.Class NewInventoryItemClass, bool bDoNotActivate = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.InventoryManager.CreateInventory", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewInventoryItemClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoNotActivate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Inventory>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: FindInventoryType
    /// </summary>
    public unsafe virtual BmSDK.Engine.Inventory FindInventoryType(BmSDK.Class DesiredClass, bool bAllowSubclass = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.InventoryManager.FindInventoryType", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowSubclass, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Inventory>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: HandlePickupQuery
    /// </summary>
    public unsafe virtual bool HandlePickupQuery(BmSDK.Class ItemClass, BmSDK.Engine.Actor Pickup)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.InventoryManager.HandlePickupQuery", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pickup, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.InventoryManager.Destroyed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetupFor
    /// </summary>
    public unsafe virtual void SetupFor(BmSDK.Engine.Pawn P)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.InventoryManager.SetupFor", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }


    /// <summary>
    /// Function: IsPendingFire
    /// </summary>
    public unsafe virtual bool IsPendingFire(BmSDK.Engine.Weapon InWeapon, int InFiringMode)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.InventoryManager.IsPendingFire", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InWeapon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InFiringMode, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: ClearPendingFire
    /// </summary>
    public unsafe virtual void ClearPendingFire(BmSDK.Engine.Weapon InWeapon, int InFiringMode)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.InventoryManager.ClearPendingFire", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InWeapon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InFiringMode, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetPendingFire
    /// </summary>
    public unsafe virtual void SetPendingFire(BmSDK.Engine.Weapon InWeapon, int InFiringMode)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.InventoryManager.SetPendingFire", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InWeapon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InFiringMode, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetPendingFireLength
    /// </summary>
    public unsafe virtual int GetPendingFireLength(BmSDK.Engine.Weapon InWeapon)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.InventoryManager.GetPendingFireLength", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InWeapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.InventoryManager.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: InventoryChain
    /// </summary>
    public unsafe BmSDK.Engine.Inventory InventoryChain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Inventory>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// ObjectProperty: PendingWeapon
    /// </summary>
    public unsafe BmSDK.Engine.Weapon PendingWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Weapon>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// ObjectProperty: LastAttemptedSwitchToWeapon
    /// </summary>
    public unsafe BmSDK.Engine.Weapon LastAttemptedSwitchToWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Weapon>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

    /// <summary>
    /// BoolProperty: bMustHoldWeapon
    /// </summary>
    public unsafe bool bMustHoldWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 440); }
    }

    /// <summary>
    /// ArrayProperty: PendingFire
    /// </summary>
    public unsafe BmSDK.TArray<int> PendingFire
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }
}
