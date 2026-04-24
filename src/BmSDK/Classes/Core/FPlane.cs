using System.Numerics;

namespace BmSDK;

public partial class GameObject
{
    public partial record struct FPlane
    {
        public Vector3 ToVector3() => new(X, Y, Z);
    }
}
