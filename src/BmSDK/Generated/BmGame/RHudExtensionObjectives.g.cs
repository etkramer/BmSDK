#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudExtensionObjectives<br/>
/// (size = 140)
/// (flags = 18)
/// </summary>
public partial class RHudExtensionObjectives : BmSDK.BmGame.RHudExtension, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHudExtensionObjectives", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RHudExtensionObjectives() { }

    /// <summary>
    /// Constructs a new RHudExtensionObjectives
    /// </summary>
    public RHudExtensionObjectives(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHudExtensionObjectives Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHudExtensionObjectives(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: FlushObjective
    /// </summary>
    public unsafe void FlushObjective(BmSDK.FString Title)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudExtensionObjectives.FlushObjective", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddObjective
    /// </summary>
    public unsafe void AddObjective(float Time, BmSDK.FString Title, BmSDK.FString Desc, BmSDK.FString OrgDesc, int ArrowType, bool bForceShowMap, BmSDK.FString BackPrompt, bool bNoDuplicates, bool bPulseCompassIndicator)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudExtensionObjectives.AddObjective", true);
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Desc, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OrgDesc, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArrowType, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceShowMap, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BackPrompt, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNoDuplicates, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPulseCompassIndicator, paramsPtr + 64);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Close
    /// </summary>
    public unsafe void Close()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudExtensionObjectives.Close", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe bool Init(BmSDK.BmGame.RPlayerController _RPC, BmSDK.FString _ExtensionName, BmSDK.FString _ExtensionPath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudExtensionObjectives.Init", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionPath, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    /// <summary>
    /// ObjectProperty: MovieInfo
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie MovieInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ObjectProperty: WiseAssetPack
    /// </summary>
    public unsafe BmSDK.Engine.AkAssetPack WiseAssetPack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkAssetPack>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }
}
