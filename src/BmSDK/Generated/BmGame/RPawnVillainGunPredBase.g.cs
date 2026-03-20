#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnVillainGunPredBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RPawnVillainGunPredBase : BmSDK.BmGame.RPawnVillainGunBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnVillainGunPredBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnVillainGunPredBase() { }

    /// <summary>
    /// Constructs a new RPawnVillainGunPredBase
    /// </summary>
    public RPawnVillainGunPredBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnVillainGunPredBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnVillainGunPredBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunPredBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// IntProperty: GrenadeLeftIndex
    /// </summary>
    public unsafe int GrenadeLeftIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6752); }
    }

    /// <summary>
    /// IntProperty: GrenadeRightIndex
    /// </summary>
    public unsafe int GrenadeRightIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6756); }
    }

    /// <summary>
    /// IntProperty: VantageMineIndex
    /// </summary>
    public unsafe int VantageMineIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6760); }
    }

    /// <summary>
    /// BoolProperty: bCanEnterLevelScriptingWhileCocky
    /// </summary>
    public unsafe bool bCanEnterLevelScriptingWhileCocky
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6764) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6764); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6764); }
    }

    /// <summary>
    /// BoolProperty: bDMDDetecting
    /// </summary>
    public unsafe bool bDMDDetecting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6764) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6764); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6764); }
    }

    /// <summary>
    /// BoolProperty: lastDMDSignalSucceeded
    /// </summary>
    public unsafe bool lastDMDSignalSucceeded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6764) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6764); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6764); }
    }

    /// <summary>
    /// BoolProperty: bDMDExploded
    /// </summary>
    public unsafe bool bDMDExploded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6764) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6764); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6764); }
    }

    /// <summary>
    /// BoolProperty: bHasDroneRemoteEquipped
    /// </summary>
    public unsafe bool bHasDroneRemoteEquipped
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6764) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6764); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6764); }
    }

    /// <summary>
    /// BoolProperty: bHasNoticedDisruptedDroneRemote
    /// </summary>
    public unsafe bool bHasNoticedDisruptedDroneRemote
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6764) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6764); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6764); }
    }

    /// <summary>
    /// BoolProperty: bSpawnedArmband
    /// </summary>
    public unsafe bool bSpawnedArmband
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6764) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6764); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6764); }
    }

    /// <summary>
    /// FloatProperty: GoggleBlindTime
    /// </summary>
    public unsafe float GoggleBlindTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6768); }
    }

    /// <summary>
    /// FloatProperty: lastDMDSignalLineTime
    /// </summary>
    public unsafe float lastDMDSignalLineTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6772); }
    }

    /// <summary>
    /// FloatProperty: lastDMDDeactivateTime
    /// </summary>
    public unsafe float lastDMDDeactivateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6776); }
    }

    /// <summary>
    /// FloatProperty: lastDMDSignalLostTime
    /// </summary>
    public unsafe float lastDMDSignalLostTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6780); }
    }

    /// <summary>
    /// ObjectProperty: BankDoorPanel
    /// </summary>
    public unsafe BmSDK.BmGame.RBankDoorControlPanelBase BankDoorPanel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBankDoorControlPanelBase>(Ptr + 6784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6784); }
    }
}
