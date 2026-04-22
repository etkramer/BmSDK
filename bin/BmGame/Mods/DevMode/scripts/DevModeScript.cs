using System.Numerics;
using BmSDK;
using BmSDK.Engine;
using Hexa.NET.ImGuizmo;

namespace DevMode;

[Script]
public class DevModeScript : Script
{
    public static DevModeScript Instance { get; private set; } = null!;

    public GameObject? Selection { get; set; }
    public FreeCamera FreeCamera { get; } = new();

    private const float GridSnapSize = 128f;

    private bool _visible;
    private bool _wasVisible;
    private readonly List<Widget> _widgets = [];

    public override void Main() => OnLoad();

    public override void OnLoad()
    {
        Instance = this;
        _widgets.Add(new MenuBar());
        _widgets.Add(new PropertiesPanel());
        _widgets.Add(new ContextMenu());

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
            Gizmos.Begin(FreeCamera, io.DisplaySize);

            // Build view/projection matrices
            var view = Gizmos.BuildViewMatrix(FreeCamera);
            var projection = Gizmos.BuildProjectionMatrix(FreeCamera.Fov, io.DisplaySize.X / io.DisplaySize.Y);

            // Update free camera controls
            FreeCamera.Update(controller.PlayerCamera, io);

            // Draw selection gizmos (before click handling so ImGuizmo.IsOver() is set)
            if (Selection is PrimitiveComponent selectedComponent)
            {
                var bounds = selectedComponent.Bounds;
                Gizmos.DrawWireBox(bounds.Origin, bounds.BoxExtent, default, 0xFFFFFFFF);
                ManipulateTranslation(selectedComponent, view, projection);
            }
            else if (Selection is Actor selectedActor)
            {
                selectedActor.GetComponentsBoundingBox(out var box);
                var boxOrigin = (box.Min + box.Max) / 2f;
                var boxExtent = (box.Max - box.Min) / 2f;
                Gizmos.DrawWireBox(boxOrigin, boxExtent, selectedActor.Rotation, 0xFFFFFFFF);
                ManipulateTranslation(selectedActor, view, projection);
            }

            // Handle object selection on left click (when not interacting with ImGui windows or gizmo)
            if (ImGui.IsMouseClicked(ImGuiMouseButton.Left) && !ImGui.IsWindowHovered(ImGuiHoveredFlags.AnyWindow) && !ImGuizmo.IsOver())
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
        FreeCamera.Activate(controller.PlayerCamera);
    }

    public void ExitDevMode()
    {
        var io = ImGui.GetIO();
        var controller = Game.GetPlayerController();
        var worldInfo = Game.GetWorldInfo();

        // Disable free camera
        FreeCamera.Deactivate(controller.PlayerCamera);

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

    private static Vector3 _dragStartWorldPos;
    private static Vector3 _dragGizmoWorldPos;
    private static Vector3 _componentDragStartTranslation;
    private static Vector3 _componentBasisX, _componentBasisY, _componentBasisZ;

    private static unsafe void ManipulateTranslation(GameObject selection, Matrix4x4 view, Matrix4x4 projection)
    {
        Vector3 worldPos;
        Rotator rotation;

        if (selection is Actor actor)
        {
            worldPos = actor.Location;
            rotation = actor.Rotation;
        }
        else if (selection is PrimitiveComponent component)
        {
            worldPos = component.Bounds.Origin;
            rotation = default;
        }
        else
        {
            return;
        }

        var wasDragging = ImGuizmo.IsUsing();
        if (wasDragging)
        {
            worldPos = _dragGizmoWorldPos;
        }

        Gizmos.RotationBasis(rotation, out var fwd, out var right, out var up);

        var matrix = new Matrix4x4(
            fwd.X,     fwd.Y,     fwd.Z,     0,
            right.X,   right.Y,   right.Z,   0,
            up.X,      up.Y,      up.Z,      0,
            worldPos.X, worldPos.Y, worldPos.Z, 1
        );

        var snap = new Vector3(GridSnapSize);
        var snapping = ImGui.IsKeyDown(ImGuiKey.LeftShift);

        ImGuizmo.Manipulate(
            (float*)&view, (float*)&projection,
            ImGuizmoOperation.Translate, ImGuizmoMode.Local,
            (float*)&matrix, null, snapping ? (float*)&snap : null
        );

        if (!ImGuizmo.IsUsing())
        {
            return;
        }

        if (!wasDragging)
        {
            _dragStartWorldPos = worldPos;
        }
        _dragGizmoWorldPos = matrix.Translation;

        var worldDelta = matrix.Translation - _dragStartWorldPos;

        if (selection is Actor a)
        {
            a.Location = matrix.Translation;
        }
        else if (selection is PrimitiveComponent c)
        {
            if (!wasDragging)
            {
                _componentDragStartTranslation = c.Translation;

                var ltw = (float*)(c.Ptr + 112);
                _componentBasisX = Vector3.Normalize(new Vector3(ltw[0], ltw[1], ltw[2]));
                _componentBasisY = Vector3.Normalize(new Vector3(ltw[4], ltw[5], ltw[6]));
                _componentBasisZ = Vector3.Normalize(new Vector3(ltw[8], ltw[9], ltw[10]));
            }

            var localDelta = new Vector3(
                Vector3.Dot(worldDelta, _componentBasisX),
                Vector3.Dot(worldDelta, _componentBasisY),
                Vector3.Dot(worldDelta, _componentBasisZ)
            );
            c.Translation = _componentDragStartTranslation + localDelta;
        }

        PropertiesPanel.OnPropertyEdited(selection);
    }

    private GameObject? PickObject(Vector2 mousePos, Vector2 displaySize)
    {
        var worldOrigin = FreeCamera.Position;
        var worldDirection = FreeCamera.ScreenToWorldDirection(mousePos, displaySize);

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
