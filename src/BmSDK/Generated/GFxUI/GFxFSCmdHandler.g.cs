#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.GFxUI;

/// <summary>
/// ABSTRACT Class: GFxFSCmdHandler<br/>
/// (size = 84)
/// (flags = 134217875)
/// </summary>
public partial class GFxFSCmdHandler : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "GFxUI.GFxFSCmdHandler", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal GFxFSCmdHandler() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GFxFSCmdHandler(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: FSCommand
    /// </summary>
    public unsafe bool FSCommand(BmSDK.GFxUI.GFxMoviePlayer Movie, BmSDK.GFxUI.GFxEvent_FSCommand Event, BmSDK.FString Cmd, BmSDK.FString Arg)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "GFxUI.GFxFSCmdHandler.FSCommand", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Movie, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Event, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Cmd, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Arg, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 48);
    }
}
