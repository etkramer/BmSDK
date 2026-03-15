#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RMadHatterPostProcess<br/>
/// (size = 128)
/// (flags = 18)
/// </summary>
public partial class RMadHatterPostProcess : BmSDK.BmGame.RViewPostProcess, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RMadHatterPostProcess", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RMadHatterPostProcess() { }

    /// <summary>
    /// Constructs a new RMadHatterPostProcess
    /// </summary>
    public RMadHatterPostProcess(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RMadHatterPostProcess Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RMadHatterPostProcess(nint ptr) : base(ptr) { }

}
