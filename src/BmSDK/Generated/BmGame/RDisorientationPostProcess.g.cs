#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDisorientationPostProcess<br/>
/// (size = 128)
/// (flags = 18)
/// </summary>
public partial class RDisorientationPostProcess : BmSDK.BmGame.RViewPostProcess, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDisorientationPostProcess", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDisorientationPostProcess() { }

    /// <summary>
    /// Constructs a new RDisorientationPostProcess
    /// </summary>
    public RDisorientationPostProcess(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDisorientationPostProcess Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDisorientationPostProcess(nint ptr) : base(ptr) { }

}
