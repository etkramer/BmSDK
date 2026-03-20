#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAIBrain_PredFull<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RAIBrain_PredFull : BmSDK.BmGame.RAIBrain_Pred, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAIBrain_PredFull", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAIBrain_PredFull() { }

    /// <summary>
    /// Constructs a new RAIBrain_PredFull
    /// </summary>
    public RAIBrain_PredFull(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAIBrain_PredFull Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAIBrain_PredFull(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: GlanceForBooth
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_MuseumBooth GlanceForBooth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_MuseumBooth>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// ObjectProperty: SonicBatarangAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_SonicBatarang SonicBatarangAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_SonicBatarang>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// ObjectProperty: EnviroStartleAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_EnvironmentStartle EnviroStartleAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_EnvironmentStartle>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// ObjectProperty: IncendiaryStartleAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_IncendiaryStartle IncendiaryStartleAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_IncendiaryStartle>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// ObjectProperty: SentryGunAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_PlaceSentryGun SentryGunAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_PlaceSentryGun>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// ArrayProperty: PotentialBooth
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAEC_MuseumBooth_PerPoint> PotentialBooth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAEC_MuseumBooth_PerPoint>>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// BoolProperty: bIsTooBusyForVoiceSynth
    /// </summary>
    public unsafe bool bIsTooBusyForVoiceSynth
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 560) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 560); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 560); }
    }
}
