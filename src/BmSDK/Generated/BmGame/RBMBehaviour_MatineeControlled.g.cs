#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_MatineeControlled<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_MatineeControlled : BmSDK.BmGame.RBMBehaviour_Controlled, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_MatineeControlled", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_MatineeControlled() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_MatineeControlled
    /// </summary>
    public RBMBehaviour_MatineeControlled(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_MatineeControlled Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_MatineeControlled(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bAllowBasingOnVehicles
    /// </summary>
    public unsafe bool bAllowBasingOnVehicles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 588); }
    }

    /// <summary>
    /// BoolProperty: bStopDialogueOnActivate
    /// </summary>
    public unsafe bool bStopDialogueOnActivate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 588); }
    }
}
