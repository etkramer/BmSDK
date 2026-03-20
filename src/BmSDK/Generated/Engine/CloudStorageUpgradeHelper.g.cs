#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: CloudStorageUpgradeHelper<br/>
/// (flags = 0)
/// </summary>
public partial class CloudStorageUpgradeHelper : BmSDK.Interface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.CloudStorageUpgradeHelper", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal CloudStorageUpgradeHelper() { }

    /// <summary>
    /// Constructs a new CloudStorageUpgradeHelper
    /// </summary>
    public CloudStorageUpgradeHelper(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, CloudStorageUpgradeHelper Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected CloudStorageUpgradeHelper(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetCloudUpgradeKeys
    /// </summary>
    public unsafe void GetCloudUpgradeKeys(out BmSDK.TArray<BmSDK.FString> CloudKeys)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.CloudStorageUpgradeHelper.GetCloudUpgradeKeys", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CloudKeys = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: HandleLocalKeyValue
    /// </summary>
    public unsafe void HandleLocalKeyValue(out BmSDK.FString CloudKeyName, out BmSDK.Engine.PlatformInterfaceBase.FPlatformInterfaceData CloudValue, out int bShouldMoveToCloud, out int bShouldDeleteLocalKey)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.CloudStorageUpgradeHelper.HandleLocalKeyValue", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CloudKeyName = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
        CloudValue = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlatformInterfaceBase.FPlatformInterfaceData>(paramsPtr + 16);
        bShouldMoveToCloud = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 60);
        bShouldDeleteLocalKey = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 64);
        return;
    }

    /// <summary>
    /// Function: HandleLocalDocument
    /// </summary>
    public unsafe void HandleLocalDocument(out BmSDK.FString DocName, out int bShouldMoveToCloud, out int bShouldDeleteLocalFile)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.CloudStorageUpgradeHelper.HandleLocalDocument", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DocName = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
        bShouldMoveToCloud = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
        bShouldDeleteLocalFile = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 20);
        return;
    }
}
