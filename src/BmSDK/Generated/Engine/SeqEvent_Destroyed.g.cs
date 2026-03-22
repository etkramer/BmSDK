#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqEvent_Destroyed<br/>
/// (size = 228)
/// (flags = 134217874)
/// </summary>
public partial class SeqEvent_Destroyed : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqEvent_Destroyed", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqEvent_Destroyed() { }

    /// <summary>
    /// Constructs a new SeqEvent_Destroyed
    /// </summary>
    public SeqEvent_Destroyed(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqEvent_Destroyed Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqEvent_Destroyed(nint ptr) : base(ptr) { }

}
