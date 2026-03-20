#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RDMThroughWallsSuppressableInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface RDMThroughWallsSuppressableInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: SuppressDetectiveModeVisibilityThroughWalls
    /// </summary>
    public unsafe void SuppressDetectiveModeVisibilityThroughWalls(bool bSuppress);

    /// <summary>
    /// Function: UnregisterDMThroughWallsSuppressable
    /// </summary>
    public unsafe void UnregisterDMThroughWallsSuppressable();

    /// <summary>
    /// Function: RegisterDMThroughWallsSuppressable
    /// </summary>
    public unsafe void RegisterDMThroughWallsSuppressable();
}
