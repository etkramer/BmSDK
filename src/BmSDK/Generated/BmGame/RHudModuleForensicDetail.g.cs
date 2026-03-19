#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudModuleForensicDetail<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RHudModuleForensicDetail : BmSDK.BmGame.RHudModule, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHudModuleForensicDetail", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RHudModuleForensicDetail() { }

    /// <summary>
    /// Constructs a new RHudModuleForensicDetail
    /// </summary>
    public RHudModuleForensicDetail(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHudModuleForensicDetail Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHudModuleForensicDetail(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: AlreadyScanned
    /// </summary>
    public unsafe bool AlreadyScanned
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: ScanInProgress
    /// </summary>
    public unsafe bool ScanInProgress
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }
}
