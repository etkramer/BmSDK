#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: OnlineSubsystem<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class OnlineSubsystem : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.OnlineSubsystem", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal OnlineSubsystem() { }

    /// <summary>
    /// Constructs a new OnlineSubsystem
    /// </summary>
    public OnlineSubsystem(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, OnlineSubsystem Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected OnlineSubsystem(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: VfTable_FTickableObject
    /// </summary>
    public unsafe System.IntPtr VfTable_FTickableObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// InterfaceProperty: AccountInterface
    /// </summary>
    public unsafe BmSDK.Engine.OnlineAccountInterface AccountInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineAccountInterface>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// InterfaceProperty: PlayerInterface
    /// </summary>
    public unsafe BmSDK.Engine.OnlinePlayerInterface PlayerInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlinePlayerInterface>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// InterfaceProperty: PlayerInterfaceEx
    /// </summary>
    public unsafe BmSDK.Engine.OnlinePlayerInterfaceEx PlayerInterfaceEx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlinePlayerInterfaceEx>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// InterfaceProperty: SystemInterface
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSystemInterface SystemInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSystemInterface>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// InterfaceProperty: GameInterface
    /// </summary>
    public unsafe BmSDK.Engine.OnlineGameInterface GameInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineGameInterface>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// InterfaceProperty: ContentInterface
    /// </summary>
    public unsafe BmSDK.Engine.OnlineContentInterface ContentInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineContentInterface>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// InterfaceProperty: VoiceInterface
    /// </summary>
    public unsafe BmSDK.Engine.OnlineVoiceInterface VoiceInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineVoiceInterface>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// InterfaceProperty: WebInterface
    /// </summary>
    public unsafe BmSDK.Engine.OnlineWebInterface WebInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineWebInterface>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// InterfaceProperty: StatsInterface
    /// </summary>
    public unsafe BmSDK.Engine.OnlineStatsInterface StatsInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineStatsInterface>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// InterfaceProperty: NewsInterface
    /// </summary>
    public unsafe BmSDK.Engine.OnlineNewsInterface NewsInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineNewsInterface>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// InterfaceProperty: CustomContentInterface
    /// </summary>
    public unsafe BmSDK.Engine.OnlineCustomContentInterface CustomContentInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineCustomContentInterface>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// InterfaceProperty: CustomContentCacheInterface
    /// </summary>
    public unsafe BmSDK.Engine.ROnlineCustomContentCacheInterface CustomContentCacheInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ROnlineCustomContentCacheInterface>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// BoolProperty: bWasLastLoginAutomatic
    /// </summary>
    public unsafe bool bWasLastLoginAutomatic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }
    }

    /// <summary>
    /// BoolProperty: bUseBuildIdOverride
    /// </summary>
    public unsafe bool bUseBuildIdOverride
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }
    }

    /// <summary>
    /// FloatProperty: TimeGuideLastOpened
    /// </summary>
    public unsafe float TimeGuideLastOpened
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// FloatProperty: TimeGuideLastClosed
    /// </summary>
    public unsafe float TimeGuideLastClosed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// InterfaceProperty: PartyChatInterface
    /// </summary>
    public unsafe BmSDK.Engine.OnlinePartyChatInterface PartyChatInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlinePartyChatInterface>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// InterfaceProperty: TitleFileInterface
    /// </summary>
    public unsafe BmSDK.Engine.OnlineTitleFileInterface TitleFileInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineTitleFileInterface>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// InterfaceProperty: TitleFileCacheInterface
    /// </summary>
    public unsafe BmSDK.Engine.OnlineTitleFileCacheInterface TitleFileCacheInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineTitleFileCacheInterface>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// InterfaceProperty: UserCloudInterface
    /// </summary>
    public unsafe BmSDK.Engine.UserCloudFileInterface UserCloudInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.UserCloudFileInterface>(Ptr + 344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }
    }

    /// <summary>
    /// InterfaceProperty: SharedCloudInterface
    /// </summary>
    public unsafe BmSDK.Engine.SharedCloudFileInterface SharedCloudInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SharedCloudFileInterface>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// InterfaceProperty: SocialInterface
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSocialInterface SocialInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSocialInterface>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// InterfaceProperty: AuthInterface
    /// </summary>
    public unsafe BmSDK.Engine.OnlineAuthInterface AuthInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineAuthInterface>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// MapProperty: VoiceRecMap
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ VoiceRecMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// ArrayProperty: NamedInterfaces
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FNamedInterface> NamedInterfaces
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FNamedInterface>>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// ArrayProperty: NamedInterfaceDefs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FNamedInterfaceDef> NamedInterfaceDefs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FNamedInterfaceDef>>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// ArrayProperty: Sessions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FNamedSession> Sessions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FNamedSession>>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// IntProperty: BuildIdOverride
    /// </summary>
    public unsafe int BuildIdOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// StrProperty: IniLocPatcherClassName
    /// </summary>
    public unsafe BmSDK.FString IniLocPatcherClassName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// ObjectProperty: Patcher
    /// </summary>
    public unsafe BmSDK.Engine.IniLocPatcher Patcher
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.IniLocPatcher>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// FloatProperty: AsyncMinCompletionTime
    /// </summary>
    public unsafe float AsyncMinCompletionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }
}
