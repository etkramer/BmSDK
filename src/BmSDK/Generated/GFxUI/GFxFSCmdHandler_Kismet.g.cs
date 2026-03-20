#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.GFxUI;

/// <summary>
/// Class: GFxFSCmdHandler_Kismet<br/>
/// (size = 84)
/// (flags = 134217874)
/// </summary>
public partial class GFxFSCmdHandler_Kismet : BmSDK.GFxUI.GFxFSCmdHandler, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "GFxUI.GFxFSCmdHandler_Kismet", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal GFxFSCmdHandler_Kismet() { }

    /// <summary>
    /// Constructs a new GFxFSCmdHandler_Kismet
    /// </summary>
    public GFxFSCmdHandler_Kismet(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GFxFSCmdHandler_Kismet Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GFxFSCmdHandler_Kismet(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: FSCommand
    /// </summary>
    public unsafe bool FSCommand(BmSDK.GFxUI.GFxMoviePlayer Movie, BmSDK.GFxUI.GFxEvent_FSCommand Event, BmSDK.FString Cmd, BmSDK.FString Arg)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "GFxUI.GFxFSCmdHandler_Kismet.FSCommand", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Movie, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Event, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Cmd, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Arg, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 48);
    }
}
