#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_SetPopulationVolumeState<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_SetPopulationVolumeState : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_SetPopulationVolumeState", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_SetPopulationVolumeState() { }

    /// <summary>
    /// Constructs a new RSeqAct_SetPopulationVolumeState
    /// </summary>
    public RSeqAct_SetPopulationVolumeState(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_SetPopulationVolumeState Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_SetPopulationVolumeState(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: PopulationVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.ROverworldPopulationVolume> PopulationVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.ROverworldPopulationVolume>>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bForceOnEvenIfAlreadyBeenActive
    /// </summary>
    public unsafe bool bForceOnEvenIfAlreadyBeenActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 368); }
    }
}
