using ImGuiNET;

[Script]
public class DevTools : Script
{
    private bool _visible;
    private bool _wasVisible;

    public override void OnKeyDown(Keys key)
    {
        if (key == Keys.Home)
        {
            _visible = !_visible;
        }
    }

    public override void OnGUI()
    {
        var controller = Game.GetPlayerController();
        if (_visible)
        {
            ImGui.ShowDemoWindow();

            // Show mouse cursor on open
            {
                controller.SetUIMouse(true);
                _wasVisible = true;
            }
        }
        else
        {
            // Hide mouse cursor on close
            if (_wasVisible)
            {
                controller.SetUIMouse(false);
                _wasVisible = false;
            }
        }
    }
}
