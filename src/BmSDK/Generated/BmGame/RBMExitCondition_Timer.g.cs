#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMExitCondition_Timer<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMExitCondition_Timer : BmSDK.BmGame.RBMExitCondition, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMExitCondition_Timer", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMExitCondition_Timer() { }

    /// <summary>
    /// Constructs a new RBMExitCondition_Timer
    /// </summary>
    public RBMExitCondition_Timer(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMExitCondition_Timer Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMExitCondition_Timer(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: ExitTime
    /// </summary>
    public unsafe float ExitTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// FloatProperty: ExitTimer
    /// </summary>
    public unsafe float ExitTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// BoolProperty: bTimerActive
    /// </summary>
    public unsafe bool bTimerActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 452); }
    }

    /// <summary>
    /// BoolProperty: bUseSyncForTimerStart
    /// </summary>
    public unsafe bool bUseSyncForTimerStart
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 452); }
    }
}
