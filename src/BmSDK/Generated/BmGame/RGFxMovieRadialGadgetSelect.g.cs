#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieRadialGadgetSelect<br/>
/// (flags = 0)
/// </summary>
public partial class RGFxMovieRadialGadgetSelect : BmSDK.BmGame.RGFxMovie, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieRadialGadgetSelect", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieRadialGadgetSelect() { }

    /// <summary>
    /// Constructs a new RGFxMovieRadialGadgetSelect
    /// </summary>
    public RGFxMovieRadialGadgetSelect(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieRadialGadgetSelect Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieRadialGadgetSelect(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bWheelOpen
    /// </summary>
    public unsafe bool bWheelOpen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bLeftCornerGadgetVisible
    /// </summary>
    public unsafe bool bLeftCornerGadgetVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bRegisteredAsManualAdvanceMovie
    /// </summary>
    public unsafe bool bRegisteredAsManualAdvanceMovie
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bIsMoving
    /// </summary>
    public unsafe bool bIsMoving
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: GadgetChangeWhileOpen
    /// </summary>
    public unsafe bool GadgetChangeWhileOpen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: PostCloseGadgetActionQueued
    /// </summary>
    public unsafe bool PostCloseGadgetActionQueued
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 696); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 696); }
    }

    /// <summary>
    /// FloatProperty: DeregisterCountdown
    /// </summary>
    public unsafe float DeregisterCountdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// StructProperty: WorldPPSettings
    /// </summary>
    public unsafe BmSDK.Engine.PostProcessVolume.FPostProcessSettings WorldPPSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PostProcessVolume.FPostProcessSettings>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// IntProperty: SelectedGadgetIndex
    /// </summary>
    public unsafe int SelectedGadgetIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1228); }
    }

    /// <summary>
    /// IntProperty: SelectedGadgetIndex_Inventory
    /// </summary>
    public unsafe int SelectedGadgetIndex_Inventory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }

    /// <summary>
    /// IntProperty: LeftCornerGadgetIndex
    /// </summary>
    public unsafe int LeftCornerGadgetIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1236); }
    }

    /// <summary>
    /// IntProperty: RequiredGadget_OutOfSixteen
    /// </summary>
    public unsafe int RequiredGadget_OutOfSixteen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }

    /// <summary>
    /// IntProperty: NumWheelSlots
    /// </summary>
    public unsafe int NumWheelSlots
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1244); }
    }

    /// <summary>
    /// FloatProperty: RadiansPerGadget
    /// </summary>
    public unsafe float RadiansPerGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// FloatProperty: LastAngleSent
    /// </summary>
    public unsafe float LastAngleSent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }

    /// <summary>
    /// NameProperty: CurrentlyLoadedGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentlyLoadedGadgets_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }
    /// <summary>
    /// NameProperty: CurrentlyLoadedGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentlyLoadedGadgets_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }
    /// <summary>
    /// NameProperty: CurrentlyLoadedGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentlyLoadedGadgets_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }
    /// <summary>
    /// NameProperty: CurrentlyLoadedGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentlyLoadedGadgets_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }
    }
    /// <summary>
    /// NameProperty: CurrentlyLoadedGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentlyLoadedGadgets_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }
    /// <summary>
    /// NameProperty: CurrentlyLoadedGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentlyLoadedGadgets_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }
    }
    /// <summary>
    /// NameProperty: CurrentlyLoadedGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentlyLoadedGadgets_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1304); }
    }
    /// <summary>
    /// NameProperty: CurrentlyLoadedGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentlyLoadedGadgets_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }
    }
    /// <summary>
    /// NameProperty: CurrentlyLoadedGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentlyLoadedGadgets_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }
    /// <summary>
    /// NameProperty: CurrentlyLoadedGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentlyLoadedGadgets_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }
    }
    /// <summary>
    /// NameProperty: CurrentlyLoadedGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentlyLoadedGadgets_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1336); }
    }
    /// <summary>
    /// NameProperty: CurrentlyLoadedGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentlyLoadedGadgets_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// FloatProperty: ControlStickX
    /// </summary>
    public unsafe float ControlStickX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }
    }

    /// <summary>
    /// FloatProperty: ControlStickY
    /// </summary>
    public unsafe float ControlStickY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1356); }
    }

    /// <summary>
    /// FloatProperty: StickMagLastFrame
    /// </summary>
    public unsafe float StickMagLastFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }

    /// <summary>
    /// ObjectProperty: CloseWheelEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent CloseWheelEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1364); }
    }

    /// <summary>
    /// ObjectProperty: CloseWheelEquipEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent CloseWheelEquipEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1372); }
    }

    /// <summary>
    /// ObjectProperty: WheelHighlightEmptyEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent WheelHighlightEmptyEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1380); }
    }

    /// <summary>
    /// ObjectProperty: WheelHighlightGadgetEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent WheelHighlightGadgetEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1388); }
    }

    /// <summary>
    /// ObjectProperty: PlayWheelMoveEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent PlayWheelMoveEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1396); }
    }

    /// <summary>
    /// ObjectProperty: StopWheelMoveEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent StopWheelMoveEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1404); }
    }

    /// <summary>
    /// ObjectProperty: WheelOpenEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent WheelOpenEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1412); }
    }

    /// <summary>
    /// FloatProperty: TimeInMenu
    /// </summary>
    public unsafe float TimeInMenu
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1420); }
    }

    /// <summary>
    /// StrProperty: DeferredExternalInterfaceCallsString
    /// </summary>
    public unsafe BmSDK.FString DeferredExternalInterfaceCallsString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }
    }

    /// <summary>
    /// IntProperty: CycleGadgetsIndexOrder
    /// </summary>
    public unsafe int CycleGadgetsIndexOrder_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1440); }
    }
    /// <summary>
    /// IntProperty: CycleGadgetsIndexOrder
    /// </summary>
    public unsafe int CycleGadgetsIndexOrder_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1444); }
    }
    /// <summary>
    /// IntProperty: CycleGadgetsIndexOrder
    /// </summary>
    public unsafe int CycleGadgetsIndexOrder_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1448); }
    }
    /// <summary>
    /// IntProperty: CycleGadgetsIndexOrder
    /// </summary>
    public unsafe int CycleGadgetsIndexOrder_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1452); }
    }
    /// <summary>
    /// IntProperty: CycleGadgetsIndexOrder
    /// </summary>
    public unsafe int CycleGadgetsIndexOrder_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1456); }
    }
    /// <summary>
    /// IntProperty: CycleGadgetsIndexOrder
    /// </summary>
    public unsafe int CycleGadgetsIndexOrder_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1460); }
    }
    /// <summary>
    /// IntProperty: CycleGadgetsIndexOrder
    /// </summary>
    public unsafe int CycleGadgetsIndexOrder_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1464); }
    }
    /// <summary>
    /// IntProperty: CycleGadgetsIndexOrder
    /// </summary>
    public unsafe int CycleGadgetsIndexOrder_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1468); }
    }
    /// <summary>
    /// IntProperty: CycleGadgetsIndexOrder
    /// </summary>
    public unsafe int CycleGadgetsIndexOrder_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1472); }
    }
    /// <summary>
    /// IntProperty: CycleGadgetsIndexOrder
    /// </summary>
    public unsafe int CycleGadgetsIndexOrder_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1476); }
    }
    /// <summary>
    /// IntProperty: CycleGadgetsIndexOrder
    /// </summary>
    public unsafe int CycleGadgetsIndexOrder_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1480); }
    }
    /// <summary>
    /// IntProperty: CycleGadgetsIndexOrder
    /// </summary>
    public unsafe int CycleGadgetsIndexOrder_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1484); }
    }
}
