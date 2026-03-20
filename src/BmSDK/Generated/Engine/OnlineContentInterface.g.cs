#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: OnlineContentInterface<br/>
/// (size = 84)
/// (flags = 0)
/// </summary>
public partial class OnlineContentInterface : BmSDK.Interface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.OnlineContentInterface", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal OnlineContentInterface() { }

    /// <summary>
    /// Constructs a new OnlineContentInterface
    /// </summary>
    public OnlineContentInterface(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, OnlineContentInterface Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected OnlineContentInterface(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: ClearSaveGames
    /// </summary>
    public unsafe bool ClearSaveGames(byte LocalUserNum)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.ClearSaveGames", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: DeleteSaveGame
    /// </summary>
    public unsafe bool DeleteSaveGame(byte LocalUserNum, int DeviceID, BmSDK.FString FriendlyName, BmSDK.FString Filename)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.DeleteSaveGame", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendlyName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 40);
    }

    /// <summary>
    /// Function: ClearWriteSaveGameDataComplete
    /// </summary>
    public unsafe void ClearWriteSaveGameDataComplete(byte LocalUserNum, System.IntPtr WriteSaveGameDataCompleteDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.ClearWriteSaveGameDataComplete", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteSaveGameDataCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddWriteSaveGameDataComplete
    /// </summary>
    public unsafe void AddWriteSaveGameDataComplete(byte LocalUserNum, System.IntPtr WriteSaveGameDataCompleteDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.AddWriteSaveGameDataComplete", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WriteSaveGameDataCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnWriteSaveGameDataComplete
    /// </summary>
    public unsafe void OnWriteSaveGameDataComplete(bool bWasSuccessful, byte LocalUserNum, int DeviceID, BmSDK.FString FriendlyName, BmSDK.FString Filename, BmSDK.FString SaveFileName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.OnWriteSaveGameDataComplete", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendlyName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SaveFileName, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: WriteSaveGameData
    /// </summary>
    public unsafe bool WriteSaveGameData(byte LocalUserNum, int DeviceID, BmSDK.FString FriendlyName, BmSDK.FString Filename, BmSDK.FString SaveFileName, out BmSDK.TArray<byte> SaveGameData)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.WriteSaveGameData", true);
        byte* paramsPtr = stackalloc byte[76];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendlyName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SaveFileName, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        SaveGameData = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(paramsPtr + 56);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 72);
    }

    /// <summary>
    /// Function: ClearReadSaveGameDataComplete
    /// </summary>
    public unsafe void ClearReadSaveGameDataComplete(byte LocalUserNum, System.IntPtr ReadSaveGameDataCompleteDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.ClearReadSaveGameDataComplete", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadSaveGameDataCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddReadSaveGameDataComplete
    /// </summary>
    public unsafe void AddReadSaveGameDataComplete(byte LocalUserNum, System.IntPtr ReadSaveGameDataCompleteDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.AddReadSaveGameDataComplete", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadSaveGameDataCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnReadSaveGameDataComplete
    /// </summary>
    public unsafe void OnReadSaveGameDataComplete(bool bWasSuccessful, byte LocalUserNum, int DeviceID, BmSDK.FString FriendlyName, BmSDK.FString Filename, BmSDK.FString SaveFileName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.OnReadSaveGameDataComplete", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendlyName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SaveFileName, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetSaveGameData
    /// </summary>
    public unsafe bool GetSaveGameData(byte LocalUserNum, int DeviceID, BmSDK.FString FriendlyName, BmSDK.FString Filename, BmSDK.FString SaveFileName, out byte bIsValid, out BmSDK.TArray<byte> SaveGameData)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.GetSaveGameData", true);
        byte* paramsPtr = stackalloc byte[80];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendlyName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SaveFileName, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        bIsValid = BmSDK.Framework.MarshalUtil.ToManaged<byte>(paramsPtr + 56);
        SaveGameData = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(paramsPtr + 60);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 76);
    }

    /// <summary>
    /// Function: ReadSaveGameData
    /// </summary>
    public unsafe bool ReadSaveGameData(byte LocalUserNum, int DeviceID, BmSDK.FString FriendlyName, BmSDK.FString Filename, BmSDK.FString SaveFileName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.ReadSaveGameData", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendlyName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SaveFileName, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 56);
    }

    /// <summary>
    /// Function: GetAvailableDownloadCounts
    /// </summary>
    public unsafe void GetAvailableDownloadCounts(byte LocalUserNum, out int NewDownloads, out int TotalDownloads)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.GetAvailableDownloadCounts", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        NewDownloads = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
        TotalDownloads = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
        return;
    }

    /// <summary>
    /// Function: ClearQueryAvailableDownloadsComplete
    /// </summary>
    public unsafe void ClearQueryAvailableDownloadsComplete(byte LocalUserNum, System.IntPtr QueryDownloadsDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.ClearQueryAvailableDownloadsComplete", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QueryDownloadsDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddQueryAvailableDownloadsComplete
    /// </summary>
    public unsafe void AddQueryAvailableDownloadsComplete(byte LocalUserNum, System.IntPtr QueryDownloadsDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.AddQueryAvailableDownloadsComplete", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QueryDownloadsDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnQueryAvailableDownloadsComplete
    /// </summary>
    public unsafe void OnQueryAvailableDownloadsComplete(bool bWasSuccessful)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.OnQueryAvailableDownloadsComplete", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: QueryAvailableDownloads
    /// </summary>
    public unsafe bool QueryAvailableDownloads(byte LocalUserNum, int CategoryMask = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.QueryAvailableDownloads", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CategoryMask, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: ClearCrossTitleSaveGames
    /// </summary>
    public unsafe bool ClearCrossTitleSaveGames(byte LocalUserNum)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.ClearCrossTitleSaveGames", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: ClearReadCrossTitleSaveGameDataComplete
    /// </summary>
    public unsafe void ClearReadCrossTitleSaveGameDataComplete(byte LocalUserNum, System.IntPtr ReadSaveGameDataCompleteDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.ClearReadCrossTitleSaveGameDataComplete", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadSaveGameDataCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddReadCrossTitleSaveGameDataComplete
    /// </summary>
    public unsafe void AddReadCrossTitleSaveGameDataComplete(byte LocalUserNum, System.IntPtr ReadSaveGameDataCompleteDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.AddReadCrossTitleSaveGameDataComplete", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadSaveGameDataCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnReadCrossTitleSaveGameDataComplete
    /// </summary>
    public unsafe void OnReadCrossTitleSaveGameDataComplete(bool bWasSuccessful, byte LocalUserNum, int DeviceID, int TitleId, BmSDK.FString FriendlyName, BmSDK.FString Filename, BmSDK.FString SaveFileName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.OnReadCrossTitleSaveGameDataComplete", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendlyName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SaveFileName, paramsPtr + 48);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetCrossTitleSaveGameData
    /// </summary>
    public unsafe bool GetCrossTitleSaveGameData(byte LocalUserNum, int DeviceID, int TitleId, BmSDK.FString FriendlyName, BmSDK.FString Filename, BmSDK.FString SaveFileName, out byte bIsValid, out BmSDK.TArray<byte> SaveGameData)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.GetCrossTitleSaveGameData", true);
        byte* paramsPtr = stackalloc byte[84];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendlyName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SaveFileName, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        bIsValid = BmSDK.Framework.MarshalUtil.ToManaged<byte>(paramsPtr + 60);
        SaveGameData = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(paramsPtr + 64);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 80);
    }

    /// <summary>
    /// Function: ReadCrossTitleSaveGameData
    /// </summary>
    public unsafe bool ReadCrossTitleSaveGameData(byte LocalUserNum, int DeviceID, int TitleId, BmSDK.FString FriendlyName, BmSDK.FString Filename, BmSDK.FString SaveFileName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.ReadCrossTitleSaveGameData", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FriendlyName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Filename, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SaveFileName, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 60);
    }

    /// <summary>
    /// Function: ClearReadCrossTitleContentCompleteDelegate
    /// </summary>
    public unsafe void ClearReadCrossTitleContentCompleteDelegate(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, System.IntPtr ReadContentCompleteDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.ClearReadCrossTitleContentCompleteDelegate", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadContentCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddReadCrossTitleContentCompleteDelegate
    /// </summary>
    public unsafe void AddReadCrossTitleContentCompleteDelegate(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, System.IntPtr ReadContentCompleteDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.AddReadCrossTitleContentCompleteDelegate", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadContentCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnReadCrossTitleContentComplete
    /// </summary>
    public unsafe void OnReadCrossTitleContentComplete(bool bWasSuccessful)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.OnReadCrossTitleContentComplete", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetCrossTitleContentList
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState GetCrossTitleContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineCrossTitleContent> ContentList)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.GetCrossTitleContentList", true);
        byte* paramsPtr = stackalloc byte[21];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ContentList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineCrossTitleContent>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: ClearCrossTitleContentList
    /// </summary>
    public unsafe void ClearCrossTitleContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.ClearCrossTitleContentList", true);
        byte* paramsPtr = stackalloc byte[2];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ReadCrossTitleContentList
    /// </summary>
    public unsafe bool ReadCrossTitleContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, int TitleId = default, int DeviceID = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.ReadCrossTitleContentList", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TitleId, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetUserLanguage
    /// </summary>
    public unsafe BmSDK.FString GetUserLanguage()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.GetUserLanguage", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetUserCountryCode
    /// </summary>
    public unsafe BmSDK.FString GetUserCountryCode()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.GetUserCountryCode", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ShowPS4DownloadList
    /// </summary>
    public unsafe void ShowPS4DownloadList(byte LocalUserNum)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.ShowPS4DownloadList", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowPS4StoreIcon
    /// </summary>
    public unsafe void ShowPS4StoreIcon(bool bShow, int Position = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.ShowPS4StoreIcon", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShow, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BrowseInGameStoreItem
    /// </summary>
    public unsafe void BrowseInGameStoreItem(byte LocalUserNum, BmSDK.FString ItemId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.BrowseInGameStoreItem", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PurchaseInGameStoreItem
    /// </summary>
    public unsafe void PurchaseInGameStoreItem(byte LocalUserNum, BmSDK.FString ItemId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.PurchaseInGameStoreItem", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemId, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearPurchaseInGameStoreContentComplete
    /// </summary>
    public unsafe void ClearPurchaseInGameStoreContentComplete(byte LocalUserNum, System.IntPtr PurchaseInGameStoreContentComplete)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.ClearPurchaseInGameStoreContentComplete", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PurchaseInGameStoreContentComplete, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddPurchaseInGameStoreContentComplete
    /// </summary>
    public unsafe void AddPurchaseInGameStoreContentComplete(byte LocalUserNum, System.IntPtr PurchaseInGameStoreContentComplete)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.AddPurchaseInGameStoreContentComplete", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PurchaseInGameStoreContentComplete, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnPurchaseInGameStoreContentComplete
    /// </summary>
    public unsafe void OnPurchaseInGameStoreContentComplete(bool bWasSuccessful)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.OnPurchaseInGameStoreContentComplete", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetInGameStoreContentList
    /// </summary>
    public unsafe void GetInGameStoreContentList(byte LocalUserNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineStoreContent> ContentList)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.GetInGameStoreContentList", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ContentList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineStoreContent>>(paramsPtr + 4);
        return;
    }

    /// <summary>
    /// Function: ReadInGameStoreContentList
    /// </summary>
    public unsafe bool ReadInGameStoreContentList(byte LocalUserNum)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.ReadInGameStoreContentList", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: ClearInGameStoreContentList
    /// </summary>
    public unsafe void ClearInGameStoreContentList(byte LocalUserNum)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.ClearInGameStoreContentList", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearReadInGameStoreContentComplete
    /// </summary>
    public unsafe void ClearReadInGameStoreContentComplete(byte LocalUserNum, System.IntPtr ReadInGameStoreContentComplete)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.ClearReadInGameStoreContentComplete", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadInGameStoreContentComplete, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddReadInGameStoreContentComplete
    /// </summary>
    public unsafe void AddReadInGameStoreContentComplete(byte LocalUserNum, System.IntPtr ReadInGameStoreContentComplete)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.AddReadInGameStoreContentComplete", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadInGameStoreContentComplete, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnReadInGameStoreContentComplete
    /// </summary>
    public unsafe void OnReadInGameStoreContentComplete(bool bWasSuccessful)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.OnReadInGameStoreContentComplete", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearContentStatusChangeDelegate
    /// </summary>
    public unsafe void ClearContentStatusChangeDelegate(System.IntPtr ContentStatusChangeDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.ClearContentStatusChangeDelegate", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentStatusChangeDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddContentStatusChangeDelegate
    /// </summary>
    public unsafe void AddContentStatusChangeDelegate(System.IntPtr ContentStatusChangeDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.AddContentStatusChangeDelegate", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentStatusChangeDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnContentStatusChange
    /// </summary>
    public unsafe void OnContentStatusChange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.OnContentStatusChange", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetContentList
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState GetContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineContent> ContentList)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.GetContentList", true);
        byte* paramsPtr = stackalloc byte[21];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ContentList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineContent>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: ClearContentList
    /// </summary>
    public unsafe void ClearContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.ClearContentList", true);
        byte* paramsPtr = stackalloc byte[2];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ReadContentList
    /// </summary>
    public unsafe bool ReadContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, int DeviceID = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.ReadContentList", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: HasContentUpdated
    /// </summary>
    public unsafe bool HasContentUpdated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.HasContentUpdated", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ClearReadContentComplete
    /// </summary>
    public unsafe void ClearReadContentComplete(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, System.IntPtr ReadContentCompleteDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.ClearReadContentComplete", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadContentCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddReadContentComplete
    /// </summary>
    public unsafe void AddReadContentComplete(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, System.IntPtr ReadContentCompleteDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.AddReadContentComplete", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentType, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadContentCompleteDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnReadContentComplete
    /// </summary>
    public unsafe void OnReadContentComplete(bool bWasSuccessful)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.OnReadContentComplete", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearContentChangeDelegate
    /// </summary>
    public unsafe void ClearContentChangeDelegate(System.IntPtr ContentDelegate, byte LocalUserNum = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.ClearContentChangeDelegate", true);
        byte* paramsPtr = stackalloc byte[17];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentDelegate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddContentChangeDelegate
    /// </summary>
    public unsafe void AddContentChangeDelegate(System.IntPtr ContentDelegate, byte LocalUserNum = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.AddContentChangeDelegate", true);
        byte* paramsPtr = stackalloc byte[17];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContentDelegate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnContentChange
    /// </summary>
    public unsafe void OnContentChange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineContentInterface.OnContentChange", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
