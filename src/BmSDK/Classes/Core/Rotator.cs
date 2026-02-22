using System.Numerics;

namespace BmSDK;

/// <summary>
/// Represents a 3D rotation with pitch, yaw, and roll components in degrees.
/// </summary>
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

    private int _pitch;
    private int _yaw;
    private int _roll;

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
        _pitch = (int)MathF.Round(pitch * DegreesToRuuFactor);
        _yaw = (int)MathF.Round(yaw * DegreesToRuuFactor);
        _roll = (int)MathF.Round(roll * DegreesToRuuFactor);
    }

    /// <summary>
    /// Creates a new Rotator from raw RUU values.
    /// </summary>
    public static Rotator FromRuu(int pitch, int yaw, int roll)
    {
        Rotator r = default;
        r._pitch = pitch;
        r._yaw = yaw;
        r._roll = roll;
        return r;
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

        return new Vector3(cosPitch * cosYaw, cosPitch * sinYaw, sinPitch);
    }

    /// <summary>
    /// Creates a Rotator from a direction vector.
    /// The resulting Rotator has Roll set to 0.
    /// </summary>
    public static Rotator FromDirection(Vector3 direction)
    {
        float length = MathF.Sqrt(direction.X * direction.X + direction.Y * direction.Y);
        int pitch = (int)MathF.Round(MathF.Atan2(direction.Z, length) * RadiansToRuuFactor);
        int yaw = (int)MathF.Round(MathF.Atan2(direction.Y, direction.X) * RadiansToRuuFactor);

        return FromRuu(pitch, yaw, 0);
    }
}
