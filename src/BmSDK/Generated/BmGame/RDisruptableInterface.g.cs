#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RDisruptableInterface<br/>
/// (size = 84)
/// (flags = 134234259)
/// </summary>
public partial interface RDisruptableInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: HitByDisruptorGadgetSecondary
    /// </summary>
    public unsafe bool HitByDisruptorGadgetSecondary();

    /// <summary>
    /// Function: CanBeDisruptedSecondary
    /// </summary>
    public unsafe bool CanBeDisruptedSecondary();

    /// <summary>
    /// Function: GetDisruptorOverridePriority
    /// </summary>
    public unsafe float GetDisruptorOverridePriority();

    /// <summary>
    /// Function: CanBeDisrupted
    /// </summary>
    public unsafe bool CanBeDisrupted();

    /// <summary>
    /// Function: GetDisruptorDescriptionParameters
    /// </summary>
    public unsafe BmSDK.FString GetDisruptorDescriptionParameters();

    /// <summary>
    /// Function: RequiresDisruptorUpgrade
    /// </summary>
    public unsafe bool RequiresDisruptorUpgrade();

    /// <summary>
    /// Function: RequiresDroneDisruptor
    /// </summary>
    public unsafe bool RequiresDroneDisruptor();

    /// <summary>
    /// Function: GetDisruptorTargetMesh
    /// </summary>
    public unsafe BmSDK.Engine.MeshComponent GetDisruptorTargetMesh();

    /// <summary>
    /// Function: IsDisrupted
    /// </summary>
    public unsafe bool IsDisrupted();

    /// <summary>
    /// Function: HitByDisruptorGadgetCharge
    /// </summary>
    public unsafe bool HitByDisruptorGadgetCharge();

    /// <summary>
    /// Function: GetDisruptorTargetPosition
    /// </summary>
    public unsafe System.Numerics.Vector3 GetDisruptorTargetPosition();
}
