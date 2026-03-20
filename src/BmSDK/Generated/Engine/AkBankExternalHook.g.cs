#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkBankExternalHook<br/>
/// (size = 124)
/// (flags = 0)
/// </summary>
public partial class AkBankExternalHook : BmSDK.Engine.RExternalHook, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkBankExternalHook", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkBankExternalHook() { }

    /// <summary>
    /// Constructs a new AkBankExternalHook
    /// </summary>
    public AkBankExternalHook(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkBankExternalHook Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkBankExternalHook(nint ptr) : base(ptr) { }

}
