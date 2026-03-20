#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAddContentPlayerCharacter<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RAddContentPlayerCharacter : BmSDK.BmGame.RAdditionalContent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAddContentPlayerCharacter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAddContentPlayerCharacter() { }

    /// <summary>
    /// Constructs a new RAddContentPlayerCharacter
    /// </summary>
    public RAddContentPlayerCharacter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAddContentPlayerCharacter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAddContentPlayerCharacter(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: HUD
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie HUD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// ObjectProperty: SpecialForensicsHud
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie SpecialForensicsHud
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ObjectProperty: JammedDetectiveModeHUD
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie JammedDetectiveModeHUD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// ObjectProperty: GadgetWheelSelectionSounds
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GadgetWheelSelectionSounds_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }
    /// <summary>
    /// ObjectProperty: GadgetWheelSelectionSounds
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GadgetWheelSelectionSounds_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }
    /// <summary>
    /// ObjectProperty: GadgetWheelSelectionSounds
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GadgetWheelSelectionSounds_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }
    /// <summary>
    /// ObjectProperty: GadgetWheelSelectionSounds
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GadgetWheelSelectionSounds_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }
    /// <summary>
    /// ObjectProperty: GadgetWheelSelectionSounds
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GadgetWheelSelectionSounds_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }
    /// <summary>
    /// ObjectProperty: GadgetWheelSelectionSounds
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GadgetWheelSelectionSounds_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }
    /// <summary>
    /// ObjectProperty: GadgetWheelSelectionSounds
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GadgetWheelSelectionSounds_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }
    /// <summary>
    /// ObjectProperty: GadgetWheelSelectionSounds
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GadgetWheelSelectionSounds_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }
    /// <summary>
    /// ObjectProperty: GadgetWheelSelectionSounds
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GadgetWheelSelectionSounds_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }
    /// <summary>
    /// ObjectProperty: GadgetWheelSelectionSounds
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GadgetWheelSelectionSounds_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }
    /// <summary>
    /// ObjectProperty: GadgetWheelSelectionSounds
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GadgetWheelSelectionSounds_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }
    /// <summary>
    /// ObjectProperty: GadgetWheelSelectionSounds
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GadgetWheelSelectionSounds_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// ObjectProperty: AnimationConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerConfig AnimationConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerConfig>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// ObjectProperty: XraySkeleton
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMesh XraySkeleton
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }

    /// <summary>
    /// ObjectProperty: XrayGuts
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMesh XrayGuts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// ObjectProperty: CapeAnimTree
    /// </summary>
    public unsafe BmSDK.Engine.AnimTree CapeAnimTree
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimTree>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }

    /// <summary>
    /// ObjectProperty: CapeConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RCapeConfig CapeConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCapeConfig>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// ObjectProperty: AudioStateSwitch
    /// </summary>
    public unsafe BmSDK.Engine.AkStateName AudioStateSwitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkStateName>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// ObjectProperty: AudioContactEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioContactEvent_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }
    /// <summary>
    /// ObjectProperty: AudioContactEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioContactEvent_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }
    /// <summary>
    /// ObjectProperty: AudioContactEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioContactEvent_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }
    /// <summary>
    /// ObjectProperty: AudioContactEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioContactEvent_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }
    /// <summary>
    /// ObjectProperty: AudioContactEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioContactEvent_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }
    /// <summary>
    /// ObjectProperty: AudioContactEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioContactEvent_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }
    /// <summary>
    /// ObjectProperty: AudioContactEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioContactEvent_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }
    /// <summary>
    /// ObjectProperty: AudioContactEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioContactEvent_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }
    /// <summary>
    /// ObjectProperty: AudioContactEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioContactEvent_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }
    /// <summary>
    /// ObjectProperty: AudioContactEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioContactEvent_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }
    /// <summary>
    /// ObjectProperty: AudioContactEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioContactEvent_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }
    /// <summary>
    /// ObjectProperty: AudioContactEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioContactEvent_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }
    }
    /// <summary>
    /// ObjectProperty: AudioContactEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioContactEvent_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
    /// <summary>
    /// ObjectProperty: AudioContactEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioContactEvent_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }
    /// <summary>
    /// ObjectProperty: AudioContactEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioContactEvent_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }
    /// <summary>
    /// ObjectProperty: AudioContactEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioContactEvent_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }
    /// <summary>
    /// ObjectProperty: AudioContactEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioContactEvent_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }
    /// <summary>
    /// ObjectProperty: AudioContactEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioContactEvent_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }
    /// <summary>
    /// ObjectProperty: AudioContactEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioContactEvent_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }
    /// <summary>
    /// ObjectProperty: AudioContactEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioContactEvent_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }
    /// <summary>
    /// ObjectProperty: AudioContactEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioContactEvent_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }
    /// <summary>
    /// ObjectProperty: AudioContactEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioContactEvent_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }
    /// <summary>
    /// ObjectProperty: AudioContactEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioContactEvent_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }
    /// <summary>
    /// ObjectProperty: AudioContactEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioContactEvent_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// ObjectProperty: AudioContactWalk
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioContactWalk
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// ObjectProperty: AudioContactRun
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioContactRun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// ObjectProperty: AudioContactWalkWet
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioContactWalkWet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// ObjectProperty: AudioContactRunWet
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioContactRunWet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// ObjectProperty: AudioContactHandSlideLand
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioContactHandSlideLand
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// ObjectProperty: AudioContactHandSlideImpact
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioContactHandSlideImpact
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// ObjectProperty: AudioContactBothHands
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioContactBothHands
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// ObjectProperty: AudioContactBothFeet
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioContactBothFeet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// ClassProperty: MultiPlayerClass
    /// </summary>
    public unsafe BmSDK.Class MultiPlayerClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// ClassProperty: PlayerClass
    /// </summary>
    public unsafe BmSDK.Class PlayerClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// NameProperty: GadgetsConsoleInner
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleInner_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleInner
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleInner_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleInner
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleInner_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleInner
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleInner_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleInner
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleInner_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleInner
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleInner_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleInner
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleInner_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleInner
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleInner_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// NameProperty: GadgetsConsoleOuter
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleOuter_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleOuter
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleOuter_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleOuter
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleOuter_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleOuter
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleOuter_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleOuter
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleOuter_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleOuter
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleOuter_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleOuter
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleOuter_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleOuter
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleOuter_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// NameProperty: GadgetsPC
    /// </summary>
    public unsafe BmSDK.FName GadgetsPC_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }
    /// <summary>
    /// NameProperty: GadgetsPC
    /// </summary>
    public unsafe BmSDK.FName GadgetsPC_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }
    /// <summary>
    /// NameProperty: GadgetsPC
    /// </summary>
    public unsafe BmSDK.FName GadgetsPC_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }
    /// <summary>
    /// NameProperty: GadgetsPC
    /// </summary>
    public unsafe BmSDK.FName GadgetsPC_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }
    /// <summary>
    /// NameProperty: GadgetsPC
    /// </summary>
    public unsafe BmSDK.FName GadgetsPC_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }
    /// <summary>
    /// NameProperty: GadgetsPC
    /// </summary>
    public unsafe BmSDK.FName GadgetsPC_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }
    /// <summary>
    /// NameProperty: GadgetsPC
    /// </summary>
    public unsafe BmSDK.FName GadgetsPC_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }
    /// <summary>
    /// NameProperty: GadgetsPC
    /// </summary>
    public unsafe BmSDK.FName GadgetsPC_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }
    /// <summary>
    /// NameProperty: GadgetsPC
    /// </summary>
    public unsafe BmSDK.FName GadgetsPC_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }
    /// <summary>
    /// NameProperty: GadgetsPC
    /// </summary>
    public unsafe BmSDK.FName GadgetsPC_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }
    /// <summary>
    /// NameProperty: GadgetsPC
    /// </summary>
    public unsafe BmSDK.FName GadgetsPC_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }
    /// <summary>
    /// NameProperty: GadgetsPC
    /// </summary>
    public unsafe BmSDK.FName GadgetsPC_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// NameProperty: GadgetsForGadgetWheel
    /// </summary>
    public unsafe BmSDK.FName GadgetsForGadgetWheel_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }
    /// <summary>
    /// NameProperty: GadgetsForGadgetWheel
    /// </summary>
    public unsafe BmSDK.FName GadgetsForGadgetWheel_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }
    /// <summary>
    /// NameProperty: GadgetsForGadgetWheel
    /// </summary>
    public unsafe BmSDK.FName GadgetsForGadgetWheel_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }
    /// <summary>
    /// NameProperty: GadgetsForGadgetWheel
    /// </summary>
    public unsafe BmSDK.FName GadgetsForGadgetWheel_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }
    /// <summary>
    /// NameProperty: GadgetsForGadgetWheel
    /// </summary>
    public unsafe BmSDK.FName GadgetsForGadgetWheel_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }
    /// <summary>
    /// NameProperty: GadgetsForGadgetWheel
    /// </summary>
    public unsafe BmSDK.FName GadgetsForGadgetWheel_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }
    /// <summary>
    /// NameProperty: GadgetsForGadgetWheel
    /// </summary>
    public unsafe BmSDK.FName GadgetsForGadgetWheel_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }
    /// <summary>
    /// NameProperty: GadgetsForGadgetWheel
    /// </summary>
    public unsafe BmSDK.FName GadgetsForGadgetWheel_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }
    /// <summary>
    /// NameProperty: GadgetsForGadgetWheel
    /// </summary>
    public unsafe BmSDK.FName GadgetsForGadgetWheel_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }
    /// <summary>
    /// NameProperty: GadgetsForGadgetWheel
    /// </summary>
    public unsafe BmSDK.FName GadgetsForGadgetWheel_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }
    /// <summary>
    /// NameProperty: GadgetsForGadgetWheel
    /// </summary>
    public unsafe BmSDK.FName GadgetsForGadgetWheel_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }
    /// <summary>
    /// NameProperty: GadgetsForGadgetWheel
    /// </summary>
    public unsafe BmSDK.FName GadgetsForGadgetWheel_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// IntProperty: GadgetWheelMaxSlots
    /// </summary>
    public unsafe int GadgetWheelMaxSlots
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// StrProperty: CharacterAcronym
    /// </summary>
    public unsafe BmSDK.FString CharacterAcronym
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// ArrayProperty: AudioAdditionalBanksToLoad
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkBank> AudioAdditionalBanksToLoad
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkBank>>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// ArrayProperty: AudioAdditionalEventsToLoad
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkEvent> AudioAdditionalEventsToLoad
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkEvent>>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// ArrayProperty: ThugConfigs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCharacterBioCue> ThugConfigs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCharacterBioCue>>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// ArrayProperty: ThugAnimsets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> ThugAnimsets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// IntProperty: ReferenceCount
    /// </summary>
    public unsafe int ReferenceCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// BoolProperty: DontShowHealth
    /// </summary>
    public unsafe bool DontShowHealth
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 936); }
    }

    /// <summary>
    /// ObjectProperty: AudioForceAzrael
    /// </summary>
    public unsafe BmSDK.Engine.AkStateName AudioForceAzrael
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkStateName>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }
}
