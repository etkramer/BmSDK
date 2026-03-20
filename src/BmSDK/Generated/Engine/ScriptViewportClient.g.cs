#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ScriptViewportClient<br/>
/// (size = 92)
/// (flags = 134217882)
/// </summary>
public partial class ScriptViewportClient : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ScriptViewportClient", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ScriptViewportClient() { }

    /// <summary>
    /// Constructs a new ScriptViewportClient
    /// </summary>
    public ScriptViewportClient(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ScriptViewportClient Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ScriptViewportClient(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: VfTable_FViewportClient
    /// </summary>
    public unsafe System.IntPtr VfTable_FViewportClient
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
