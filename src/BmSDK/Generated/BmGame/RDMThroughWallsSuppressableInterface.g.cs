#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDMThroughWallsSuppressableInterface<br/>
/// (size = 84)
/// (flags = 0)
/// </summary>
public partial class RDMThroughWallsSuppressableInterface : BmSDK.Interface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDMThroughWallsSuppressableInterface", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDMThroughWallsSuppressableInterface() { }

    /// <summary>
    /// Constructs a new RDMThroughWallsSuppressableInterface
    /// </summary>
    public RDMThroughWallsSuppressableInterface(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDMThroughWallsSuppressableInterface Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDMThroughWallsSuppressableInterface(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: SuppressDetectiveModeVisibilityThroughWalls
    /// </summary>
    public unsafe void SuppressDetectiveModeVisibilityThroughWalls(bool bSuppress)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDMThroughWallsSuppressableInterface.SuppressDetectiveModeVisibilityThroughWalls", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSuppress, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UnregisterDMThroughWallsSuppressable
    /// </summary>
    public unsafe void UnregisterDMThroughWallsSuppressable()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDMThroughWallsSuppressableInterface.UnregisterDMThroughWallsSuppressable", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RegisterDMThroughWallsSuppressable
    /// </summary>
    public unsafe void RegisterDMThroughWallsSuppressable()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RDMThroughWallsSuppressableInterface.RegisterDMThroughWallsSuppressable", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
