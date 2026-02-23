using System.Numerics;

namespace BmSDK;

/// <summary>
/// Represents a 3D rotation with pitch, yaw, and roll components in degrees.
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public record struct Rotator
{
    /// <summary>
    /// Factor used to convert Rotational Unreal Units (RUUs) to degrees.
    /// </summary>
    public const float RuuToDegreesFactor = 360f / 65536f;

    /// <summary>
    /// Factor used to convert degrees to Rotational Unreal Units (RUUs).
    /// </summary>
    public const float DegreesToRuuFactor = 65536f / 360f;

    /// <summary>
    /// Factor used to convert Rotational Unreal Units (RUUs) to radians.
    /// </summary>
    public const float RuuToRadiansFactor = MathF.PI / 32768f;

    /// <summary>
    /// Factor used to convert radians to Rotational Unreal Units (RUUs).
    /// </summary>
    public const float RadiansToRuuFactor = 32768f / MathF.PI;

    int _pitch;
    int _yaw;
    int _roll;

    /// <summary>
    /// Pitch rotation in degrees.
    /// </summary>
    public float Pitch
    {
        readonly get => _pitch * RuuToDegreesFactor;
        set => _pitch = (int)MathF.Round(value * DegreesToRuuFactor);
    }

    /// <summary>
    /// Yaw rotation in degrees.
    /// </summary>
    public float Yaw
    {
        readonly get => _yaw * RuuToDegreesFactor;
        set => _yaw = (int)MathF.Round(value * DegreesToRuuFactor);
    }

    /// <summary>
    /// Roll rotation in degrees.
    /// </summary>
    public float Roll
    {
        readonly get => _roll * RuuToDegreesFactor;
        set => _roll = (int)MathF.Round(value * DegreesToRuuFactor);
    }

    /// <summary>
    /// Creates a new Rotator from degrees.
    /// </summary>
    public Rotator(float pitch, float yaw, float roll)
    {
        Pitch = pitch;
        Yaw = yaw;
        Roll = roll;
    }

    /// <summary>
    /// Creates a new Rotator from raw RUU values.
    /// </summary>
    public static Rotator FromRuu(int pitch, int yaw, int roll) => new()
    {
        _pitch = pitch,
        _yaw = yaw,
        _roll = roll,
    };

    /// <summary>
    /// Creates a Rotator from a direction vector.
    /// The resulting Rotator has Roll set to 0.
    /// </summary>
    public static Rotator FromDirection(Vector3 direction)
    {
        float length = MathF.Sqrt(direction.X * direction.X + direction.Y * direction.Y);
        float pitch = MathF.Atan2(direction.Z, length);
        float yaw = MathF.Atan2(direction.Y, direction.X);

        return FromRuu(
            pitch: (int)MathF.Round(pitch * RadiansToRuuFactor),
            yaw: (int)MathF.Round(yaw * RadiansToRuuFactor),
            roll: 0
        );
    }

    /// <summary>
    /// Converts the current pitch and yaw angles to a normalized direction vector.
    /// </summary>
    public readonly Vector3 ToDirection()
    {
        float pitchRad = _pitch * RuuToRadiansFactor;
        float yawRad = _yaw * RuuToRadiansFactor;

        float cosPitch = MathF.Cos(pitchRad);
        float sinPitch = MathF.Sin(pitchRad);
        float cosYaw = MathF.Cos(yawRad);
        float sinYaw = MathF.Sin(yawRad);

        return new(x: cosPitch * cosYaw, y: cosPitch * sinYaw, z: sinPitch);
    }
}
