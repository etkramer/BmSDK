using System.Numerics;

namespace BmSDK;

public partial class GameObject
{
    public partial record struct FRotator
    {
        /// <summary>
        /// Factor used to convert Rotational Unreal Units (RUUs) to radians.
        /// This is useful for using trigonomic functions on FRotators.
        /// </summary>
        public const float RuuToRadiansFactor = MathF.PI / 32768f;
        /// <summary>
        /// Factor used to convert radians to Rotational Unreal Units (RUUs).
        /// This is useful when applying angles to FRotators.
        /// </summary>
        public const float RadiansToRuuFactor = 1f / RuuToRadiansFactor;

        public FRotator(int pitch, int yaw, int roll)
        {
            Pitch = pitch;
            Yaw = yaw;
            Roll = roll;
        }

        /// <summary>
        /// Converts the current pitch and yaw angles to a normalized direction vector.
        /// </summary>
        /// <returns>A tuple containing the x, y, and z components of the direction vector
        /// corresponding to the FRotator.</returns>
        public (float x, float y, float z) ToDirectionCoords()
        {
            float pitchRad = Pitch * RuuToRadiansFactor;
            float sinPitch = MathF.Sin(pitchRad);
            float cosPitch = MathF.Cos(pitchRad);

            float yawRad = Yaw * RuuToRadiansFactor;
            float sinYaw = MathF.Sin(yawRad);
            float cosYaw = MathF.Cos(yawRad);

            return (x: cosPitch * cosYaw, y: cosPitch * sinYaw, z: sinPitch);
        }

        /// <summary>
        /// Converts the instance's pitch and yaw to a directional unit <see cref="FVector"/>.
        /// </summary>
        /// <returns>An FVector that represents the direction of the FRotator.</returns>
        public FVector ToFVector()
        {
            var (x, y, z) = ToDirectionCoords();
            return new(x, y, z);
        }

        /// <summary>
        /// Converts the instance's pitch and yaw to a directional unit <see cref="Vector3"/>.
        /// </summary>
        /// <returns>An Vector3 that represents the direction of the FRotator.</returns>
        public Vector3 ToVector3()
        {
            var (x, y, z) = ToDirectionCoords();
            return new(x, y, z);
        }

        /// <summary>
        /// Creates an FRotator representing the orientation corresponding to the specified direction vector components.
        /// </summary>
        /// <remarks>The input vector does not need to be normalized.
        /// The resulting FRotator has Roll set to 0.</remarks>
        /// <param name="x">The X component of the direction vector.</param>
        /// <param name="y">The Y component of the direction vector.</param>
        /// <param name="z">The Z component of the direction vector.</param>
        /// <returns>An FRotator instance with pitch and yaw calculated from the direction vector.</returns>
        public static FRotator FromDirectionCoords(float x, float y, float z)
        {
            float length = MathF.Sqrt(x * x + y * y);
            float pitch = MathF.Atan2(z, length) * RadiansToRuuFactor;
            float yaw = MathF.Atan2(y, x) * RadiansToRuuFactor;

            return new FRotator(
                (int)MathF.Round(pitch),
                (int)MathF.Round(yaw),
                roll: 0
            );
        }

        /// <summary>
        /// Creates an FRotator representing the orientation corresponding to the specified direction <see cref="FVector"/>.
        /// </summary>
        /// <remarks>The input vector does not need to be normalized.
        /// The resulting FRotator has Roll set to 0.</remarks>
        /// <param name="v">The direction vector for which to compute the rotation.</param>
        /// <returns>An FRotator corresponding to the FVector.</returns>
        public static FRotator FromFVector(FVector v) => FromDirectionCoords(v.X, v.Y, v.Z);

        /// <summary>
        /// Creates an FRotator representing the orientation corresponding to the specified direction <see cref="Vector3"/>.
        /// </summary>
        /// <remarks>The input vector does not need to be normalized.
        /// The resulting FRotator has Roll set to 0.</remarks>
        /// <param name="v">The direction vector for which to compute the rotation.</param>
        /// <returns>An FRotator corresponding to the Vector3.</returns>
        public static FRotator FromVector3(Vector3 v) => FromDirectionCoords(v.X, v.Y, v.Z);

        public static explicit operator FRotator(FVector v) => FromFVector(v);

        public static explicit operator FRotator(Vector3 v) => FromVector3(v);

        public static explicit operator FVector(FRotator r) => r.ToFVector();

        public static explicit operator Vector3(FRotator r) => r.ToVector3();
    }

    public partial record struct FVector
    {
        public FVector(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vector3 ToVector3() => new(X, Y, Z);

        /// <summary>
        /// Converts this vector to an FRotator representing its orientation.
        /// <see cref="FRotator.FromFVector(FVector)"/>
        /// </summary>
        /// <returns>An FRotator that describes the orientation of this vector.</returns>
        public FRotator ToFRotator() => FRotator.FromFVector(this);

        public static FVector FromVector3(Vector3 v) => new(v.X, v.Y, v.Z);

        public static implicit operator Vector3(FVector v) => v.ToVector3();

        public static implicit operator FVector(Vector3 v) => FromVector3(v);
    }

    public partial record struct FVector2D
    {
        public FVector2D(float x, float y)
        {
            X = x;
            Y = y;
        }

        public Vector2 ToVector2() => new(X, Y);

        public static FVector2D FromVector2(Vector2 v) => new(v.X, v.Y);

        public static implicit operator Vector2(FVector2D v) => v.ToVector2();

        public static implicit operator FVector2D(Vector2 v) => FromVector2(v);
    }

    public partial record struct FVector4
    {
        public FVector4(float x, float y, float z, float w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        public Vector4 ToVector4() => new(X, Y, Z, W);

        public static FVector4 FromVector4(Vector4 v) => new(v.X, v.Y, v.Z, v.W);

        public static implicit operator Vector4(FVector4 v) => v.ToVector4();

        public static implicit operator FVector4(Vector4 v) => FromVector4(v);
    }
}
