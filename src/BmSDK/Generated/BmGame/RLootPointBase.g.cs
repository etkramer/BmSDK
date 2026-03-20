#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RLootPointBase<br/>
/// (flags = 0)
/// </summary>
public partial class RLootPointBase : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RLootPointBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RLootPointBase() { }

    /// <summary>
    /// Constructs a new RLootPointBase
    /// </summary>
    public RLootPointBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RLootPointBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RLootPointBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RLootPointBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLootPointBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RLootPointBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLootPointBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLootPointBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RLootPointBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLootPointBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: VfTable_IRDisruptableInterface
    /// </summary>
    public unsafe System.IntPtr VfTable_IRDisruptableInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ComponentProperty: SkeletalMeshComponent
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent SkeletalMeshComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ComponentProperty: StaticMeshComponent
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent StaticMeshComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// StructProperty: lootingAnimInfo_Cocky
    /// </summary>
    public unsafe BmSDK.BmGame.RLootPointBase.FLootingAnimInfo lootingAnimInfo_Cocky
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLootPointBase.FLootingAnimInfo>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// StructProperty: lootingAnimInfo_Nervous
    /// </summary>
    public unsafe BmSDK.BmGame.RLootPointBase.FLootingAnimInfo lootingAnimInfo_Nervous
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLootPointBase.FLootingAnimInfo>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// BoolProperty: bDisrupted
    /// </summary>
    public unsafe bool bDisrupted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 756); }
    }

    /// <summary>
    /// BoolProperty: bAwaitingDestruction
    /// </summary>
    public unsafe bool bAwaitingDestruction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 756); }
    }

    /// <summary>
    /// ComponentProperty: inAnimCylinder_Cocky
    /// </summary>
    public unsafe BmSDK.Engine.CylinderComponent inAnimCylinder_Cocky
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CylinderComponent>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// ComponentProperty: outAnimCylinder_Cocky
    /// </summary>
    public unsafe BmSDK.Engine.CylinderComponent outAnimCylinder_Cocky
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CylinderComponent>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// ComponentProperty: inAnimCylinder_Nervous
    /// </summary>
    public unsafe BmSDK.Engine.CylinderComponent inAnimCylinder_Nervous
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CylinderComponent>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// ComponentProperty: outAnimCylinder_Nervous
    /// </summary>
    public unsafe BmSDK.Engine.CylinderComponent outAnimCylinder_Nervous
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CylinderComponent>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// ComponentProperty: waypointDbgLines
    /// </summary>
    public unsafe BmSDK.Engine.ArrowComponent waypointDbgLines_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ArrowComponent>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }
    /// <summary>
    /// ComponentProperty: waypointDbgLines
    /// </summary>
    public unsafe BmSDK.Engine.ArrowComponent waypointDbgLines_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ArrowComponent>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }
    /// <summary>
    /// ComponentProperty: waypointDbgLines
    /// </summary>
    public unsafe BmSDK.Engine.ArrowComponent waypointDbgLines_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ArrowComponent>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }
    /// <summary>
    /// ComponentProperty: waypointDbgLines
    /// </summary>
    public unsafe BmSDK.Engine.ArrowComponent waypointDbgLines_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ArrowComponent>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }
    /// <summary>
    /// ComponentProperty: waypointDbgLines
    /// </summary>
    public unsafe BmSDK.Engine.ArrowComponent waypointDbgLines_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ArrowComponent>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }
    /// <summary>
    /// ComponentProperty: waypointDbgLines
    /// </summary>
    public unsafe BmSDK.Engine.ArrowComponent waypointDbgLines_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ArrowComponent>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }
    /// <summary>
    /// ComponentProperty: waypointDbgLines
    /// </summary>
    public unsafe BmSDK.Engine.ArrowComponent waypointDbgLines_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ArrowComponent>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }
    /// <summary>
    /// ComponentProperty: waypointDbgLines
    /// </summary>
    public unsafe BmSDK.Engine.ArrowComponent waypointDbgLines_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ArrowComponent>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// ArrayProperty: waypoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> waypoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }
}
