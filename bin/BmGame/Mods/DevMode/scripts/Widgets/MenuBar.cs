namespace DevMode;

public class MenuBar : Widget
{
    private const string ControlsText = "RMB: Move Camera | Home: Exit ";

    public sealed override void OnGUI()
    {
        ImGui.BeginMainMenuBar();
        ImGui.Text("Dev Mode (press Home to exit)");

        var selection = DevModeScript.Instance.Selection;
        if (selection is not null)
        {
            ImGui.Separator();
            ImGui.Text($"Selected: {selection.Class.Name} ({selection.GetPathName()})");
        }

        var controlsWidth = ImGui.CalcTextSize(ControlsText).X;
        ImGui.SameLine(ImGui.GetWindowWidth() - controlsWidth - ImGui.GetStyle().ItemSpacing.X);
        ImGui.TextDisabled(ControlsText);

        ImGui.EndMainMenuBar();
    }
}
