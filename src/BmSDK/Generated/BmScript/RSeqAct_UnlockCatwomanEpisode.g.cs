#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_UnlockCatwomanEpisode<br/>
/// (size = 208)
/// (flags = 8210)
/// </summary>
public partial class RSeqAct_UnlockCatwomanEpisode : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_UnlockCatwomanEpisode", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_UnlockCatwomanEpisode() { }

    /// <summary>
    /// Constructs a new RSeqAct_UnlockCatwomanEpisode
    /// </summary>
    public RSeqAct_UnlockCatwomanEpisode(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_UnlockCatwomanEpisode Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_UnlockCatwomanEpisode(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: Activated
    /// </summary>
    public unsafe override void Activated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_UnlockCatwomanEpisode.Activated", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// IntProperty: EpisodeId
    /// </summary>
    public unsafe int EpisodeId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }
}
