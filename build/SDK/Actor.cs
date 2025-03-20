using BmSDK;
using BmSDK.Framework;

namespace BmSDK.Engine;

public class Actor : Framework.UObject
{
	public enum EDoubleClickDir : byte
	{
		DCLICK_None = 0x1,
		DCLICK_Left = 0x2,
		DCLICK_Right = 0x4,
		DCLICK_Forward = 0x8,
		DCLICK_Back = 0x10,
		DCLICK_Active = 0x20,
		DCLICK_Done = 0x40,
	}

	public enum ETravelType : byte
	{
		TRAVEL_Absolute = 0x1,
		TRAVEL_Partial = 0x2,
		TRAVEL_Relative = 0x4,
	}

	public enum ECollisionType : byte
	{
		COLLIDE_CustomDefault = 0x1,
		COLLIDE_NoCollision = 0x2,
		COLLIDE_BlockAll = 0x4,
		COLLIDE_BlockWeapons = 0x8,
		COLLIDE_TouchAll = 0x10,
		COLLIDE_TouchWeapons = 0x20,
		COLLIDE_BlockAllButWeapons = 0x40,
		COLLIDE_TouchAllButWeapons = 0x80,
		COLLIDE_BlockWeaponsKickable = 0x100,
	}

	public enum ENetRole : byte
	{
		ROLE_None = 0x1,
		ROLE_SimulatedProxy = 0x2,
		ROLE_AutonomousProxy = 0x4,
		ROLE_Authority = 0x8,
	}

	public enum EMoveDir : byte
	{
		MD_Stationary = 0x1,
		MD_Forward = 0x2,
		MD_Backward = 0x4,
		MD_Left = 0x8,
		MD_Right = 0x10,
		MD_Up = 0x20,
		MD_Down = 0x40,
	}

	public enum EPhysics : byte
	{
		PHYS_None = 0x1,
		PHYS_Walking = 0x2,
		PHYS_Falling = 0x4,
		PHYS_Swimming = 0x8,
		PHYS_Flying = 0x10,
		PHYS_Rotating = 0x20,
		PHYS_Projectile = 0x40,
		PHYS_Interpolating = 0x80,
		PHYS_Spider = 0x100,
		PHYS_Ladder = 0x200,
		PHYS_RigidBody = 0x400,
		PHYS_SoftBody = 0x800,
		PHYS_Floating = 0x1000,
		PHYS_Unused = 0x2000,
	}

	public struct FNavReference
	{
		public Engine.NavigationPoint Nav => (Engine.NavigationPoint)GetPropertyValue(0, "UObjectProperty");
		public int Guid => (int)GetPropertyValue(4, "UStructProperty");
	}

	public struct FActorReference
	{
		public Engine.Actor Actor => (Engine.Actor)GetPropertyValue(0, "UObjectProperty");
		public int Guid => (int)GetPropertyValue(4, "UStructProperty");
	}

	public struct FInvestigationData
	{
		public string InvestigationInfoTitle => (string)GetPropertyValue(0, "UStrProperty");
		public string InvestigationInfo => (string)GetPropertyValue(4, "UStrProperty");
		public Engine.SoundCue BatmanThought => (Engine.SoundCue)GetPropertyValue(8, "UObjectProperty");
		public string GlobalFlagCheck => (string)GetPropertyValue(12, "UNameProperty");
		public bool bInvertFlag => GetBoolPropertyValue(16, 1);
		public bool bWarningFlag => GetBoolPropertyValue(16, 2);
	}

	public struct FPhysEffectInfo
	{
		public float MinEffectSpeed => (float)GetPropertyValue(0, "UFloatProperty");
		public float MaxEffectSpeed => (float)GetPropertyValue(4, "UFloatProperty");
		public float ReFireDelay => (float)GetPropertyValue(8, "UFloatProperty");
		public Engine.ParticleSystem Effect => (Engine.ParticleSystem)GetPropertyValue(12, "UObjectProperty");
		public Engine.SoundCue Sound => (Engine.SoundCue)GetPropertyValue(16, "UObjectProperty");
		public Engine.RB_ForceComponent Force => (Engine.RB_ForceComponent)GetPropertyValue(20, "UComponentProperty");
	}

