#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_LinkCinematicProxyToInGameActor<br/>
/// (size = 236)
/// (flags = 134226066)
/// </summary>
public partial class RSeqAct_LinkCinematicProxyToInGameActor : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_LinkCinematicProxyToInGameActor", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_LinkCinematicProxyToInGameActor() { }

    /// <summary>
    /// Constructs a new RSeqAct_LinkCinematicProxyToInGameActor
    /// </summary>
    public RSeqAct_LinkCinematicProxyToInGameActor(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_LinkCinematicProxyToInGameActor Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_LinkCinematicProxyToInGameActor(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: InGameActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor InGameActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// ObjectProperty: CinematicActor
    /// </summary>
    public unsafe BmSDK.BmGame.RCinematicActor CinematicActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCinematicActor>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// FloatProperty: WarningTimeout
    /// </summary>
    public unsafe float WarningTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// FloatProperty: WarningTimeoutRemaining
    /// </summary>
    public unsafe float WarningTimeoutRemaining
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }
}
