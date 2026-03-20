#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkActionGlobal_State<br/>
/// (flags = 0)
/// </summary>
public partial class AkActionGlobal_State : BmSDK.Engine.AkActionGlobal, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkActionGlobal_State", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkActionGlobal_State() { }

    /// <summary>
    /// Constructs a new AkActionGlobal_State
    /// </summary>
    public AkActionGlobal_State(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkActionGlobal_State Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkActionGlobal_State(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: ActivationState
    /// </summary>
    public unsafe BmSDK.Engine.AkStateName ActivationState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkStateName>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }
}
