#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: ROnlineStatsWriteMostWanted<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ROnlineStatsWriteMostWanted : BmSDK.Engine.OnlineStatsWrite, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.ROnlineStatsWriteMostWanted", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ROnlineStatsWriteMostWanted() { }

    /// <summary>
    /// Constructs a new ROnlineStatsWriteMostWanted
    /// </summary>
    public ROnlineStatsWriteMostWanted(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ROnlineStatsWriteMostWanted Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ROnlineStatsWriteMostWanted(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: StatMappings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>> StatMappings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>>>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: Properties
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>> Properties
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ArrayProperty: ViewIds
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<System.IntPtr>> ViewIds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ArrayProperty: ArbitratedViewIds
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ArbitratedViewIds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// IntProperty: RatingId
    /// </summary>
    public unsafe int RatingId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// DelegateProperty: __OnStatsWriteComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnStatsWriteComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }
}
