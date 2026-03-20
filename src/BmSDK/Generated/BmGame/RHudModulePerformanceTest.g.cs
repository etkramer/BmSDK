#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudModulePerformanceTest<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RHudModulePerformanceTest : BmSDK.BmGame.RHudModule, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHudModulePerformanceTest", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RHudModulePerformanceTest() { }

    /// <summary>
    /// Constructs a new RHudModulePerformanceTest
    /// </summary>
    public RHudModulePerformanceTest(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHudModulePerformanceTest Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHudModulePerformanceTest(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: CachedFunction_SetTankParamsFromArray
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetTankParamsFromArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_CreateTanks
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_CreateTanks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// ObjectProperty: FlashConsolidatedDataArray
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject FlashConsolidatedDataArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// ObjectProperty: FlashTanksMovieClipArray
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject FlashTanksMovieClipArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// ArrayProperty: IndividualTankObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GFxUI.GFxObject> IndividualTankObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GFxUI.GFxObject>>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// ArrayProperty: IndividualTankDisplayInfos
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GFxUI.GFxObject.FASDisplayInfo> IndividualTankDisplayInfos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GFxUI.GFxObject.FASDisplayInfo>>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// ArrayProperty: IndividualTankCurrentFrames
    /// </summary>
    public unsafe BmSDK.TArray<int> IndividualTankCurrentFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// IntProperty: NumTankObjects
    /// </summary>
    public unsafe int NumTankObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }
}
