#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RRobinXRayViewPostProcess<br/>
/// (size = 128)
/// (flags = 18)
/// </summary>
public partial class RRobinXRayViewPostProcess : BmSDK.BmGame.RXRayViewPostProcess, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RRobinXRayViewPostProcess", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RRobinXRayViewPostProcess() { }

    /// <summary>
    /// Constructs a new RRobinXRayViewPostProcess
    /// </summary>
    public RRobinXRayViewPostProcess(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RRobinXRayViewPostProcess Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRobinXRayViewPostProcess(nint ptr) : base(ptr) { }

}
