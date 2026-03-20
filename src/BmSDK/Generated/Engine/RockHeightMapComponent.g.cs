#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RockHeightMapComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RockHeightMapComponent : BmSDK.Engine.ActorComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RockHeightMapComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RockHeightMapComponent() { }

    /// <summary>
    /// Constructs a new RockHeightMapComponent
    /// </summary>
    public RockHeightMapComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RockHeightMapComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RockHeightMapComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: SceneInfo
    /// </summary>
    public unsafe System.IntPtr SceneInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }
}
