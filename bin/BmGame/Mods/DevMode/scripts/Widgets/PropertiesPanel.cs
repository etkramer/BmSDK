using System.Numerics;
using BmSDK;
using BmSDK.Engine;

namespace DevMode;

public class PropertiesPanel : Widget
{
    private const int UObjectNameOffset = 28;
    private const int SpecializedPropertyFieldOffset = 88;

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
        ImGui.TextColored(new Vector4(0.5f, 0.8f, 1f, 1f), obj.Class.Name.ToString());
        ImGui.TextDisabled(obj.GetPathName());

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

            var flags = structDef == obj.Class ? ImGuiTreeNodeFlags.DefaultOpen : ImGuiTreeNodeFlags.None;
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

    private unsafe void DrawProperty(GameObject obj, Property prop, float labelWidth)
    {
        var label = prop.Name.ToString();
        var tooltip = $"Type: {prop.Class.Name}";

        if (prop is FloatProperty)
        {
            PropertyLabel(label, labelWidth, tooltip);
            if (ImGui.DragFloat($"##{label}", ref *(float*)(obj.Ptr + prop.Offset), 0.1f))
            {
                OnPropertyEdited(obj);
            }
        }
        else if (prop is IntProperty)
        {
            PropertyLabel(label, labelWidth, tooltip);
            ImGui.InputInt($"##{label}", ref *(int*)(obj.Ptr + prop.Offset));
        }
        else if (prop is BoolProperty boolProp)
        {
            var bitMask = *(int*)(boolProp.Ptr + SpecializedPropertyFieldOffset);
            var packed = (int*)(obj.Ptr + boolProp.Offset);
            var value = (*packed & bitMask) != 0;
            PropertyLabel(label, labelWidth, tooltip);
            if (ImGui.Checkbox($"##{label}", ref value))
            {
                *packed = value ? (*packed | bitMask) : (*packed & ~bitMask);
            }
        }
        else if (prop is ByteProperty)
        {
            var ptr = (byte*)(obj.Ptr + prop.Offset);
            var value = (int)*ptr;
            PropertyLabel(label, labelWidth, tooltip);
            if (ImGui.DragInt($"##{label}", ref value, 1f, 0, 255))
            {
                *ptr = (byte)value;
            }
        }
        else if (prop is StructProperty structProp)
        {
            DrawStructProperty(obj, structProp, label, labelWidth, tooltip);
        }
        else if (prop is NameProperty)
        {
            PropertyLabel(label, labelWidth, tooltip);
            var name = *(FName*)(obj.Ptr + prop.Offset);
            ImGui.Text(name.ToString());
        }
        else if (prop is StrProperty)
        {
            PropertyLabel(label, labelWidth, tooltip);
            var str = *(FString*)(obj.Ptr + prop.Offset);
            ImGui.Text(str.ToString() ?? "(null)");
        }
        else if (prop is ObjectProperty)
        {
            DrawObjectProperty(obj, prop, label, labelWidth, tooltip);
        }
        else if (prop is ArrayProperty)
        {
            PropertyLabel(label, labelWidth, tooltip);
            var count = *(int*)(obj.Ptr + prop.Offset + 4);
            ImGui.TextDisabled($"[{count} elements]");
        }
        else
        {
            PropertyLabel(label, labelWidth, tooltip);
            ImGui.TextDisabled($"({prop.Class.Name})");
        }
    }

    private unsafe void DrawObjectProperty(GameObject obj, Property prop, string label, float labelWidth, string tooltip)
    {
        var refPtr = *(IntPtr*)(obj.Ptr + prop.Offset);
        if (refPtr == IntPtr.Zero)
        {
            PropertyLabel(label, labelWidth, tooltip);
            ImGui.TextDisabled("None");
            return;
        }

        var refName = *(FName*)(refPtr + UObjectNameOffset);
        var csProp = obj.GetType().GetProperty(label);

        PropertyLabel(label, labelWidth, tooltip);
        if (csProp != null)
        {
            if (ImGui.Button($"{refName}##nav", new Vector2(-1, 0)))
            {
                if (csProp.GetValue(obj) is GameObject refObj && refObj.IsValid)
                {
                    NavigateTo(refObj);
                }
            }
        }
        else
        {
            ImGui.Text(refName.ToString());
        }
    }

    private unsafe void DrawStructProperty(GameObject obj, StructProperty prop, string label, float labelWidth, string tooltip)
    {
        var structTypePtr = *(IntPtr*)(prop.Ptr + SpecializedPropertyFieldOffset);
        if (structTypePtr == IntPtr.Zero)
        {
            PropertyLabel(label, labelWidth, tooltip);
            ImGui.TextDisabled("(struct)");
            return;
        }

        var structName = *(FName*)(structTypePtr + UObjectNameOffset);
        var typeName = structName.ToString();

        switch (typeName)
        {
            case "Vector":
            {
                PropertyLabel(label, labelWidth, tooltip);
                if (ImGui.DragFloat3($"##{label}", ref *(Vector3*)(obj.Ptr + prop.Offset), 1f))
                {
                    OnPropertyEdited(obj);
                }

                break;
            }
            case "Rotator":
            {
                var rotPtr = (Rotator*)(obj.Ptr + prop.Offset);
                var rot = *rotPtr;
                var degrees = new Vector3(rot.Pitch, rot.Yaw, rot.Roll);
                PropertyLabel(label, labelWidth, tooltip);
                if (ImGui.DragFloat3($"##{label}", ref degrees, 1f))
                {
                    *rotPtr = new Rotator(degrees.X, degrees.Y, degrees.Z);
                    OnPropertyEdited(obj);
                }

                break;
            }
            case "Color":
            {
                var ptr = (byte*)(obj.Ptr + prop.Offset);
                var color = new Vector4(ptr[2] / 255f, ptr[1] / 255f, ptr[0] / 255f, ptr[3] / 255f);
                PropertyLabel(label, labelWidth, tooltip);
                if (ImGui.ColorEdit4($"##{label}", ref color))
                {
                    ptr[0] = (byte)(color.Z * 255f);
                    ptr[1] = (byte)(color.Y * 255f);
                    ptr[2] = (byte)(color.X * 255f);
                    ptr[3] = (byte)(color.W * 255f);
                }

                break;
            }
            case "LinearColor":
            {
                PropertyLabel(label, labelWidth, tooltip);
                ImGui.ColorEdit4($"##{label}", ref *(Vector4*)(obj.Ptr + prop.Offset));
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

    private static void OnPropertyEdited(GameObject obj)
    {
        if (obj is Actor actor)
        {
            actor.ForceUpdateComponents(false, true);
        }
    }
}
