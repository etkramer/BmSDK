#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RApexStaticDestructibleComponent<br/>
/// (flags = 0)
/// </summary>
public partial class RApexStaticDestructibleComponent : BmSDK.Engine.ApexStaticDestructibleComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RApexStaticDestructibleComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RApexStaticDestructibleComponent() { }

    /// <summary>
    /// Constructs a new RApexStaticDestructibleComponent
    /// </summary>
    public RApexStaticDestructibleComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RApexStaticDestructibleComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RApexStaticDestructibleComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: InitialSupportArea
    /// </summary>
    public unsafe float InitialSupportArea
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// FloatProperty: MinimumAmountOfSupportToRemainStanding
    /// </summary>
    public unsafe float MinimumAmountOfSupportToRemainStanding
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bUsingReducedValidBounds
    /// </summary>
    public unsafe bool bUsingReducedValidBounds
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 716) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 716); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 716); }
    }

    /// <summary>
    /// BoolProperty: bValidPlayerNavigationGeomtry
    /// </summary>
    public unsafe bool bValidPlayerNavigationGeomtry
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 716) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 716); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 716); }
    }

    /// <summary>
    /// IntProperty: NumFracturedDestructibleChunks
    /// </summary>
    public unsafe int NumFracturedDestructibleChunks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// IntProperty: ForceRemoveChunksInGroupOnFirstDamage
    /// </summary>
    public unsafe int ForceRemoveChunksInGroupOnFirstDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// StructProperty: PlayerNavigationGeometry
    /// </summary>
    public unsafe BmSDK.Engine.KMeshProps.FKAggregateGeom PlayerNavigationGeometry
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.KMeshProps.FKAggregateGeom>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// FloatProperty: ValidBoundsExtentsBelowGround
    /// </summary>
    public unsafe float ValidBoundsExtentsBelowGround
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// ClassProperty: ChainGunDamageType
    /// </summary>
    public unsafe BmSDK.Class ChainGunDamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }
}
