#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkActionGlobal_MusicLocation<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AkActionGlobal_MusicLocation : BmSDK.Engine.AkActionGlobal, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkActionGlobal_MusicLocation", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkActionGlobal_MusicLocation() { }

    /// <summary>
    /// Constructs a new AkActionGlobal_MusicLocation
    /// </summary>
    public AkActionGlobal_MusicLocation(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkActionGlobal_MusicLocation Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkActionGlobal_MusicLocation(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: StateToResolveTo
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT StateToResolveTo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// BoolProperty: UseDeathAggLocation
    /// </summary>
    public unsafe bool UseDeathAggLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 156); }
    }

    /// <summary>
    /// StrProperty: DebugLocationComment
    /// </summary>
    public unsafe BmSDK.FString DebugLocationComment
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }
}
