#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: PendingLevel<br/>
/// (size = 256)
/// (flags = 268435593)
/// </summary>
public partial class PendingLevel : BmSDK.Engine.LevelBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.PendingLevel", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal PendingLevel() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected PendingLevel(nint ptr) : base(ptr) { }

}
