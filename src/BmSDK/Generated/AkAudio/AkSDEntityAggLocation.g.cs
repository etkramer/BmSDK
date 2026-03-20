#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: AkSDEntityAggLocation<br/>
/// (size = 268)
/// (flags = 0)
/// </summary>
public partial class AkSDEntityAggLocation : BmSDK.AkAudio.AkSDEntitySymbol, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.AkSDEntityAggLocation", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkSDEntityAggLocation() { }

    /// <summary>
    /// Constructs a new AkSDEntityAggLocation
    /// </summary>
    public AkSDEntityAggLocation(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkSDEntityAggLocation Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkSDEntityAggLocation(nint ptr) : base(ptr) { }

}
