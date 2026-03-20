#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.WinDrv;

/// <summary>
/// Class: XnaForceFeedbackManager<br/>
/// (size = 172)
/// (flags = 268435596)
/// </summary>
public partial class XnaForceFeedbackManager : BmSDK.Engine.ForceFeedbackManager, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "WinDrv.XnaForceFeedbackManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal XnaForceFeedbackManager() { }

    /// <summary>
    /// Constructs a new XnaForceFeedbackManager
    /// </summary>
    public XnaForceFeedbackManager(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, XnaForceFeedbackManager Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected XnaForceFeedbackManager(nint ptr) : base(ptr) { }

}
