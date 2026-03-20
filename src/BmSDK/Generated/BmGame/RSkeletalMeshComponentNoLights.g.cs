#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSkeletalMeshComponentNoLights<br/>
/// (flags = 0)
/// </summary>
public partial class RSkeletalMeshComponentNoLights : BmSDK.Engine.SkeletalMeshComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSkeletalMeshComponentNoLights", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSkeletalMeshComponentNoLights() { }

    /// <summary>
    /// Constructs a new RSkeletalMeshComponentNoLights
    /// </summary>
    public RSkeletalMeshComponentNoLights(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSkeletalMeshComponentNoLights Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSkeletalMeshComponentNoLights(nint ptr) : base(ptr) { }

}
