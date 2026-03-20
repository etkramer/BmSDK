#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: FacebookIntegration<br/>
/// (flags = 0)
/// </summary>
public partial class FacebookIntegration : BmSDK.Engine.PlatformInterfaceBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.FacebookIntegration", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal FacebookIntegration() { }

    /// <summary>
    /// Constructs a new FacebookIntegration
    /// </summary>
    public FacebookIntegration(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, FacebookIntegration Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected FacebookIntegration(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: AppID
    /// </summary>
    public unsafe BmSDK.FString AppID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ArrayProperty: Permissions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> Permissions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// StrProperty: UserName
    /// </summary>
    public unsafe BmSDK.FString UserName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// StrProperty: UserId
    /// </summary>
    public unsafe BmSDK.FString UserId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// StrProperty: AccessToken
    /// </summary>
    public unsafe BmSDK.FString AccessToken
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// ArrayProperty: FriendsList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.FacebookIntegration.FFacebookFriend> FriendsList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.FacebookIntegration.FFacebookFriend>>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// Enum: EFacebookIntegrationDelegate
    /// </summary>
    public enum EFacebookIntegrationDelegate
    {
        FID_AuthorizationComplete = 0,
        FID_FacebookRequestComplete = 1,
        FID_DialogComplete = 2,
        FID_FriendsListComplete = 3,
        FID_MAX = 4,
    }
}
