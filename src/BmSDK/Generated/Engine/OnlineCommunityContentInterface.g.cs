#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: OnlineCommunityContentInterface<br/>
/// (flags = 0)
/// </summary>
public partial class OnlineCommunityContentInterface : BmSDK.Interface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.OnlineCommunityContentInterface", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal OnlineCommunityContentInterface() { }

    /// <summary>
    /// Constructs a new OnlineCommunityContentInterface
    /// </summary>
    public OnlineCommunityContentInterface(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, OnlineCommunityContentInterface Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected OnlineCommunityContentInterface(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: RateContent
    /// </summary>
    public unsafe void RateContent(byte PlayerNum, out BmSDK.Engine.OnlineSubsystem.FCommunityContentFile FileToRate, int NewRating)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineCommunityContentInterface.RateContent", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRating, paramsPtr + 60);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        FileToRate = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FCommunityContentFile>(paramsPtr + 4);
        return;
    }

    /// <summary>
    /// Function: ClearGetContentPayloadCompleteDelegate
    /// </summary>
    public unsafe void ClearGetContentPayloadCompleteDelegate(System.IntPtr GetContentPayloadCompleteDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineCommunityContentInterface.ClearGetContentPayloadCompleteDelegate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GetContentPayloadCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddGetContentPayloadCompleteDelegate
    /// </summary>
    public unsafe void AddGetContentPayloadCompleteDelegate(System.IntPtr GetContentPayloadCompleteDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineCommunityContentInterface.AddGetContentPayloadCompleteDelegate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GetContentPayloadCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnGetContentPayloadComplete
    /// </summary>
    public unsafe void OnGetContentPayloadComplete(bool bWasSuccessful, BmSDK.Engine.OnlineSubsystem.FCommunityContentFile FileDownloaded, out BmSDK.TArray<byte> Payload)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineCommunityContentInterface.OnGetContentPayloadComplete", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FileDownloaded, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Payload = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(paramsPtr + 60);
        return;
    }

    /// <summary>
    /// Function: GetContentPayload
    /// </summary>
    public unsafe bool GetContentPayload(byte PlayerNum, out BmSDK.Engine.OnlineSubsystem.FCommunityContentFile FileDownloaded)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineCommunityContentInterface.GetContentPayload", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        FileDownloaded = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FCommunityContentFile>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 60);
    }

    /// <summary>
    /// Function: ClearDownloadContentCompleteDelegate
    /// </summary>
    public unsafe void ClearDownloadContentCompleteDelegate(System.IntPtr DownloadContentCompleteDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineCommunityContentInterface.ClearDownloadContentCompleteDelegate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DownloadContentCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddDownloadContentCompleteDelegate
    /// </summary>
    public unsafe void AddDownloadContentCompleteDelegate(System.IntPtr DownloadContentCompleteDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineCommunityContentInterface.AddDownloadContentCompleteDelegate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DownloadContentCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnDownloadContentComplete
    /// </summary>
    public unsafe void OnDownloadContentComplete(bool bWasSuccessful, BmSDK.Engine.OnlineSubsystem.FCommunityContentFile FileDownloaded)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineCommunityContentInterface.OnDownloadContentComplete", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FileDownloaded, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DownloadContent
    /// </summary>
    public unsafe bool DownloadContent(byte PlayerNum, out BmSDK.Engine.OnlineSubsystem.FCommunityContentFile FileToDownload)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineCommunityContentInterface.DownloadContent", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        FileToDownload = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FCommunityContentFile>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 60);
    }

    /// <summary>
    /// Function: ClearUploadContentCompleteDelegate
    /// </summary>
    public unsafe void ClearUploadContentCompleteDelegate(System.IntPtr UploadContentCompleteDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineCommunityContentInterface.ClearUploadContentCompleteDelegate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UploadContentCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddUploadContentCompleteDelegate
    /// </summary>
    public unsafe void AddUploadContentCompleteDelegate(System.IntPtr UploadContentCompleteDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineCommunityContentInterface.AddUploadContentCompleteDelegate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UploadContentCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnUploadContentComplete
    /// </summary>
    public unsafe void OnUploadContentComplete(bool bWasSuccessful, BmSDK.Engine.OnlineSubsystem.FCommunityContentFile UploadedFile)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineCommunityContentInterface.OnUploadContentComplete", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UploadedFile, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UploadContent
    /// </summary>
    public unsafe bool UploadContent(byte PlayerNum, out BmSDK.TArray<byte> Payload, out BmSDK.Engine.OnlineSubsystem.FCommunityContentMetadata MetaData)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineCommunityContentInterface.UploadContent", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Payload = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(paramsPtr + 4);
        MetaData = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FCommunityContentMetadata>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 40);
    }

    /// <summary>
    /// Function: GetFriendsContentList
    /// </summary>
    public unsafe bool GetFriendsContentList(byte PlayerNum, out BmSDK.Engine.OnlineSubsystem.FOnlineFriend Friend, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FCommunityContentFile> ContentFiles)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineCommunityContentInterface.GetFriendsContentList", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Friend = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FOnlineFriend>(paramsPtr + 4);
        ContentFiles = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FCommunityContentFile>>(paramsPtr + 60);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 76);
    }

    /// <summary>
    /// Function: ClearReadFriendsContentListCompleteDelegate
    /// </summary>
    public unsafe void ClearReadFriendsContentListCompleteDelegate(System.IntPtr ReadFriendsContentListCompleteDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineCommunityContentInterface.ClearReadFriendsContentListCompleteDelegate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadFriendsContentListCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddReadFriendsContentListCompleteDelegate
    /// </summary>
    public unsafe void AddReadFriendsContentListCompleteDelegate(System.IntPtr ReadFriendsContentListCompleteDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineCommunityContentInterface.AddReadFriendsContentListCompleteDelegate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadFriendsContentListCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnReadFriendsContentListComplete
    /// </summary>
    public unsafe void OnReadFriendsContentListComplete(bool bWasSuccessful)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineCommunityContentInterface.OnReadFriendsContentListComplete", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ReadFriendsContentList
    /// </summary>
    public unsafe bool ReadFriendsContentList(byte PlayerNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineFriend> Friends, int StartAt = default, int NumToRead = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineCommunityContentInterface.ReadFriendsContentList", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartAt, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumToRead, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Friends = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineFriend>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: GetContentList
    /// </summary>
    public unsafe bool GetContentList(byte PlayerNum, out BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FCommunityContentFile> ContentFiles)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineCommunityContentInterface.GetContentList", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ContentFiles = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FCommunityContentFile>>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: ClearReadContentListCompleteDelegate
    /// </summary>
    public unsafe void ClearReadContentListCompleteDelegate(System.IntPtr ReadContentListCompleteDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineCommunityContentInterface.ClearReadContentListCompleteDelegate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadContentListCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddReadContentListCompleteDelegate
    /// </summary>
    public unsafe void AddReadContentListCompleteDelegate(System.IntPtr ReadContentListCompleteDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineCommunityContentInterface.AddReadContentListCompleteDelegate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReadContentListCompleteDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnReadContentListComplete
    /// </summary>
    public unsafe void OnReadContentListComplete(bool bWasSuccessful)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineCommunityContentInterface.OnReadContentListComplete", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ReadContentList
    /// </summary>
    public unsafe bool ReadContentList(byte PlayerNum, int StartAt = default, int NumToRead = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineCommunityContentInterface.ReadContentList", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartAt, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumToRead, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: Exit
    /// </summary>
    public unsafe void Exit()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineCommunityContentInterface.Exit", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe bool Init()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineCommunityContentInterface.Init", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }
}
