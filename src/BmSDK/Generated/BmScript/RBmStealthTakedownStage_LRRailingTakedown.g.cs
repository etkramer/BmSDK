#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBmStealthTakedownStage_LRRailingTakedown<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBmStealthTakedownStage_LRRailingTakedown : BmSDK.BmGame.RStealthTakedownStageQuickBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBmStealthTakedownStage_LRRailingTakedown", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBmStealthTakedownStage_LRRailingTakedown() { }

    /// <summary>
    /// Constructs a new RBmStealthTakedownStage_LRRailingTakedown
    /// </summary>
    public RBmStealthTakedownStage_LRRailingTakedown(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBmStealthTakedownStage_LRRailingTakedown Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBmStealthTakedownStage_LRRailingTakedown(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBmStealthTakedownStage_LRRailingTakedown>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBmStealthTakedownStage_LRRailingTakedown>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBmStealthTakedownStage_LRRailingTakedown>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBmStealthTakedownStage_LRRailingTakedown>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBmStealthTakedownStage_LRRailingTakedown>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBmStealthTakedownStage_LRRailingTakedown>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBmStealthTakedownStage_LRRailingTakedown>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// BoolProperty: RopesReleased
    /// </summary>
    public unsafe bool RopesReleased
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1700) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1700); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1700); }
    }

    /// <summary>
    /// BoolProperty: AttachRope
    /// </summary>
    public unsafe bool AttachRope
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1700) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1700); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1700); }
    }

    /// <summary>
    /// BoolProperty: DisableCutRope
    /// </summary>
    public unsafe bool DisableCutRope
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1700) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1700); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1700); }
    }

    /// <summary>
    /// ComponentProperty: MyRope
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MyRope
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1704); }
    }

    /// <summary>
    /// FloatProperty: RopeLength
    /// </summary>
    public unsafe float RopeLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1712); }
    }

    /// <summary>
    /// StructProperty: RopeAttachPoint
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RopeAttachPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1716); }
    }

    /// <summary>
    /// StructProperty: RopeRenderAttachPoint
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RopeRenderAttachPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1728); }
    }

    /// <summary>
    /// StructProperty: RopeRenderStartOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RopeRenderStartOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1740); }
    }

    /// <summary>
    /// StructProperty: RopePhysStartOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RopePhysStartOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1752); }
    }
}
