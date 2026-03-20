#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: Path_TowardPoint<br/>
/// (flags = 0)
/// </summary>
public partial class Path_TowardPoint : BmSDK.Engine.PathConstraint, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.Path_TowardPoint", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Path_TowardPoint() { }

    /// <summary>
    /// Constructs a new Path_TowardPoint
    /// </summary>
    public Path_TowardPoint(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Path_TowardPoint Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Path_TowardPoint(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: GoalPoint
    /// </summary>
    public unsafe System.Numerics.Vector3 GoalPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }
}
