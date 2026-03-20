#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ApexForceFieldComponent<br/>
/// (flags = 0)
/// </summary>
public partial class ApexForceFieldComponent : BmSDK.Engine.ApexFieldSamplerComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ApexForceFieldComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ApexForceFieldComponent() { }

    /// <summary>
    /// Constructs a new ApexForceFieldComponent
    /// </summary>
    public ApexForceFieldComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ApexForceFieldComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ApexForceFieldComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: FieldSamplerScene
    /// </summary>
    public unsafe BmSDK.Engine.ApexFieldSamplerComponent.FSS_FieldSamplerScene FieldSamplerScene
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexFieldSamplerComponent.FSS_FieldSamplerScene>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// ByteProperty: CollisionChannel
    /// </summary>
    public unsafe BmSDK.Engine.PrimitiveComponent.ERBCollisionChannel CollisionChannel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent.ERBCollisionChannel>(Ptr + 541); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 541); }
    }

    /// <summary>
    /// BoolProperty: bEnabled
    /// </summary>
    public unsafe bool bEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 544); }
    }

    /// <summary>
    /// StructProperty: CollideWithChannels
    /// </summary>
    public unsafe BmSDK.Engine.PrimitiveComponent.FRBCollisionChannelContainer CollideWithChannels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent.FRBCollisionChannelContainer>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// FloatProperty: Duration
    /// </summary>
    public unsafe float Duration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// FloatProperty: ElapsedTime
    /// </summary>
    public unsafe float ElapsedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// StructProperty: GroupsMask
    /// </summary>
    public unsafe System.IntPtr GroupsMask
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// StructProperty: GroupsMask64
    /// </summary>
    public unsafe System.IntPtr GroupsMask64
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// ComponentProperty: DrawComponent
    /// </summary>
    public unsafe BmSDK.Engine.PrimitiveComponent DrawComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// StructProperty: ApexAsset
    /// </summary>
    public unsafe System.IntPtr ApexAsset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// StructProperty: ApexActor
    /// </summary>
    public unsafe System.IntPtr ApexActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// IntProperty: PhysSceneIndex
    /// </summary>
    public unsafe int PhysSceneIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// Enum: FSS_FieldSamplerScene
    /// </summary>
    public enum FSS_FieldSamplerScene
    {
        FSS_RigidBodyScene = 0,
        FSS_ClothScene = 1,
        FSS_TurbulenceScene = 2,
        FSS_MAX = 3,
    }

    /// <summary>
    /// Enum: EGeometryType
    /// </summary>
    public enum EGeometryType
    {
        EGeometryType_Sphere = 0,
        EGeometryType_Box = 1,
        EGeometryType_MAX = 2,
    }
}
