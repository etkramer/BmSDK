#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_DiveAwayFromCar<br/>
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_DiveAwayFromCar : BmSDK.BmGame.RBMBehaviour, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_DiveAwayFromCar", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_DiveAwayFromCar() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_DiveAwayFromCar
    /// </summary>
    public RBMBehaviour_DiveAwayFromCar(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_DiveAwayFromCar Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_DiveAwayFromCar(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: DiveNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> DiveNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// ArrayProperty: TazerDiveNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> TazerDiveNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// ArrayProperty: DiveFromHighNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> DiveFromHighNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// ArrayProperty: BraceNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> BraceNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// ArrayProperty: WallHugNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> WallHugNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// ArrayProperty: TazerOnSpotNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> TazerOnSpotNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ObjectProperty: AnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet AnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ObjectProperty: Car
    /// </summary>
    public unsafe BmSDK.Engine.Actor Car
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// BoolProperty: bStarted
    /// </summary>
    public unsafe bool bStarted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bDivingOffVehicle
    /// </summary>
    public unsafe bool bDivingOffVehicle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bStumbleFar
    /// </summary>
    public unsafe bool bStumbleFar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bCanStumble
    /// </summary>
    public unsafe bool bCanStumble
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: bCanEvadeAgain
    /// </summary>
    public unsafe bool bCanEvadeAgain
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 700); }
    }

    /// <summary>
    /// FloatProperty: CarSpeed
    /// </summary>
    public unsafe float CarSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ByteProperty: EvadeType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EEvadeVehicleType EvadeType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EEvadeVehicleType>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// StructProperty: ForceDiveDirection
    /// </summary>
    public unsafe System.Numerics.Vector3 ForceDiveDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }
}