	public struct FReplicatedHitImpulse
	{
		public int AppliedImpulse => (int)GetPropertyValue(0, "UStructProperty");
		public int HitLocation => (int)GetPropertyValue(4, "UStructProperty");
		public string BoneName => (string)GetPropertyValue(8, "UNameProperty");
		public byte ImpulseCount => (byte)GetPropertyValue(12, "UByteProperty");
		public bool bRadialImpulse => GetBoolPropertyValue(13, 1);
	}

	public struct FCollisionImpactData
	{
		public Array ContactInfos => (Array)GetPropertyValue(0, "UArrayProperty");
		public int TotalNormalForceVector => (int)GetPropertyValue(12, "UStructProperty");
		public int TotalFrictionForceVector => (int)GetPropertyValue(16, "UStructProperty");
	}

	public struct FRigidBodyContactInfo
	{
		public int ContactPosition => (int)GetPropertyValue(0, "UStructProperty");
		public int ContactNormal => (int)GetPropertyValue(4, "UStructProperty");
		public float ContactPenetration => (float)GetPropertyValue(8, "UFloatProperty");
		public int ContactVelocity => (int)GetPropertyValue(12, "UStructProperty");
		public Engine.PhysicalMaterial PhysMaterial => (Engine.PhysicalMaterial)GetPropertyValue(16, "UObjectProperty");
	}

	public struct FRigidBodyState
	{
		public int Position => (int)GetPropertyValue(0, "UStructProperty");
		public int Quaternion => (int)GetPropertyValue(4, "UStructProperty");
		public int LinVel => (int)GetPropertyValue(8, "UStructProperty");
		public int AngVel => (int)GetPropertyValue(12, "UStructProperty");
		public byte bNewData => (byte)GetPropertyValue(16, "UByteProperty");
	}

	public struct FPhysContactModificationData
	{
		public int ChangeFlags => (int)GetPropertyValue(0, "UIntProperty");
		public int PhysShape0 => (int)GetPropertyValue(4, "UStructProperty");
		public int PhysShape1 => (int)GetPropertyValue(8, "UStructProperty");
		public Engine.Actor Actor0 => (Engine.Actor)GetPropertyValue(12, "UObjectProperty");
		public Engine.Actor Actor1 => (Engine.Actor)GetPropertyValue(16, "UObjectProperty");
		public int PhysFeatureIndex0 => (int)GetPropertyValue(20, "UIntProperty");
		public int physFeatureIndex1 => (int)GetPropertyValue(24, "UIntProperty");
		public int PhysData => (int)GetPropertyValue(28, "UStructProperty");
	}

	public struct FAnimSlotDesc
	{
		public string SlotName => (string)GetPropertyValue(0, "UNameProperty");
		public int NumChannels => (int)GetPropertyValue(4, "UIntProperty");
	}

	public struct FAnimSlotInfo
	{
		public string SlotName => (string)GetPropertyValue(0, "UNameProperty");
		public Array ChannelWeights => (Array)GetPropertyValue(4, "UArrayProperty");
	}

	public struct FImpactInfo
	{
		public Engine.Actor HitActor => (Engine.Actor)GetPropertyValue(0, "UObjectProperty");
		public int HitLocation => (int)GetPropertyValue(4, "UStructProperty");
		public int HitNormal => (int)GetPropertyValue(8, "UStructProperty");
		public int RayDir => (int)GetPropertyValue(12, "UStructProperty");
		public int StartTrace => (int)GetPropertyValue(16, "UStructProperty");
		public int HitInfo => (int)GetPropertyValue(20, "UStructProperty");
	}

	public struct FTraceHitInfo
	{
		public Engine.Material Material => (Engine.Material)GetPropertyValue(0, "UObjectProperty");
		public Engine.PhysicalMaterial PhysMaterial => (Engine.PhysicalMaterial)GetPropertyValue(4, "UObjectProperty");
		public int Item => (int)GetPropertyValue(8, "UIntProperty");
		public int LevelIndex => (int)GetPropertyValue(12, "UIntProperty");
		public string BoneName => (string)GetPropertyValue(16, "UNameProperty");
		public Engine.PrimitiveComponent HitComponent => (Engine.PrimitiveComponent)GetPropertyValue(20, "UComponentProperty");
	}

	public struct FTimerData
	{
		public bool bLoop => GetBoolPropertyValue(0, 1);
		public string FuncName => (string)GetPropertyValue(4, "UNameProperty");
		public float Rate => (float)GetPropertyValue(8, "UFloatProperty");
		public float Count => (float)GetPropertyValue(12, "UFloatProperty");
		public Framework.UObject TimerObj => (Framework.UObject)GetPropertyValue(16, "UObjectProperty");
		public bool bPaused => GetBoolPropertyValue(20, 1);
	}

