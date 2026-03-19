#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCapeSkeletalMeshComponent<br/>
/// (size = 0)
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
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.Animations>> CoreAnimSets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.Animations>>>(Ptr + 2648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2648); }
    }

    /// <summary>
    /// ByteProperty: CapeBoundsCalculationType
    /// </summary>
    public unsafe byte CapeBoundsCalculationType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2664); }
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
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.Animations> BoneUseComponentReferenceRotationFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent.Animations>>(Ptr + 2672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2672); }
    }

    /// <summary>
    /// ObjectProperty: MatInstConst
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent.Animations MatInstConst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent.Animations>(Ptr + 2688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2688); }
    }

    /// <summary>
    /// ObjectProperty: DefaultMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DefaultMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2696); }
    }

    /// <summary>
    /// ObjectProperty: OverrideMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OverrideMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2704); }
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
