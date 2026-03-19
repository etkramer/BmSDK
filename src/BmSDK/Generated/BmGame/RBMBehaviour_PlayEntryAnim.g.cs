#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_PlayEntryAnim<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_PlayEntryAnim : BmSDK.BmGame.RBMBehaviour_Controlled, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_PlayEntryAnim", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_PlayEntryAnim() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_PlayEntryAnim
    /// </summary>
    public RBMBehaviour_PlayEntryAnim(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_PlayEntryAnim Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_PlayEntryAnim(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bAlertedNearbyThugs
    /// </summary>
    public unsafe bool bAlertedNearbyThugs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// IntProperty: UnhideCounter
    /// </summary>
    public unsafe int UnhideCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }
}
