#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkGlobalFlagCheck<br/>
/// (flags = 0)
/// </summary>
public partial class AkGlobalFlagCheck : BmSDK.Engine.AkPredicate, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkGlobalFlagCheck", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkGlobalFlagCheck() { }

    /// <summary>
    /// Constructs a new AkGlobalFlagCheck
    /// </summary>
    public AkGlobalFlagCheck(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkGlobalFlagCheck Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkGlobalFlagCheck(nint ptr) : base(ptr) { }

}
