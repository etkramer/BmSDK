#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.GFxUI;

/// <summary>
/// Class: GFxInteraction<br/>
/// (size = 100)
/// (flags = 134217882)
/// </summary>
public partial class GFxInteraction : BmSDK.Engine.Interaction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "GFxUI.GFxInteraction", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal GFxInteraction() { }

    /// <summary>
    /// Constructs a new GFxInteraction
    /// </summary>
    public GFxInteraction(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GFxInteraction Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GFxInteraction(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: CloseAllMoviePlayers
    /// </summary>
    public unsafe virtual void CloseAllMoviePlayers()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "GFxUI.GFxInteraction.CloseAllMoviePlayers", true);
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: NotifyPlayerRemoved
    /// </summary>
    public unsafe override void NotifyPlayerRemoved(int PlayerIndex, BmSDK.Engine.LocalPlayer RemovedPlayer)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "GFxUI.GFxInteraction.NotifyPlayerRemoved", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RemovedPlayer, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: NotifyPlayerAdded
    /// </summary>
    public unsafe override void NotifyPlayerAdded(int PlayerIndex, BmSDK.Engine.LocalPlayer AddedPlayer)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "GFxUI.GFxInteraction.NotifyPlayerAdded", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AddedPlayer, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: NotifyGameSessionEnded
    /// </summary>
    public unsafe override void NotifyGameSessionEnded()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "GFxUI.GFxInteraction.NotifyGameSessionEnded", true);
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: GetFocusMovie
    /// </summary>
    public unsafe virtual BmSDK.GFxUI.GFxMoviePlayer GetFocusMovie(int ControllerId)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "GFxUI.GFxInteraction.GetFocusMovie", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxMoviePlayer>(paramsPtr + 4);
    }

    /// <summary>
    /// StructProperty: VfTable_FCallbackEventDevice
    /// </summary>
    public unsafe System.IntPtr VfTable_FCallbackEventDevice
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }
}
