#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCrowdSpawnPointMaster<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RCrowdSpawnPointMaster : BmSDK.BmGame.RDummyTarget, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCrowdSpawnPointMaster", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCrowdSpawnPointMaster() { }

    /// <summary>
    /// Constructs a new RCrowdSpawnPointMaster
    /// </summary>
    public RCrowdSpawnPointMaster(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCrowdSpawnPointMaster Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCrowdSpawnPointMaster(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCrowdSpawnPointMaster>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCrowdSpawnPointMaster>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCrowdSpawnPointMaster>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCrowdSpawnPointMaster>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCrowdSpawnPointMaster>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCrowdSpawnPointMaster>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCrowdSpawnPointMaster>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ArrayProperty: CrowdChilds
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>> CrowdChilds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// IntProperty: NumChildren
    /// </summary>
    public unsafe int NumChildren
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// FloatProperty: MinDistBetweenPoints
    /// </summary>
    public unsafe float MinDistBetweenPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// FloatProperty: MaxDistBetweenPoints
    /// </summary>
    public unsafe float MaxDistBetweenPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// ByteProperty: Shape
    /// </summary>
    public unsafe byte Shape
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// ByteProperty: Grouping
    /// </summary>
    public unsafe byte Grouping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 697); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 697); }
    }

    /// <summary>
    /// IntProperty: NumPerGroupMin
    /// </summary>
    public unsafe int NumPerGroupMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// IntProperty: NumPerGroupMax
    /// </summary>
    public unsafe int NumPerGroupMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// IntProperty: GroupSeperationDist
    /// </summary>
    public unsafe int GroupSeperationDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// IntProperty: GroupSeperationDistVariance
    /// </summary>
    public unsafe int GroupSeperationDistVariance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// StructProperty: OldLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OldLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// StructProperty: OldRotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OldRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// BoolProperty: bRegenerateChildren
    /// </summary>
    public unsafe bool bRegenerateChildren
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 740); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 740); }
    }

    /// <summary>
    /// Enum: SpawnGrouping
    /// </summary>
    public enum SpawnGrouping
    {
        SpnG_Groups = 0,
        SpnG_Individuals = 1,
        SpnG_MAX = 2,
    }

    /// <summary>
    /// Enum: SpawnShape
    /// </summary>
    public enum SpawnShape
    {
        SpnS_Circle = 0,
        SpnS_Square = 1,
        SpnS_MAX = 2,
    }
}
