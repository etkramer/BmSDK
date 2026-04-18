namespace DevMode;

public class MenuBar : Widget
{
    public sealed override void OnGUI()
    {
        ImGui.BeginMainMenuBar();
        ImGui.Text($"Dev Mode (press Home to exit)");
        ImGui.EndMainMenuBar();
    }
}
