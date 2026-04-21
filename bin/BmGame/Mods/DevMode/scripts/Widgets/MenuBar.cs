namespace DevMode;

public class MenuBar : Widget
{
    public sealed override void OnGUI()
    {
        ImGui.BeginMainMenuBar();
        ImGui.Text("Dev Mode (press Home to exit)");

        var selectedObject = DevModeScript.Instance.SelectedObject;
        if (selectedObject is not null)
        {
            ImGui.Separator();
            ImGui.Text($"Selected: {selectedObject.Class.Name} ({selectedObject.GetPathName()})");
        }

        ImGui.EndMainMenuBar();
    }
}
