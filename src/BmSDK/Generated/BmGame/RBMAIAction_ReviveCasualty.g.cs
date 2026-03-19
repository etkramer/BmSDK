#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMAIAction_ReviveCasualty<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMAIAction_ReviveCasualty : BmSDK.BmGame.RBMAIAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMAIAction_ReviveCasualty", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMAIAction_ReviveCasualty() { }

    /// <summary>
    /// Constructs a new RBMAIAction_ReviveCasualty
    /// </summary>
    public RBMAIAction_ReviveCasualty(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMAIAction_ReviveCasualty Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMAIAction_ReviveCasualty(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_ReviveCasualty>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_ReviveCasualty>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_ReviveCasualty>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_ReviveCasualty>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_ReviveCasualty>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_ReviveCasualty>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_ReviveCasualty>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: Casualty
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Casualty
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// ObjectProperty: pawnInWay
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT pawnInWay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// ObjectProperty: parentAEC
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT parentAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// ObjectProperty: groupParent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT groupParent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// ObjectProperty: casParent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT casParent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// ObjectProperty: thugInTheWayAEC
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT thugInTheWayAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// BoolProperty: bStartedIntroBark
    /// </summary>
    public unsafe bool bStartedIntroBark
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 912); }
    }

    /// <summary>
    /// BoolProperty: bFollowOnBarkStarted
    /// </summary>
    public unsafe bool bFollowOnBarkStarted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 912); }
    }

    /// <summary>
    /// BoolProperty: bFollowOnBarkFinished
    /// </summary>
    public unsafe bool bFollowOnBarkFinished
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 912); }
    }

    /// <summary>
    /// BoolProperty: bDoneConsoleFinishedNotify
    /// </summary>
    public unsafe bool bDoneConsoleFinishedNotify
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 912); }
    }

    /// <summary>
    /// BoolProperty: bDonePushFinishedNotify
    /// </summary>
    public unsafe bool bDonePushFinishedNotify
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 912); }
    }

    /// <summary>
    /// BoolProperty: bStartedRevivingBark
    /// </summary>
    public unsafe bool bStartedRevivingBark
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 912); }
    }

    /// <summary>
    /// BoolProperty: bRevivingBarkFinished
    /// </summary>
    public unsafe bool bRevivingBarkFinished
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 912); }
    }

    /// <summary>
    /// BoolProperty: bInPreExit
    /// </summary>
    public unsafe bool bInPreExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 912); }
    }

    /// <summary>
    /// BoolProperty: bAssignedCasualty
    /// </summary>
    public unsafe bool bAssignedCasualty
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 912); }
    }

    /// <summary>
    /// BoolProperty: bIsExiting
    /// </summary>
    public unsafe bool bIsExiting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 912); }
    }

    /// <summary>
    /// BoolProperty: bTriggeredRecoveryLine
    /// </summary>
    public unsafe bool bTriggeredRecoveryLine
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 912); }
    }

    /// <summary>
    /// BoolProperty: medicOnCasLeft
    /// </summary>
    public unsafe bool medicOnCasLeft
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 912); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 912); }
    }

    /// <summary>
    /// FloatProperty: ConsoleFinishedTimer
    /// </summary>
    public unsafe float ConsoleFinishedTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// NameProperty: inAnimName
    /// </summary>
    public unsafe BmSDK.FName inAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// NameProperty: JabAnimName
    /// </summary>
    public unsafe BmSDK.FName JabAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// NameProperty: IdleName
    /// </summary>
    public unsafe BmSDK.FName IdleName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// NameProperty: animName_ThugInWay
    /// </summary>
    public unsafe BmSDK.FName animName_ThugInWay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// ByteProperty: dialogueState
    /// </summary>
    public unsafe byte dialogueState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// ByteProperty: thugInWayAnimType
    /// </summary>
    public unsafe byte thugInWayAnimType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 953); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 953); }
    }

    /// <summary>
    /// StructProperty: InAnimNames
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT InAnimNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// StructProperty: InAnimNames_RightTurn
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT InAnimNames_RightTurn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// StructProperty: InAnimNames_LeftTurn
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT InAnimNames_LeftTurn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// StructProperty: JabAnimNames
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT JabAnimNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// StructProperty: IdleAnimNames
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT IdleAnimNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// StructProperty: OutAnimNames_Medic
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OutAnimNames_Medic
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// StructProperty: OutAnimNames_Cas
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OutAnimNames_Cas
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// StructProperty: OutAnimNames_Cas_Unarmed
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OutAnimNames_Cas_Unarmed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// NameProperty: ThugInWayAnims_Medic
    /// </summary>
    public unsafe BmSDK.FName ThugInWayAnims_Medic_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1212); }
    }
    /// <summary>
    /// NameProperty: ThugInWayAnims_Medic
    /// </summary>
    public unsafe BmSDK.FName ThugInWayAnims_Medic_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1220); }
    }
    /// <summary>
    /// NameProperty: ThugInWayAnims_Medic
    /// </summary>
    public unsafe BmSDK.FName ThugInWayAnims_Medic_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1228); }
    }
    /// <summary>
    /// NameProperty: ThugInWayAnims_Medic
    /// </summary>
    public unsafe BmSDK.FName ThugInWayAnims_Medic_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1236); }
    }
    /// <summary>
    /// NameProperty: ThugInWayAnims_Medic
    /// </summary>
    public unsafe BmSDK.FName ThugInWayAnims_Medic_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1244); }
    }
    /// <summary>
    /// NameProperty: ThugInWayAnims_Medic
    /// </summary>
    public unsafe BmSDK.FName ThugInWayAnims_Medic_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }
    /// <summary>
    /// NameProperty: ThugInWayAnims_Medic
    /// </summary>
    public unsafe BmSDK.FName ThugInWayAnims_Medic_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1260); }
    }

    /// <summary>
    /// NameProperty: ThugInWayAnims_Thug
    /// </summary>
    public unsafe BmSDK.FName ThugInWayAnims_Thug_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }
    /// <summary>
    /// NameProperty: ThugInWayAnims_Thug
    /// </summary>
    public unsafe BmSDK.FName ThugInWayAnims_Thug_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1276); }
    }
    /// <summary>
    /// NameProperty: ThugInWayAnims_Thug
    /// </summary>
    public unsafe BmSDK.FName ThugInWayAnims_Thug_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }
    /// <summary>
    /// NameProperty: ThugInWayAnims_Thug
    /// </summary>
    public unsafe BmSDK.FName ThugInWayAnims_Thug_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1292); }
    }
    /// <summary>
    /// NameProperty: ThugInWayAnims_Thug
    /// </summary>
    public unsafe BmSDK.FName ThugInWayAnims_Thug_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }
    /// <summary>
    /// NameProperty: ThugInWayAnims_Thug
    /// </summary>
    public unsafe BmSDK.FName ThugInWayAnims_Thug_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1308); }
    }
    /// <summary>
    /// NameProperty: ThugInWayAnims_Thug
    /// </summary>
    public unsafe BmSDK.FName ThugInWayAnims_Thug_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1316); }
    }

    /// <summary>
    /// StructProperty: medicTransID
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT medicTransID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }

    /// <summary>
    /// StructProperty: thugInWayTransID
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT thugInWayTransID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }
    }

    /// <summary>
    /// StructProperty: transitionStartLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT transitionStartLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1332); }
    }

    /// <summary>
    /// StructProperty: crouchLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT crouchLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// StructProperty: crouchRotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT crouchRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1356); }
    }

    /// <summary>
    /// FloatProperty: transTravel
    /// </summary>
    public unsafe float transTravel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1368); }
    }

    /// <summary>
    /// NameProperty: outAnimNameMedic
    /// </summary>
    public unsafe BmSDK.FName outAnimNameMedic
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1372); }
    }

    /// <summary>
    /// NameProperty: outAnimNameCas
    /// </summary>
    public unsafe BmSDK.FName outAnimNameCas
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1380); }
    }
}
