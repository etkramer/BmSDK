#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RNavMeshGoal_SafeCombat<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RNavMeshGoal_SafeCombat : BmSDK.Engine.NavMeshPathGoalEvaluator, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RNavMeshGoal_SafeCombat", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RNavMeshGoal_SafeCombat() { }

    /// <summary>
    /// Constructs a new RNavMeshGoal_SafeCombat
    /// </summary>
    public RNavMeshGoal_SafeCombat(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RNavMeshGoal_SafeCombat Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RNavMeshGoal_SafeCombat(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: NavHandle
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT NavHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }
}
