#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RParticleModuleTypeDataLight<br/>
/// (size = 272)
/// (flags = 142610578)
/// </summary>
public partial class RParticleModuleTypeDataLight : BmSDK.Engine.ParticleModuleTypeDataBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RParticleModuleTypeDataLight", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RParticleModuleTypeDataLight.
    /// </summary>
    public static RParticleModuleTypeDataLight DefaultObject => (RParticleModuleTypeDataLight)StaticClass().DefaultObject;

    internal RParticleModuleTypeDataLight() { }

    /// <summary>
    /// Constructs a new RParticleModuleTypeDataLight
    /// </summary>
    public RParticleModuleTypeDataLight(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RParticleModuleTypeDataLight Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RParticleModuleTypeDataLight(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RParticleModuleTypeDataLight>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RParticleModuleTypeDataLight>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RParticleModuleTypeDataLight>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RParticleModuleTypeDataLight>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RParticleModuleTypeDataLight>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RParticleModuleTypeDataLight>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RParticleModuleTypeDataLight>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RParticleModuleTypeDataLight>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// BoolProperty: DrawParticles
    /// </summary>
    public unsafe bool DrawParticles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: UseLightSizeOverride
    /// </summary>
    public unsafe bool UseLightSizeOverride
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: UseLightColourOverride
    /// </summary>
    public unsafe bool UseLightColourOverride
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// StructProperty: LightSizeOverride
    /// </summary>
    public unsafe ref BmSDK.DistributionFloat.FRawDistributionFloat LightSizeOverride
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 100);

    /// <summary>
    /// StructProperty: FalloffExponent
    /// </summary>
    public unsafe ref BmSDK.DistributionFloat.FRawDistributionFloat FalloffExponent
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 136);

    /// <summary>
    /// StructProperty: LightColourOverride
    /// </summary>
    public unsafe ref BmSDK.DistributionVector.FRawDistributionVector LightColourOverride
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionVector.FRawDistributionVector>(Ptr + 172);

    /// <summary>
    /// StructProperty: LightBrightness
    /// </summary>
    public unsafe ref BmSDK.DistributionFloat.FRawDistributionFloat LightBrightness
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 236);
}
