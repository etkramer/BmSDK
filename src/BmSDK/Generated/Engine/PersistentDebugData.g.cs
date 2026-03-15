#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: PersistentDebugData<br/>
/// (size = 48)
/// (flags = 134217874)
/// </summary>
public partial class PersistentDebugData : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.PersistentDebugData", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal PersistentDebugData() { }

    /// <summary>
    /// Constructs a new PersistentDebugData
    /// </summary>
    public PersistentDebugData(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, PersistentDebugData Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected PersistentDebugData(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: Debug_Disable_RFlaps_Update
    /// </summary>
    public unsafe bool Debug_Disable_RFlaps_Update
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 44); }
    }
}
