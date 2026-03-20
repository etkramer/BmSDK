#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RInvestigationInterface<br/>
/// (flags = 0)
/// </summary>
public partial class RInvestigationInterface : BmSDK.Interface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RInvestigationInterface", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RInvestigationInterface() { }

    /// <summary>
    /// Constructs a new RInvestigationInterface
    /// </summary>
    public RInvestigationInterface(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RInvestigationInterface Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RInvestigationInterface(nint ptr) : base(ptr) { }

}
