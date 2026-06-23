#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RNavMeshObstacleForLockinVol<br/>
/// (size = 840)
/// (flags = 10486290)
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

    /// <summary>
    /// Gets the class default object as RNavMeshObstacleForLockinVol.
    /// </summary>
    public static RNavMeshObstacleForLockinVol DefaultObject => (RNavMeshObstacleForLockinVol)StaticClass().DefaultObject;

    internal RNavMeshObstacleForLockinVol() { }

    /// <summary>
    /// Constructs a new RNavMeshObstacleForLockinVol
    /// </summary>
    public RNavMeshObstacleForLockinVol(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RNavMeshObstacleForLockinVol(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RNavMeshObstacleForLockinVol>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RNavMeshObstacleForLockinVol>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RNavMeshObstacleForLockinVol>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RNavMeshObstacleForLockinVol>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RNavMeshObstacleForLockinVol>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RNavMeshObstacleForLockinVol>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RNavMeshObstacleForLockinVol>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RNavMeshObstacleForLockinVol>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: SetupEncompassCheck
    /// </summary>
    public unsafe virtual void SetupEncompassCheck()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RNavMeshObstacleForLockinVol.SetupEncompassCheck", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StaggerPawn
    /// </summary>
    public unsafe virtual void StaggerPawn(BmSDK.BmGame.RPawnVillain PawnToDamage)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RNavMeshObstacleForLockinVol.StaggerPawn", true);
        byte* paramsPtr = stackalloc byte[280];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnToDamage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StaggerNearbyThugs
    /// </summary>
    public unsafe virtual void StaggerNearbyThugs()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RNavMeshObstacleForLockinVol.StaggerNearbyThugs", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetEnabled
    /// </summary>
    public unsafe override void SetEnabled(bool bInEnabled)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RNavMeshObstacleForLockinVol.SetEnabled", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInEnabled, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: LockInVol
    /// </summary>
    public unsafe BmSDK.BmGame.RLockinVolume LockInVol
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLockinVolume>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// ArrayProperty: PolyShape
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> PolyShape
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: planeOrigins
    /// </summary>
    public InlineArray<System.Numerics.Vector3> planeOrigins => new(4, Ptr + 716, 12, this);

    /// <summary>
    /// StructProperty: planeOrigins
    /// </summary>
    public unsafe ref System.Numerics.Vector3 planeOrigins_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 716);
    /// <summary>
    /// StructProperty: planeOrigins
    /// </summary>
    public unsafe ref System.Numerics.Vector3 planeOrigins_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 728);
    /// <summary>
    /// StructProperty: planeOrigins
    /// </summary>
    public unsafe ref System.Numerics.Vector3 planeOrigins_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 740);
    /// <summary>
    /// StructProperty: planeOrigins
    /// </summary>
    public unsafe ref System.Numerics.Vector3 planeOrigins_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 752);

    /// <summary>
    /// InlineArray{StructProperty}: planeNormals
    /// </summary>
    public InlineArray<System.Numerics.Vector3> planeNormals => new(4, Ptr + 764, 12, this);

    /// <summary>
    /// StructProperty: planeNormals
    /// </summary>
    public unsafe ref System.Numerics.Vector3 planeNormals_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 764);
    /// <summary>
    /// StructProperty: planeNormals
    /// </summary>
    public unsafe ref System.Numerics.Vector3 planeNormals_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 776);
    /// <summary>
    /// StructProperty: planeNormals
    /// </summary>
    public unsafe ref System.Numerics.Vector3 planeNormals_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 788);
    /// <summary>
    /// StructProperty: planeNormals
    /// </summary>
    public unsafe ref System.Numerics.Vector3 planeNormals_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 800);

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
    public unsafe ref System.Numerics.Vector3 longSideNormal
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 816);

    /// <summary>
    /// StructProperty: ImpulseDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ImpulseDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 828);
}
