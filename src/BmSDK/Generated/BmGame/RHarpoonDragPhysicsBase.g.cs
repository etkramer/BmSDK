#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHarpoonDragPhysicsBase<br/>
/// (flags = 0)
/// </summary>
public partial class RHarpoonDragPhysicsBase : BmSDK.BmGame.RSmashableProp, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHarpoonDragPhysicsBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RHarpoonDragPhysicsBase() { }

    /// <summary>
    /// Constructs a new RHarpoonDragPhysicsBase
    /// </summary>
    public RHarpoonDragPhysicsBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHarpoonDragPhysicsBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHarpoonDragPhysicsBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHarpoonDragPhysicsBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHarpoonDragPhysicsBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHarpoonDragPhysicsBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHarpoonDragPhysicsBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHarpoonDragPhysicsBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHarpoonDragPhysicsBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHarpoonDragPhysicsBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: MoveForce
    /// </summary>
    public unsafe System.Numerics.Vector3 MoveForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// ObjectProperty: PushMoveMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig PushMoveMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// ComponentProperty: Interactions
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent Interactions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// FloatProperty: MaximumDragSpeed
    /// </summary>
    public unsafe float MaximumDragSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// ArrayProperty: AnchorPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHarpoonDragPhysicsBase.FBatclawAnchorPoints> AnchorPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHarpoonDragPhysicsBase.FBatclawAnchorPoints>>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// FloatProperty: EstimatedMaxHarpoonDragFriction
    /// </summary>
    public unsafe float EstimatedMaxHarpoonDragFriction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// FloatProperty: InternalEstimatedMaxHarpoonDragFrictionAccumulator
    /// </summary>
    public unsafe float InternalEstimatedMaxHarpoonDragFrictionAccumulator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// ArrayProperty: TouchingActors
    /// </summary>
    public unsafe BmSDK.TArray<int> TouchingActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

}
