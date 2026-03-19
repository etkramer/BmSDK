#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RNavMeshPath_WithinVolume<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RNavMeshPath_WithinVolume : BmSDK.Engine.NavMeshPathConstraint, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RNavMeshPath_WithinVolume", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RNavMeshPath_WithinVolume() { }

    /// <summary>
    /// Constructs a new RNavMeshPath_WithinVolume
    /// </summary>
    public RNavMeshPath_WithinVolume(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RNavMeshPath_WithinVolume Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RNavMeshPath_WithinVolume(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: WithinVol
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WithinVol
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: bOnlyThrowOutNodesThatLeaveVolume
    /// </summary>
    public unsafe bool bOnlyThrowOutNodesThatLeaveVolume
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }
}
