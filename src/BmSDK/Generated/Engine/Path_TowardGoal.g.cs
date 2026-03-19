#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: Path_TowardGoal<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class Path_TowardGoal : BmSDK.Engine.PathConstraint, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.Path_TowardGoal", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Path_TowardGoal() { }

    /// <summary>
    /// Constructs a new Path_TowardGoal
    /// </summary>
    public Path_TowardGoal(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Path_TowardGoal Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Path_TowardGoal(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: GoalActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GoalActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }
}
