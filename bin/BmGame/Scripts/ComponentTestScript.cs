using BmSDK.Engine;

/// <summary>
/// This is a script component that is automatically attached to Actors when they spawn.
/// </summary>
/// <remarks>
/// The "AutoAttach" property of the Attribute defines whether the SpinningComponent
/// should attach to actors on PostBeginPlay(). The property is optional and set to false by default.
/// <br>
/// The Actor type which custom components can attach to may be declared as a generic argument
/// in the parent class. In this case, it's SkeletalMeshActor and its child classes.
/// </remarks>
[ScriptComponent(AutoAttach = true)]
public class SpinningComponent : ScriptComponent<SkeletalMeshActor>
{
    const int RuuToRotate = 65536;  // = 2PI

    public override void OnAttach()
        => Debug.Log($"SpinningComponent attached to {Owner}");

    public override void OnDetach()
        => Debug.Log($"SpinningComponent detached from {Owner}");

    public override void OnTick()
    {
        // Rotate the actor a bit every tick
        Owner.Rotation = Owner.Rotation with
        {
            // 1 complete rotation around the Z-axis per second
            Yaw = (int)MathF.Round(Owner.Rotation.Yaw + RuuToRotate * Game.GetDeltaTime()),
        };
    }
}
