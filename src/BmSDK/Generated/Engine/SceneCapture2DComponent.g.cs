#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SceneCapture2DComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SceneCapture2DComponent : BmSDK.Engine.SceneCaptureComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SceneCapture2DComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SceneCapture2DComponent() { }

    /// <summary>
    /// Constructs a new SceneCapture2DComponent
    /// </summary>
    public SceneCapture2DComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SceneCapture2DComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SceneCapture2DComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: TextureTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TextureTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// FloatProperty: FieldOfView
    /// </summary>
    public unsafe float FieldOfView
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// FloatProperty: NearPlane
    /// </summary>
    public unsafe float NearPlane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// FloatProperty: FarPlane
    /// </summary>
    public unsafe float FarPlane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// BoolProperty: bUpdateMatrices
    /// </summary>
    public unsafe bool bUpdateMatrices
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 232) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 232); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 232); }
    }

    /// <summary>
    /// StructProperty: ViewMatrix
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ViewMatrix
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// StructProperty: ProjMatrix
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ProjMatrix
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }
}
