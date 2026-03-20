#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkActionTargeted<br/>
/// (flags = 0)
/// </summary>
public partial class AkActionTargeted : BmSDK.Engine.AkAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkActionTargeted", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkActionTargeted() { }

    /// <summary>
    /// Constructs a new AkActionTargeted
    /// </summary>
    public AkActionTargeted(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkActionTargeted Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkActionTargeted(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: CustomTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor CustomTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }
}
