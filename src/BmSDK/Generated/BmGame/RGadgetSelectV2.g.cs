#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGadgetSelectV2<br/>
/// (size = 556)
/// (flags = 18)
/// </summary>
public partial class RGadgetSelectV2 : BmSDK.BmGame.RGadgetSelect, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGadgetSelectV2", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGadgetSelectV2() { }

    /// <summary>
    /// Constructs a new RGadgetSelectV2
    /// </summary>
    public RGadgetSelectV2(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGadgetSelectV2 Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGadgetSelectV2(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: PawnChanged
    /// </summary>
    public unsafe override void PawnChanged()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGadgetSelectV2.PawnChanged", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HideGadgetSelect
    /// </summary>
    public unsafe override void HideGadgetSelect()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGadgetSelectV2.HideGadgetSelect", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GadgetUpdated
    /// </summary>
    public unsafe override void GadgetUpdated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGadgetSelectV2.GadgetUpdated", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoubleGadget
    /// </summary>
    public unsafe override void DoubleGadget(byte Row, byte Column)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGadgetSelectV2.DoubleGadget", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Row, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Column, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GadgetSelected
    /// </summary>
    public unsafe override void GadgetSelected(byte Row, byte Column)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGadgetSelectV2.GadgetSelected", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Row, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Column, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGadgetSelectV2.Tick", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DrawHUD
    /// </summary>
    public unsafe override void DrawHUD(BmSDK.Engine.HUD H)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGadgetSelectV2.DrawHUD", true);
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(H, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ChangeState
    /// </summary>
    public unsafe virtual void ChangeState(BmSDK.BmGame.RGadgetSelectV2.EGadgetSelectState NewState)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGadgetSelectV2.ChangeState", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateGadgetList
    /// </summary>
    public unsafe virtual void UpdateGadgetList()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGadgetSelectV2.UpdateGadgetList", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGadgetSelectV2.Init", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: EGadgetSelectState
    /// </summary>
    public enum EGadgetSelectState
    {
        GSS_Closed = 0,
        GSS_UpOpen = 1,
        GSS_DownOpen = 2,
        GSS_MAX = 3,
    }

    /// <summary>
    /// StructProperty: UpOffset
    /// </summary>
    public unsafe System.Numerics.Vector2 UpOffset_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
    /// <summary>
    /// StructProperty: UpOffset
    /// </summary>
    public unsafe System.Numerics.Vector2 UpOffset_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }
    /// <summary>
    /// StructProperty: UpOffset
    /// </summary>
    public unsafe System.Numerics.Vector2 UpOffset_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }
    /// <summary>
    /// StructProperty: UpOffset
    /// </summary>
    public unsafe System.Numerics.Vector2 UpOffset_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }
    /// <summary>
    /// StructProperty: UpOffset
    /// </summary>
    public unsafe System.Numerics.Vector2 UpOffset_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }
    /// <summary>
    /// StructProperty: UpOffset
    /// </summary>
    public unsafe System.Numerics.Vector2 UpOffset_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }
    /// <summary>
    /// StructProperty: UpOffset
    /// </summary>
    public unsafe System.Numerics.Vector2 UpOffset_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }
    /// <summary>
    /// StructProperty: UpOffset
    /// </summary>
    public unsafe System.Numerics.Vector2 UpOffset_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// StructProperty: DownOffset
    /// </summary>
    public unsafe System.Numerics.Vector2 DownOffset_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }
    /// <summary>
    /// StructProperty: DownOffset
    /// </summary>
    public unsafe System.Numerics.Vector2 DownOffset_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }
    /// <summary>
    /// StructProperty: DownOffset
    /// </summary>
    public unsafe System.Numerics.Vector2 DownOffset_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }
    /// <summary>
    /// StructProperty: DownOffset
    /// </summary>
    public unsafe System.Numerics.Vector2 DownOffset_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }
    /// <summary>
    /// StructProperty: DownOffset
    /// </summary>
    public unsafe System.Numerics.Vector2 DownOffset_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// IntProperty: UpSelectIndex
    /// </summary>
    public unsafe int UpSelectIndex_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }
    /// <summary>
    /// IntProperty: UpSelectIndex
    /// </summary>
    public unsafe int UpSelectIndex_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }
    /// <summary>
    /// IntProperty: UpSelectIndex
    /// </summary>
    public unsafe int UpSelectIndex_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }
    /// <summary>
    /// IntProperty: UpSelectIndex
    /// </summary>
    public unsafe int UpSelectIndex_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }
    /// <summary>
    /// IntProperty: UpSelectIndex
    /// </summary>
    public unsafe int UpSelectIndex_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }
    /// <summary>
    /// IntProperty: UpSelectIndex
    /// </summary>
    public unsafe int UpSelectIndex_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }
    /// <summary>
    /// IntProperty: UpSelectIndex
    /// </summary>
    public unsafe int UpSelectIndex_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }
    /// <summary>
    /// IntProperty: UpSelectIndex
    /// </summary>
    public unsafe int UpSelectIndex_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }
    /// <summary>
    /// IntProperty: UpSelectIndex
    /// </summary>
    public unsafe int UpSelectIndex_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// IntProperty: DownSelectIndex
    /// </summary>
    public unsafe int DownSelectIndex_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }
    /// <summary>
    /// IntProperty: DownSelectIndex
    /// </summary>
    public unsafe int DownSelectIndex_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }
    /// <summary>
    /// IntProperty: DownSelectIndex
    /// </summary>
    public unsafe int DownSelectIndex_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }
    /// <summary>
    /// IntProperty: DownSelectIndex
    /// </summary>
    public unsafe int DownSelectIndex_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }
    /// <summary>
    /// IntProperty: DownSelectIndex
    /// </summary>
    public unsafe int DownSelectIndex_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }
    /// <summary>
    /// IntProperty: DownSelectIndex
    /// </summary>
    public unsafe int DownSelectIndex_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }
    /// <summary>
    /// IntProperty: DownSelectIndex
    /// </summary>
    public unsafe int DownSelectIndex_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }
    /// <summary>
    /// IntProperty: DownSelectIndex
    /// </summary>
    public unsafe int DownSelectIndex_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }
    /// <summary>
    /// IntProperty: DownSelectIndex
    /// </summary>
    public unsafe int DownSelectIndex_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// StructProperty: GadgetSelectOrigin
    /// </summary>
    public unsafe System.Numerics.Vector2 GadgetSelectOrigin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// StructProperty: IconSize
    /// </summary>
    public unsafe System.Numerics.Vector2 IconSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// StructProperty: GadgetSelectRadius
    /// </summary>
    public unsafe System.Numerics.Vector2 GadgetSelectRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// ObjectProperty: ArrowMat
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface ArrowMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// StructProperty: SmallArrowSize
    /// </summary>
    public unsafe System.Numerics.Vector2 SmallArrowSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// StructProperty: LargeArrowSize
    /// </summary>
    public unsafe System.Numerics.Vector2 LargeArrowSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// StructProperty: TextPosition
    /// </summary>
    public unsafe System.Numerics.Vector2 TextPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// StructProperty: CurrentOffset
    /// </summary>
    public unsafe System.Numerics.Vector2 CurrentOffset_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }
    /// <summary>
    /// StructProperty: CurrentOffset
    /// </summary>
    public unsafe System.Numerics.Vector2 CurrentOffset_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }
    /// <summary>
    /// StructProperty: CurrentOffset
    /// </summary>
    public unsafe System.Numerics.Vector2 CurrentOffset_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }
    /// <summary>
    /// StructProperty: CurrentOffset
    /// </summary>
    public unsafe System.Numerics.Vector2 CurrentOffset_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }
    /// <summary>
    /// StructProperty: CurrentOffset
    /// </summary>
    public unsafe System.Numerics.Vector2 CurrentOffset_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }
    }
    /// <summary>
    /// StructProperty: CurrentOffset
    /// </summary>
    public unsafe System.Numerics.Vector2 CurrentOffset_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
    /// <summary>
    /// StructProperty: CurrentOffset
    /// </summary>
    public unsafe System.Numerics.Vector2 CurrentOffset_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }
    /// <summary>
    /// StructProperty: CurrentOffset
    /// </summary>
    public unsafe System.Numerics.Vector2 CurrentOffset_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// NameProperty: CurrentGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentGadgets_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }
    /// <summary>
    /// NameProperty: CurrentGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentGadgets_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }
    /// <summary>
    /// NameProperty: CurrentGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentGadgets_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }
    /// <summary>
    /// NameProperty: CurrentGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentGadgets_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }
    /// <summary>
    /// NameProperty: CurrentGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentGadgets_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }
    /// <summary>
    /// NameProperty: CurrentGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentGadgets_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }
    /// <summary>
    /// NameProperty: CurrentGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentGadgets_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }
    /// <summary>
    /// NameProperty: CurrentGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentGadgets_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// NameProperty: CurrentExtraGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentExtraGadgets_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }
    /// <summary>
    /// NameProperty: CurrentExtraGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentExtraGadgets_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }
    /// <summary>
    /// NameProperty: CurrentExtraGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentExtraGadgets_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }
    /// <summary>
    /// NameProperty: CurrentExtraGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentExtraGadgets_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }
    /// <summary>
    /// NameProperty: CurrentExtraGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentExtraGadgets_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }
    /// <summary>
    /// NameProperty: CurrentExtraGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentExtraGadgets_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }
    /// <summary>
    /// NameProperty: CurrentExtraGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentExtraGadgets_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }
    /// <summary>
    /// NameProperty: CurrentExtraGadgets
    /// </summary>
    public unsafe BmSDK.FName CurrentExtraGadgets_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// ByteProperty: CurrentAllowSubClasses
    /// </summary>
    public unsafe byte CurrentAllowSubClasses_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }
    /// <summary>
    /// ByteProperty: CurrentAllowSubClasses
    /// </summary>
    public unsafe byte CurrentAllowSubClasses_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 505); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 505); }
    }
    /// <summary>
    /// ByteProperty: CurrentAllowSubClasses
    /// </summary>
    public unsafe byte CurrentAllowSubClasses_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 506); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 506); }
    }
    /// <summary>
    /// ByteProperty: CurrentAllowSubClasses
    /// </summary>
    public unsafe byte CurrentAllowSubClasses_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 507); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 507); }
    }
    /// <summary>
    /// ByteProperty: CurrentAllowSubClasses
    /// </summary>
    public unsafe byte CurrentAllowSubClasses_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }
    /// <summary>
    /// ByteProperty: CurrentAllowSubClasses
    /// </summary>
    public unsafe byte CurrentAllowSubClasses_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 509); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 509); }
    }
    /// <summary>
    /// ByteProperty: CurrentAllowSubClasses
    /// </summary>
    public unsafe byte CurrentAllowSubClasses_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 510); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 510); }
    }
    /// <summary>
    /// ByteProperty: CurrentAllowSubClasses
    /// </summary>
    public unsafe byte CurrentAllowSubClasses_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 511); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 511); }
    }

    /// <summary>
    /// ByteProperty: CurrentState
    /// </summary>
    public unsafe BmSDK.BmGame.RGadgetSelectV2.EGadgetSelectState CurrentState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGadgetSelectV2.EGadgetSelectState>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// IntProperty: CurrentSelectIndex
    /// </summary>
    public unsafe int CurrentSelectIndex_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }
    /// <summary>
    /// IntProperty: CurrentSelectIndex
    /// </summary>
    public unsafe int CurrentSelectIndex_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }
    /// <summary>
    /// IntProperty: CurrentSelectIndex
    /// </summary>
    public unsafe int CurrentSelectIndex_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }
    /// <summary>
    /// IntProperty: CurrentSelectIndex
    /// </summary>
    public unsafe int CurrentSelectIndex_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }
    /// <summary>
    /// IntProperty: CurrentSelectIndex
    /// </summary>
    public unsafe int CurrentSelectIndex_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }
    /// <summary>
    /// IntProperty: CurrentSelectIndex
    /// </summary>
    public unsafe int CurrentSelectIndex_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }
    /// <summary>
    /// IntProperty: CurrentSelectIndex
    /// </summary>
    public unsafe int CurrentSelectIndex_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }
    /// <summary>
    /// IntProperty: CurrentSelectIndex
    /// </summary>
    public unsafe int CurrentSelectIndex_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }
    /// <summary>
    /// IntProperty: CurrentSelectIndex
    /// </summary>
    public unsafe int CurrentSelectIndex_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// IntProperty: GadgetToDisplay
    /// </summary>
    public unsafe int GadgetToDisplay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }
}
