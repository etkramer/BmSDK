#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_DodgeProjectile<br/>
/// (size = 428)
/// (flags = 8210)
/// </summary>
public partial class RBMBehaviour_DodgeProjectile : BmSDK.BmGame.RBMBehaviour, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_DodgeProjectile", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_DodgeProjectile() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_DodgeProjectile
    /// </summary>
    public RBMBehaviour_DodgeProjectile(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_DodgeProjectile Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_DodgeProjectile(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_DodgeProjectile>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_DodgeProjectile>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_DodgeProjectile>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_DodgeProjectile>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_DodgeProjectile>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_DodgeProjectile>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMBehaviour_DodgeProjectile>
        => ((GameObject)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: OnDeactivate
    /// </summary>
    public unsafe override void OnDeactivate()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBehaviour_DodgeProjectile.OnDeactivate", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanDodgeProjectile
    /// </summary>
    public unsafe override bool CanDodgeProjectile(System.Numerics.Vector3 ThrownFromPos, int CheckBatarangID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBehaviour_DodgeProjectile.CanDodgeProjectile", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrownFromPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckBatarangID, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: CanDodgeToPoint
    /// </summary>
    public unsafe virtual bool CanDodgeToPoint(System.Numerics.Vector3 DodgePoint)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBehaviour_DodgeProjectile.CanDodgeToPoint", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DodgePoint, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: AlreadyDodging
    /// </summary>
    public unsafe virtual bool AlreadyDodging()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBehaviour_DodgeProjectile.AlreadyDodging", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanDodgeLineLaunchKick
    /// </summary>
    public unsafe override bool CanDodgeLineLaunchKick(BmSDK.BmGame.RPawnPlayer Attacker, System.Numerics.Vector3 KickDirection)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBehaviour_DodgeProjectile.CanDodgeLineLaunchKick", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KickDirection, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: CanDodgeAgain
    /// </summary>
    public unsafe virtual void CanDodgeAgain()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBehaviour_DodgeProjectile.CanDodgeAgain", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetThrower
    /// </summary>
    public unsafe virtual void SetThrower(BmSDK.BmGame.RPawn NewThrower, BmSDK.FName NewTargetBone, int NewBatarangID, bool bNewPredAttackOnFinish)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBehaviour_DodgeProjectile.SetThrower", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewThrower, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTargetBone, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBatarangID, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewPredAttackOnFinish, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: Thrower
    /// </summary>
    public unsafe BmSDK.BmGame.RPawn Thrower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawn>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// StructProperty: DodgeId
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId DodgeId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// NameProperty: TargetBone
    /// </summary>
    public unsafe BmSDK.FName TargetBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// FloatProperty: CanRedodgeTimer
    /// </summary>
    public unsafe float CanRedodgeTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// IntProperty: BatarangID
    /// </summary>
    public unsafe int BatarangID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// FloatProperty: WaitTime
    /// </summary>
    public unsafe float WaitTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bPredAttackOnFinish
    /// </summary>
    public unsafe bool bPredAttackOnFinish
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 424); }
    }

    /// <summary>
    /// BoolProperty: bCanDodgeAgain
    /// </summary>
    public unsafe bool bCanDodgeAgain
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 424); }
    }

    /// <summary>
    /// BoolProperty: bAllowDodgeAgain
    /// </summary>
    public unsafe bool bAllowDodgeAgain
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 424); }
    }

    /// <summary>
    /// BoolProperty: bDodgeLineLauncher
    /// </summary>
    public unsafe bool bDodgeLineLauncher
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 424); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 424); }
    }
}
