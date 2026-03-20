#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RWhipBase<br/>
/// (flags = 0)
/// </summary>
public partial class RWhipBase : BmSDK.BmGame.RInventoryGadget, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RWhipBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RWhipBase() { }

    /// <summary>
    /// Constructs a new RWhipBase
    /// </summary>
    public RWhipBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RWhipBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RWhipBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RWhipBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RWhipBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RWhipBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RWhipBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RWhipBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RWhipBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RWhipBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ByteProperty: GadgetState
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.GadgetEquipState GadgetState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.GadgetEquipState>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// ByteProperty: GadgetType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction GadgetType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 785); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 785); }
    }

    /// <summary>
    /// ByteProperty: QuickGadgetType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction QuickGadgetType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 786); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 786); }
    }

    /// <summary>
    /// ByteProperty: ThrowType
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.BatarangThrowType ThrowType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.BatarangThrowType>(Ptr + 787); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 787); }
    }

    /// <summary>
    /// ByteProperty: HudGadgetId
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.FGadgetIDs HudGadgetId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.FGadgetIDs>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ByteProperty: HudSlot
    /// </summary>
    public unsafe byte HudSlot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 789); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 789); }
    }

    /// <summary>
    /// ByteProperty: HudSlotPC
    /// </summary>
    public unsafe byte HudSlotPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 790); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 790); }
    }

    /// <summary>
    /// ComponentProperty: Mesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent Mesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// ComponentProperty: Mesh2
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent Mesh2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// ObjectProperty: XrayMaskMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface XrayMaskMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// ObjectProperty: CachedTargetClass
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass CachedTargetClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// ObjectProperty: GadgetSelectMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface GadgetSelectMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// ObjectProperty: GetOutSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GetOutSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// ObjectProperty: OverrideTargets
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass OverrideTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// ObjectProperty: LastPlayedGadgetSpeech
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech LastPlayedGadgetSpeech
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// ObjectProperty: FailedGadgetSpeechReplacementSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FailedGadgetSpeechReplacementSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// ComponentProperty: XrayMaskMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent XrayMaskMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// NameProperty: CurrEquippedBoneName
    /// </summary>
    public unsafe BmSDK.FName CurrEquippedBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// NameProperty: CurrEquippedBoneName2
    /// </summary>
    public unsafe BmSDK.FName CurrEquippedBoneName2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// NameProperty: EquipBoneName
    /// </summary>
    public unsafe BmSDK.FName EquipBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// NameProperty: EquipBoneName2
    /// </summary>
    public unsafe BmSDK.FName EquipBoneName2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// NameProperty: ThrowEquipBoneNameOverride
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneNameOverride_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneNameOverride
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneNameOverride_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneNameOverride
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneNameOverride_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneNameOverride
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneNameOverride_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneNameOverride
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneNameOverride_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneNameOverride
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneNameOverride_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneNameOverride
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneNameOverride_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneNameOverride
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneNameOverride_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneNameOverride
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneNameOverride_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneNameOverride
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneNameOverride_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneNameOverride
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneNameOverride_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneNameOverride
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneNameOverride_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneNameOverride
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneNameOverride_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// NameProperty: ThrowEquipBoneName2Override
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneName2Override_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneName2Override
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneName2Override_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneName2Override
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneName2Override_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneName2Override
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneName2Override_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneName2Override
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneName2Override_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneName2Override
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneName2Override_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneName2Override
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneName2Override_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneName2Override
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneName2Override_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneName2Override
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneName2Override_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneName2Override
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneName2Override_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneName2Override
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneName2Override_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneName2Override
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneName2Override_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }
    /// <summary>
    /// NameProperty: ThrowEquipBoneName2Override
    /// </summary>
    public unsafe BmSDK.FName ThrowEquipBoneName2Override_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// NameProperty: UnequipBoneName
    /// </summary>
    public unsafe BmSDK.FName UnequipBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bSelectable
    /// </summary>
    public unsafe bool bSelectable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bAiming
    /// </summary>
    public unsafe bool bAiming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bAutomaticAiming
    /// </summary>
    public unsafe bool bAutomaticAiming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bNoQuickFire
    /// </summary>
    public unsafe bool bNoQuickFire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bUnequipToSocket
    /// </summary>
    public unsafe bool bUnequipToSocket
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bCanUseXRay
    /// </summary>
    public unsafe bool bCanUseXRay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bCanRechargeFromZeroAmmo
    /// </summary>
    public unsafe bool bCanRechargeFromZeroAmmo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bUsableFromVantagePoints
    /// </summary>
    public unsafe bool bUsableFromVantagePoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bUsableFromCornerCover
    /// </summary>
    public unsafe bool bUsableFromCornerCover
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bUsableFromCrawlSpace
    /// </summary>
    public unsafe bool bUsableFromCrawlSpace
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bNotUsableFromWire
    /// </summary>
    public unsafe bool bNotUsableFromWire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bLeaveCoverAfterThrow
    /// </summary>
    public unsafe bool bLeaveCoverAfterThrow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bCanUseFromSilentPredator
    /// </summary>
    public unsafe bool bCanUseFromSilentPredator
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bDontLockCornerAiming
    /// </summary>
    public unsafe bool bDontLockCornerAiming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bForceShowGadget
    /// </summary>
    public unsafe bool bForceShowGadget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bRunningThrow
    /// </summary>
    public unsafe bool bRunningThrow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bCanEquipWhileRecharging
    /// </summary>
    public unsafe bool bCanEquipWhileRecharging
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bCanEquipWhileFlying
    /// </summary>
    public unsafe bool bCanEquipWhileFlying
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bSelectableLast
    /// </summary>
    public unsafe bool bSelectableLast
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: AutoTargetRequiresLOS
    /// </summary>
    public unsafe bool AutoTargetRequiresLOS
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: MustAutoTarget
    /// </summary>
    public unsafe bool MustAutoTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bUseAbsoluteTurnForGetOut
    /// </summary>
    public unsafe bool bUseAbsoluteTurnForGetOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bUseRechargeDisplay
    /// </summary>
    public unsafe bool bUseRechargeDisplay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bDoLOSCheckFromPawn
    /// </summary>
    public unsafe bool bDoLOSCheckFromPawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bGadgetCanBeMirrored
    /// </summary>
    public unsafe bool bGadgetCanBeMirrored
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bRecharging
    /// </summary>
    public unsafe bool bRecharging
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bHighlighted
    /// </summary>
    public unsafe bool bHighlighted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bXRayMode
    /// </summary>
    public unsafe bool bXRayMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bAllowGrappleUse
    /// </summary>
    public unsafe bool bAllowGrappleUse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bReverseButtonControlsOnPS3
    /// </summary>
    public unsafe bool bReverseButtonControlsOnPS3
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bEmergencyFire
    /// </summary>
    public unsafe bool bEmergencyFire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bOverriddenCombatMove
    /// </summary>
    public unsafe bool bOverriddenCombatMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bOverrideAllowRun
    /// </summary>
    public unsafe bool bOverrideAllowRun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysUseHorizontalAutoTargetHelp
    /// </summary>
    public unsafe bool bAlwaysUseHorizontalAutoTargetHelp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bQuickGlideGadget
    /// </summary>
    public unsafe bool bQuickGlideGadget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bCanUseInteractableItemWhileAiming
    /// </summary>
    public unsafe bool bCanUseInteractableItemWhileAiming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bNeverTargetOffscreen
    /// </summary>
    public unsafe bool bNeverTargetOffscreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreAngleCheck
    /// </summary>
    public unsafe bool bIgnoreAngleCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bGetOutSoundIsLooping
    /// </summary>
    public unsafe bool bGetOutSoundIsLooping
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: ShownNoGadget
    /// </summary>
    public unsafe bool ShownNoGadget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bKeepCursorsWhenHolstered
    /// </summary>
    public unsafe bool bKeepCursorsWhenHolstered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bSharedWithNewGamePlus
    /// </summary>
    public unsafe bool bSharedWithNewGamePlus
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bRequiresPawnForLOS
    /// </summary>
    public unsafe bool bRequiresPawnForLOS
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bHideHighlightsInDetectiveMode
    /// </summary>
    public unsafe bool bHideHighlightsInDetectiveMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bDontAutoTargetDown
    /// </summary>
    public unsafe bool bDontAutoTargetDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bOverrideWorldPPSettings
    /// </summary>
    public unsafe bool bOverrideWorldPPSettings
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bOverrideTargetWeightsWhenZoomed
    /// </summary>
    public unsafe bool bOverrideTargetWeightsWhenZoomed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// NameProperty: GlobalFlag
    /// </summary>
    public unsafe BmSDK.FName GlobalFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// IntProperty: MaxAmmo
    /// </summary>
    public unsafe int MaxAmmo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// IntProperty: Ammo
    /// </summary>
    public unsafe int Ammo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// FloatProperty: CurrentRechargeTime
    /// </summary>
    public unsafe float CurrentRechargeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// IntProperty: CurrentRechargeValOverride
    /// </summary>
    public unsafe int CurrentRechargeValOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// FloatProperty: InterThrowRechargeTime
    /// </summary>
    public unsafe float InterThrowRechargeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// IntProperty: UpgradeLevel
    /// </summary>
    public unsafe int UpgradeLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }

    /// <summary>
    /// IntProperty: MaxUpgradeLevel
    /// </summary>
    public unsafe int MaxUpgradeLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// IntProperty: AutoTargetAnglePower
    /// </summary>
    public unsafe int AutoTargetAnglePower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// FloatProperty: AutoTargetAngleWeight
    /// </summary>
    public unsafe float AutoTargetAngleWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// FloatProperty: AutoTargetRangeWeight
    /// </summary>
    public unsafe float AutoTargetRangeWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1172); }
    }

    /// <summary>
    /// StructProperty: AutoTargetExtCamRotationOffset
    /// </summary>
    public unsafe BmSDK.Rotator AutoTargetExtCamRotationOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// IntProperty: MaxCornerViewAngle
    /// </summary>
    public unsafe int MaxCornerViewAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }

    /// <summary>
    /// IntProperty: AmmoLast
    /// </summary>
    public unsafe int AmmoLast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// FloatProperty: LookSensitivity
    /// </summary>
    public unsafe float LookSensitivity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// StructProperty: ThrowTransition
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId ThrowTransition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// NameProperty: TargetClass
    /// </summary>
    public unsafe BmSDK.FName TargetClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1204); }
    }

    /// <summary>
    /// NameProperty: CachedTargetClassName
    /// </summary>
    public unsafe BmSDK.FName CachedTargetClassName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1212); }
    }

    /// <summary>
    /// StructProperty: EmergencyThrowDirection
    /// </summary>
    public unsafe System.Numerics.Vector3 EmergencyThrowDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1220); }
    }

    /// <summary>
    /// FloatProperty: AutoTargetPlaneOffset
    /// </summary>
    public unsafe float AutoTargetPlaneOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }

    /// <summary>
    /// StrProperty: TutorialText
    /// </summary>
    public unsafe BmSDK.FString TutorialText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1236); }
    }

    /// <summary>
    /// StrProperty: TutorialFlag
    /// </summary>
    public unsafe BmSDK.FString TutorialFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }

    /// <summary>
    /// StrProperty: GlidingSuccessIcon
    /// </summary>
    public unsafe BmSDK.FString GlidingSuccessIcon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }

    /// <summary>
    /// IntProperty: CurrHuDAmmo
    /// </summary>
    public unsafe int CurrHuDAmmo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }

    /// <summary>
    /// IntProperty: CurrHuDRecharge
    /// </summary>
    public unsafe int CurrHuDRecharge
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// FloatProperty: DefaultHighlightTimerCheck
    /// </summary>
    public unsafe float DefaultHighlightTimerCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1292); }
    }

    /// <summary>
    /// FloatProperty: HighlightTimerCheck
    /// </summary>
    public unsafe float HighlightTimerCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }
    }

    /// <summary>
    /// IntProperty: GadgetListEnum
    /// </summary>
    public unsafe int GadgetListEnum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// FloatProperty: DestructibleImpactMomentum
    /// </summary>
    public unsafe float DestructibleImpactMomentum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1304); }
    }

    /// <summary>
    /// FloatProperty: DestructibleImpactDamage
    /// </summary>
    public unsafe float DestructibleImpactDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1308); }
    }

    /// <summary>
    /// StructProperty: GetOutSoundSoundHandle
    /// </summary>
    public unsafe BmSDK.Engine.AkWwise.FAkSoundHandle GetOutSoundSoundHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 1312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }
    }

    /// <summary>
    /// NameProperty: WireLeftTurn
    /// </summary>
    public unsafe BmSDK.FName WireLeftTurn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }
    }

    /// <summary>
    /// NameProperty: WireRightTurn
    /// </summary>
    public unsafe BmSDK.FName WireRightTurn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1336); }
    }

    /// <summary>
    /// NameProperty: RailingLeftTurn
    /// </summary>
    public unsafe BmSDK.FName RailingLeftTurn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// NameProperty: RailingRightTurn
    /// </summary>
    public unsafe BmSDK.FName RailingRightTurn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }
    }

    /// <summary>
    /// NameProperty: QuickFireCameraState
    /// </summary>
    public unsafe BmSDK.FName QuickFireCameraState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }

    /// <summary>
    /// StrProperty: AssociatedGadgetFlagName
    /// </summary>
    public unsafe BmSDK.FString AssociatedGadgetFlagName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1368); }
    }

    /// <summary>
    /// StructProperty: MirrorRelativeRotation
    /// </summary>
    public unsafe BmSDK.Rotator MirrorRelativeRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 1384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1384); }
    }

    /// <summary>
    /// ArrayProperty: CurrentHighlightTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> CurrentHighlightTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 1396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1396); }
    }

    /// <summary>
    /// ArrayProperty: HighlightedMeshes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RInventoryGadget.FHighlightedMesh> HighlightedMeshes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RInventoryGadget.FHighlightedMesh>>(Ptr + 1412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1412); }
    }

    /// <summary>
    /// IntProperty: iMaxHighlightMeshes
    /// </summary>
    public unsafe int iMaxHighlightMeshes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1428); }
    }

    /// <summary>
    /// FloatProperty: fHighlightDepthBiasMinimumValue
    /// </summary>
    public unsafe float fHighlightDepthBiasMinimumValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1432); }
    }

    /// <summary>
    /// FloatProperty: fHighlightDepthBiasMaximumValue
    /// </summary>
    public unsafe float fHighlightDepthBiasMaximumValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1436); }
    }

    /// <summary>
    /// FloatProperty: fHighlightDepthBiasLerpStartDistance
    /// </summary>
    public unsafe float fHighlightDepthBiasLerpStartDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1440); }
    }

    /// <summary>
    /// FloatProperty: fHighlightDepthBiasLerpEndDistance
    /// </summary>
    public unsafe float fHighlightDepthBiasLerpEndDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1444); }
    }

    /// <summary>
    /// ArrayProperty: CachedSkelMeshes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent> CachedSkelMeshes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent>>(Ptr + 1448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1448); }
    }

    /// <summary>
    /// ArrayProperty: CachedStaticMeshes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.StaticMeshComponent> CachedStaticMeshes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.StaticMeshComponent>>(Ptr + 1464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1464); }
    }

    /// <summary>
    /// FloatProperty: fLastPlayedGadgetSpeechTime
    /// </summary>
    public unsafe float fLastPlayedGadgetSpeechTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1480); }
    }

    /// <summary>
    /// FloatProperty: fGadgetSpeechCooldownTime
    /// </summary>
    public unsafe float fGadgetSpeechCooldownTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1484); }
    }

    /// <summary>
    /// ArrayProperty: RainMaterials
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant> RainMaterials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant>>(Ptr + 1488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1488); }
    }

    /// <summary>
    /// NameProperty: RainParameterName
    /// </summary>
    public unsafe BmSDK.FName RainParameterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1504); }
    }

    /// <summary>
    /// FloatProperty: TargetCapeBlendWeight
    /// </summary>
    public unsafe float TargetCapeBlendWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1512); }
    }

    /// <summary>
    /// StructProperty: WorldPPSettings
    /// </summary>
    public unsafe BmSDK.Engine.PostProcessVolume.FPostProcessSettings WorldPPSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PostProcessVolume.FPostProcessSettings>(Ptr + 1516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1516); }
    }

    /// <summary>
    /// StructProperty: vAdditiveArmAvoidanceTraceExtent
    /// </summary>
    public unsafe System.Numerics.Vector3 vAdditiveArmAvoidanceTraceExtent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2040); }
    }

    /// <summary>
    /// FloatProperty: fAdditiveArmAvoidanceRightBias
    /// </summary>
    public unsafe float fAdditiveArmAvoidanceRightBias
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2052); }
    }

    /// <summary>
    /// FloatProperty: fAdditiveArmAvoidanceTraceDistance
    /// </summary>
    public unsafe float fAdditiveArmAvoidanceTraceDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2056); }
    }

    /// <summary>
    /// FloatProperty: fAdditiveArmAvoidanceMaximumAvoidanceDistance
    /// </summary>
    public unsafe float fAdditiveArmAvoidanceMaximumAvoidanceDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2060); }
    }

    /// <summary>
    /// FloatProperty: fAdditiveArmAvoidanceInterpolationDistance
    /// </summary>
    public unsafe float fAdditiveArmAvoidanceInterpolationDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2064); }
    }

    /// <summary>
    /// Struct: FGlideGadgetTargetContainer
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FGlideGadgetTargetContainer
    {
        /// <summary>
        /// StrProperty: IconAnimName
        /// </summary>
        public unsafe BmSDK.FString IconAnimName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: TargetActor
        /// </summary>
        public unsafe BmSDK.Engine.Actor TargetActor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: Duration
        /// </summary>
        public unsafe float Duration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Enum: CoverCornerType
    /// </summary>
    public enum CoverCornerType
    {
        CCT_NoCorner = 0,
        CCT_LeftCorner = 1,
        CCT_RightCorner = 2,
        CCT_MAX = 3,
    }

    /// <summary>
    /// Enum: BatarangThrowType
    /// </summary>
    public enum BatarangThrowType
    {
        BTT_NullThrow = 0,
        BTT_StandingThrow = 1,
        BTT_CoverLeftThrow = 2,
        BTT_CoverRightThrow = 3,
        BTT_VantagePointThrow = 4,
        BTT_WireThrow = 5,
        BTT_RailingThrow = 6,
        BTT_CeilingThrow = 7,
        BTT_CrawlSpaceThrow = 8,
        BTT_ComboThrow = 9,
        BTT_RunningComboThrow = 10,
        BTT_GlidingThrow = 11,
        BTT_WhipRappelThrow = 12,
        BTT_NUMBatarangThrowTypes = 13,
        BTT_MAX = 14,
    }

    /// <summary>
    /// Enum: PlayerWantsToCrouch
    /// </summary>
    public enum PlayerWantsToCrouch
    {
        PWC_Crouch = 0,
        PWC_StandUp = 1,
        PWC_MAX = 2,
    }

    /// <summary>
    /// Enum: GadgetEquipState
    /// </summary>
    public enum GadgetEquipState
    {
        GS_AttachedToBelt = 0,
        GS_AttachetToHand = 1,
        GS_None = 2,
        GS_MAX = 3,
    }
}
