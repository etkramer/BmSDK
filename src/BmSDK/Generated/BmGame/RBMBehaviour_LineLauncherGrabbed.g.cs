#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_LineLauncherGrabbed<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_LineLauncherGrabbed : BmSDK.BmGame.RBMBehaviour_Controlled, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_LineLauncherGrabbed", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_LineLauncherGrabbed() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_LineLauncherGrabbed
    /// </summary>
    public RBMBehaviour_LineLauncherGrabbed(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_LineLauncherGrabbed Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_LineLauncherGrabbed(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Victim
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Victim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }
}
