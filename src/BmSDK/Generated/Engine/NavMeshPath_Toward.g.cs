#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: NavMeshPath_Toward<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class NavMeshPath_Toward : BmSDK.Engine.NavMeshPathConstraint, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.NavMeshPath_Toward", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal NavMeshPath_Toward() { }

    /// <summary>
    /// Constructs a new NavMeshPath_Toward
    /// </summary>
    public NavMeshPath_Toward(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, NavMeshPath_Toward Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected NavMeshPath_Toward(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bBiasAgainstHighLevelPath
    /// </summary>
    public unsafe bool bBiasAgainstHighLevelPath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// FloatProperty: OutOfHighLevelPathBias
    /// </summary>
    public unsafe float OutOfHighLevelPathBias
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// ObjectProperty: GoalActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GoalActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// StructProperty: GoalPoint
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GoalPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }
}
