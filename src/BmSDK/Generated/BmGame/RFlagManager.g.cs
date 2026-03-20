#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RFlagManager<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RFlagManager : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RFlagManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RFlagManager() { }

    /// <summary>
    /// Constructs a new RFlagManager
    /// </summary>
    public RFlagManager(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RFlagManager Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RFlagManager(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: NonSavedFlags
    /// </summary>
    public unsafe BmSDK.FString NonSavedFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: ChFlagsToNeverClear
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ChFlagsToNeverClear
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// MapProperty: Flags
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ Flags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }
}
