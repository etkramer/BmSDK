#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RPhysOnContactHandler<br/>
/// (flags = 0)
/// </summary>
public partial class RPhysOnContactHandler : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RPhysOnContactHandler", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPhysOnContactHandler() { }

    /// <summary>
    /// Constructs a new RPhysOnContactHandler
    /// </summary>
    public RPhysOnContactHandler(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPhysOnContactHandler Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPhysOnContactHandler(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: OwnerObject
    /// </summary>
    public unsafe BmSDK.GameObject OwnerObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
