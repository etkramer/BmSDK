#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudModuleTargets<br/>
/// (size = 564)
/// (flags = 0)
/// </summary>
public partial class RHudModuleTargets : BmSDK.BmGame.RHudModule, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHudModuleTargets", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RHudModuleTargets() { }

    /// <summary>
    /// Constructs a new RHudModuleTargets
    /// </summary>
    public RHudModuleTargets(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHudModuleTargets Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHudModuleTargets(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: SetSuperEjectLevel
    /// </summary>
    public unsafe void SetSuperEjectLevel(float boost_level, int upgrade_level)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.SetSuperEjectLevel", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(boost_level, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(upgrade_level, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetGrappleBoostLevel
    /// </summary>
    public unsafe void SetGrappleBoostLevel(float boost_level, int upgrade_level)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.SetGrappleBoostLevel", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(boost_level, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(upgrade_level, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetGrappleHidden
    /// </summary>
    public unsafe void SetGrappleHidden()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.SetGrappleHidden", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetGrappleTarget2D
    /// </summary>
    public unsafe void SetGrappleTarget2D(BmSDK.FString _ScreenGrappleString, float _ScreenGrappleX, float _ScreenGrappleY, float _ScreenGrappleDepth)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.SetGrappleTarget2D", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ScreenGrappleString, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ScreenGrappleX, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ScreenGrappleY, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ScreenGrappleDepth, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetCompassMode
    /// </summary>
    public unsafe void SetCompassMode(bool is_batmobile)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.SetCompassMode", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_batmobile, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SendToFlash
    /// </summary>
    public unsafe void SendToFlash(int _Num_Cursors, int _MainCursorIndex, bool _MainCursorPulsing, int _MainCursorCharges, int _MainCursorMaxCharges, bool _bCompassVisible, float _CompassFacingAngle, int _NumVisibleCompassArrayItems)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.SendToFlash", true);
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_Num_Cursors, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_MainCursorIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_MainCursorPulsing, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_MainCursorCharges, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_MainCursorMaxCharges, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_bCompassVisible, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_CompassFacingAngle, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_NumVisibleCompassArrayItems, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SendCursors
    /// </summary>
    public unsafe void SendCursors()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.SendCursors", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoesEncounterCountAsCombat
    /// </summary>
    public unsafe bool DoesEncounterCountAsCombat(BmSDK.BmGame.RVehicleNPC.EVehicleCombatEncounterType the_encounter)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.DoesEncounterCountAsCombat", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_encounter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: TargetCursor
    /// </summary>
    public unsafe void TargetCursor(int CursorID, BmSDK.FString AnimName, bool bVisible, bool bSnapToPosition, float X, float Y, float Depth, bool Pulsing = default, int Charges = default, int MaxCharges = default, float ScreenSize = default, bool ForceMain = default, float CursorLockon = default, float CursorOpacity = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.TargetCursor", true);
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CursorID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bVisible, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSnapToPosition, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Depth, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pulsing, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Charges, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxCharges, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScreenSize, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceMain, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CursorLockon, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CursorOpacity, paramsPtr + 64);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RetargetForScreen
    /// </summary>
    public unsafe void RetargetForScreen(int ArrayIndex)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.RetargetForScreen", true);
        byte* paramsPtr = stackalloc byte[260];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArrayIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetPositionDirectlyAboveActor
    /// </summary>
    public unsafe System.Numerics.Vector3 GetPositionDirectlyAboveActor(BmSDK.Engine.Canvas HudCanvas, BmSDK.Engine.Actor TheActor)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.GetPositionDirectlyAboveActor", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HudCanvas, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheActor, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: SetActorScreenSizeAndLocation
    /// </summary>
    public unsafe void SetActorScreenSizeAndLocation(BmSDK.Engine.Canvas HudCanvas, BmSDK.Engine.Actor TheActor, out float ScreenSize, out System.Numerics.Vector3 ScreenLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.SetActorScreenSizeAndLocation", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HudCanvas, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheActor, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ScreenSize = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 16);
        ScreenLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 20);
        return;
    }

    /// <summary>
    /// Function: SendFocusDetailToFlash
    /// </summary>
    public unsafe void SendFocusDetailToFlash(BmSDK.FString focus_string)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.SendFocusDetailToFlash", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(focus_string, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetFocusDetail
    /// </summary>
    public unsafe void SetFocusDetail()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.SetFocusDetail", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FlushThreeDeeCursors
    /// </summary>
    public unsafe void FlushThreeDeeCursors()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.FlushThreeDeeCursors", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlaySubAnimOnCursor3DPrivate
    /// </summary>
    public unsafe void PlaySubAnimOnCursor3DPrivate(int CursorIndex, BmSDK.FString subanim)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.PlaySubAnimOnCursor3DPrivate", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CursorIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(subanim, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlaySubAnimOnCursor3D
    /// </summary>
    public unsafe void PlaySubAnimOnCursor3D(BmSDK.FString CursorID, BmSDK.FString subanim)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.PlaySubAnimOnCursor3D", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CursorID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(subanim, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HideCursor3D
    /// </summary>
    public unsafe void HideCursor3D(BmSDK.FString CursorID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.HideCursor3D", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CursorID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetSingleIntChargeValue
    /// </summary>
    public unsafe int GetSingleIntChargeValue(int Charges, int max_charges)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.GetSingleIntChargeValue", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Charges, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(max_charges, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: TargetCursor3dWithActorAndComponentReference
    /// </summary>
    public unsafe int TargetCursor3dWithActorAndComponentReference(BmSDK.FString CursorID, BmSDK.FString AnimName, BmSDK.Engine.Actor LinkedActor, BmSDK.Engine.PrimitiveComponent LinkedComponent = default, int AttributeFlags = default, int Charges = default, int MaxCharges = default, BmSDK.FString ExtraInfo = default, bool ForceMain = default, float CursorLockon = default, BmSDK.FString OptionalFocusDetail = default, BmSDK.FString MapRefName = default, BmSDK.FString MapTypeName = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.TargetCursor3dWithActorAndComponentReference", true);
        byte* paramsPtr = stackalloc byte[152];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CursorID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkedActor, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkedComponent, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttributeFlags, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Charges, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxCharges, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraInfo, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceMain, paramsPtr + 76);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CursorLockon, paramsPtr + 80);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OptionalFocusDetail, paramsPtr + 84);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapRefName, paramsPtr + 100);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapTypeName, paramsPtr + 116);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 132);
    }

    /// <summary>
    /// Function: TargetCursor3dWithActorReference
    /// </summary>
    public unsafe int TargetCursor3dWithActorReference(BmSDK.FString CursorID, BmSDK.FString AnimName, BmSDK.Engine.Actor LinkedActor, int AttributeFlags = default, int Charges = default, int MaxCharges = default, BmSDK.FString ExtraInfo = default, bool ForceMain = default, float CursorLockon = default, BmSDK.FString OptionalFocusDetail = default, BmSDK.FString MapRefName = default, BmSDK.FString MapTypeName = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.TargetCursor3dWithActorReference", true);
        byte* paramsPtr = stackalloc byte[128];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CursorID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkedActor, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttributeFlags, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Charges, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxCharges, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraInfo, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceMain, paramsPtr + 68);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CursorLockon, paramsPtr + 72);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OptionalFocusDetail, paramsPtr + 76);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapRefName, paramsPtr + 92);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapTypeName, paramsPtr + 108);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 124);
    }

    /// <summary>
    /// Function: TargetCursor3D
    /// </summary>
    public unsafe int TargetCursor3D(BmSDK.FString CursorID, BmSDK.FString AnimName, System.Numerics.Vector3 Location, int AttributeFlags = default, int Charges = default, int MaxCharges = default, BmSDK.FString ExtraInfo = default, bool ForceMain = default, float CursorLockon = default, BmSDK.FString OptionalFocusDetail = default, BmSDK.FString MapRefName = default, BmSDK.FString MapTypeName = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.TargetCursor3D", true);
        byte* paramsPtr = stackalloc byte[136];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CursorID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Location, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttributeFlags, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Charges, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxCharges, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraInfo, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceMain, paramsPtr + 72);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CursorLockon, paramsPtr + 76);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OptionalFocusDetail, paramsPtr + 80);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapRefName, paramsPtr + 96);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapTypeName, paramsPtr + 112);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 128);
    }

    /// <summary>
    /// Function: TargetCursorScreenSpace
    /// </summary>
    public unsafe int TargetCursorScreenSpace(BmSDK.FString CursorID, BmSDK.FString AnimName, float x_position, float y_position, int AttributeFlags = default, int Charges = default, int MaxCharges = default, BmSDK.FString ExtraInfo = default, bool ForceMain = default, float CursorLockon = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.TargetCursorScreenSpace", true);
        byte* paramsPtr = stackalloc byte[92];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CursorID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(x_position, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(y_position, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttributeFlags, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Charges, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxCharges, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraInfo, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceMain, paramsPtr + 68);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CursorLockon, paramsPtr + 72);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 76);
    }

    /// <summary>
    /// Function: TargetCursorCentreScreen
    /// </summary>
    public unsafe int TargetCursorCentreScreen(BmSDK.FString CursorID, BmSDK.FString AnimName, int AttributeFlags = default, int Charges = default, int MaxCharges = default, BmSDK.FString ExtraInfo = default, bool ForceMain = default, float CursorLockon = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.TargetCursorCentreScreen", true);
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CursorID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttributeFlags, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Charges, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxCharges, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraInfo, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceMain, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CursorLockon, paramsPtr + 64);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 68);
    }

    /// <summary>
    /// Function: DisruptorTarget
    /// </summary>
    public unsafe int DisruptorTarget(BmSDK.FString target_string, bool target_locked, int current_ammo, int max_ammo, int upgrade_level, BmSDK.FString detail_string, BmSDK.FString anim_event)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.DisruptorTarget", true);
        byte* paramsPtr = stackalloc byte[88];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(target_string, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(target_locked, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(current_ammo, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(max_ammo, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(upgrade_level, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(detail_string, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(anim_event, paramsPtr + 48);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 64);
    }

    /// <summary>
    /// Function: ExtendThreeDeeArray
    /// </summary>
    public unsafe void ExtendThreeDeeArray()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.ExtendThreeDeeArray", true);
        byte* paramsPtr = stackalloc byte[152];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetAvailableArrayIndex
    /// </summary>
    public unsafe int GetAvailableArrayIndex()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.GetAvailableArrayIndex", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetArrayIndexFromCursorID
    /// </summary>
    public unsafe int GetArrayIndexFromCursorID(BmSDK.FString CursorID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.GetArrayIndexFromCursorID", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CursorID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: SendCompassInfoPrivate
    /// </summary>
    public unsafe void SendCompassInfoPrivate(bool _bCompassVisible, float _CompassFacingAngle, int _NumVisibleCompassArrayItems)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.SendCompassInfoPrivate", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_bCompassVisible, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_CompassFacingAngle, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_NumVisibleCompassArrayItems, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RetargetCompassItemForScreen
    /// </summary>
    public unsafe void RetargetCompassItemForScreen(int CompassItemIndex, int ScreenArray, float DisplayAlpha = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.RetargetCompassItemForScreen", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CompassItemIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ScreenArray, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DisplayAlpha, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FlushCompassItems
    /// </summary>
    public unsafe void FlushCompassItems()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.FlushCompassItems", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DeregisterCompassItem
    /// </summary>
    public unsafe void DeregisterCompassItem(BmSDK.FString StringID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.DeregisterCompassItem", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StringID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RegisterCompassItem
    /// </summary>
    public unsafe void RegisterCompassItem(BmSDK.FString StringID, BmSDK.FString IconName, BmSDK.Engine.Actor LinkedActor = default, System.Numerics.Vector3 ItemLocation = default, int RangeForDisappear = default, int FadeOutDistance = default, bool IsExclusive = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.RegisterCompassItem", true);
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StringID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IconName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkedActor, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemLocation, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RangeForDisappear, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FadeOutDistance, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsExclusive, paramsPtr + 60);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetAvailableCompassArrayIndex
    /// </summary>
    public unsafe int GetAvailableCompassArrayIndex()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.GetAvailableCompassArrayIndex", true);
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetCompassArrayIndexFromStringID
    /// </summary>
    public unsafe int GetCompassArrayIndexFromStringID(BmSDK.FString StringID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.GetCompassArrayIndexFromStringID", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StringID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: SetLevelUpVisiblePrivate
    /// </summary>
    public unsafe void SetLevelUpVisiblePrivate(bool _LevelUpVisible)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.SetLevelUpVisiblePrivate", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_LevelUpVisible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateLevelUpVisibility
    /// </summary>
    public unsafe void UpdateLevelUpVisibility()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.UpdateLevelUpVisibility", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetLevelUpSuppressed
    /// </summary>
    public unsafe void SetLevelUpSuppressed(bool _LevelUpSuppressed)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.SetLevelUpSuppressed", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_LevelUpSuppressed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetLevelUpVisible
    /// </summary>
    public unsafe void SetLevelUpVisible(bool _LevelUpVisible)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.SetLevelUpVisible", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_LevelUpVisible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InitialiseFlash
    /// </summary>
    public unsafe void InitialiseFlash()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.InitialiseFlash", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PadConsolidatedArray
    /// </summary>
    public unsafe void PadConsolidatedArray(int length_requested)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.PadConsolidatedArray", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(length_requested, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Close
    /// </summary>
    public unsafe void Close()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.Close", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe bool Init(BmSDK.BmGame.RPlayerController _RPC, BmSDK.FString _ExtensionName, BmSDK.FString _ExtensionPath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleTargets.Init", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionPath, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 40);
    }

    /// <summary>
    /// Struct: FCompassItemThreeDee
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 60)]
    public partial record struct FCompassItemThreeDee
    {
        /// <summary>
        /// StrProperty: StringID
        /// </summary>
        public unsafe BmSDK.FString StringID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: IconName
        /// </summary>
        public unsafe BmSDK.FString IconName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ObjectProperty: LinkedActor
        /// </summary>
        public unsafe BmSDK.Engine.Actor LinkedActor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// StructProperty: ItemLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 ItemLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// IntProperty: RangeForDisappear
        /// </summary>
        public unsafe int RangeForDisappear
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// IntProperty: FadeOutDistance
        /// </summary>
        public unsafe int FadeOutDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }
    }

    /// <summary>
    /// Struct: FThreeDeeTarget
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 152)]
    public partial record struct FThreeDeeTarget
    {
        /// <summary>
        /// StrProperty: CursorID
        /// </summary>
        public unsafe BmSDK.FString CursorID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: AnimName
        /// </summary>
        public unsafe BmSDK.FString AnimName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ObjectProperty: OptionalLinkedActor
        /// </summary>
        public unsafe BmSDK.Engine.Actor OptionalLinkedActor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// ComponentProperty: OptionalLinkedComponent
        /// </summary>
        public unsafe BmSDK.Engine.PrimitiveComponent OptionalLinkedComponent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// StructProperty: Location
        /// </summary>
        public unsafe System.Numerics.Vector3 Location
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// IntProperty: AttributeFlags
        /// </summary>
        public unsafe int AttributeFlags
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// StrProperty: ExtraInfo
        /// </summary>
        public unsafe BmSDK.FString ExtraInfo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// BoolProperty: ForceMainFlag
        /// </summary>
        public unsafe bool ForceMainFlag
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 80); }; }
        }

        /// <summary>
        /// FloatProperty: ScreenX
        /// </summary>
        public unsafe float ScreenX
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// FloatProperty: ScreenY
        /// </summary>
        public unsafe float ScreenY
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 88); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }; }
        }

        /// <summary>
        /// IntProperty: ChargeLevel
        /// </summary>
        public unsafe int ChargeLevel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }; }
        }

        /// <summary>
        /// BoolProperty: KeepAliveFlag
        /// </summary>
        public unsafe bool KeepAliveFlag
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }; }
        }

        /// <summary>
        /// FloatProperty: LockonProportion
        /// </summary>
        public unsafe float LockonProportion
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 100); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }; }
        }

        /// <summary>
        /// StrProperty: OptionalFocusDetail
        /// </summary>
        public unsafe BmSDK.FString OptionalFocusDetail
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 104); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }; }
        }

        /// <summary>
        /// StrProperty: MapRefName
        /// </summary>
        public unsafe BmSDK.FString MapRefName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 120); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }; }
        }

        /// <summary>
        /// StrProperty: MapTypeName
        /// </summary>
        public unsafe BmSDK.FString MapTypeName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 136); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }; }
        }
    }

    /// <summary>
    /// ArrayProperty: ConsolidatedArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ConsolidatedArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// ArrayProperty: ConsolidatedArrayCopy
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ConsolidatedArrayCopy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// IntProperty: Num_Cursors
    /// </summary>
    public unsafe int Num_Cursors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// ArrayProperty: ThreeDeeTargetArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHudModuleTargets.FThreeDeeTarget> ThreeDeeTargetArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHudModuleTargets.FThreeDeeTarget>>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// BoolProperty: SuppressMainTargetThisFrame
    /// </summary>
    public unsafe bool SuppressMainTargetThisFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: MainCursorPulsing
    /// </summary>
    public unsafe bool MainCursorPulsing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: BatmobileHeavyWeaponValid
    /// </summary>
    public unsafe bool BatmobileHeavyWeaponValid
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: CurrentlyInCombat
    /// </summary>
    public unsafe bool CurrentlyInCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: ScreenGrappleVisible
    /// </summary>
    public unsafe bool ScreenGrappleVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: ScreenGrappleDirty
    /// </summary>
    public unsafe bool ScreenGrappleDirty
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: bCompassVisible
    /// </summary>
    public unsafe bool bCompassVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: bCompassVisibleInFlash
    /// </summary>
    public unsafe bool bCompassVisibleInFlash
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: LevelUpVisible
    /// </summary>
    public unsafe bool LevelUpVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: LevelUpSuppressed
    /// </summary>
    public unsafe bool LevelUpSuppressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: LevelUpVisiblePrivate
    /// </summary>
    public unsafe bool LevelUpVisiblePrivate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: bAnyCursorsActive
    /// </summary>
    public unsafe bool bAnyCursorsActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// ObjectProperty: FlashTargetsArrayObject
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject FlashTargetsArrayObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// IntProperty: FocusTargetIndex
    /// </summary>
    public unsafe int FocusTargetIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// IntProperty: FocusTargetIndexCurrentlyDisplayed
    /// </summary>
    public unsafe int FocusTargetIndexCurrentlyDisplayed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// IntProperty: FocusTargetIndexPending
    /// </summary>
    public unsafe int FocusTargetIndexPending
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// FloatProperty: FocusTargetDistSqFromCentre
    /// </summary>
    public unsafe float FocusTargetDistSqFromCentre
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// FloatProperty: FocusTargetChangeTimer
    /// </summary>
    public unsafe float FocusTargetChangeTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// IntProperty: MainCursorIndex
    /// </summary>
    public unsafe int MainCursorIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// IntProperty: MainCursorCharges
    /// </summary>
    public unsafe int MainCursorCharges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// IntProperty: MainCursorMaxCharges
    /// </summary>
    public unsafe int MainCursorMaxCharges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// FloatProperty: DefaultCursorDepth
    /// </summary>
    public unsafe float DefaultCursorDepth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// StrProperty: BatmobileCurrentHeavyWeapon
    /// </summary>
    public unsafe BmSDK.FString BatmobileCurrentHeavyWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// FloatProperty: ScreenGrappleX
    /// </summary>
    public unsafe float ScreenGrappleX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// FloatProperty: ScreenGrappleY
    /// </summary>
    public unsafe float ScreenGrappleY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// FloatProperty: ScreenGrappleDepth
    /// </summary>
    public unsafe float ScreenGrappleDepth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// StrProperty: ScreenGrappleString
    /// </summary>
    public unsafe BmSDK.FString ScreenGrappleString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// IntProperty: NumVisibleCompassArrayItems
    /// </summary>
    public unsafe int NumVisibleCompassArrayItems
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// FloatProperty: CompassFacingAngle
    /// </summary>
    public unsafe float CompassFacingAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// ArrayProperty: CompassItemThreeDeeArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHudModuleTargets.FCompassItemThreeDee> CompassItemThreeDeeArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHudModuleTargets.FCompassItemThreeDee>>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// IntProperty: ExclusiveCompassItem
    /// </summary>
    public unsafe int ExclusiveCompassItem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// FloatProperty: fCurrentGrappleBoostLevel
    /// </summary>
    public unsafe float fCurrentGrappleBoostLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// IntProperty: iCurrentGrappleEjectUpgLevel
    /// </summary>
    public unsafe int iCurrentGrappleEjectUpgLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// StrProperty: CachedVariable_ConsolidatedArray
    /// </summary>
    public unsafe BmSDK.FString CachedVariable_ConsolidatedArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SendToFlash
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SendToFlash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SendCompassInfo
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SendCompassInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetLevelUpVisible
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetLevelUpVisible
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetCompassMode
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetCompassMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetGrappleBoostLevel
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetGrappleBoostLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetSuperEjectLevel
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetSuperEjectLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SendFocusDetailToFlash
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SendFocusDetailToFlash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_PlaySubAnimOnCursor3D
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_PlaySubAnimOnCursor3D
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// Enum: CompassArrayIndices
    /// </summary>
    public enum CompassArrayIndices
    {
        CAI_Compass_Angle = 0,
        CAI_Compass_Alpha = 1,
        CAI_Compass_IconName = 2,
        CAI_Compass_MAX = 3,
    }

    /// <summary>
    /// Enum: TargetsArrayIndices
    /// </summary>
    public enum TargetsArrayIndices
    {
        TAI_Cursor_X = 0,
        TAI_Cursor_Y = 1,
        TAI_Cursor_Depth = 2,
        TAI_Cursor_ScreenSize = 3,
        TAI_Cursor_IconName = 4,
        TAI_Cursor_LockonProportion = 5,
        TAI_Cursor_Opacity = 6,
        TAI_Cursor_MAX = 7,
    }

    /// <summary>
    /// Enum: HeaderArrayIndices
    /// </summary>
    public enum HeaderArrayIndices
    {
        HAI_Header_ScreenGrappleDirty = 0,
        HAI_Header_ScreenGrappleVisible = 1,
        HAI_Header_ScreenGrappleString = 2,
        HAI_Header_ScreenGrappleX = 3,
        HAI_Header_ScreenGrappleY = 4,
        HAI_Header_ScreenGrappleDepth = 5,
        HAI_Header_MAX = 6,
    }
}
