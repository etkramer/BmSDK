#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Interface: RMagneticBlastInterface<br/>
/// (size = 84)
/// (flags = 16403)
/// </summary>
public partial interface RMagneticBlastInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: GetMagTargetTangent
    /// </summary>
    public unsafe System.Numerics.Vector3 GetMagTargetTangent();

    /// <summary>
    /// Function: IsSecondaryTarget
    /// </summary>
    public unsafe bool IsSecondaryTarget();

    /// <summary>
    /// Function: IsMagActive
    /// </summary>
    public unsafe bool IsMagActive();

    /// <summary>
    /// Function: GetActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor GetActor();

    /// <summary>
    /// Function: GetMagLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 GetMagLocation();

    /// <summary>
    /// Function: SetMagnetStrength
    /// </summary>
    public unsafe float SetMagnetStrength(BmSDK.BmGame.RMagneticBlastReceiver REC, float MagStr, System.Numerics.Vector3 MagPos, float DeltaTime, bool bInitialImpulse = default, BmSDK.BmGame.RMagneticSurfaceSMBase Surface = default);
}
