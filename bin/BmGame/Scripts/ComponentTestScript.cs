using BmSDK.Engine;

/// <summary>
/// This is a script component that is automatically attached to Actors when they spawn.
/// <br>
/// The first parameter of the Attribute defines which types this component can attach to.
///     By default, every actor is allowed. Here we set SkeletalMeshActor and it's children.
/// The second parameter specifies whether BmSDK should  
/// </summary>
[ScriptComponent(autoAttach: true)]
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
