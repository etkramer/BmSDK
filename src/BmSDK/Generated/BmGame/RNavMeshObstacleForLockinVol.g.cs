#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RNavMeshObstacleForLockinVol<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RNavMeshObstacleForLockinVol : BmSDK.Engine.NavMeshObstacle, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RNavMeshObstacleForLockinVol", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RNavMeshObstacleForLockinVol() { }

    /// <summary>
    /// Constructs a new RNavMeshObstacleForLockinVol
    /// </summary>
    public RNavMeshObstacleForLockinVol(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RNavMeshObstacleForLockinVol Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RNavMeshObstacleForLockinVol(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RNavMeshObstacleForLockinVol>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RNavMeshObstacleForLockinVol>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RNavMeshObstacleForLockinVol>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RNavMeshObstacleForLockinVol>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RNavMeshObstacleForLockinVol>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RNavMeshObstacleForLockinVol>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RNavMeshObstacleForLockinVol>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: LockInVol
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LockInVol
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// ArrayProperty: PolyShape
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>> PolyShape
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// StructProperty: planeOrigins
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT planeOrigins_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }
    /// <summary>
    /// StructProperty: planeOrigins
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT planeOrigins_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }
    /// <summary>
    /// StructProperty: planeOrigins
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT planeOrigins_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }
    /// <summary>
    /// StructProperty: planeOrigins
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT planeOrigins_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// StructProperty: planeNormals
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT planeNormals_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }
    /// <summary>
    /// StructProperty: planeNormals
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT planeNormals_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }
    /// <summary>
    /// StructProperty: planeNormals
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT planeNormals_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }
    /// <summary>
    /// StructProperty: planeNormals
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT planeNormals_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// FloatProperty: expanded2DExtentSq
    /// </summary>
    public unsafe float expanded2DExtentSq
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// StructProperty: longSideNormal
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT longSideNormal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// StructProperty: ImpulseDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ImpulseDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }
}
