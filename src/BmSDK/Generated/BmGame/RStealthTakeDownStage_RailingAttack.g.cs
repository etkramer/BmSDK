#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RStealthTakeDownStage_RailingAttack<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RStealthTakeDownStage_RailingAttack : BmSDK.BmGame.RStealthTakeDownStage, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RStealthTakeDownStage_RailingAttack", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RStealthTakeDownStage_RailingAttack() { }

    /// <summary>
    /// Constructs a new RStealthTakeDownStage_RailingAttack
    /// </summary>
    public RStealthTakeDownStage_RailingAttack(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RStealthTakeDownStage_RailingAttack Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RStealthTakeDownStage_RailingAttack(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_RailingAttack>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_RailingAttack>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_RailingAttack>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_RailingAttack>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_RailingAttack>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_RailingAttack>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_RailingAttack>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: RopeAttachPoint
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RopeAttachPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1664); }
    }

    /// <summary>
    /// StructProperty: RopeRenderAttachPoint
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RopeRenderAttachPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1676); }
    }

    /// <summary>
    /// BoolProperty: AttachRope
    /// </summary>
    public unsafe bool AttachRope
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1688); }
    }

    /// <summary>
    /// BoolProperty: bAttachRopeToFeet
    /// </summary>
    public unsafe bool bAttachRopeToFeet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1688); }
    }

    /// <summary>
    /// BoolProperty: DisableCutRope
    /// </summary>
    public unsafe bool DisableCutRope
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1688); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1688); }
    }

    /// <summary>
    /// FloatProperty: RopeLength
    /// </summary>
    public unsafe float RopeLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1692); }
    }

    /// <summary>
    /// NameProperty: RopeBoneAttachName
    /// </summary>
    public unsafe BmSDK.FName RopeBoneAttachName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1696); }
    }

    /// <summary>
    /// FloatProperty: RopeAttachConnectionDistance
    /// </summary>
    public unsafe float RopeAttachConnectionDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1704); }
    }

    /// <summary>
    /// StructProperty: RopePelvisAttachPoint
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RopePelvisAttachPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1708); }
    }

    /// <summary>
    /// ArrayProperty: RopeExtraAttachConnections
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RStealthTakeDownStage.VictimTransitions>> RopeExtraAttachConnections
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RStealthTakeDownStage.VictimTransitions>>>(Ptr + 1720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1720); }
    }

    /// <summary>
    /// StructProperty: RopeRenderStartOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RopeRenderStartOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1736); }
    }

    /// <summary>
    /// StructProperty: RopePhysStartOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RopePhysStartOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1748); }
    }

    /// <summary>
    /// ObjectProperty: HangRope
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HangRope
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1760); }
    }
}
