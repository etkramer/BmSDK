#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RRemoteTakeoverVideoScreenInterface<br/>
/// (size = 84)
/// (flags = 0)
/// </summary>
public partial class RRemoteTakeoverVideoScreenInterface : BmSDK.Interface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RRemoteTakeoverVideoScreenInterface", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RRemoteTakeoverVideoScreenInterface() { }

    /// <summary>
    /// Constructs a new RRemoteTakeoverVideoScreenInterface
    /// </summary>
    public RRemoteTakeoverVideoScreenInterface(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RRemoteTakeoverVideoScreenInterface Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRemoteTakeoverVideoScreenInterface(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: SetStaticTransitionParameter
    /// </summary>
    public unsafe void SetStaticTransitionParameter(float val)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteTakeoverVideoScreenInterface.SetStaticTransitionParameter", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(val, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RevertToStandardTexture
    /// </summary>
    public unsafe void RevertToStandardTexture()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteTakeoverVideoScreenInterface.RevertToStandardTexture", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetTakeoverTexture
    /// </summary>
    public unsafe void SetTakeoverTexture(BmSDK.Engine.TextureRenderTarget2D takeoverTexture)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteTakeoverVideoScreenInterface.SetTakeoverTexture", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(takeoverTexture, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanBeTakenOverByScarecrow
    /// </summary>
    public unsafe bool CanBeTakenOverByScarecrow()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteTakeoverVideoScreenInterface.CanBeTakenOverByScarecrow", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanBeTakenOverByRiddler
    /// </summary>
    public unsafe bool CanBeTakenOverByRiddler()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRemoteTakeoverVideoScreenInterface.CanBeTakenOverByRiddler", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }
}
