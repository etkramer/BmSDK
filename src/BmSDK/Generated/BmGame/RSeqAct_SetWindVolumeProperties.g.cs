#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_SetWindVolumeProperties<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_SetWindVolumeProperties : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_SetWindVolumeProperties", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_SetWindVolumeProperties() { }

    /// <summary>
    /// Constructs a new RSeqAct_SetWindVolumeProperties
    /// </summary>
    public RSeqAct_SetWindVolumeProperties(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_SetWindVolumeProperties Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_SetWindVolumeProperties(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: WindVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RWindForceFieldVolume> WindVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RWindForceFieldVolume>>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// FloatProperty: WindStrengthScale
    /// </summary>
    public unsafe float WindStrengthScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }
}
