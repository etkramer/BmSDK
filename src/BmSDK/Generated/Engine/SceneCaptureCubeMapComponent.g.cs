#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SceneCaptureCubeMapComponent<br/>
/// (size = 164)
/// (flags = 134217874)
/// </summary>
public partial class SceneCaptureCubeMapComponent : BmSDK.Engine.SceneCaptureComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SceneCaptureCubeMapComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SceneCaptureCubeMapComponent() { }

    /// <summary>
    /// Constructs a new SceneCaptureCubeMapComponent
    /// </summary>
    public SceneCaptureCubeMapComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SceneCaptureCubeMapComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SceneCaptureCubeMapComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: TextureTarget
    /// </summary>
    public unsafe BmSDK.Engine.TextureRenderTargetCube TextureTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.TextureRenderTargetCube>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// FloatProperty: NearPlane
    /// </summary>
    public unsafe float NearPlane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// FloatProperty: FarPlane
    /// </summary>
    public unsafe float FarPlane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// StructProperty: WorldLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 WorldLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }
}
