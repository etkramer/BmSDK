#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RArkhamKnightSniperPostProcess<br/>
/// (size = 180)
/// (flags = 18)
/// </summary>
public partial class RArkhamKnightSniperPostProcess : BmSDK.BmGame.RViewPostProcess, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RArkhamKnightSniperPostProcess", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RArkhamKnightSniperPostProcess() { }

    /// <summary>
    /// Constructs a new RArkhamKnightSniperPostProcess
    /// </summary>
    public RArkhamKnightSniperPostProcess(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RArkhamKnightSniperPostProcess Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RArkhamKnightSniperPostProcess(nint ptr) : base(ptr) { }

}
