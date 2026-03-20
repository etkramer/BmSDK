#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDetonateGadgetInterface<br/>
/// (size = 84)
/// (flags = 0)
/// </summary>
public partial class RDetonateGadgetInterface : BmSDK.Interface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDetonateGadgetInterface", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDetonateGadgetInterface() { }

    /// <summary>
    /// Constructs a new RDetonateGadgetInterface
    /// </summary>
    public RDetonateGadgetInterface(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDetonateGadgetInterface Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDetonateGadgetInterface(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetCurrentDetonateTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor GetCurrentDetonateTarget()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDetonateGadgetInterface.GetCurrentDetonateTarget", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(paramsPtr + 0);
    }
}
