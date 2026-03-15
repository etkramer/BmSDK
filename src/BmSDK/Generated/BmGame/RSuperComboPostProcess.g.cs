#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSuperComboPostProcess<br/>
/// (size = 128)
/// (flags = 18)
/// </summary>
public partial class RSuperComboPostProcess : BmSDK.BmGame.RViewPostProcess, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSuperComboPostProcess", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSuperComboPostProcess() { }

    /// <summary>
    /// Constructs a new RSuperComboPostProcess
    /// </summary>
    public RSuperComboPostProcess(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSuperComboPostProcess Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSuperComboPostProcess(nint ptr) : base(ptr) { }

}
