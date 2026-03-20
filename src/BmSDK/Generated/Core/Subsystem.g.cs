#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK;

/// <summary>
/// Class: Subsystem<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class Subsystem : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Core.Subsystem", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Subsystem() { }

    /// <summary>
    /// Constructs a new Subsystem
    /// </summary>
    public Subsystem(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Subsystem Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Subsystem(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: VfTable_FExec
    /// </summary>
    public unsafe System.IntPtr VfTable_FExec
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
