using BmSDK;
using BmSDK.Framework;

namespace BmSDK.BmGame;

public class RCapeConfig : Framework.UObject
{
	public struct FMinLengthSpringConfig
	{
		public int Chain1Index => (int)GetPropertyValue(0, "UIntProperty");
		public int Link1Index => (int)GetPropertyValue(4, "UIntProperty");
		public int Chain2Index => (int)GetPropertyValue(8, "UIntProperty");
		public int Link2Index => (int)GetPropertyValue(12, "UIntProperty");
		public float MinLength => (float)GetPropertyValue(16, "UFloatProperty");
	}

	public struct FCapeSupportConnectorIndexPair
	{
		public int ConnectionIndex1 => (int)GetPropertyValue(0, "UIntProperty");
		public int ConnectionIndex2 => (int)GetPropertyValue(4, "UIntProperty");
	}

	public struct FCapeBoolArrayType
	{
		public Array BoolArray => (Array)GetPropertyValue(0, "UArrayProperty");
	}

	public struct FCapeFloatArrayType
	{
		public Array FloatArray => (Array)GetPropertyValue(0, "UArrayProperty");
	}

	public struct FCapeIntArrayType
	{
		public Array IntArray => (Array)GetPropertyValue(0, "UArrayProperty");
	}

	public int CapeDataVersionNumber => (int)GetPropertyValue(0, "UIntProperty");
	public int NumChainsInCape => (int)GetPropertyValue(4, "UIntProperty");
	public Array NumBonesInChains => (Array)GetPropertyValue(8, "UArrayProperty");
	public Array CapeChainDrapeStart => (Array)GetPropertyValue(20, "UArrayProperty");
	public float MinAutoPauseTimeStep => (float)GetPropertyValue(32, "UFloatProperty");
	public Array StateConfigs => (Array)GetPropertyValue(36, "UArrayProperty");
	public string DefaultCapeStateName => (string)GetPropertyValue(48, "UNameProperty");
	public string CinematicCapeStateName => (string)GetPropertyValue(52, "UNameProperty");
	public BmGame.RCapeStateConfig DefaultCinematicTemplateStateConfig => (BmGame.RCapeStateConfig)GetPropertyValue(56, "UObjectProperty");
	public float CapeChainWidth => (float)GetPropertyValue(60, "UFloatProperty");
	public Array CapeChainWidthOverrides => (Array)GetPropertyValue(64, "UArrayProperty");
	public Array SupportConstraintConnectionIndices => (Array)GetPropertyValue(76, "UArrayProperty");
	public Array SupportSpringConnectionIndices => (Array)GetPropertyValue(88, "UArrayProperty");
	public Array SupportSpringConnectionLengths => (Array)GetPropertyValue(100, "UArrayProperty");
	public Array SupportConnectorIndexPairs => (Array)GetPropertyValue(112, "UArrayProperty");
	public Array MinLengthSprings => (Array)GetPropertyValue(124, "UArrayProperty");
	public Array BoneCollisionWithWorldStates => (Array)GetPropertyValue(136, "UArrayProperty");
	public Array BoneCollisionWithCollisionShapesAllowedStates => (Array)GetPropertyValue(148, "UArrayProperty");
	public Array CapeBoneOverstretchLimits => (Array)GetPropertyValue(160, "UArrayProperty");
	public float DefaultCapeBoneOverstretchLimit => (float)GetPropertyValue(172, "UFloatProperty");
	public int UnusedCollisionShapeWorldPosition => (int)GetPropertyValue(176, "UStructProperty");
	public bool IsUseManualDamping => GetBoolPropertyValue(180, 1);
	public bool IsUseHorizontalParentRelativeDamping => GetBoolPropertyValue(180, 2);
	public bool IsUseVerticalParentRelativeDamping => GetBoolPropertyValue(180, 3);
	public float HorizontalDamping => (float)GetPropertyValue(184, "UFloatProperty");
	public float VerticalDamping => (float)GetPropertyValue(188, "UFloatProperty");
	public float InterChainSpringStrength => (float)GetPropertyValue(192, "UFloatProperty");
	public float InterChainSpringStrengthIncreaseRate => (float)GetPropertyValue(196, "UFloatProperty");
	public float MinHandleDeepCapeIntersectionVelocity => (float)GetPropertyValue(200, "UFloatProperty");
	public float HandleDeepCapeIntersectionStopDelay => (float)GetPropertyValue(204, "UFloatProperty");
	public float SupportConstraintLengthRatio => (float)GetPropertyValue(208, "UFloatProperty");
	public float MaxForwardWindComponent => (float)GetPropertyValue(212, "UFloatProperty");
	public int NumAffectedBonesPerChain => (int)GetPropertyValue(216, "UIntProperty");
	public float WindForceDropoffProportion => (float)GetPropertyValue(220, "UFloatProperty");
	public int WindForceDropoffPower => (int)GetPropertyValue(224, "UIntProperty");
	public float WindFlutterForceMultiplier => (float)GetPropertyValue(228, "UFloatProperty");
	public float WindForceMultiplier => (float)GetPropertyValue(232, "UFloatProperty");
	public string ParentConnectBoneName => (string)GetPropertyValue(236, "UNameProperty");
	public string CapeAnimNodeName => (string)GetPropertyValue(240, "UNameProperty");
	public Array CoreAnimSets => (Array)GetPropertyValue(244, "UArrayProperty");
	public Array ForcedRequiredBones => (Array)GetPropertyValue(256, "UArrayProperty");
	public string DefaultAnimName => (string)GetPropertyValue(268, "UNameProperty");
	public float BackwardsDepthBias => (float)GetPropertyValue(272, "UFloatProperty");
	public float ForwardsDepthBias => (float)GetPropertyValue(276, "UFloatProperty");
	public float InterpolationAngleRange => (float)GetPropertyValue(280, "UFloatProperty");
	public float CapeGlideToggleMaxChangePerSec => (float)GetPropertyValue(284, "UFloatProperty");
	public float CapeStateMaterialConstantMaxChangePerSec => (float)GetPropertyValue(288, "UFloatProperty");
	public float CapeRainToggleMaxChangePerSec => (float)GetPropertyValue(292, "UFloatProperty");
	public string CapeRainToggleMaterialConstantName => (string)GetPropertyValue(296, "UNameProperty");
	public string CapeSpeedToggleMaterialConstantName => (string)GetPropertyValue(300, "UNameProperty");
	public float MinDepthBiasTestDistanceFromCameraPlane => (float)GetPropertyValue(304, "UFloatProperty");
	public float CinematicMinDepthBiasTestDistanceFromCameraPlane => (float)GetPropertyValue(308, "UFloatProperty");
	public float HeadDepthBiasMultiplier => (float)GetPropertyValue(312, "UFloatProperty");
}
