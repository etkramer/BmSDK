#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnVillainGunBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RPawnVillainGunBase : BmSDK.BmGame.RPawnVillain, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnVillainGunBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnVillainGunBase() { }

    /// <summary>
    /// Constructs a new RPawnVillainGunBase
    /// </summary>
    public RPawnVillainGunBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnVillainGunBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnVillainGunBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainGunBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ComponentProperty: GoggleVFX
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent GoggleVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 6664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6664); }
    }

    /// <summary>
    /// ObjectProperty: GoggleVFXMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant GoggleVFXMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 6672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6672); }
    }

    /// <summary>
    /// ObjectProperty: GuardVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RGuardVolume GuardVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGuardVolume>(Ptr + 6680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6680); }
    }

    /// <summary>
    /// ComponentProperty: OldPlayerInteractions
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent OldPlayerInteractions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 6688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6688); }
    }

    /// <summary>
    /// ComponentProperty: HostageTakerInteractions
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent HostageTakerInteractions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 6696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6696); }
    }

    /// <summary>
    /// FloatProperty: WarmUpTimer
    /// </summary>
    public unsafe float WarmUpTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6704); }
    }

    /// <summary>
    /// FloatProperty: SearchSpecialMoveTime
    /// </summary>
    public unsafe float SearchSpecialMoveTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6708); }
    }

    /// <summary>
    /// FloatProperty: LastDisarmTime
    /// </summary>
    public unsafe float LastDisarmTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6712); }
    }

    /// <summary>
    /// ByteProperty: CurrentGoggleState
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillainGunBase.ThermalGoggleState CurrentGoggleState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillainGunBase.ThermalGoggleState>(Ptr + 6716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6716); }
    }

    /// <summary>
    /// FloatProperty: GoggleVFXCycleTimer
    /// </summary>
    public unsafe float GoggleVFXCycleTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6720); }
    }

    /// <summary>
    /// BoolProperty: bGoggleCycleOn
    /// </summary>
    public unsafe bool bGoggleCycleOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6724) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6724); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6724); }
    }

    /// <summary>
    /// BoolProperty: bForceNoXPBankWhileAlive
    /// </summary>
    public unsafe bool bForceNoXPBankWhileAlive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6724) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6724); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6724); }
    }

    /// <summary>
    /// FloatProperty: RECDisableSpecialsTime
    /// </summary>
    public unsafe float RECDisableSpecialsTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6728); }
    }

    /// <summary>
    /// IntProperty: bHasDoneJokerWalk
    /// </summary>
    public unsafe int bHasDoneJokerWalk
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6732); }
    }

    /// <summary>
    /// ArrayProperty: JokerNervousSyncWalks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> JokerNervousSyncWalks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 6736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6736); }
    }
}
