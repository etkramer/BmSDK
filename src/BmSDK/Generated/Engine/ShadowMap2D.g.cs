#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ShadowMap2D<br/>
/// (size = 80)
/// (flags = 8389010)
/// </summary>
public partial class ShadowMap2D : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ShadowMap2D", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ShadowMap2D() { }

    /// <summary>
    /// Constructs a new ShadowMap2D
    /// </summary>
    public ShadowMap2D(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ShadowMap2D Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ShadowMap2D(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Texture
    /// </summary>
    public unsafe BmSDK.Engine.ShadowMapTexture2D Texture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ShadowMapTexture2D>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// StructProperty: CoordinateScale
    /// </summary>
    public unsafe System.Numerics.Vector2 CoordinateScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// StructProperty: CoordinateBias
    /// </summary>
    public unsafe System.Numerics.Vector2 CoordinateBias
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// StructProperty: LightGuid
    /// </summary>
    public unsafe BmSDK.GameObject.FGuid LightGuid
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FGuid>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// BoolProperty: bIsShadowFactorTexture
    /// </summary>
    public unsafe bool bIsShadowFactorTexture
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }
    }

    /// <summary>
    /// ComponentProperty: Component
    /// </summary>
    public unsafe BmSDK.Engine.InstancedStaticMeshComponent Component
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.InstancedStaticMeshComponent>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }

    /// <summary>
    /// IntProperty: InstanceIndex
    /// </summary>
    public unsafe int InstanceIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }
    }
}
