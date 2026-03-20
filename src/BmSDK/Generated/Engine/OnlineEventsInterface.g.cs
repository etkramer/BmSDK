#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: OnlineEventsInterface<br/>
/// (flags = 0)
/// </summary>
public partial class OnlineEventsInterface : BmSDK.Interface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.OnlineEventsInterface", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal OnlineEventsInterface() { }

    /// <summary>
    /// Constructs a new OnlineEventsInterface
    /// </summary>
    public OnlineEventsInterface(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, OnlineEventsInterface Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected OnlineEventsInterface(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: UpdatePlaylistPopulation
    /// </summary>
    public unsafe bool UpdatePlaylistPopulation(int PlaylistId, int NumPlayers)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineEventsInterface.UpdatePlaylistPopulation", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlaylistId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumPlayers, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: UploadGameplayEventsData
    /// </summary>
    public unsafe bool UploadGameplayEventsData(BmSDK.Engine.OnlineSubsystem.FUniqueNetId UniqueId, out BmSDK.TArray<byte> Payload)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineEventsInterface.UploadGameplayEventsData", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UniqueId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Payload = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: UploadPlayerData
    /// </summary>
    public unsafe bool UploadPlayerData(BmSDK.Engine.OnlineSubsystem.FUniqueNetId UniqueId, BmSDK.FString PlayerNick, BmSDK.Engine.OnlineProfileSettings ProfileSettings, BmSDK.Engine.OnlinePlayerStorage PlayerStorage)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.OnlineEventsInterface.UploadPlayerData", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UniqueId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerNick, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileSettings, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerStorage, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 40);
    }
}
