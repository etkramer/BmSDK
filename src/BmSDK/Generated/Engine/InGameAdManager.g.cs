#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: InGameAdManager<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class InGameAdManager : BmSDK.Engine.PlatformInterfaceBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.InGameAdManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InGameAdManager() { }

    /// <summary>
    /// Constructs a new InGameAdManager
    /// </summary>
    public InGameAdManager(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InGameAdManager Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InGameAdManager(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bShouldPauseWhileAdOpen
    /// </summary>
    public unsafe bool bShouldPauseWhileAdOpen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// Enum: EAdManagerDelegate
    /// </summary>
    public enum EAdManagerDelegate
    {
        AMD_ClickedBanner = 0,
        AMD_UserClosedAd = 1,
        AMD_MAX = 2,
    }
}
