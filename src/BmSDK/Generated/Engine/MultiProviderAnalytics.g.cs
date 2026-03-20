#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MultiProviderAnalytics<br/>
/// (flags = 0)
/// </summary>
public partial class MultiProviderAnalytics : BmSDK.Engine.AnalyticEventsBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MultiProviderAnalytics", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MultiProviderAnalytics() { }

    /// <summary>
    /// Constructs a new MultiProviderAnalytics
    /// </summary>
    public MultiProviderAnalytics(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MultiProviderAnalytics Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MultiProviderAnalytics(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: AnalyticsProviderClassNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> AnalyticsProviderClassNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// ArrayProperty: AnalyticsProviders
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnalyticEventsBase> AnalyticsProviders
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnalyticEventsBase>>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }
}
