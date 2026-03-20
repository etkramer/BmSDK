#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: Interface_NavMeshPathObstacle<br/>
/// (size = 84)
/// (flags = 134234259)
/// </summary>
public partial interface Interface_NavMeshPathObstacle : BmSDK.Interface
{
    /// <summary>
    /// Function: GetObstacleActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor GetObstacleActor();

    /// <summary>
    /// Enum: EEdgeHandlingStatus
    /// </summary>
    public enum EEdgeHandlingStatus
    {
        EHS_AddedBothDirs = 0,
        EHS_Added0to1 = 1,
        EHS_Added1to0 = 2,
        EHS_AddedNone = 3,
        EHS_MAX = 4,
    }
}
