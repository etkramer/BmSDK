#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.IpDrv;

/// <summary>
/// ABSTRACT Class: MCPBase<br/>
/// (size = 48)
/// (flags = 134217875)
/// </summary>
public partial class MCPBase : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "IpDrv.MCPBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MCPBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MCPBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: VfTable_FTickableObject
    /// </summary>
    public unsafe System.IntPtr VfTable_FTickableObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }
}
