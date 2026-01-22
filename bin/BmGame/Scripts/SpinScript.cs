using BmSDK;
using BmSDK.Engine;

[Script]
public class SpinScript : Script
{
    public override void OnEnterGame()
    {
        // NOTE: Avoid using FindObjectsSlow() to find actors. Returned actors aren't
        // guaranteed to be valid or even to exist in the current world.
        foreach (var skelMeshActor in GameObject.FindObjectsSlow<SkeletalMeshActor>())
        {
            if (skelMeshActor == skelMeshActor.Class.DefaultObject)
            {
                continue;
            }

            // Add spinning component to all SkeletalMeshActors
            skelMeshActor.AttachScriptComponent<SpinningComponent>();
        }
    }
}

class SpinningComponent : ScriptComponent
{
    public override void OnAttach()
    {
        Debug.Log($"SpinningComponent attached to {Owner}");
    }

    public override void OnDetach()
    {
        Debug.Log($"SpinningComponent detached from {Owner}");
    }

    public override void OnTick()
    {
        // Rotate the actor a bit every tick
        Owner.Rotation = Owner.Rotation with
        {
            Yaw = (int)MathF.Round(Owner.Rotation.Yaw + (100000f * Game.GetDeltaTime())),
        };
    }
}
