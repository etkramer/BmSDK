#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudModuleHeavyTankScanBase<br/>
/// (size = 240)
/// (flags = 18)
/// </summary>
public partial class RHudModuleHeavyTankScanBase : BmSDK.BmGame.RHudModule, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHudModuleHeavyTankScanBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RHudModuleHeavyTankScanBase() { }

    /// <summary>
    /// Constructs a new RHudModuleHeavyTankScanBase
    /// </summary>
    public RHudModuleHeavyTankScanBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHudModuleHeavyTankScanBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHudModuleHeavyTankScanBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: XI_HeavyTankScan_ThreeDeeAnimComplete
    /// </summary>
    public unsafe void XI_HeavyTankScan_ThreeDeeAnimComplete()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleHeavyTankScanBase.XI_HeavyTankScan_ThreeDeeAnimComplete", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_HeavyTankScan_ScanResolved
    /// </summary>
    public unsafe void XI_HeavyTankScan_ScanResolved(float proportion_revealed_this_scan, float total_proportion_revealed, float scan_angle)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleHeavyTankScanBase.XI_HeavyTankScan_ScanResolved", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(proportion_revealed_this_scan, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(total_proportion_revealed, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(scan_angle, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AnalyseAndOutro
    /// </summary>
    public unsafe void AnalyseAndOutro()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleHeavyTankScanBase.AnalyseAndOutro", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RevealParts
    /// </summary>
    public unsafe void RevealParts(float AngleRangeDegrees, float AngleRangeForBack)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleHeavyTankScanBase.RevealParts", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AngleRangeDegrees, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AngleRangeForBack, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetAngles
    /// </summary>
    public unsafe void SetAngles(float tank_angle_degrees, float turret_angle_degrees)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleHeavyTankScanBase.SetAngles", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(tank_angle_degrees, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(turret_angle_degrees, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
