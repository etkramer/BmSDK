#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMDeathCutscene_FinalCounterCam<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMDeathCutscene_FinalCounterCam : BmSDK.BmGame.RBMDeathCutscene_Cam, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMDeathCutscene_FinalCounterCam", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMDeathCutscene_FinalCounterCam() { }

    /// <summary>
    /// Constructs a new RBMDeathCutscene_FinalCounterCam
    /// </summary>
    public RBMDeathCutscene_FinalCounterCam(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMDeathCutscene_FinalCounterCam Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMDeathCutscene_FinalCounterCam(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: CamTimer
    /// </summary>
    public unsafe float CamTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// FloatProperty: TimeOutOfShot
    /// </summary>
    public unsafe float TimeOutOfShot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// FloatProperty: FOVSpeed
    /// </summary>
    public unsafe float FOVSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// FloatProperty: FOVSpeedDecel
    /// </summary>
    public unsafe float FOVSpeedDecel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// BoolProperty: bRunTimer
    /// </summary>
    public unsafe bool bRunTimer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 252) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 252); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 252); }
    }

    /// <summary>
    /// BoolProperty: bLookAtKiller
    /// </summary>
    public unsafe bool bLookAtKiller
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 252) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 252); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 252); }
    }

    /// <summary>
    /// FloatProperty: DirMulti
    /// </summary>
    public unsafe float DirMulti
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// IntProperty: CurrYaw
    /// </summary>
    public unsafe int CurrYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// ObjectProperty: PlayerBase
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// StructProperty: PreviousBaseLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PreviousBaseLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }
}
