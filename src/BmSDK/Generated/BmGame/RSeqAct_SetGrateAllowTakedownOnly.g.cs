#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_SetGrateAllowTakedownOnly<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_SetGrateAllowTakedownOnly : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_SetGrateAllowTakedownOnly", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_SetGrateAllowTakedownOnly() { }

    /// <summary>
    /// Constructs a new RSeqAct_SetGrateAllowTakedownOnly
    /// </summary>
    public RSeqAct_SetGrateAllowTakedownOnly(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_SetGrateAllowTakedownOnly Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_SetGrateAllowTakedownOnly(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Grate
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelGrateBase Grate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelGrateBase>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }
}
