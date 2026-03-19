#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_DistributeAcrossFrames<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_DistributeAcrossFrames : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_DistributeAcrossFrames", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_DistributeAcrossFrames() { }

    /// <summary>
    /// Constructs a new RSeqAct_DistributeAcrossFrames
    /// </summary>
    public RSeqAct_DistributeAcrossFrames(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_DistributeAcrossFrames Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_DistributeAcrossFrames(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: NextOutputToTrigger
    /// </summary>
    public unsafe int NextOutputToTrigger
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// IntProperty: LinkCount
    /// </summary>
    public unsafe int LinkCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }
}
