#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: UIDataStore_OnlinePlayerData<br/>
/// (size = 204)
/// (flags = 134217886)
/// </summary>
public partial class UIDataStore_OnlinePlayerData : BmSDK.Engine.UIDataStore_Remote, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.UIDataStore_OnlinePlayerData", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal UIDataStore_OnlinePlayerData() { }

    /// <summary>
    /// Constructs a new UIDataStore_OnlinePlayerData
    /// </summary>
    public UIDataStore_OnlinePlayerData(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, UIDataStore_OnlinePlayerData Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected UIDataStore_OnlinePlayerData(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetCachedPlayerStorage
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlinePlayerStorage GetCachedPlayerStorage(int ControllerId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UIDataStore_OnlinePlayerData.GetCachedPlayerStorage", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlinePlayerStorage>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetCachedPlayerProfile
    /// </summary>
    public unsafe virtual BmSDK.Engine.OnlineProfileSettings GetCachedPlayerProfile(int ControllerId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UIDataStore_OnlinePlayerData.GetCachedPlayerProfile", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineProfileSettings>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: ClearDelegates
    /// </summary>
    public unsafe virtual void ClearDelegates()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UIDataStore_OnlinePlayerData.ClearDelegates", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RegisterDelegates
    /// </summary>
    public unsafe virtual void RegisterDelegates()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UIDataStore_OnlinePlayerData.RegisterDelegates", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnPlayerDataChange
    /// </summary>
    public unsafe virtual void OnPlayerDataChange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UIDataStore_OnlinePlayerData.OnPlayerDataChange", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnLoginChange
    /// </summary>
    public unsafe virtual void OnLoginChange(byte LocalUserNum)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UIDataStore_OnlinePlayerData.OnLoginChange", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnUnregister
    /// </summary>
    public unsafe virtual void OnUnregister()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UIDataStore_OnlinePlayerData.OnUnregister", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnRegister
    /// </summary>
    public unsafe virtual void OnRegister(BmSDK.Engine.LocalPlayer InPlayer)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UIDataStore_OnlinePlayerData.OnRegister", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnSettingProviderChanged
    /// </summary>
    public unsafe virtual void OnSettingProviderChanged(BmSDK.Engine.UIDataProvider SourceProvider, BmSDK.FName SettingsName = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UIDataStore_OnlinePlayerData.OnSettingProviderChanged", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SourceProvider, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SettingsName, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// ObjectProperty: FriendsProvider
    /// </summary>
    public unsafe BmSDK.Engine.UIDataProvider_OnlineFriends FriendsProvider
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.UIDataProvider_OnlineFriends>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// IntProperty: PlayerControllerId
    /// </summary>
    public unsafe int PlayerControllerId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// StrProperty: PlayerNick
    /// </summary>
    public unsafe BmSDK.FString PlayerNick
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// StrProperty: ProfileSettingsClassName
    /// </summary>
    public unsafe BmSDK.FString ProfileSettingsClassName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// ClassProperty: ProfileSettingsClass
    /// </summary>
    public unsafe BmSDK.Class ProfileSettingsClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ObjectProperty: ProfileProvider
    /// </summary>
    public unsafe BmSDK.Engine.UIDataProvider_OnlineProfileSettings ProfileProvider
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.UIDataProvider_OnlineProfileSettings>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// StrProperty: PlayerStorageClassName
    /// </summary>
    public unsafe BmSDK.FString PlayerStorageClassName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ClassProperty: PlayerStorageClass
    /// </summary>
    public unsafe BmSDK.Class PlayerStorageClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// ObjectProperty: StorageProvider
    /// </summary>
    public unsafe BmSDK.Engine.UIDataProvider_OnlinePlayerStorage StorageProvider
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.UIDataProvider_OnlinePlayerStorage>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ObjectProperty: AchievementsProvider
    /// </summary>
    public unsafe BmSDK.Engine.UIDataProvider_PlayerAchievements AchievementsProvider
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.UIDataProvider_PlayerAchievements>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// StrProperty: FriendsProviderClassName
    /// </summary>
    public unsafe BmSDK.FString FriendsProviderClassName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// ClassProperty: FriendsProviderClass
    /// </summary>
    public unsafe BmSDK.Class FriendsProviderClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// StrProperty: AchievementsProviderClassName
    /// </summary>
    public unsafe BmSDK.FString AchievementsProviderClassName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// ClassProperty: AchievementsProviderClass
    /// </summary>
    public unsafe BmSDK.Class AchievementsProviderClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }
}
