#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudExtensionBroadcastJammer<br/>
/// (size = 132)
/// (flags = 33554450)
/// </summary>
public partial class RHudExtensionBroadcastJammer : BmSDK.BmGame.RHudExtension, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHudExtensionBroadcastJammer", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RHudExtensionBroadcastJammer() { }

    /// <summary>
    /// Constructs a new RHudExtensionBroadcastJammer
    /// </summary>
    public RHudExtensionBroadcastJammer(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHudExtensionBroadcastJammer Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHudExtensionBroadcastJammer(nint ptr) : base(ptr) { }

}
