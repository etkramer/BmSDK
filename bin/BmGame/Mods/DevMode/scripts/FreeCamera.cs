using System.Numerics;
using BmSDK;
using BmSDK.Engine;

namespace DevMode;

public class FreeCamera
{
    private Vector3 _position;
    private float _pitch;
    private float _yaw;
    private float _fov;
    private GameObject.FTPOV _savedPOV;

    public void Activate(Camera camera)
    {
        _savedPOV = camera.CameraCache.POV;
        _position = _savedPOV.Location;
        _pitch = _savedPOV.Rotation.Pitch;
        _yaw = _savedPOV.Rotation.Yaw;
        _fov = _savedPOV.FOV;
    }

    public void Deactivate(Camera camera)
    {
        camera.CameraCache.POV = _savedPOV;
    }

    public void Update(Camera camera, ImGuiIOPtr io)
    {
        // RMB: Move camera
        var rightDown = ImGui.IsMouseDown(ImGuiMouseButton.Right);
        if (rightDown)
        {
            io.MouseDrawCursor = false;

            // Process mouse look
            var delta = io.MouseDelta;
            _yaw += delta.X * 0.15f;
            _pitch = Math.Clamp(_pitch - delta.Y * 0.15f, -90f, 90f);

            var speed = 500f * Game.GetDeltaTime();
            if (ImGui.IsKeyDown(ImGuiKey.LeftShift))
            {
                speed *= 3f;
            }

            // Get forward/right vectors
            var forward = new Rotator(_pitch, _yaw, 0).ToDirection();
            var right = new Rotator(0, _yaw + 90f, 0).ToDirection();

            // W: Move forward
            if (ImGui.IsKeyDown(ImGuiKey.W))
            {
                _position += forward * speed;
            }

            // A: Move left
            if (ImGui.IsKeyDown(ImGuiKey.A))
            {
                _position -= right * speed;
            }

            // S: Move back
            if (ImGui.IsKeyDown(ImGuiKey.S))
            {
                _position -= forward * speed;
            }

            // D: Move right
            if (ImGui.IsKeyDown(ImGuiKey.D))
            {
                _position += right * speed;
            }

            _fov = Math.Clamp(_fov - io.MouseWheel * 5f, 10f, 170f);
        }
        else
        {
            io.MouseDrawCursor = true;
        }

        var pov = camera.CameraCache.POV;
        pov.Location = _position;
        pov.Rotation = new Rotator(_pitch, _yaw, 0);
        pov.FOV = _fov;
        camera.CameraCache.POV = pov;
    }
}
