#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMWeaponCombatExpertSword<br/>
/// (size = 1756)
/// (flags = 10485810)
/// </summary>
public partial class RBMWeaponCombatExpertSword : BmSDK.BmGame.RBMWeaponMelee, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMWeaponCombatExpertSword", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMWeaponCombatExpertSword() { }

    /// <summary>
    /// Constructs a new RBMWeaponCombatExpertSword
    /// </summary>
    public RBMWeaponCombatExpertSword(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMWeaponCombatExpertSword Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMWeaponCombatExpertSword(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMWeaponCombatExpertSword>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeaponCombatExpertSword>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMWeaponCombatExpertSword>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeaponCombatExpertSword>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeaponCombatExpertSword>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMWeaponCombatExpertSword>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeaponCombatExpertSword>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: GetCounterAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet GetCounterAnimSet(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMWeaponCombatExpertSword.GetCounterAnimSet", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GetBMCounterAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet GetBMCounterAnimSet(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMWeaponCombatExpertSword.GetBMCounterAnimSet", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GetRECHitReactionAnimName
    /// </summary>
    public unsafe BmSDK.FName GetRECHitReactionAnimName()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMWeaponCombatExpertSword.GetRECHitReactionAnimName", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetFearTakedownReactionAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet GetFearTakedownReactionAnimset()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMWeaponCombatExpertSword.GetFearTakedownReactionAnimset", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: InitialisePlayerSpecificAnimsets
    /// </summary>
    public unsafe void InitialisePlayerSpecificAnimsets(BmSDK.BmGame.RPawnPlayerCombat NewPlayer, int PlayerIndex)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMWeaponCombatExpertSword.InitialisePlayerSpecificAnimsets", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIndex, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetMultiAttackAnimNames
    /// </summary>
    public unsafe void GetMultiAttackAnimNames(out BmSDK.FName IntroName, out BmSDK.FName AttackName, out BmSDK.FName FailName, out BmSDK.FName CounterName, BmSDK.BmGame.RPawnPlayerCombat Player)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMWeaponCombatExpertSword.GetMultiAttackAnimNames", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        IntroName = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
        AttackName = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 8);
        FailName = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 16);
        CounterName = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 24);
        return;
    }

    /// <summary>
    /// Function: GetRECPriority
    /// </summary>
    public unsafe float GetRECPriority()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMWeaponCombatExpertSword.GetRECPriority", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CreateWeaponConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RWeaponConfig CreateWeaponConfig(BmSDK.GameObject NewOwner)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMWeaponCombatExpertSword.CreateWeaponConfig", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: CreateCombatWeaponConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RWeaponConfig CreateCombatWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.Engine.AnimSet AnimSet1, BmSDK.Engine.AnimSet AnimSet2, BmSDK.Engine.AnimSet AnimSet3, BmSDK.Engine.AnimSet AnimSet4)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMWeaponCombatExpertSword.CreateCombatWeaponConfig", true);
        byte* paramsPtr = stackalloc byte[6364];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet1, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet2, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet3, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet4, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 40);
    }

    /// <summary>
    /// Function: HideWeapon
    /// </summary>
    public unsafe void HideWeapon()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMWeaponCombatExpertSword.HideWeapon", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetCombatAimingConfig
    /// </summary>
    public unsafe static BmSDK.Engine.RAimingConfig GetCombatAimingConfig()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMWeaponCombatExpertSword.GetCombatAimingConfig", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAimingConfig>(paramsPtr + 0);
    }

    /// <summary>
    /// ObjectProperty: BatclawAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BatclawAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 1748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1748); }
    }
}
