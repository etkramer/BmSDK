namespace DevMode;

[Script]
public class DevModeScript : Script
{
    private bool _visible;
    private bool _wasVisible;

    private readonly FreeCamera _freeCamera = new();
    private readonly List<Widget> _widgets = [];

    public override void Main() => OnLoad();

    public override void OnLoad()
    {
        _widgets.Add(new MenuBar());

        base.OnLoad();
    }

    public override void OnGUI()
    {
        if (ImGui.IsKeyPressed(ImGuiKey.Home))
        {
            _visible = !_visible;
        }

        var io = ImGui.GetIO();
        var controller = Game.GetPlayerController();
        var worldInfo = Game.GetWorldInfo();

        if (_visible)
        {
            // Enter dev mode
            if (!_wasVisible)
            {
                // Pause world
                worldInfo.Pauser = controller.PlayerReplicationInfo;

                // Block input from reaching the game while tools are visible
                io.WantCaptureMouse = true;
                io.WantCaptureKeyboard = true;

                // Hide game HUD
                controller.bGFxHideHUD = true;

                // Enable free camera
                _freeCamera.Activate(controller.PlayerCamera);
            }

            // Update free camera controls
            _freeCamera.Update(controller.PlayerCamera, io);

            // Do ImGui layout
            ImGui.ShowDemoWindow();
            ImGui.ShowAboutWindow();
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
                // Disable free camera
                _freeCamera.Deactivate(controller.PlayerCamera);

                // Unhide game HUD
                controller.bGFxHideHUD = false;

                // Stop blocking input
                io.MouseDrawCursor = false;
                io.WantCaptureKeyboard = false;
                io.WantCaptureMouse = false;

                // Unpause world
                worldInfo.Pauser = null;

                _wasVisible = false;
            }
        }
    }
}
