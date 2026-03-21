#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: LevelBase<br/>
/// (size = 128)
/// (flags = 268435585)
/// </summary>
public partial class LevelBase : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.LevelBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal LevelBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected LevelBase(nint ptr) : base(ptr) { }

}
