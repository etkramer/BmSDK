#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleLocationPrimitiveSphere_Seeded<br/>
/// (size = 168)
/// (flags = 142610578)
/// </summary>
public partial class ParticleModuleLocationPrimitiveSphere_Seeded : BmSDK.Engine.ParticleModuleLocationPrimitiveSphere, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleLocationPrimitiveSphere_Seeded", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as ParticleModuleLocationPrimitiveSphere_Seeded.
    /// </summary>
    public static ParticleModuleLocationPrimitiveSphere_Seeded DefaultObject => (ParticleModuleLocationPrimitiveSphere_Seeded)StaticClass().DefaultObject;

    internal ParticleModuleLocationPrimitiveSphere_Seeded() { }

    /// <summary>
    /// Constructs a new ParticleModuleLocationPrimitiveSphere_Seeded
    /// </summary>
    public ParticleModuleLocationPrimitiveSphere_Seeded(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleLocationPrimitiveSphere_Seeded Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleLocationPrimitiveSphere_Seeded(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ParticleModuleLocationPrimitiveSphere_Seeded>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleLocationPrimitiveSphere_Seeded>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ParticleModuleLocationPrimitiveSphere_Seeded>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleLocationPrimitiveSphere_Seeded>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleLocationPrimitiveSphere_Seeded>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleLocationPrimitiveSphere_Seeded>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ParticleModuleLocationPrimitiveSphere_Seeded>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ParticleModuleLocationPrimitiveSphere_Seeded>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// StructProperty: RandomSeedInfo
    /// </summary>
    public unsafe ref BmSDK.Engine.ParticleModule.FParticleRandomSeedInfo RandomSeedInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.ParticleModule.FParticleRandomSeedInfo>(Ptr + 144);
}
