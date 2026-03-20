#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MHarleyForensicsInvestigator<br/>
/// (size = 364)
/// (flags = 0)
/// </summary>
public partial class MHarleyForensicsInvestigator : BmSDK.BmGame.RForensicsInvestigator, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MHarleyForensicsInvestigator", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MHarleyForensicsInvestigator() { }

    /// <summary>
    /// Constructs a new MHarleyForensicsInvestigator
    /// </summary>
    public MHarleyForensicsInvestigator(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MHarleyForensicsInvestigator Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MHarleyForensicsInvestigator(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: SetNPCInfoCursor
    /// </summary>
    public unsafe void SetNPCInfoCursor(BmSDK.BmGame.RPlayerController RPC, int HeartBeatType, int WeaponType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHarleyForensicsInvestigator.SetNPCInfoCursor", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HeartBeatType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponType, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
