#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPredatorGunLockerBase<br/>
/// (flags = 0)
/// </summary>
public partial class RPredatorGunLockerBase : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPredatorGunLockerBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPredatorGunLockerBase() { }

    /// <summary>
    /// Constructs a new RPredatorGunLockerBase
    /// </summary>
    public RPredatorGunLockerBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPredatorGunLockerBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPredatorGunLockerBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPredatorGunLockerBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPredatorGunLockerBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPredatorGunLockerBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPredatorGunLockerBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPredatorGunLockerBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPredatorGunLockerBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPredatorGunLockerBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: VfTable_IInterface_NavMeshPathObstacle
    /// </summary>
    public unsafe System.IntPtr VfTable_IInterface_NavMeshPathObstacle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// StructProperty: VfTable_IRDisruptableInterface
    /// </summary>
    public unsafe System.IntPtr VfTable_IRDisruptableInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ClassProperty: WeaponType
    /// </summary>
    public unsafe BmSDK.Class WeaponType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ObjectProperty: ThugAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet ThugAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// ObjectProperty: ThugInvestigateAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet ThugInvestigateAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ObjectProperty: LoadedWeaponRefHolder
    /// </summary>
    public unsafe BmSDK.BmGame.RCharacterBioCue LoadedWeaponRefHolder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCharacterBioCue>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ObjectProperty: CurrentUser
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIAction CurrentUser
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIAction>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ObjectProperty: JammedExplosionVFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem JammedExplosionVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ObjectProperty: ExplodeEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ExplodeEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ObjectProperty: LockerDisruptedVFXTemplate
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem LockerDisruptedVFXTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ObjectProperty: NormalXrayMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant NormalXrayMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ObjectProperty: JammedXrayMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant JammedXrayMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ComponentProperty: InteractionComp
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent InteractionComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ComponentProperty: GunLockerSkeletalMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent GunLockerSkeletalMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// NameProperty: ThugAnim_GetGun
    /// </summary>
    public unsafe BmSDK.FName ThugAnim_GetGun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// NameProperty: ThugAnim_Investigate_Left_Cocky
    /// </summary>
    public unsafe BmSDK.FName ThugAnim_Investigate_Left_Cocky
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// NameProperty: ThugAnim_Investigate_Left_Nervous
    /// </summary>
    public unsafe BmSDK.FName ThugAnim_Investigate_Left_Nervous
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// NameProperty: ThugAnim_Investigate_Straight_Cocky
    /// </summary>
    public unsafe BmSDK.FName ThugAnim_Investigate_Straight_Cocky
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// NameProperty: ThugAnim_Investigate_Straight_Nervous
    /// </summary>
    public unsafe BmSDK.FName ThugAnim_Investigate_Straight_Nervous
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// NameProperty: ThugAnim_Investigate_Right_Cocky
    /// </summary>
    public unsafe BmSDK.FName ThugAnim_Investigate_Right_Cocky
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// NameProperty: ThugAnim_Investigate_Right_Nervous
    /// </summary>
    public unsafe BmSDK.FName ThugAnim_Investigate_Right_Nervous
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// NameProperty: ThugAnim_Investigate_NoTouch_Left_Nervous
    /// </summary>
    public unsafe BmSDK.FName ThugAnim_Investigate_NoTouch_Left_Nervous
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// NameProperty: ThugAnim_Investigate_NoTouch_Straight_Nervous
    /// </summary>
    public unsafe BmSDK.FName ThugAnim_Investigate_NoTouch_Straight_Nervous
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// NameProperty: ThugAnim_Investigate_NoTouch_Right_Nervous
    /// </summary>
    public unsafe BmSDK.FName ThugAnim_Investigate_NoTouch_Right_Nervous
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// NameProperty: ThugAnim_Investigate_Minigunner_Touch_Left
    /// </summary>
    public unsafe BmSDK.FName ThugAnim_Investigate_Minigunner_Touch_Left
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// NameProperty: ThugAnim_Investigate_Minigunner_Touch_Straight
    /// </summary>
    public unsafe BmSDK.FName ThugAnim_Investigate_Minigunner_Touch_Straight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// NameProperty: ThugAnim_Investigate_Minigunner_Touch_Right
    /// </summary>
    public unsafe BmSDK.FName ThugAnim_Investigate_Minigunner_Touch_Right
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// NameProperty: ThugAnim_Investigate_Minigunner_NoTouch_Left
    /// </summary>
    public unsafe BmSDK.FName ThugAnim_Investigate_Minigunner_NoTouch_Left
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// NameProperty: ThugAnim_Investigate_Minigunner_NoTouch_Straight
    /// </summary>
    public unsafe BmSDK.FName ThugAnim_Investigate_Minigunner_NoTouch_Straight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// NameProperty: ThugAnim_Investigate_Minigunner_NoTouch_Right
    /// </summary>
    public unsafe BmSDK.FName ThugAnim_Investigate_Minigunner_NoTouch_Right
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// BoolProperty: bWaitingForWeaponLoad
    /// </summary>
    public unsafe bool bWaitingForWeaponLoad
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 908); }
    }

    /// <summary>
    /// BoolProperty: bJammed
    /// </summary>
    public unsafe bool bJammed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 908); }
    }

    /// <summary>
    /// BoolProperty: bCheckForWeaponLoad
    /// </summary>
    public unsafe bool bCheckForWeaponLoad
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 908); }
    }

    /// <summary>
    /// BoolProperty: bObstacleRegistered
    /// </summary>
    public unsafe bool bObstacleRegistered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 908); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 908); }
    }

    /// <summary>
    /// StrProperty: WeaponPackage
    /// </summary>
    public unsafe BmSDK.FString WeaponPackage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// StrProperty: LoadingWeaponPackage
    /// </summary>
    public unsafe BmSDK.FString LoadingWeaponPackage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// ArrayProperty: CurrentGrabbersAssigned
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMAIAction> CurrentGrabbersAssigned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMAIAction>>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// FloatProperty: TimeUntilNextLoadCheck
    /// </summary>
    public unsafe float TimeUntilNextLoadCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }
}
