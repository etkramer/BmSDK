#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: NavMeshPath_SameCoverLink<br/>
/// (flags = 0)
/// </summary>
public partial class NavMeshPath_SameCoverLink : BmSDK.Engine.NavMeshPathConstraint, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.NavMeshPath_SameCoverLink", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal NavMeshPath_SameCoverLink() { }

    /// <summary>
    /// Constructs a new NavMeshPath_SameCoverLink
    /// </summary>
    public NavMeshPath_SameCoverLink(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, NavMeshPath_SameCoverLink Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected NavMeshPath_SameCoverLink(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: TestLink
    /// </summary>
    public unsafe BmSDK.Engine.CoverLink TestLink
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CoverLink>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }
}
