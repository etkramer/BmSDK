#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RPawnVillainMultiStage<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RPawnVillainMultiStage : BmSDK.BmGame.RPawnVillainMultiStageBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RPawnVillainMultiStage", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnVillainMultiStage() { }

    /// <summary>
    /// Constructs a new RPawnVillainMultiStage
    /// </summary>
    public RPawnVillainMultiStage(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnVillainMultiStage Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnVillainMultiStage(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMultiStage>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMultiStage>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMultiStage>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMultiStage>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMultiStage>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMultiStage>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainMultiStage>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: ArmourMic
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ArmourMic
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 6800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6800); }
    }

    /// <summary>
    /// ObjectProperty: ShieldAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ShieldAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 6808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6808); }
    }

    /// <summary>
    /// ObjectProperty: ArmourAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ArmourAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 6816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6816); }
    }

    /// <summary>
    /// ObjectProperty: BladeAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BladeAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 6824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6824); }
    }

    /// <summary>
    /// ObjectProperty: BlockSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BlockSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 6832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6832); }
    }

    /// <summary>
    /// ComponentProperty: BladeTrail
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BladeTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 6840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6840); }
    }

    /// <summary>
    /// ComponentProperty: BatarangOverride
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BatarangOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 6848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6848); }
    }

    /// <summary>
    /// FloatProperty: ArmourParam
    /// </summary>
    public unsafe float ArmourParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6856); }
    }

    /// <summary>
    /// FloatProperty: TargetArmourParam
    /// </summary>
    public unsafe float TargetArmourParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6860); }
    }

    /// <summary>
    /// ArrayProperty: ShieldStepList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RPawnVillainMultiStageBase.WeaponXrayMIC>>>>>> ShieldStepList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RPawnVillainMultiStageBase.WeaponXrayMIC>>>>>>>(Ptr + 6864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6864); }
    }

    /// <summary>
    /// NameProperty: ShieldForwardStepName
    /// </summary>
    public unsafe BmSDK.FName ShieldForwardStepName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6880); }
    }

    /// <summary>
    /// ArrayProperty: ArmourStepList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RPawnVillainMultiStageBase.WeaponXrayMIC>>>>> ArmourStepList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RPawnVillainMultiStageBase.WeaponXrayMIC>>>>>>(Ptr + 6888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6888); }
    }

    /// <summary>
    /// NameProperty: ArmourForwardStepName
    /// </summary>
    public unsafe BmSDK.FName ArmourForwardStepName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6904); }
    }

    /// <summary>
    /// ArrayProperty: BladeStepList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RPawnVillainMultiStageBase.WeaponXrayMIC>>>> BladeStepList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RPawnVillainMultiStageBase.WeaponXrayMIC>>>>>(Ptr + 6912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6912); }
    }

    /// <summary>
    /// NameProperty: BladeForwardStepName
    /// </summary>
    public unsafe BmSDK.FName BladeForwardStepName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6928); }
    }

    /// <summary>
    /// NameProperty: ThrowInAnimName
    /// </summary>
    public unsafe BmSDK.FName ThrowInAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6936); }
    }

    /// <summary>
    /// IntProperty: TakedownDamageAmount
    /// </summary>
    public unsafe int TakedownDamageAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6944); }
    }

    /// <summary>
    /// BoolProperty: bCanBeBataranged
    /// </summary>
    public unsafe bool bCanBeBataranged
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6948) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6948); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6948); }
    }

    /// <summary>
    /// BoolProperty: bSetHealthMaterial
    /// </summary>
    public unsafe bool bSetHealthMaterial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6948) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6948); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6948); }
    }

    /// <summary>
    /// ArrayProperty: ShieldMaterialIds
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RPawnVillainMultiStageBase.WeaponXrayMIC>>> ShieldMaterialIds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RPawnVillainMultiStageBase.WeaponXrayMIC>>>>(Ptr + 6952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6952); }
    }

    /// <summary>
    /// ArrayProperty: HandMaterialIds
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RPawnVillainMultiStageBase.WeaponXrayMIC>> HandMaterialIds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RPawnVillainMultiStageBase.WeaponXrayMIC>>>(Ptr + 6968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6968); }
    }

    /// <summary>
    /// ArrayProperty: BladeMaterialIds
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnVillainMultiStageBase.WeaponXrayMIC> BladeMaterialIds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnVillainMultiStageBase.WeaponXrayMIC>>(Ptr + 6984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6984); }
    }
}
