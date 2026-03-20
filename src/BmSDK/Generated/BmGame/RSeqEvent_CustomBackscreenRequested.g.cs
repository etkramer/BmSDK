#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_CustomBackscreenRequested<br/>
/// (size = 384)
/// (flags = 18)
/// </summary>
public partial class RSeqEvent_CustomBackscreenRequested : BmSDK.BmGame.RSeqEvent_CustomBackscreenRequestedBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_CustomBackscreenRequested", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_CustomBackscreenRequested() { }

    /// <summary>
    /// Constructs a new RSeqEvent_CustomBackscreenRequested
    /// </summary>
    public RSeqEvent_CustomBackscreenRequested(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_CustomBackscreenRequested Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_CustomBackscreenRequested(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetAvailability
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqEvent_CustomBackscreenRequested.BackscreenAvailability GetAvailability()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqEvent_CustomBackscreenRequested.GetAvailability", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqEvent_CustomBackscreenRequested.BackscreenAvailability>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqEvent_CustomBackscreenRequested.GetObjClassVersion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// IntProperty: Priority
    /// </summary>
    public unsafe int Priority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// Enum: BackscreenAvailability
    /// </summary>
    public enum BackscreenAvailability
    {
        BA_NotAvailableAbort = 0,
        BA_NotAvailableContinue = 1,
        BA_Available = 2,
        BA_MAX = 3,
    }
}
