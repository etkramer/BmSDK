#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RSkeletalMeshPhysSceneInterface<br/>
/// (size = 92)
/// (flags = 0)
/// </summary>
public partial class RSkeletalMeshPhysSceneInterface : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RSkeletalMeshPhysSceneInterface", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSkeletalMeshPhysSceneInterface() { }

    /// <summary>
    /// Constructs a new RSkeletalMeshPhysSceneInterface
    /// </summary>
    public RSkeletalMeshPhysSceneInterface(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSkeletalMeshPhysSceneInterface Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSkeletalMeshPhysSceneInterface(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: VfTable_IRAsyncPhysXSceneInterface
    /// </summary>
    public unsafe System.IntPtr VfTable_IRAsyncPhysXSceneInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
