#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnnounceAAITannoyRunner<br/>
/// (flags = 0)
/// </summary>
public partial class RAnnounceAAITannoyRunner : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnnounceAAITannoyRunner", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnnounceAAITannoyRunner() { }

    /// <summary>
    /// Constructs a new RAnnounceAAITannoyRunner
    /// </summary>
    public RAnnounceAAITannoyRunner(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnnounceAAITannoyRunner Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnnounceAAITannoyRunner(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Tannoy
    /// </summary>
    public unsafe BmSDK.BmGame.RJokerTannoy Tannoy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RJokerTannoy>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: OwningCasAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_Casualty OwningCasAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_Casualty>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ArrayProperty: PendingAnnouncementList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAnnounceAAITannoyRunner.FAnnouncementInfo> PendingAnnouncementList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAnnounceAAITannoyRunner.FAnnouncementInfo>>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: CurrentAnnouncement
    /// </summary>
    public unsafe BmSDK.BmGame.RAnnounceAAITannoyRunner.FAnnouncementInfo CurrentAnnouncement
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnnounceAAITannoyRunner.FAnnouncementInfo>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ArrayProperty: QueuedResponseList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAnnounceAAITannoyRunner.FAnnouncementInfo> QueuedResponseList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAnnounceAAITannoyRunner.FAnnouncementInfo>>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// BoolProperty: bPlayedLine
    /// </summary>
    public unsafe bool bPlayedLine
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// FloatProperty: WaitTimer
    /// </summary>
    public unsafe float WaitTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }
}
