#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGameSettingsCoop<br/>
/// (size = 156)
/// (flags = 50)
/// </summary>
public partial class RGameSettingsCoop : BmSDK.Engine.OnlineGameSettings, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGameSettingsCoop", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGameSettingsCoop() { }

    /// <summary>
    /// Constructs a new RGameSettingsCoop
    /// </summary>
    public RGameSettingsCoop(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGameSettingsCoop Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGameSettingsCoop(nint ptr) : base(ptr) { }

}
