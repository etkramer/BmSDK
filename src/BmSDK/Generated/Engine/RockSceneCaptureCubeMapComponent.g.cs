#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RockSceneCaptureCubeMapComponent<br/>
/// (size = 256)
/// (flags = 134217874)
/// </summary>
public partial class RockSceneCaptureCubeMapComponent : BmSDK.Engine.SceneCaptureCubeMapComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RockSceneCaptureCubeMapComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RockSceneCaptureCubeMapComponent() { }

    /// <summary>
    /// Constructs a new RockSceneCaptureCubeMapComponent
    /// </summary>
    public RockSceneCaptureCubeMapComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RockSceneCaptureCubeMapComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RockSceneCaptureCubeMapComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: SceneInfo
    /// </summary>
    public unsafe System.IntPtr SceneInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// ByteProperty: DepthPriorityGroup
    /// </summary>
    public unsafe BmSDK.Engine.Scene.ESceneDepthPriorityGroup DepthPriorityGroup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Scene.ESceneDepthPriorityGroup>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// BoolProperty: bIsInteriorMappingSceneCapture
    /// </summary>
    public unsafe bool bIsInteriorMappingSceneCapture
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 252) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 252); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 252); }
    }
}
