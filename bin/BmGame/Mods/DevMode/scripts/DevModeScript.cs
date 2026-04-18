using System.Numerics;
using ImGuiNET;

namespace DevMode;

[Script]
public class DevModeScript : Script
{
    private bool _visible;
    private bool _wasVisible;

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
            // Block input from reaching the game while tools are visible
            io.WantCaptureMouse = true;
            io.WantCaptureKeyboard = true;
            io.MouseDrawCursor = true;

            // Enter dev mode
            if (!_wasVisible)
            {
                // Pause world
                worldInfo.Pauser = controller.PlayerReplicationInfo;
            }

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
                // Unpause world
                worldInfo.Pauser = null;

                // Stop blocking input
                io.MouseDrawCursor = false;
                io.WantCaptureKeyboard = false;
                io.WantCaptureMouse = false;

                _wasVisible = false;
            }
        }
    }
}
