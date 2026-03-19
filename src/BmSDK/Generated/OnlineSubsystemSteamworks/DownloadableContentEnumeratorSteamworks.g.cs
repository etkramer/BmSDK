#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.OnlineSubsystemSteamworks;

/// <summary>
/// Class: DownloadableContentEnumeratorSteamworks<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class DownloadableContentEnumeratorSteamworks : BmSDK.Engine.DownloadableContentEnumerator, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "OnlineSubsystemSteamworks.DownloadableContentEnumeratorSteamworks", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DownloadableContentEnumeratorSteamworks() { }

    /// <summary>
    /// Constructs a new DownloadableContentEnumeratorSteamworks
    /// </summary>
    public DownloadableContentEnumeratorSteamworks(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DownloadableContentEnumeratorSteamworks Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DownloadableContentEnumeratorSteamworks(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: ReadsOutstanding
    /// </summary>
    public unsafe int ReadsOutstanding
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }
}
