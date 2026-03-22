#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_FreezeBlastHit<br/>
/// (size = 228)
/// (flags = 18)
/// </summary>
public partial class RSeqEvent_FreezeBlastHit : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_FreezeBlastHit", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_FreezeBlastHit() { }

    /// <summary>
    /// Constructs a new RSeqEvent_FreezeBlastHit
    /// </summary>
    public RSeqEvent_FreezeBlastHit(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_FreezeBlastHit Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_FreezeBlastHit(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqEvent_FreezeBlastHit.GetObjClassVersion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }
}
