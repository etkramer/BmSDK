#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: LevelStreamingKismet<br/>
/// (flags = 0)
/// </summary>
public partial class LevelStreamingKismet : BmSDK.Engine.LevelStreaming, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.LevelStreamingKismet", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal LevelStreamingKismet() { }

    /// <summary>
    /// Constructs a new LevelStreamingKismet
    /// </summary>
    public LevelStreamingKismet(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, LevelStreamingKismet Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected LevelStreamingKismet(nint ptr) : base(ptr) { }

}
