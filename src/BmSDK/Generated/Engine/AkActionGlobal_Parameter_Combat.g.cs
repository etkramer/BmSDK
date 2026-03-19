#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkActionGlobal_Parameter_Combat<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AkActionGlobal_Parameter_Combat : BmSDK.Engine.AkActionGlobal, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkActionGlobal_Parameter_Combat", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkActionGlobal_Parameter_Combat() { }

    /// <summary>
    /// Constructs a new AkActionGlobal_Parameter_Combat
    /// </summary>
    public AkActionGlobal_Parameter_Combat(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkActionGlobal_Parameter_Combat Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkActionGlobal_Parameter_Combat(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: ActivationValue
    /// </summary>
    public unsafe float ActivationValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// FloatProperty: InterpolationTime
    /// </summary>
    public unsafe float InterpolationTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }
}
