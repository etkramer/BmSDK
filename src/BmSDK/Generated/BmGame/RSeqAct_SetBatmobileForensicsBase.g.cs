#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_SetBatmobileForensicsBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_SetBatmobileForensicsBase : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_SetBatmobileForensicsBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_SetBatmobileForensicsBase() { }

    /// <summary>
    /// Constructs a new RSeqAct_SetBatmobileForensicsBase
    /// </summary>
    public RSeqAct_SetBatmobileForensicsBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_SetBatmobileForensicsBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_SetBatmobileForensicsBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: SplineProximityArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SplineLoftActor> SplineProximityArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SplineLoftActor>>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// ObjectProperty: ForensicsScanParticle
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ForensicsScanParticle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// ObjectProperty: ForensicsScanSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ForensicsScanSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }
}
