#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkStateGroupName<br/>
/// (size = 57)
/// (flags = 134217874)
/// </summary>
public partial class AkStateGroupName : BmSDK.Engine.AkAsset, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkStateGroupName", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkStateGroupName() { }

    /// <summary>
    /// Constructs a new AkStateGroupName
    /// </summary>
    public AkStateGroupName(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkStateGroupName Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkStateGroupName(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: StateGroupType
    /// </summary>
    public unsafe BmSDK.Engine.AkWwise.EAkGameSyncType StateGroupType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkWwise.EAkGameSyncType>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }
}
