using System.Numerics;
using BmSDK;
using BmSDK.Engine;

namespace DevMode;

public class PropertiesPanel : Widget
{
    private readonly Stack<GameObject> _navigationStack = new();
    private GameObject? _inspectedObject;
    private GameObject? _selectionRoot;

    public sealed override void OnGUI()
    {
        var selection = DevModeScript.Instance.Selection;
        if (selection is null)
        {
            ClearNavigation();
            return;
        }

        if (selection != _selectionRoot)
        {
            ClearNavigation();
            _selectionRoot = selection;
        }

        var obj = _inspectedObject ?? selection;
        if (!obj.IsValid)
        {
            ClearNavigation();
            return;
        }

        ImGui.SetNextWindowSize(new Vector2(400, 600), ImGuiCond.FirstUseEver);
        if (!ImGui.Begin("Properties###Properties"))
        {
            ImGui.End();
            return;
        }

        // Back button
        if (_navigationStack.Count > 0)
        {
            if (ImGui.SmallButton("< Back"))
            {
                _inspectedObject = _navigationStack.Pop();
                if (_inspectedObject == _selectionRoot)
                {
                    _inspectedObject = null;
                }
            }

            ImGui.SameLine();
        }

        // Header
        ImGui.TextColored(new Vector4(0.5f, 0.8f, 1f, 1f), obj.Name.ToString());
        ImGui.TextDisabled($"{obj.Class.Name} ({obj.GetPathName()})");

        ImGui.Separator();

        var labelWidth = ImGui.GetWindowWidth() * 0.35f;

        // Walk class hierarchy, most-derived first
        foreach (var structDef in obj.Class.EnumerateSupersAndSelf())
        {
            var properties = structDef.EnumerateFields()
                .OfType<Property>()
                .Where(p => (p.PropertyFlags & (Property.EPropertyFlags.CPF_Parm | Property.EPropertyFlags.CPF_ReturnParm)) == 0)
                .ToList();

            if (properties.Count == 0)
            {
                continue;
            }

            var flags = (structDef == obj.Class ? ImGuiTreeNodeFlags.DefaultOpen : ImGuiTreeNodeFlags.None) | ImGuiTreeNodeFlags.SpanFullWidth;
            var category = structDef.Name.ToString();
            if (ImGui.CollapsingHeader(category, flags))
            {
                foreach (var prop in properties)
                {
                    ImGui.PushID(prop.Ptr.ToInt32());
                    DrawProperty(obj, prop, labelWidth);
                    ImGui.PopID();
                }
            }
        }

        ImGui.End();
    }

    private static void PropertyLabel(string label, float labelWidth, string tooltip)
    {
        ImGui.AlignTextToFramePadding();
        // ImGui.Text(label);
        ImGui.TextDisabled(label);
        if (ImGui.IsItemHovered())
        {
            ImGui.SetTooltip(tooltip);
        }

        ImGui.SameLine(labelWidth);
        ImGui.SetNextItemWidth(-1);
    }

    private void ClearNavigation()
    {
        _navigationStack.Clear();
        _inspectedObject = null;
        _selectionRoot = null;
    }

    private void NavigateTo(GameObject target)
    {
        var current = _inspectedObject ?? DevModeScript.Instance.Selection!;
        _navigationStack.Push(current);
        _inspectedObject = target;
    }

    private void DrawProperty(GameObject obj, Property prop, float labelWidth)
    {
        var label = prop.Name.ToString();
        var tooltip = $"Type: {prop.Class.Name}";

        if (prop is FloatProperty)
        {
            PropertyLabel(label, labelWidth, tooltip);
            if (ImGui.DragFloat($"##{label}", ref prop.AsRef<float>(obj), 0.1f))
            {
                OnPropertyEdited(obj);
            }
        }
        else if (prop is IntProperty)
        {
            PropertyLabel(label, labelWidth, tooltip);
            ImGui.InputInt($"##{label}", ref prop.AsRef<int>(obj));
        }
        else if (prop is BoolProperty boolProp)
        {
            var value = boolProp.GetValue(obj);
            PropertyLabel(label, labelWidth, tooltip);
            if (ImGui.Checkbox($"##{label}", ref value))
            {
                boolProp.SetValue(obj, value);
            }
        }
        else if (prop is ByteProperty)
        {
            var value = (int)prop.AsRef<byte>(obj);
            PropertyLabel(label, labelWidth, tooltip);
            if (ImGui.DragInt($"##{label}", ref value, 1f, 0, 255))
            {
                prop.AsRef<byte>(obj) = (byte)value;
            }
        }
        else if (prop is StructProperty structProp)
        {
            DrawStructProperty(obj, structProp, label, labelWidth, tooltip);
        }
        else if (prop is NameProperty)
        {
            PropertyLabel(label, labelWidth, tooltip);
            ImGui.Text(prop.AsRef<FName>(obj).ToString());
        }
        else if (prop is StrProperty)
        {
            PropertyLabel(label, labelWidth, tooltip);
            ImGui.Text(prop.AsRef<FString>(obj).ToString() ?? "(null)");
        }
        else if (prop is ObjectProperty objProp)
        {
            DrawObjectProperty(obj, objProp, label, labelWidth, tooltip);
        }
        else if (prop is ArrayProperty arrProp)
        {
            PropertyLabel(label, labelWidth, tooltip);
            ImGui.TextDisabled($"[{arrProp.GetCount(obj)} elements]");
        }
        else
        {
            PropertyLabel(label, labelWidth, tooltip);
            ImGui.TextDisabled($"({prop.Class.Name})");
        }
    }

