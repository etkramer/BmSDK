#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAllInOneVisionPostProcess<br/>
/// (size = 180)
/// (flags = 0)
/// </summary>
public partial class RAllInOneVisionPostProcess : BmSDK.BmGame.RViewPostProcess, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAllInOneVisionPostProcess", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAllInOneVisionPostProcess() { }

    /// <summary>
    /// Constructs a new RAllInOneVisionPostProcess
    /// </summary>
    public RAllInOneVisionPostProcess(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAllInOneVisionPostProcess Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAllInOneVisionPostProcess(nint ptr) : base(ptr) { }

}
