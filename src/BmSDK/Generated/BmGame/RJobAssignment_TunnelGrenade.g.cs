#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RJobAssignment_TunnelGrenade<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RJobAssignment_TunnelGrenade : BmSDK.BmGame.RJobAssignment, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RJobAssignment_TunnelGrenade", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RJobAssignment_TunnelGrenade() { }

    /// <summary>
    /// Constructs a new RJobAssignment_TunnelGrenade
    /// </summary>
    public RJobAssignment_TunnelGrenade(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RJobAssignment_TunnelGrenade Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RJobAssignment_TunnelGrenade(nint ptr) : base(ptr) { }

    /// <summary>
    /// ClassProperty: TemplateOwnerClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TemplateOwnerClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// NameProperty: TemplateName
    /// </summary>
    public unsafe BmSDK.FName TemplateName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }
}