	public struct FThought
	{
		public string Text => (string)GetPropertyValue(0, "UStrProperty");
		public byte Red => (byte)GetPropertyValue(4, "UByteProperty");
		public byte Green => (byte)GetPropertyValue(5, "UByteProperty");
		public byte Blue => (byte)GetPropertyValue(6, "UByteProperty");
		public byte Alpha => (byte)GetPropertyValue(7, "UByteProperty");
	}

	public bool bLoadIfPhysXLevel0 => GetBoolPropertyValue(0, 1);
	public bool bLoadIfPhysXLevel1 => GetBoolPropertyValue(0, 2);
	public bool bLoadIfPhysXLevel2 => GetBoolPropertyValue(0, 3);
	public bool bStatic => GetBoolPropertyValue(0, 4);
	public bool bHidden => GetBoolPropertyValue(0, 5);
	public bool bNoDelete => GetBoolPropertyValue(0, 6);
	public bool bDeleteMe => GetBoolPropertyValue(0, 7);
	public bool bTicked => GetBoolPropertyValue(0, 8);
	public bool bOnlyOwnerSee => GetBoolPropertyValue(0, 9);
	public bool bStasis => GetBoolPropertyValue(0, 10);
	public bool bExtraStasis => GetBoolPropertyValue(0, 11);
	public bool bWorldGeometry => GetBoolPropertyValue(0, 12);
	public bool bIgnoreRigidBodyPawns => GetBoolPropertyValue(0, 13);
	public bool bOrientOnSlope => GetBoolPropertyValue(0, 14);
	public bool bIgnoreEncroachers => GetBoolPropertyValue(0, 15);
	public bool bPushedByEncroachers => GetBoolPropertyValue(0, 16);
	public bool bDestroyedByInterpActor => GetBoolPropertyValue(0, 17);
	public bool bRouteBeginPlayEvenIfStatic => GetBoolPropertyValue(0, 18);
	public bool bIsMoving => GetBoolPropertyValue(0, 19);
	public bool bAlwaysEncroachCheck => GetBoolPropertyValue(0, 20);
	public bool bHasAlternateTargetLocation => GetBoolPropertyValue(0, 21);
	public bool bCanStepUpOn => GetBoolPropertyValue(0, 22);
	public bool bNetTemporary => GetBoolPropertyValue(0, 23);
	public bool bOnlyRelevantToOwner => GetBoolPropertyValue(0, 24);
	public bool bNetDirty => GetBoolPropertyValue(0, 25);
	public bool bAlwaysRelevant => GetBoolPropertyValue(0, 26);
	public bool bReplicateInstigator => GetBoolPropertyValue(0, 27);
	public bool bReplicateMovement => GetBoolPropertyValue(0, 28);
	public bool bSkipActorPropertyReplication => GetBoolPropertyValue(0, 29);
	public bool bUpdateSimulatedPosition => GetBoolPropertyValue(0, 30);
	public bool bTearOff => GetBoolPropertyValue(0, 31);
	public bool bOnlyDirtyReplication => GetBoolPropertyValue(0, 32);
	public bool bAllowFluidSurfaceInteraction => GetBoolPropertyValue(4, 0);
	public bool bDemoRecording => GetBoolPropertyValue(4, 1);
	public bool bDemoOwner => GetBoolPropertyValue(4, 2);
	public bool bForceDemoRelevant => GetBoolPropertyValue(4, 3);
	public bool bNetInitialRotation => GetBoolPropertyValue(4, 4);
	public bool bReplicateRigidBodyLocation => GetBoolPropertyValue(4, 5);
	public bool bKillDuringLevelTransition => GetBoolPropertyValue(4, 6);
	public bool bExchangedRoles => GetBoolPropertyValue(4, 7);
	public bool bConsiderAllStaticMeshComponentsForStreaming => GetBoolPropertyValue(4, 8);
	public bool bDebug => GetBoolPropertyValue(4, 9);
	public bool bPostRenderIfNotVisible => GetBoolPropertyValue(4, 10);
	public bool bForceNetUpdate => GetBoolPropertyValue(4, 11);
	public bool bAutomaticPerformPhysics => GetBoolPropertyValue(4, 12);
	public bool bHardAttach => GetBoolPropertyValue(4, 13);
	public bool bSnapAttach => GetBoolPropertyValue(4, 14);
	public bool bIgnoreBaseRotation => GetBoolPropertyValue(4, 15);
	public bool bShadowParented => GetBoolPropertyValue(4, 16);
	public bool bCanBeAdheredTo => GetBoolPropertyValue(4, 17);
	public bool bCanBeFrictionedTo => GetBoolPropertyValue(4, 18);
	public bool bHurtEntry => GetBoolPropertyValue(4, 19);
	public bool bGameRelevant => GetBoolPropertyValue(4, 20);
	public bool bMovable => GetBoolPropertyValue(4, 21);
	public bool bDestroyInPainVolume => GetBoolPropertyValue(4, 22);
	public bool bCanBeDamaged => GetBoolPropertyValue(4, 23);
	public bool bShouldBaseAtStartup => GetBoolPropertyValue(4, 24);
	public bool bPendingDelete => GetBoolPropertyValue(4, 25);
	public bool bCanTeleport => GetBoolPropertyValue(4, 26);
	public bool bAlwaysTick => GetBoolPropertyValue(4, 27);
	public bool bBlocksNavigation => GetBoolPropertyValue(4, 28);
	public bool BlockRigidBody => GetBoolPropertyValue(4, 29);
	public bool bCollideWhenPlacing => GetBoolPropertyValue(4, 30);
	public bool bCollideActors => GetBoolPropertyValue(4, 31);
	public bool bCollideWorld => GetBoolPropertyValue(4, 32);
	public bool bCollideComplex => GetBoolPropertyValue(8, 0);
	public bool bBlockActors => GetBoolPropertyValue(8, 1);
	public bool bProjTarget => GetBoolPropertyValue(8, 2);
	public bool bBlocksTeleport => GetBoolPropertyValue(8, 3);
	public bool bForceZeroExtentCollision => GetBoolPropertyValue(8, 4);
	public bool bPlayerMovementCheck => GetBoolPropertyValue(8, 5);
	public bool bIgnoreDynamic => GetBoolPropertyValue(8, 6);
	public bool bNoEncroachCheck => GetBoolPropertyValue(8, 7);
	public bool bPhysRigidBodyOutOfWorldCheck => GetBoolPropertyValue(8, 8);
	public bool bComponentOutsideWorld => GetBoolPropertyValue(8, 9);
	public bool bBounce => GetBoolPropertyValue(8, 10);
	public bool bJustTeleported => GetBoolPropertyValue(8, 11);
	public bool bNetInitial => GetBoolPropertyValue(8, 12);
	public bool bNetOwner => GetBoolPropertyValue(8, 13);
	public bool bHiddenEd => GetBoolPropertyValue(8, 14);
	public bool bHiddenEdGroup => GetBoolPropertyValue(8, 15);
	public bool bHiddenEdCustom => GetBoolPropertyValue(8, 16);
	public bool bEdShouldSnap => GetBoolPropertyValue(8, 17);
	public bool bTempEditor => GetBoolPropertyValue(8, 18);
	public bool bPathColliding => GetBoolPropertyValue(8, 19);
	public bool bPathTemp => GetBoolPropertyValue(8, 20);
	public bool bScriptInitialized => GetBoolPropertyValue(8, 21);
	public bool bLockLocation => GetBoolPropertyValue(8, 22);
	public bool bForceAllowKismetModification => GetBoolPropertyValue(8, 23);
	public bool bIsPointOfInterest => GetBoolPropertyValue(8, 24);
	public bool bDonePostBeginPlay => GetBoolPropertyValue(8, 25);
	public bool bBatmanCanClimb => GetBoolPropertyValue(8, 26);
	public bool bValidLineLauncherTarget => GetBoolPropertyValue(8, 27);
	public bool bValidGelTarget => GetBoolPropertyValue(8, 28);
	public bool bCurrentInvestigateHightlighted => GetBoolPropertyValue(8, 29);
	public bool CachedInvestigateSightCheck => GetBoolPropertyValue(8, 30);
	public Array Components => (Array)GetPropertyValue(12, "UArrayProperty");
	public Array AllComponents => (Array)GetPropertyValue(24, "UArrayProperty");
	public int Location => (int)GetPropertyValue(36, "UStructProperty");
	public int Rotation => (int)GetPropertyValue(40, "UStructProperty");
	public float DrawScale => (float)GetPropertyValue(44, "UFloatProperty");
	public int DrawScale3D => (int)GetPropertyValue(48, "UStructProperty");
	public int PrePivot => (int)GetPropertyValue(52, "UStructProperty");
	public int DetachFence => (int)GetPropertyValue(56, "UStructProperty");
	public float CustomTimeDilation => (float)GetPropertyValue(60, "UFloatProperty");
	public EPhysics Physics => (EPhysics)GetPropertyValue(64, "UByteProperty");
	public ENetRole RemoteRole => (ENetRole)GetPropertyValue(65, "UByteProperty");
	public ENetRole Role => (ENetRole)GetPropertyValue(66, "UByteProperty");
	public ECollisionType CollisionType => (ECollisionType)GetPropertyValue(67, "UByteProperty");
	public ECollisionType ReplicatedCollisionType => (ECollisionType)GetPropertyValue(68, "UByteProperty");
	public ETickingGroup TickGroup => (ETickingGroup)GetPropertyValue(69, "UByteProperty");
	public byte FramesTillInvestigateSightCheck => (byte)GetPropertyValue(70, "UByteProperty");
	public Engine.Actor Owner => (Engine.Actor)GetPropertyValue(71, "UObjectProperty");
	public Engine.Actor Base => (Engine.Actor)GetPropertyValue(75, "UObjectProperty");
	public Array Timers => (Array)GetPropertyValue(79, "UArrayProperty");
	public Engine.Pawn Instigator => (Engine.Pawn)GetPropertyValue(91, "UObjectProperty");
	public Engine.WorldInfo WorldInfo => (Engine.WorldInfo)GetPropertyValue(95, "UObjectProperty");
	public float LifeSpan => (float)GetPropertyValue(99, "UFloatProperty");
	public float CreationTime => (float)GetPropertyValue(103, "UFloatProperty");
	public float LastRenderTime => (float)GetPropertyValue(107, "UFloatProperty");
	public string Tag => (string)GetPropertyValue(111, "UNameProperty");
	public string InitialState => (string)GetPropertyValue(115, "UNameProperty");
	public string Group => (string)GetPropertyValue(119, "UNameProperty");
	public Array Touching => (Array)GetPropertyValue(123, "UArrayProperty");
	public Array Children => (Array)GetPropertyValue(135, "UArrayProperty");
	public float LatentFloat => (float)GetPropertyValue(147, "UFloatProperty");
	public Engine.AnimNodeSequence LatentSeqNode => (Engine.AnimNodeSequence)GetPropertyValue(151, "UObjectProperty");
	public Engine.PhysicsVolume PhysicsVolume => (Engine.PhysicsVolume)GetPropertyValue(155, "UObjectProperty");
	public int Velocity => (int)GetPropertyValue(159, "UStructProperty");
	public int Acceleration => (int)GetPropertyValue(163, "UStructProperty");
	public int AngularVelocity => (int)GetPropertyValue(167, "UStructProperty");
	public Engine.SkeletalMeshComponent BaseSkelComponent => (Engine.SkeletalMeshComponent)GetPropertyValue(171, "UComponentProperty");
	public string BaseBoneName => (string)GetPropertyValue(175, "UNameProperty");
	public Array Attached => (Array)GetPropertyValue(179, "UArrayProperty");
	public int RelativeLocation => (int)GetPropertyValue(191, "UStructProperty");
	public int RelativeRotation => (int)GetPropertyValue(195, "UStructProperty");
	public Engine.PrimitiveComponent CollisionComponent => (Engine.PrimitiveComponent)GetPropertyValue(199, "UComponentProperty");
	public int OverlapTag => (int)GetPropertyValue(203, "UIntProperty");
	public int RotationRate => (int)GetPropertyValue(207, "UStructProperty");
	public int DesiredRotation => (int)GetPropertyValue(211, "UStructProperty");
	public Engine.Actor PendingTouch => (Engine.Actor)GetPropertyValue(215, "UObjectProperty");
	public Array SupportedEvents => (Array)GetPropertyValue(219, "UArrayProperty");
	public Array GeneratedEvents => (Array)GetPropertyValue(231, "UArrayProperty");
	public Array LatentActions => (Array)GetPropertyValue(243, "UArrayProperty");
	public float InvestigationMaxDistance => (float)GetPropertyValue(255, "UFloatProperty");
	public Array InvestigationDataArray => (Array)GetPropertyValue(259, "UArrayProperty");
}
