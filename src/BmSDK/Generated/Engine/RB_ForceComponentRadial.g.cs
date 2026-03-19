#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RB_ForceComponentRadial<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RB_ForceComponentRadial : BmSDK.Engine.RB_ForceComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RB_ForceComponentRadial", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RB_ForceComponentRadial() { }

    /// <summary>
    /// Constructs a new RB_ForceComponentRadial
    /// </summary>
    public RB_ForceComponentRadial(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RB_ForceComponentRadial Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RB_ForceComponentRadial(nint ptr) : base(ptr) { }

    /// <summary>
    /// ComponentProperty: RenderComponentSphere
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RenderComponentSphere
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// FloatProperty: ForceStrength
    /// </summary>
    public unsafe float ForceStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// FloatProperty: ForceRadius
    /// </summary>
    public unsafe float ForceRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// FloatProperty: SwirlStrength
    /// </summary>
    public unsafe float SwirlStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// FloatProperty: SpinTorque
    /// </summary>
    public unsafe float SpinTorque
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// ByteProperty: ForceFalloff
    /// </summary>
    public unsafe byte ForceFalloff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }
}
