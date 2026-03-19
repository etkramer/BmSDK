#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkParameterName<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AkParameterName : BmSDK.Engine.AkHash, BmSDK.IGameObject
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
    /// FloatProperty: MinValue
    /// </summary>
    public unsafe float MinValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// FloatProperty: MaxValue
    /// </summary>
    public unsafe float MaxValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// FloatProperty: DefaultValue
    /// </summary>
    public unsafe float DefaultValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }
}
