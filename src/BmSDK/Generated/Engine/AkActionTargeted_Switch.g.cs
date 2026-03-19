#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkActionTargeted_Switch<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AkActionTargeted_Switch : BmSDK.Engine.AkActionTargeted, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkActionTargeted_Switch", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkActionTargeted_Switch() { }

    /// <summary>
    /// Constructs a new AkActionTargeted_Switch
    /// </summary>
    public AkActionTargeted_Switch(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkActionTargeted_Switch Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkActionTargeted_Switch(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: ActivationSwitch
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ActivationSwitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ObjectProperty: DeactivationSwitch
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DeactivationSwitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }
}
