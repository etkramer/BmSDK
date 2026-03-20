#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCapeSkeletalMeshComponent<br/>
/// (flags = 0)
/// </summary>
public partial class RCapeSkeletalMeshComponent : BmSDK.Engine.SkeletalMeshComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCapeSkeletalMeshComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCapeSkeletalMeshComponent() { }

    /// <summary>
    /// Constructs a new RCapeSkeletalMeshComponent
    /// </summary>
    public RCapeSkeletalMeshComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCapeSkeletalMeshComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCapeSkeletalMeshComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: CoreAnimSets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> CoreAnimSets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 2648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2648); }
    }

    /// <summary>
    /// ByteProperty: CapeBoundsCalculationType
    /// </summary>
    public unsafe BmSDK.BmGame.RCapeSkeletalMeshComponent.ECapeBoundsCalculationType CapeBoundsCalculationType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCapeSkeletalMeshComponent.ECapeBoundsCalculationType>(Ptr + 2664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2664); }
    }

    /// <summary>
    /// FloatProperty: LooseCapeBoundsRadius
    /// </summary>
    public unsafe float LooseCapeBoundsRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2668); }
    }

    /// <summary>
    /// ArrayProperty: BoneUseComponentReferenceRotationFlags
    /// </summary>
    public unsafe BmSDK.TArray<int> BoneUseComponentReferenceRotationFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2672); }
    }

    /// <summary>
    /// ObjectProperty: MatInstConst
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant MatInstConst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 2688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2688); }
    }

    /// <summary>
    /// ObjectProperty: DefaultMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface DefaultMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2696); }
    }

    /// <summary>
    /// ObjectProperty: OverrideMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface OverrideMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2704); }
    }

    /// <summary>
    /// Enum: ECapeBoundsCalculationType
    /// </summary>
    public enum ECapeBoundsCalculationType
    {
        CAPEBOUNDSCALCULATION_Tight = 0,
        CAPEBOUNDSCALCULATION_Loose = 1,
        CAPEBOUNDSCALCULATION_Standard = 2,
        CAPEBOUNDSCALCULATION_MAX = 3,
    }
}
