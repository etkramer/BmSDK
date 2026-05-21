#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RPollenStaticMeshActor<br/>
/// (size = 798)
/// (flags = 144704146)
/// </summary>
public partial class RPollenStaticMeshActor : BmSDK.Engine.DynamicSMActor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RPollenStaticMeshActor", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPollenStaticMeshActor.
    /// </summary>
    public static RPollenStaticMeshActor DefaultObject => (RPollenStaticMeshActor)StaticClass().DefaultObject;

    internal RPollenStaticMeshActor() { }

    /// <summary>
    /// Constructs a new RPollenStaticMeshActor
    /// </summary>
    public RPollenStaticMeshActor(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPollenStaticMeshActor(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPollenStaticMeshActor>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPollenStaticMeshActor>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPollenStaticMeshActor>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPollenStaticMeshActor>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPollenStaticMeshActor>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPollenStaticMeshActor>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPollenStaticMeshActor>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPollenStaticMeshActor>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: CreateResources
    /// </summary>
    public unsafe virtual void CreateResources()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.RPollenStaticMeshActor.CreateResources", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.RPollenStaticMeshActor.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: EParticlesActiveState
    /// </summary>
    public enum EParticlesActiveState : byte
    {
        PPA_InPollen = 0,
        PPA_PostPollen = 1,
        PPA_InPollenAndPostPollen = 2,
        PPA_MAX = 3,
    }

    /// <summary>
    /// Enum: EPollenVisibility
    /// </summary>
    public enum EPollenVisibility : byte
    {
        PV_InPollen = 0,
        PV_PostPollen = 1,
        PV_InPollenAndPostPollen = 2,
        PV_MAX = 3,
    }

    /// <summary>
    /// ObjectProperty: PollenEffectTemplate
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem PollenEffectTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// ComponentProperty: pollenFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent pollenFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// StructProperty: PollenEffectPositionOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PollenEffectPositionOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 784);

    /// <summary>
    /// ByteProperty: PollenVisibility
    /// </summary>
    public unsafe BmSDK.Engine.RPollenStaticMeshActor.EPollenVisibility PollenVisibility
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RPollenStaticMeshActor.EPollenVisibility>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// ByteProperty: ParticleActiveState
    /// </summary>
    public unsafe BmSDK.Engine.RPollenStaticMeshActor.EParticlesActiveState ParticleActiveState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RPollenStaticMeshActor.EParticlesActiveState>(Ptr + 797); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 797); }
    }
}
