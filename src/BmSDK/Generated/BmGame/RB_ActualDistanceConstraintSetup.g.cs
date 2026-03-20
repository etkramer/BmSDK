#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RB_ActualDistanceConstraintSetup<br/>
/// (size = 300)
/// (flags = 0)
/// </summary>
public partial class RB_ActualDistanceConstraintSetup : BmSDK.Engine.RB_ConstraintSetup, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RB_ActualDistanceConstraintSetup", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RB_ActualDistanceConstraintSetup() { }

    /// <summary>
    /// Constructs a new RB_ActualDistanceConstraintSetup
    /// </summary>
    public RB_ActualDistanceConstraintSetup(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RB_ActualDistanceConstraintSetup Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RB_ActualDistanceConstraintSetup(nint ptr) : base(ptr) { }

}
