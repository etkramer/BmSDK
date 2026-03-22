#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkSwitchGroupName<br/>
/// (size = 56)
/// (flags = 134217874)
/// </summary>
public partial class AkSwitchGroupName : BmSDK.Engine.AkAsset, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkSwitchGroupName", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkSwitchGroupName() { }

    /// <summary>
    /// Constructs a new AkSwitchGroupName
    /// </summary>
    public AkSwitchGroupName(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkSwitchGroupName Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkSwitchGroupName(nint ptr) : base(ptr) { }

}
