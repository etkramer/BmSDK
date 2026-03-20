#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMBehaviour_ZipKicked<br/>
/// (size = 716)
/// (flags = 8396818)
/// </summary>
public partial class RBMBehaviour_ZipKicked : BmSDK.BmGame.RBMBehaviour_BatClawed, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMBehaviour_ZipKicked", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_ZipKicked() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_ZipKicked
    /// </summary>
    public RBMBehaviour_ZipKicked(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_ZipKicked Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_ZipKicked(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: BumpedIntoPlayer
    /// </summary>
    public unsafe override void BumpedIntoPlayer()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMBehaviour_ZipKicked.BumpedIntoPlayer", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
