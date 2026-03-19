#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_SpawnVehicleBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_SpawnVehicleBase : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_SpawnVehicleBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_SpawnVehicleBase() { }

    /// <summary>
    /// Constructs a new RSeqAct_SpawnVehicleBase
    /// </summary>
    public RSeqAct_SpawnVehicleBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_SpawnVehicleBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_SpawnVehicleBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: EnableAltSetupForNewGamePlus
    /// </summary>
    public unsafe bool EnableAltSetupForNewGamePlus
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bNewGamePlus
    /// </summary>
    public unsafe bool bNewGamePlus
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bFireflyRemovesAndAddsToPopulation
    /// </summary>
    public unsafe bool bFireflyRemovesAndAddsToPopulation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bDisableDynamicObstacle
    /// </summary>
    public unsafe bool bDisableDynamicObstacle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }
}
