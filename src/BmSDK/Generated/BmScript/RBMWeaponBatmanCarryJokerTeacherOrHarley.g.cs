#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMWeaponBatmanCarryJokerTeacherOrHarley<br/>
/// (size = 1756)
/// (flags = 10485810)
/// </summary>
public partial class RBMWeaponBatmanCarryJokerTeacherOrHarley : BmSDK.BmGame.RBMWeapon, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMWeaponBatmanCarryJokerTeacherOrHarley", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMWeaponBatmanCarryJokerTeacherOrHarley() { }

    /// <summary>
    /// Constructs a new RBMWeaponBatmanCarryJokerTeacherOrHarley
    /// </summary>
    public RBMWeaponBatmanCarryJokerTeacherOrHarley(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMWeaponBatmanCarryJokerTeacherOrHarley Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMWeaponBatmanCarryJokerTeacherOrHarley(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMWeaponBatmanCarryJokerTeacherOrHarley>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeaponBatmanCarryJokerTeacherOrHarley>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMWeaponBatmanCarryJokerTeacherOrHarley>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeaponBatmanCarryJokerTeacherOrHarley>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeaponBatmanCarryJokerTeacherOrHarley>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMWeaponBatmanCarryJokerTeacherOrHarley>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeaponBatmanCarryJokerTeacherOrHarley>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: CreateWeaponConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RWeaponConfig CreateWeaponConfig(BmSDK.GameObject NewOwner)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMWeaponBatmanCarryJokerTeacherOrHarley.CreateWeaponConfig", true);
        byte* paramsPtr = stackalloc byte[1512];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: ItemRemovedFromInvManager
    /// </summary>
    public unsafe void ItemRemovedFromInvManager()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMWeaponBatmanCarryJokerTeacherOrHarley.ItemRemovedFromInvManager", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GivenTo
    /// </summary>
    public unsafe void GivenTo(BmSDK.Engine.Pawn thisPawn, bool bDoNotActivate = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMWeaponBatmanCarryJokerTeacherOrHarley.GivenTo", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(thisPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoNotActivate, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: CarryAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet CarryAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 1748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1748); }
    }
}
