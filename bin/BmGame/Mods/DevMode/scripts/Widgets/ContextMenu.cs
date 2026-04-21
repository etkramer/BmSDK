using System.Numerics;
using BmSDK;
using BmSDK.BmGame;
using BmSDK.BmScript;
using BmSDK.Engine;

namespace DevMode;

public class ContextMenu : Widget
{
    private const string PopupId = "ContextMenu";
    private const float MaxClickDistance = 5f;

    private Vector2 _rightClickStartPos;
    private Vector3 _spawnLocation;

    public sealed override void OnGUI()
    {
        var io = ImGui.GetIO();

        if (ImGui.IsMouseClicked(ImGuiMouseButton.Right))
        {
            _rightClickStartPos = io.MousePos;
        }

        if (ImGui.IsMouseReleased(ImGuiMouseButton.Right) && !ImGui.IsWindowHovered(ImGuiHoveredFlags.AnyWindow))
        {
            var dragDistance = Vector2.Distance(io.MousePos, _rightClickStartPos);
            if (dragDistance < MaxClickDistance)
            {
                var camera = DevModeScript.Instance.FreeCamera;
                var worldOrigin = camera.Position;
                var worldDirection = camera.ScreenToWorldDirection(io.MousePos, io.DisplaySize);
                var traceEnd = worldOrigin + worldDirection * 100000f;

                var hitActor = Game.GetWorldInfo().Trace(
                    out var hitLocation,
                    out _,
                    traceEnd,
                    worldOrigin,
                    true,
                    Vector3.Zero,
                    out _,
                    0
                );

                _spawnLocation = hitActor != null ? hitLocation : worldOrigin + worldDirection * 1000f;
                ImGui.OpenPopup(PopupId);
            }
        }

        if (ImGui.BeginPopup(PopupId))
        {
            if (ImGui.BeginMenu("Spawn Actor"))
            {
                if (ImGui.MenuItem("PointLight"))
                {
                    var newActor = Game.SpawnActor<PointLight>(Location: _spawnLocation)!;
                    newActor.LightComponent.LightAffectsClassification = LightComponent.ELightAffectsClassification.LAC_DYNAMIC_AND_STATIC_AFFECTING;
                    newActor.LightComponent.LightingChannels.bInitialized = true;
                    newActor.LightComponent.LightingChannels.Character = true;
                    newActor.LightComponent.LightingChannels.Dynamic = true;
                    newActor.LightComponent.LightingChannels.CompositeDynamic = true;
                    foreach (var pawn in Game.FindObjects<RPawn>())
                    {
                        pawn.LightEnvironment?.ResetEnvironment();
                    }

                    DevModeScript.Instance.Selection = newActor;
                }

                if (ImGui.MenuItem("RHelicopter"))
                {
                    Game.LoadPackage("PDLCOW");

                    var newActor = Game.SpawnActor<RHelicopter>(Location: _spawnLocation)!;
                    newActor.SpawnDefaultController();
                    newActor.SetLocation(_spawnLocation);
                    newActor.ForceUpdateComponents(true);

                    DevModeScript.Instance.Selection = newActor;
                }

                ImGui.EndMenu();
            }

            ImGui.EndPopup();
        }
    }
}
