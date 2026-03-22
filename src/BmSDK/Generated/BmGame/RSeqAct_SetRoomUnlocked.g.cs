#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_SetRoomUnlocked<br/>
/// (size = 208)
/// (flags = 134226066)
/// </summary>
public partial class RSeqAct_SetRoomUnlocked : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_SetRoomUnlocked", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_SetRoomUnlocked() { }

    /// <summary>
    /// Constructs a new RSeqAct_SetRoomUnlocked
    /// </summary>
    public RSeqAct_SetRoomUnlocked(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_SetRoomUnlocked Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_SetRoomUnlocked(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqAct_SetRoomUnlocked.GetObjClassVersion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: Lock
    /// </summary>
    public unsafe virtual void Lock()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqAct_SetRoomUnlocked.Lock", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Unlock
    /// </summary>
    public unsafe virtual void Unlock()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqAct_SetRoomUnlocked.Unlock", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: CSA
    /// </summary>
    public unsafe BmSDK.BmGame.RCrimeSceneAsset CSA
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCrimeSceneAsset>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }
}
