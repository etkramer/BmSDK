#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnPlayerAnim<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RPawnPlayerAnim : BmSDK.BmGame.RPawnCombat, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnPlayerAnim", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnPlayerAnim() { }

    /// <summary>
    /// Constructs a new RPawnPlayerAnim
    /// </summary>
    public RPawnPlayerAnim(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnPlayerAnim Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnPlayerAnim(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerAnim>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerAnim>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerAnim>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerAnim>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerAnim>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerAnim>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerAnim>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ArrayProperty: UsefulAimingConfigs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> UsefulAimingConfigs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2976); }
    }

    /// <summary>
    /// ObjectProperty: OverrideNormalStandAnimSet
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OverrideNormalStandAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2992); }
    }

    /// <summary>
    /// ObjectProperty: OverrideNormalCrouchAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OverrideNormalCrouchAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3000); }
    }

    /// <summary>
    /// ObjectProperty: PoseConfig_Combat
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PoseConfig_Combat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3008); }
    }

    /// <summary>
    /// ObjectProperty: AnimationConfig
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AnimationConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 3016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3016); }
    }

    /// <summary>
    /// StructProperty: BaseAimAtTiming
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BaseAimAtTiming
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3024); }
    }

    /// <summary>
    /// FloatProperty: CoverWallDistanceOffset
    /// </summary>
    public unsafe float CoverWallDistanceOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3036); }
    }

    /// <summary>
    /// StructProperty: ForceMoveDirection
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ForceMoveDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 3040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3040); }
    }
}
