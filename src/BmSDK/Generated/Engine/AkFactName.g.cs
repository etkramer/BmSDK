#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkFactName<br/>
/// (flags = 0)
/// </summary>
public partial class AkFactName : BmSDK.Engine.AkPredicate, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkFactName", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkFactName() { }

    /// <summary>
    /// Constructs a new AkFactName
    /// </summary>
    public AkFactName(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkFactName Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkFactName(nint ptr) : base(ptr) { }

}