    private void DrawObjectProperty(GameObject obj, ObjectProperty prop, string label, float labelWidth, string tooltip)
    {
        var refObj = prop.GetValue(obj);
        if (refObj is null || !refObj.IsValid)
        {
            PropertyLabel(label, labelWidth, tooltip);
            ImGui.TextDisabled("None");
            return;
        }

        PropertyLabel(label, labelWidth, tooltip);
        if (ImGui.Button($"{refObj.Name}##nav", new Vector2(-1, 0)))
        {
            NavigateTo(refObj);
        }
    }

    private void DrawStructProperty(GameObject obj, StructProperty prop, string label, float labelWidth, string tooltip)
    {
        var structType = prop.Struct;
        if (structType is null || !structType.IsValid)
        {
            PropertyLabel(label, labelWidth, tooltip);
            ImGui.TextDisabled("(struct)");
            return;
        }

        var typeName = structType.Name.ToString();

        switch (typeName)
        {
            case "Vector":
            {
                PropertyLabel(label, labelWidth, tooltip);
                if (ImGui.DragFloat3($"##{label}", ref prop.AsRef<Vector3>(obj), 1f))
                {
                    OnPropertyEdited(obj);
                }

                break;
            }
            case "Rotator":
            {
                ref var rot = ref prop.AsRef<Rotator>(obj);
                var degrees = new Vector3(rot.Pitch, rot.Yaw, rot.Roll);
                PropertyLabel(label, labelWidth, tooltip);
                if (ImGui.DragFloat3($"##{label}", ref degrees, 1f))
                {
                    rot = new Rotator(degrees.X, degrees.Y, degrees.Z);
                    OnPropertyEdited(obj);
                }

                break;
            }
            case "Color":
            {
                ref var nativeColor = ref prop.AsRef<GameObject.FColor>(obj);
                var color = new Vector4(nativeColor.R / 255f, nativeColor.G / 255f, nativeColor.B / 255f, nativeColor.A / 255f);
                PropertyLabel(label, labelWidth, tooltip);
                if (ImGui.ColorEdit4($"##{label}", ref color))
                {
                    nativeColor.R = (byte)(color.X * 255f);
                    nativeColor.G = (byte)(color.Y * 255f);
                    nativeColor.B = (byte)(color.Z * 255f);
                    nativeColor.A = (byte)(color.W * 255f);
                    OnPropertyEdited(obj);
                }

                break;
            }
            case "LinearColor":
            {
                PropertyLabel(label, labelWidth, tooltip);
                if (ImGui.ColorEdit4($"##{label}", ref prop.AsRef<Vector4>(obj)))
                {
                    OnPropertyEdited(obj);
                }

                break;
            }
            default:
            {
                PropertyLabel(label, labelWidth, tooltip);
                ImGui.TextDisabled($"({typeName})");
                break;
            }
        }
    }

    public static void OnPropertyEdited(GameObject obj)
    {
        if (obj is Actor actor)
        {
            if (obj is Light)
            {
                // Reset DLEs so characters pick up location changes immediately
                foreach (var lightEnvironment in Game.FindObjects<DynamicLightEnvironmentComponent>())
                {
                    lightEnvironment?.ResetEnvironment();
                }
            }

            actor.ForceUpdateComponents(true);
        }
        else if (obj is ActorComponent component)
        {
            component.ForceUpdate(false);

            if (component is LightComponent)
            {
                // Reset DLEs so characters pick up color/brightness changes immediately
                foreach (var lightEnvironment in Game.FindObjects<DynamicLightEnvironmentComponent>())
                {
                    lightEnvironment?.ResetEnvironment();
                }
            }
        }
    }
}
