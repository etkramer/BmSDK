#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCheckpointWaveController<br/>
/// (flags = 0)
/// </summary>
public partial class RCheckpointWaveController : BmSDK.BmGame.RBMWaveController, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCheckpointWaveController", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCheckpointWaveController() { }

    /// <summary>
    /// Constructs a new RCheckpointWaveController
    /// </summary>
    public RCheckpointWaveController(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCheckpointWaveController Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCheckpointWaveController(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: NumLeftForBreak
    /// </summary>
    public unsafe int NumLeftForBreak
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// ObjectProperty: Captain
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat Captain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileDangerArea
    /// </summary>
    public unsafe BmSDK.Engine.Volume BatmobileDangerArea
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Volume>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// BoolProperty: bCanBeSpookedByTanks
    /// </summary>
    public unsafe bool bCanBeSpookedByTanks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 432); }
    }

    /// <summary>
    /// BoolProperty: bSetFleeFlags
    /// </summary>
    public unsafe bool bSetFleeFlags
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 432); }
    }

    /// <summary>
    /// FloatProperty: BatmobileProxDist
    /// </summary>
    public unsafe float BatmobileProxDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }
}
