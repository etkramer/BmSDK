#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMSeqEvent_WanderPointActivated<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMSeqEvent_WanderPointActivated : BmSDK.BmGame.RBMSeqEvent_BehaviourRoot, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMSeqEvent_WanderPointActivated", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMSeqEvent_WanderPointActivated() { }

    /// <summary>
    /// Constructs a new RBMSeqEvent_WanderPointActivated
    /// </summary>
    public RBMSeqEvent_WanderPointActivated(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMSeqEvent_WanderPointActivated Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMSeqEvent_WanderPointActivated(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: NumOutputs
    /// </summary>
    public unsafe int NumOutputs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// ArrayProperty: RequiredWeapon
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Class> RequiredWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }
}
