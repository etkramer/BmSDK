#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ApexForceFieldRadialComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ApexForceFieldRadialComponent : BmSDK.Engine.ApexForceFieldComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ApexForceFieldRadialComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ApexForceFieldRadialComponent() { }

    /// <summary>
    /// Constructs a new ApexForceFieldRadialComponent
    /// </summary>
    public ApexForceFieldRadialComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ApexForceFieldRadialComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ApexForceFieldRadialComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: ForceStrength
    /// </summary>
    public unsafe float ForceStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// FloatProperty: ForceRadius
    /// </summary>
    public unsafe float ForceRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// FloatProperty: ForceHeight
    /// </summary>
    public unsafe float ForceHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// ByteProperty: ForceFalloff
    /// </summary>
    public unsafe byte ForceFalloff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }
}
