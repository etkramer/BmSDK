#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: InteractiveFoliageComponent<br/>
/// (size = 756)
/// (flags = 2290094290)
/// </summary>
public partial class InteractiveFoliageComponent : BmSDK.Engine.StaticMeshComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.InteractiveFoliageComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InteractiveFoliageComponent() { }

    /// <summary>
    /// Constructs a new InteractiveFoliageComponent
    /// </summary>
    public InteractiveFoliageComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InteractiveFoliageComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InteractiveFoliageComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: FoliageSceneProxy
    /// </summary>
    public unsafe System.IntPtr FoliageSceneProxy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }
}
