#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: Path_AvoidInEscapableNodes<br/>
/// (flags = 0)
/// </summary>
public partial class Path_AvoidInEscapableNodes : BmSDK.Engine.PathConstraint, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.Path_AvoidInEscapableNodes", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Path_AvoidInEscapableNodes() { }

    /// <summary>
    /// Constructs a new Path_AvoidInEscapableNodes
    /// </summary>
    public Path_AvoidInEscapableNodes(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Path_AvoidInEscapableNodes Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Path_AvoidInEscapableNodes(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: Radius
    /// </summary>
    public unsafe int Radius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// IntProperty: Height
    /// </summary>
    public unsafe int Height
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// IntProperty: MaxFallSpeed
    /// </summary>
    public unsafe int MaxFallSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// IntProperty: MoveFlags
    /// </summary>
    public unsafe int MoveFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }
}
