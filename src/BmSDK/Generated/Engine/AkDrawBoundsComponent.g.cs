#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkDrawBoundsComponent<br/>
/// (size = 476)
/// (flags = 2290102418)
/// </summary>
public partial class AkDrawBoundsComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkDrawBoundsComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkDrawBoundsComponent() { }

    /// <summary>
    /// Constructs a new AkDrawBoundsComponent
    /// </summary>
    public AkDrawBoundsComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkDrawBoundsComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkDrawBoundsComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: DrawBoundsColor
    /// </summary>
    public unsafe BmSDK.GameObject.FColor DrawBoundsColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// StructProperty: DrawBounds
    /// </summary>
    public unsafe BmSDK.GameObject.FBoxSphereBounds DrawBounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FBoxSphereBounds>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// StructProperty: X_LMH
    /// </summary>
    public unsafe System.Numerics.Vector3 X_LMH
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

    /// <summary>
    /// StructProperty: Y_LMH
    /// </summary>
    public unsafe System.Numerics.Vector3 Y_LMH
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// StructProperty: Z_LMH
    /// </summary>
    public unsafe System.Numerics.Vector3 Z_LMH
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// BoolProperty: X_Enabled
    /// </summary>
    public unsafe bool X_Enabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 472) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 472); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 472); }
    }

    /// <summary>
    /// BoolProperty: Y_Enabled
    /// </summary>
    public unsafe bool Y_Enabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 472) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 472); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 472); }
    }

    /// <summary>
    /// BoolProperty: Z_Enabled
    /// </summary>
    public unsafe bool Z_Enabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 472) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 472); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 472); }
    }
}
