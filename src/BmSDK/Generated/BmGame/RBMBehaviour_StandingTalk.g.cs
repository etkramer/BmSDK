#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_StandingTalk<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_StandingTalk : BmSDK.BmGame.RBMBehaviour, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_StandingTalk", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_StandingTalk() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_StandingTalk
    /// </summary>
    public RBMBehaviour_StandingTalk(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_StandingTalk Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_StandingTalk(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Subject
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Subject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// FloatProperty: StartTimer
    /// </summary>
    public unsafe float StartTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }
}
