#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCarListenerInterface<br/>
/// (size = 84)
/// (flags = 0)
/// </summary>
public partial class RCarListenerInterface : BmSDK.Interface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCarListenerInterface", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCarListenerInterface() { }

    /// <summary>
    /// Constructs a new RCarListenerInterface
    /// </summary>
    public RCarListenerInterface(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCarListenerInterface Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCarListenerInterface(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: BatmanLeftCar
    /// </summary>
    public unsafe void BatmanLeftCar()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCarListenerInterface.BatmanLeftCar", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
