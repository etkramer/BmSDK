#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: Path_WithinTraversalDist<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class Path_WithinTraversalDist : BmSDK.Engine.PathConstraint, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.Path_WithinTraversalDist", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Path_WithinTraversalDist() { }

    /// <summary>
    /// Constructs a new Path_WithinTraversalDist
    /// </summary>
    public Path_WithinTraversalDist(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Path_WithinTraversalDist Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Path_WithinTraversalDist(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: MaxTraversalDist
    /// </summary>
    public unsafe float MaxTraversalDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bSoft
    /// </summary>
    public unsafe bool bSoft
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// FloatProperty: SoftStartPenalty
    /// </summary>
    public unsafe float SoftStartPenalty
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }
}
