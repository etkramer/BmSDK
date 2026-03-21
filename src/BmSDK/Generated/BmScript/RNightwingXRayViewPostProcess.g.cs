#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RNightwingXRayViewPostProcess<br/>
/// (size = 128)
/// (flags = 18)
/// </summary>
public partial class RNightwingXRayViewPostProcess : BmSDK.BmGame.RXRayViewPostProcess, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RNightwingXRayViewPostProcess", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RNightwingXRayViewPostProcess() { }

    /// <summary>
    /// Constructs a new RNightwingXRayViewPostProcess
    /// </summary>
    public RNightwingXRayViewPostProcess(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RNightwingXRayViewPostProcess Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RNightwingXRayViewPostProcess(nint ptr) : base(ptr) { }

}
