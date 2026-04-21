using System.Numerics;
using BmSDK;
using BmSDK.Engine;

namespace DevMode;

[Script]
public class DevModeScript : Script
{
    public static DevModeScript Instance { get; private set; } = null!;

    public GameObject? Selection { get; set; }

    private bool _visible;
    private bool _wasVisible;

    private readonly FreeCamera _freeCamera = new();
    private readonly List<Widget> _widgets = [];

    public override void Main() => OnLoad();

    public override void OnLoad()
    {
        Instance = this;
        _widgets.Add(new MenuBar());
        _widgets.Add(new PropertiesPanel());

        base.OnLoad();
    }

    public override void OnUnload()
    {
        if (_visible)
        {
            ExitDevMode();
        }

        base.OnUnload();
    }

    public override void OnGUI()
    {
        if (ImGui.IsKeyPressed(ImGuiKey.Home))
        {
            _visible = !_visible;
        }

        var io = ImGui.GetIO();
        var controller = Game.GetPlayerController();

        if (_visible)
        {
            // Enter dev mode
            if (!_wasVisible)
            {
                EnterDevMode();
            }

            // Clear selection if object was unloaded
            if (Selection is { IsValid: false })
            {
                Selection = null;
            }

            // Snapshot camera state for gizmos before updating (matches the rendered scene)
            Gizmos.Begin(_freeCamera, io.DisplaySize);

            // Update free camera controls
            _freeCamera.Update(controller.PlayerCamera, io);

            // Handle object selection on left click (when not interacting with ImGui windows)
            if (ImGui.IsMouseClicked(ImGuiMouseButton.Left) && !ImGui.IsWindowHovered(ImGuiHoveredFlags.AnyWindow))
            {
                Selection = PickObject(io.MousePos, io.DisplaySize);
            }

            // Handle object deselect on Esc
            if (ImGui.IsKeyPressed(ImGuiKey.Escape))
            {
                Selection = null;
            }

            // Do ImGui layout
            foreach (var widget in _widgets)
            {
                widget.OnGUI();
            }

            // Draw selection gizmos
            if (Selection is PrimitiveComponent selectedComponent)
            {
                var bounds = selectedComponent.Bounds;
                Gizmos.DrawWireBox(bounds.Origin, bounds.BoxExtent, default, 0xFFFFFFFF);
            }
            else if (Selection is Actor selectedActor)
            {
                selectedActor.GetComponentsBoundingBox(out var box);
                var boxOrigin = (box.Min + box.Max) / 2f;
                var boxExtent = (box.Max - box.Min) / 2f;
                
                Gizmos.DrawWireBox(boxOrigin, boxExtent, selectedActor.Rotation, 0xFFFFFFFF);
            }

            _wasVisible = true;
        }
        else
        {
            // Exit dev mode
            if (_wasVisible)
            {
                ExitDevMode();
            }
        }
    }

    public void EnterDevMode()
    {
        var io = ImGui.GetIO();
        var controller = Game.GetPlayerController();
        var worldInfo = Game.GetWorldInfo();

        // Pause world
        worldInfo.Pauser = controller.PlayerReplicationInfo;

        // Prevent alt+tab from triggering the pause menu while already paused
        Game.GetEngine().bPauseOnLossOfFocus = false;

        // Block input from reaching the game while tools are visible
        io.WantCaptureMouse = true;
        io.WantCaptureKeyboard = true;

        // Hide game HUD
        controller.bGFxHideHUD = true;

        // Enable free camera
        _freeCamera.Activate(controller.PlayerCamera);
    }

    public void ExitDevMode()
    {
        var io = ImGui.GetIO();
        var controller = Game.GetPlayerController();
        var worldInfo = Game.GetWorldInfo();

        // Disable free camera
        _freeCamera.Deactivate(controller.PlayerCamera);

        // Unhide game HUD
        controller.bGFxHideHUD = false;

        // Stop blocking input
        io.MouseDrawCursor = false;
        io.WantCaptureKeyboard = false;
        io.WantCaptureMouse = false;

        // Re-enable normal pause-on-focus-loss behavior
        Game.GetEngine().bPauseOnLossOfFocus = true;

        // Unpause world
        worldInfo.Pauser = null;

        _wasVisible = false;
    }

    private GameObject? PickObject(Vector2 mousePos, Vector2 displaySize)
    {
        var worldOrigin = _freeCamera.Position;
        var worldDirection = _freeCamera.ScreenToWorldDirection(mousePos, displaySize);

        var traceEnd = worldOrigin + worldDirection * 100000f;

        var hitActor = Game.GetWorldInfo().Trace(
            out _,
            out _,
            traceEnd,
            worldOrigin,
            true,
            Vector3.Zero,
            out var hitInfo,
            0
        );

        if (hitActor is StaticMeshCollectionActor)
        {
            return hitInfo.HitComponent;
        }

        return hitActor;
    }
}
