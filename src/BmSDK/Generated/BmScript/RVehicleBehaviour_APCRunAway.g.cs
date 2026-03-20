#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RVehicleBehaviour_APCRunAway<br/>
/// (flags = 0)
/// </summary>
public partial class RVehicleBehaviour_APCRunAway : BmSDK.BmGame.RVehicleBehaviour_RunAway, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RVehicleBehaviour_APCRunAway", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleBehaviour_APCRunAway() { }

    /// <summary>
    /// Constructs a new RVehicleBehaviour_APCRunAway
    /// </summary>
    public RVehicleBehaviour_APCRunAway(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleBehaviour_APCRunAway Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleBehaviour_APCRunAway(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: OverrideChapterDifficulty
    /// </summary>
    public unsafe int OverrideChapterDifficulty
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }
}
