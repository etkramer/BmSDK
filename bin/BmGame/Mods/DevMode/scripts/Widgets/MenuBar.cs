namespace DevMode;

public class MenuBar : Widget
{
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

        ImGui.EndMainMenuBar();
    }
}
