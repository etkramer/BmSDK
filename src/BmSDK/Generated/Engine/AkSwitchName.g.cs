#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkSwitchName<br/>
/// (size = 100)
/// (flags = 0)
/// </summary>
public partial class AkSwitchName : BmSDK.Engine.AkHash, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkSwitchName", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkSwitchName() { }

    /// <summary>
    /// Constructs a new AkSwitchName
    /// </summary>
    public AkSwitchName(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkSwitchName Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkSwitchName(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: ParentSwitchGroup
    /// </summary>
    public unsafe BmSDK.Engine.AkSwitchGroupName ParentSwitchGroup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchGroupName>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }
}
