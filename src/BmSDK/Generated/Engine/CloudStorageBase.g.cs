#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: CloudStorageBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class CloudStorageBase : BmSDK.Engine.PlatformInterfaceBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.CloudStorageBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal CloudStorageBase() { }

    /// <summary>
    /// Constructs a new CloudStorageBase
    /// </summary>
    public CloudStorageBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, CloudStorageBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected CloudStorageBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: LocalCloudFiles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<System.IntPtr>> LocalCloudFiles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: bSuppressDelegateCalls
    /// </summary>
    public unsafe bool bSuppressDelegateCalls
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 132); }
    }

    /// <summary>
    /// Enum: ECloudStorageDelegate
    /// </summary>
    public enum ECloudStorageDelegate
    {
        CSD_KeyValueReadComplete = 0,
        CSD_KeyValueWriteComplete = 1,
        CSD_ValueChanged = 2,
        CSD_DocumentQueryComplete = 3,
        CSD_DocumentReadComplete = 4,
        CSD_DocumentWriteComplete = 5,
        CSD_DocumentConflictDetected = 6,
        CSD_MAX = 7,
    }
}
