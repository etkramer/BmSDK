using BmSDK;
using BmSDK.Framework;

namespace BmSDK.BmGame;

public class RPawn : Engine.Pawn
{
	public enum StunnedHitType : byte
	{
		HT_None = 0x1,
		HT_Head = 0x2,
		HT_Body = 0x4,
		HT_LeftLeg = 0x8,
		HT_RightLeg = 0x10,
		HT_LeftArm = 0x20,
		HT_RightArm = 0x40,
		HT_LeftShoulder = 0x80,
		HT_RightShoulder = 0x100,
		HT_Chest = 0x200,
	}

	public string NameFromScriptDatabase => (string)GetPropertyValue(0, "UNameProperty");
	public BmGame.RBMSpeechManager SpeechManager => (BmGame.RBMSpeechManager)GetPropertyValue(4, "UComponentProperty");
	public float TimeUntilCanBark => (float)GetPropertyValue(8, "UFloatProperty");
	public Engine.DynamicLightEnvironmentComponent LightEnvironment => (Engine.DynamicLightEnvironmentComponent)GetPropertyValue(12, "UComponentProperty");
	public Engine.SkeletalMeshComponent HeadMesh => (Engine.SkeletalMeshComponent)GetPropertyValue(16, "UComponentProperty");
	public Array LOSCheckBones => (Array)GetPropertyValue(20, "UArrayProperty");
	public bool bTurnOffPathShortenOptimisation => GetBoolPropertyValue(32, 1);
	public bool bDoAvoidance => GetBoolPropertyValue(32, 2);
	public bool bSmoothBothEnds => GetBoolPropertyValue(32, 3);
	public bool bCheapShortenCheck => GetBoolPropertyValue(32, 4);
	public bool bDumpDebugSpheres => GetBoolPropertyValue(32, 5);
	public int LastLocation => (int)GetPropertyValue(36, "UStructProperty");
	public Array RunAwayPointList => (Array)GetPropertyValue(40, "UArrayProperty");
	public int NumPointsTested => (int)GetPropertyValue(52, "UIntProperty");
	public int SweepDist => (int)GetPropertyValue(56, "UIntProperty");
	public BmGame.RBMPathNode_SpecialMove LockedDynamicNode => (BmGame.RBMPathNode_SpecialMove)GetPropertyValue(60, "UObjectProperty");
	public Engine.AnimSet PawnSpecificAnimSet => (Engine.AnimSet)GetPropertyValue(64, "UObjectProperty");
	public Engine.NavigationPoint EstimateStartAnchor => (Engine.NavigationPoint)GetPropertyValue(68, "UObjectProperty");
	public int DS_R => (int)GetPropertyValue(72, "UIntProperty");
	public int DS_G => (int)GetPropertyValue(76, "UIntProperty");
	public int DS_B => (int)GetPropertyValue(80, "UIntProperty");
	public float DS_Size => (float)GetPropertyValue(84, "UFloatProperty");
	public Action __IsActorSafe__Delegate => (Action)GetPropertyValue(88, "UDelegateProperty");
	public Action __IsRoamPointValid__Delegate => (Action)GetPropertyValue(92, "UDelegateProperty");
	public Action __IsSniperPointValid__Delegate => (Action)GetPropertyValue(96, "UDelegateProperty");
}
