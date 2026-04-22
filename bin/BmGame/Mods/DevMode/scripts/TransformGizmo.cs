using System.Numerics;
using BmSDK;
using BmSDK.Engine;
using Hexa.NET.ImGuizmo;

namespace DevMode;

public class TransformGizmo
{
    private const float GridSnapSize = 128f;

    private Vector3 _dragStartWorldPos;
    private Vector3 _dragGizmoWorldPos;
    private Vector3 _componentDragStartTranslation;
    private Vector3 _componentBasisX, _componentBasisY, _componentBasisZ;

    public void Draw(GameObject selection, Matrix4x4 view, Matrix4x4 projection)
    {
        if (selection is PrimitiveComponent component)
        {
            var bounds = component.Bounds;
            Gizmos.DrawWireBox(bounds.Origin, bounds.BoxExtent, default, 0xFFFFFFFF);
            Manipulate(selection, view, projection);
        }
        else if (selection is Actor actor)
        {
            actor.GetComponentsBoundingBox(out var box);
            var boxOrigin = (box.Min + box.Max) / 2f;
            var boxExtent = (box.Max - box.Min) / 2f;
            Gizmos.DrawWireBox(boxOrigin, boxExtent, actor.Rotation, 0xFFFFFFFF);
            Manipulate(selection, view, projection);
        }
    }

    private unsafe void Manipulate(GameObject selection, Matrix4x4 view, Matrix4x4 projection)
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
}
