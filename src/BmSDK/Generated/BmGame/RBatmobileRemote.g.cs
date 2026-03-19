#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBatmobileRemote<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBatmobileRemote : BmSDK.BmGame.RInventoryGadget, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBatmobileRemote", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBatmobileRemote() { }

    /// <summary>
    /// Constructs a new RBatmobileRemote
    /// </summary>
    public RBatmobileRemote(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBatmobileRemote Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBatmobileRemote(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileRemote>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileRemote>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileRemote>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileRemote>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileRemote>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileRemote>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileRemote>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// BoolProperty: bUseBehindBack
    /// </summary>
    public unsafe bool bUseBehindBack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2068); }
    }

    /// <summary>
    /// StructProperty: ForcedBackUseRotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ForcedBackUseRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2072); }
    }

    /// <summary>
    /// StructProperty: AimPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AimPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2084); }
    }

    /// <summary>
    /// StructProperty: AimVelocity
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AimVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2096); }
    }

    /// <summary>
    /// StructProperty: WorldAimPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WorldAimPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2108); }
    }

    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2120); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2136); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2152); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2168); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2184); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2200); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2216); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2232); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2248); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2264); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2280); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2296); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2312); }
    }
}
