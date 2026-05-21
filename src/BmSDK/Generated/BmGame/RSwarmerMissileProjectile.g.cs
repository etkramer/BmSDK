#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSwarmerMissileProjectile<br/>
/// (size = 1340)
/// (flags = 10485778)
/// </summary>
public partial class RSwarmerMissileProjectile : BmSDK.BmGame.RProjectile, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSwarmerMissileProjectile", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RSwarmerMissileProjectile.
    /// </summary>
    public static RSwarmerMissileProjectile DefaultObject => (RSwarmerMissileProjectile)StaticClass().DefaultObject;

    internal RSwarmerMissileProjectile() { }

    /// <summary>
    /// Constructs a new RSwarmerMissileProjectile
    /// </summary>
    public RSwarmerMissileProjectile(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSwarmerMissileProjectile(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSwarmerMissileProjectile>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSwarmerMissileProjectile>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSwarmerMissileProjectile>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSwarmerMissileProjectile>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSwarmerMissileProjectile>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSwarmerMissileProjectile>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSwarmerMissileProjectile>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSwarmerMissileProjectile>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: Explode
    /// </summary>
    public unsafe override void Explode(System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal, bool bPlayExplosionSound = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSwarmerMissileProjectile.Explode", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayExplosionSound, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ExplodeSingleRocket
    /// </summary>
    public unsafe virtual void ExplodeSingleRocket(System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal, bool bPlayExplosionSound = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSwarmerMissileProjectile.ExplodeSingleRocket", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPlayExplosionSound, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSwarmerMissileProjectile.Tick", true);
        byte* paramsPtr = stackalloc byte[140];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(System.Numerics.Vector3 Target)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSwarmerMissileProjectile.Init", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// StructProperty: TargetPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TargetPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 840);

    /// <summary>
    /// InlineArray{ComponentProperty}: Mesh
    /// </summary>
    public InlineArray<BmSDK.Engine.StaticMeshComponent> Mesh => new(8, Ptr + 852);

    /// <summary>
    /// ComponentProperty: Mesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent Mesh_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }
    /// <summary>
    /// ComponentProperty: Mesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent Mesh_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }
    /// <summary>
    /// ComponentProperty: Mesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent Mesh_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }
    /// <summary>
    /// ComponentProperty: Mesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent Mesh_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }
    /// <summary>
    /// ComponentProperty: Mesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent Mesh_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }
    /// <summary>
    /// ComponentProperty: Mesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent Mesh_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }
    /// <summary>
    /// ComponentProperty: Mesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent Mesh_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }
    /// <summary>
    /// ComponentProperty: Mesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent Mesh_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// InlineArray{ComponentProperty}: Trail
    /// </summary>
    public InlineArray<BmSDK.Engine.ParticleSystemComponent> Trail => new(8, Ptr + 916);

    /// <summary>
    /// ComponentProperty: Trail
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent Trail_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }
    /// <summary>
    /// ComponentProperty: Trail
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent Trail_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }
    /// <summary>
    /// ComponentProperty: Trail
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent Trail_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }
    /// <summary>
    /// ComponentProperty: Trail
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent Trail_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }
    /// <summary>
    /// ComponentProperty: Trail
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent Trail_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }
    /// <summary>
    /// ComponentProperty: Trail
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent Trail_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }
    /// <summary>
    /// ComponentProperty: Trail
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent Trail_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }
    /// <summary>
    /// ComponentProperty: Trail
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent Trail_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: MissileOffset
    /// </summary>
    public InlineArray<System.Numerics.Vector3> MissileOffset => new(8, Ptr + 980);

    /// <summary>
    /// StructProperty: MissileOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MissileOffset_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 980);
    /// <summary>
    /// StructProperty: MissileOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MissileOffset_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 992);
    /// <summary>
    /// StructProperty: MissileOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MissileOffset_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1004);
    /// <summary>
    /// StructProperty: MissileOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MissileOffset_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1016);
    /// <summary>
    /// StructProperty: MissileOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MissileOffset_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1028);
    /// <summary>
    /// StructProperty: MissileOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MissileOffset_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1040);
    /// <summary>
    /// StructProperty: MissileOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MissileOffset_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1052);
    /// <summary>
    /// StructProperty: MissileOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MissileOffset_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1064);

    /// <summary>
    /// InlineArray{FloatProperty}: MissileDelay
    /// </summary>
    public InlineArray<float> MissileDelay => new(8, Ptr + 1076);

    /// <summary>
    /// FloatProperty: MissileDelay
    /// </summary>
    public unsafe float MissileDelay_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }
    /// <summary>
    /// FloatProperty: MissileDelay
    /// </summary>
    public unsafe float MissileDelay_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }
    /// <summary>
    /// FloatProperty: MissileDelay
    /// </summary>
    public unsafe float MissileDelay_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }
    /// <summary>
    /// FloatProperty: MissileDelay
    /// </summary>
    public unsafe float MissileDelay_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }
    /// <summary>
    /// FloatProperty: MissileDelay
    /// </summary>
    public unsafe float MissileDelay_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }
    /// <summary>
    /// FloatProperty: MissileDelay
    /// </summary>
    public unsafe float MissileDelay_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }
    /// <summary>
    /// FloatProperty: MissileDelay
    /// </summary>
    public unsafe float MissileDelay_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }
    /// <summary>
    /// FloatProperty: MissileDelay
    /// </summary>
    public unsafe float MissileDelay_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: MissileTarget
    /// </summary>
    public InlineArray<System.Numerics.Vector3> MissileTarget => new(8, Ptr + 1108);

    /// <summary>
    /// StructProperty: MissileTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MissileTarget_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1108);
    /// <summary>
    /// StructProperty: MissileTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MissileTarget_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1120);
    /// <summary>
    /// StructProperty: MissileTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MissileTarget_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1132);
    /// <summary>
    /// StructProperty: MissileTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MissileTarget_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1144);
    /// <summary>
    /// StructProperty: MissileTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MissileTarget_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1156);
    /// <summary>
    /// StructProperty: MissileTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MissileTarget_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1168);
    /// <summary>
    /// StructProperty: MissileTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MissileTarget_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1180);
    /// <summary>
    /// StructProperty: MissileTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MissileTarget_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1192);

    /// <summary>
    /// InlineArray{ByteProperty}: MissileExploded
    /// </summary>
    public InlineArray<byte> MissileExploded => new(8, Ptr + 1204);

    /// <summary>
    /// ByteProperty: MissileExploded
    /// </summary>
    public unsafe byte MissileExploded_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1204); }
    }
    /// <summary>
    /// ByteProperty: MissileExploded
    /// </summary>
    public unsafe byte MissileExploded_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1205); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1205); }
    }
    /// <summary>
    /// ByteProperty: MissileExploded
    /// </summary>
    public unsafe byte MissileExploded_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1206); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1206); }
    }
    /// <summary>
    /// ByteProperty: MissileExploded
    /// </summary>
    public unsafe byte MissileExploded_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1207); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1207); }
    }
    /// <summary>
    /// ByteProperty: MissileExploded
    /// </summary>
    public unsafe byte MissileExploded_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }
    }
    /// <summary>
    /// ByteProperty: MissileExploded
    /// </summary>
    public unsafe byte MissileExploded_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1209); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1209); }
    }
    /// <summary>
    /// ByteProperty: MissileExploded
    /// </summary>
    public unsafe byte MissileExploded_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1210); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1210); }
    }
    /// <summary>
    /// ByteProperty: MissileExploded
    /// </summary>
    public unsafe byte MissileExploded_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1211); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1211); }
    }

    /// <summary>
    /// StructProperty: SpreadHorizontalVsLifespan
    /// </summary>
    public unsafe ref BmSDK.GameObject.FInterpCurveFloat SpreadHorizontalVsLifespan
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FInterpCurveFloat>(Ptr + 1212);

    /// <summary>
    /// StructProperty: SpreadVerticalVsLifespan
    /// </summary>
    public unsafe ref BmSDK.GameObject.FInterpCurveFloat SpreadVerticalVsLifespan
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FInterpCurveFloat>(Ptr + 1232);

    /// <summary>
    /// StructProperty: PositionVerticalVsLifespan
    /// </summary>
    public unsafe ref BmSDK.GameObject.FInterpCurveFloat PositionVerticalVsLifespan
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FInterpCurveFloat>(Ptr + 1252);

    /// <summary>
    /// FloatProperty: MissileLifespan
    /// </summary>
    public unsafe float MissileLifespan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }

    /// <summary>
    /// FloatProperty: InitialLifespan
    /// </summary>
    public unsafe float InitialLifespan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1276); }
    }

    /// <summary>
    /// FloatProperty: TotalDistance
    /// </summary>
    public unsafe float TotalDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }
    }

    /// <summary>
    /// ObjectProperty: ImpactExplosion
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ImpactExplosion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }

    /// <summary>
    /// ObjectProperty: ImpactExplosionSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ImpactExplosionSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1292); }
    }

    /// <summary>
    /// ObjectProperty: LaunchEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent LaunchEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// ObjectProperty: FlightSoundPlay
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FlightSoundPlay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1308); }
    }

    /// <summary>
    /// StructProperty: StartPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StartPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1316);

    /// <summary>
    /// StructProperty: InvActorRot
    /// </summary>
    public unsafe ref BmSDK.Rotator InvActorRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1328);
}
