#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.IpDrv;

/// <summary>
/// Class: OnlineSubsystemCommonImpl<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class OnlineSubsystemCommonImpl : BmSDK.Engine.OnlineSubsystem, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "IpDrv.OnlineSubsystemCommonImpl", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal OnlineSubsystemCommonImpl() { }

    /// <summary>
    /// Constructs a new OnlineSubsystemCommonImpl
    /// </summary>
    public OnlineSubsystemCommonImpl(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, OnlineSubsystemCommonImpl Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected OnlineSubsystemCommonImpl(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: VoiceEngine
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VoiceEngine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// IntProperty: MaxLocalTalkers
    /// </summary>
    public unsafe int MaxLocalTalkers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// IntProperty: MaxRemoteTalkers
    /// </summary>
    public unsafe int MaxRemoteTalkers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// BoolProperty: bIsUsingSpeechRecognition
    /// </summary>
    public unsafe bool bIsUsingSpeechRecognition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: bOverrideCustomContentAccessMode
    /// </summary>
    public unsafe bool bOverrideCustomContentAccessMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// ObjectProperty: GameInterfaceImpl
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GameInterfaceImpl
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// ObjectProperty: AuthInterfaceImpl
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AuthInterfaceImpl
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// ObjectProperty: TitleFileDownloadCache
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TitleFileDownloadCache
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// ObjectProperty: CustomContentCacheManager
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CustomContentCacheManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// ByteProperty: CustomContentAccessModeOverride
    /// </summary>
    public unsafe byte CustomContentAccessModeOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// ArrayProperty: OnlineCustomContentRequests
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>> OnlineCustomContentRequests
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }
}
