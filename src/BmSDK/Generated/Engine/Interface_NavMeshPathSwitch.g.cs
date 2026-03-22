#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: Interface_NavMeshPathSwitch<br/>
/// (size = 44)
/// (flags = 134234259)
/// </summary>
public partial interface Interface_NavMeshPathSwitch : BmSDK.Engine.Interface_NavMeshPathObject
{
    /// <summary>
    /// Function: AIActivateSwitch
    /// </summary>
    public unsafe bool AIActivateSwitch(BmSDK.Engine.AIController AI);
}
