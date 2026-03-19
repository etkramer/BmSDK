#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnPlayerFPS<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RPawnPlayerFPS : BmSDK.BmGame.RPawnPlayerAnim, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnPlayerFPS", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnPlayerFPS() { }

    /// <summary>
    /// Constructs a new RPawnPlayerFPS
    /// </summary>
    public RPawnPlayerFPS(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnPlayerFPS Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnPlayerFPS(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerFPS>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerFPS>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerFPS>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerFPS>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerFPS>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerFPS>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerFPS>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: MyController
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MyController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3052); }
    }

    /// <summary>
    /// ObjectProperty: FireDuringMatineeAction
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FireDuringMatineeAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3060); }
    }

    /// <summary>
    /// ComponentProperty: GunMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GunMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3068); }
    }

    /// <summary>
    /// NameProperty: PostMatineeState
    /// </summary>
    public unsafe BmSDK.FName PostMatineeState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 3076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3076); }
    }

    /// <summary>
    /// BoolProperty: bNoShooting
    /// </summary>
    public unsafe bool bNoShooting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3084) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3084); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3084); }
    }

    /// <summary>
    /// BoolProperty: bDisableFinishMatineeCall
    /// </summary>
    public unsafe bool bDisableFinishMatineeCall
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3084) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3084); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3084); }
    }

    /// <summary>
    /// BoolProperty: bUseSwayAnim
    /// </summary>
    public unsafe bool bUseSwayAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3084) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3084); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3084); }
    }

    /// <summary>
    /// BoolProperty: bCanPlayAdditiveOverlays
    /// </summary>
    public unsafe bool bCanPlayAdditiveOverlays
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3084) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3084); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3084); }
    }

    /// <summary>
    /// IntProperty: GunAmmo
    /// </summary>
    public unsafe int GunAmmo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3088); }
    }

    /// <summary>
    /// FloatProperty: TimeBetweenShotMin
    /// </summary>
    public unsafe float TimeBetweenShotMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3092); }
    }

    /// <summary>
    /// FloatProperty: TimeOfLastShot
    /// </summary>
    public unsafe float TimeOfLastShot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3096); }
    }

    /// <summary>
    /// IntProperty: MaxViewYaw
    /// </summary>
    public unsafe int MaxViewYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3100); }
    }

    /// <summary>
    /// NameProperty: NextCameraState
    /// </summary>
    public unsafe BmSDK.FName NextCameraState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 3104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3104); }
    }

    /// <summary>
    /// StructProperty: CopOffsetVal
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CopOffsetVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3112); }
    }

    /// <summary>
    /// StructProperty: CopTranslationTarget
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CopTranslationTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3124); }
    }

    /// <summary>
    /// StructProperty: CopRotationTarget
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CopRotationTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3136); }
    }

    /// <summary>
    /// FloatProperty: MeshLerpValue
    /// </summary>
    public unsafe float MeshLerpValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3148); }
    }

    /// <summary>
    /// FloatProperty: MeshRotLerpValue
    /// </summary>
    public unsafe float MeshRotLerpValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3152); }
    }

    /// <summary>
    /// FloatProperty: SavedTick
    /// </summary>
    public unsafe float SavedTick
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3156); }
    }

    /// <summary>
    /// FloatProperty: CurrentWalkAnimTime
    /// </summary>
    public unsafe float CurrentWalkAnimTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3160); }
    }

    /// <summary>
    /// FloatProperty: WalkAnimLength
    /// </summary>
    public unsafe float WalkAnimLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3164); }
    }

    /// <summary>
    /// FloatProperty: MaxSwayVelocity
    /// </summary>
    public unsafe float MaxSwayVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3168); }
    }

    /// <summary>
    /// FloatProperty: GlobalAdditiveWeight
    /// </summary>
    public unsafe float GlobalAdditiveWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3172); }
    }

    /// <summary>
    /// StructProperty: FiringAnim
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FiringAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3176); }
    }

    /// <summary>
    /// StructProperty: ReloadAnim
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ReloadAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3180); }
    }

    /// <summary>
    /// ArrayProperty: NoShootItems
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> NoShootItems
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 3184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3184); }
    }
}
