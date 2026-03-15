#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCatwomanXRayViewPostProcess<br/>
/// (size = 128)
/// (flags = 18)
/// </summary>
public partial class RCatwomanXRayViewPostProcess : BmSDK.BmGame.RXRayViewPostProcess, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCatwomanXRayViewPostProcess", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCatwomanXRayViewPostProcess() { }

    /// <summary>
    /// Constructs a new RCatwomanXRayViewPostProcess
    /// </summary>
    public RCatwomanXRayViewPostProcess(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCatwomanXRayViewPostProcess Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCatwomanXRayViewPostProcess(nint ptr) : base(ptr) { }

}
