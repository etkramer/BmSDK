#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudModuleAlertsAndSurveillance<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RHudModuleAlertsAndSurveillance : BmSDK.BmGame.RHudModule, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHudModuleAlertsAndSurveillance", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RHudModuleAlertsAndSurveillance() { }

    /// <summary>
    /// Constructs a new RHudModuleAlertsAndSurveillance
    /// </summary>
    public RHudModuleAlertsAndSurveillance(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHudModuleAlertsAndSurveillance Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHudModuleAlertsAndSurveillance(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: TripleTrailActive
    /// </summary>
    public unsafe bool TripleTrailActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// IntProperty: TripleTrailFocusIndex
    /// </summary>
    public unsafe int TripleTrailFocusIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// StrProperty: AudioSurvFrame
    /// </summary>
    public unsafe BmSDK.FString AudioSurvFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// ByteProperty: CurrentSurveillanceMode
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleAlertsAndSurveillance.SurveillanceModes CurrentSurveillanceMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleAlertsAndSurveillance.SurveillanceModes>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetInterceptAngle
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetInterceptAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetSurveillanceMovieState
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetSurveillanceMovieState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetAudioText
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetAudioText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// FloatProperty: InterceptActorAngle
    /// </summary>
    public unsafe float InterceptActorAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// IntProperty: InterceptActorDistance
    /// </summary>
    public unsafe int InterceptActorDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }
}
