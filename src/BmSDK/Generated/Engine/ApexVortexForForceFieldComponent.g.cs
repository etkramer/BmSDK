#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ApexVortexForForceFieldComponent<br/>
/// (flags = 0)
/// </summary>
public partial class ApexVortexForForceFieldComponent : BmSDK.Engine.ApexVortexComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ApexVortexForForceFieldComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ApexVortexForForceFieldComponent() { }

    /// <summary>
    /// Constructs a new ApexVortexForForceFieldComponent
    /// </summary>
    public ApexVortexForForceFieldComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ApexVortexForForceFieldComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ApexVortexForForceFieldComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: RotationalFieldStrength
    /// </summary>
    public unsafe float RotationalFieldStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// FloatProperty: RadialFieldStrength
    /// </summary>
    public unsafe float RadialFieldStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// FloatProperty: LiftFieldStrength
    /// </summary>
    public unsafe float LiftFieldStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// FloatProperty: CapsuleFieldHeight
    /// </summary>
    public unsafe float CapsuleFieldHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// FloatProperty: CapsuleFieldBottomRadius
    /// </summary>
    public unsafe float CapsuleFieldBottomRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// FloatProperty: CapsuleFieldTopRadius
    /// </summary>
    public unsafe float CapsuleFieldTopRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// FloatProperty: BoundaryFadePercentage
    /// </summary>
    public unsafe float BoundaryFadePercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }
}
