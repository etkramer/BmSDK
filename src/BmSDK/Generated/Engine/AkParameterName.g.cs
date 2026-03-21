#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkParameterName<br/>
/// (size = 57)
/// (flags = 134217874)
/// </summary>
public partial class AkParameterName : BmSDK.Engine.AkAsset, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkParameterName", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkParameterName() { }

    /// <summary>
    /// Constructs a new AkParameterName
    /// </summary>
    public AkParameterName(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkParameterName Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkParameterName(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: ParameterType
    /// </summary>
    public unsafe BmSDK.Engine.AkWwise.EAkGameSyncType ParameterType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkWwise.EAkGameSyncType>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }
}
