#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RFlaps_ConstraintSetupPlane<br/>
/// (size = 180)
/// (flags = 134217874)
/// </summary>
public partial class RFlaps_ConstraintSetupPlane : BmSDK.Engine.RFlaps_ConstraintSetup, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RFlaps_ConstraintSetupPlane", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RFlaps_ConstraintSetupPlane.
    /// </summary>
    public static RFlaps_ConstraintSetupPlane DefaultObject => (RFlaps_ConstraintSetupPlane)StaticClass().DefaultObject;

    internal RFlaps_ConstraintSetupPlane() { }

    /// <summary>
    /// Constructs a new RFlaps_ConstraintSetupPlane
    /// </summary>
    public RFlaps_ConstraintSetupPlane(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RFlaps_ConstraintSetupPlane Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RFlaps_ConstraintSetupPlane(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RFlaps_ConstraintSetupPlane>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFlaps_ConstraintSetupPlane>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RFlaps_ConstraintSetupPlane>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFlaps_ConstraintSetupPlane>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFlaps_ConstraintSetupPlane>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFlaps_ConstraintSetupPlane>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RFlaps_ConstraintSetupPlane>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFlaps_ConstraintSetupPlane>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// StructProperty: ConstrainedParticles
    /// </summary>
    public unsafe ref BmSDK.Engine.RFlaps_ConstraintSetup.FRFlapsParticleReference ConstrainedParticles_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RFlaps_ConstraintSetup.FRFlapsParticleReference>(Ptr + 64);
    /// <summary>
    /// StructProperty: ConstrainedParticles
    /// </summary>
    public unsafe ref BmSDK.Engine.RFlaps_ConstraintSetup.FRFlapsParticleReference ConstrainedParticles_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RFlaps_ConstraintSetup.FRFlapsParticleReference>(Ptr + 80);
    /// <summary>
    /// StructProperty: ConstrainedParticles
    /// </summary>
    public unsafe ref BmSDK.Engine.RFlaps_ConstraintSetup.FRFlapsParticleReference ConstrainedParticles_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RFlaps_ConstraintSetup.FRFlapsParticleReference>(Ptr + 96);
    /// <summary>
    /// StructProperty: ConstrainedParticles
    /// </summary>
    public unsafe ref BmSDK.Engine.RFlaps_ConstraintSetup.FRFlapsParticleReference ConstrainedParticles_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RFlaps_ConstraintSetup.FRFlapsParticleReference>(Ptr + 112);
    /// <summary>
    /// StructProperty: ConstrainedParticles
    /// </summary>
    public unsafe ref BmSDK.Engine.RFlaps_ConstraintSetup.FRFlapsParticleReference ConstrainedParticles_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RFlaps_ConstraintSetup.FRFlapsParticleReference>(Ptr + 128);

    /// <summary>
    /// StructProperty: InPlaneParticle
    /// </summary>
    public unsafe ref BmSDK.Engine.RFlaps_ConstraintSetup.FRFlapsParticleReference InPlaneParticle
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RFlaps_ConstraintSetup.FRFlapsParticleReference>(Ptr + 144);

    /// <summary>
    /// StructProperty: PlaneNormalDirParticle
    /// </summary>
    public unsafe ref BmSDK.Engine.RFlaps_ConstraintSetup.FRFlapsParticleReference PlaneNormalDirParticle
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RFlaps_ConstraintSetup.FRFlapsParticleReference>(Ptr + 160);

    /// <summary>
    /// FloatProperty: Restitution
    /// </summary>
    public unsafe float Restitution
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

}
