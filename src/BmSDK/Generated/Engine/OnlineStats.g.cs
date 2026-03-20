#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: OnlineStats<br/>
/// (flags = 0)
/// </summary>
public partial class OnlineStats : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.OnlineStats", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal OnlineStats() { }

    /// <summary>
    /// Constructs a new OnlineStats
    /// </summary>
    public OnlineStats(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, OnlineStats Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected OnlineStats(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: ViewIdMappings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Settings.FStringIdToStringMapping> ViewIdMappings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Settings.FStringIdToStringMapping>>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
