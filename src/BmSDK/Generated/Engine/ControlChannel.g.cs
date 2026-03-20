#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ControlChannel<br/>
/// (size = 168)
/// (flags = 0)
/// </summary>
public partial class ControlChannel : BmSDK.Engine.Channel, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ControlChannel", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ControlChannel() { }

    /// <summary>
    /// Constructs a new ControlChannel
    /// </summary>
    public ControlChannel(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ControlChannel Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ControlChannel(nint ptr) : base(ptr) { }

}
