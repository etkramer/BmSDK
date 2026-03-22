#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_BatarangStartle<br/>
/// (size = 464)
/// (flags = 8210)
/// </summary>
public partial class RBMBehaviour_BatarangStartle : BmSDK.BmGame.RBMBehaviour_BaseStartle, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_BatarangStartle", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_BatarangStartle() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_BatarangStartle
    /// </summary>
    public RBMBehaviour_BatarangStartle(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_BatarangStartle Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_BatarangStartle(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: SetThreatLocation
    /// </summary>
    public unsafe override void SetThreatLocation(System.Numerics.Vector3 NewLoc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMBehaviour_BatarangStartle.SetThreatLocation", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewLoc, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
