#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_WaitForBatmobileAction<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_WaitForBatmobileAction : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_WaitForBatmobileAction", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_WaitForBatmobileAction() { }

    /// <summary>
    /// Constructs a new RSeqAct_WaitForBatmobileAction
    /// </summary>
    public RSeqAct_WaitForBatmobileAction(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_WaitForBatmobileAction Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_WaitForBatmobileAction(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bBatmobileMoved
    /// </summary>
    public unsafe bool bBatmobileMoved
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// ObjectProperty: Batmobile
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobileBase Batmobile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }
}
