#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RProfileSettings<br/>
/// (size = 184)
/// (flags = 0)
/// </summary>
public partial class RProfileSettings : BmSDK.Engine.OnlineProfileSettings, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RProfileSettings", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RProfileSettings() { }

    /// <summary>
    /// Constructs a new RProfileSettings
    /// </summary>
    public RProfileSettings(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RProfileSettings Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RProfileSettings(nint ptr) : base(ptr) { }

}
