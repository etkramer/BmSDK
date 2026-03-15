#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RRCBatarangViewPostProcess<br/>
/// (size = 128)
/// (flags = 18)
/// </summary>
public partial class RRCBatarangViewPostProcess : BmSDK.BmGame.RViewPostProcess, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RRCBatarangViewPostProcess", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RRCBatarangViewPostProcess() { }

    /// <summary>
    /// Constructs a new RRCBatarangViewPostProcess
    /// </summary>
    public RRCBatarangViewPostProcess(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RRCBatarangViewPostProcess Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRCBatarangViewPostProcess(nint ptr) : base(ptr) { }

}
