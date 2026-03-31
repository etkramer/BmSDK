#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNotify_BeginRagdoll<br/>
/// (size = 76)
/// (flags = 134230162)
/// </summary>
public partial class RAnimNotify_BeginRagdoll : BmSDK.Engine.AnimNotify, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNotify_BeginRagdoll", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RAnimNotify_BeginRagdoll.
    /// </summary>
    public static RAnimNotify_BeginRagdoll DefaultObject => (RAnimNotify_BeginRagdoll)StaticClass().DefaultObject;

    internal RAnimNotify_BeginRagdoll() { }

    /// <summary>
    /// Constructs a new RAnimNotify_BeginRagdoll
    /// </summary>
    public RAnimNotify_BeginRagdoll(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotify_BeginRagdoll Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_BeginRagdoll(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAnimNotify_BeginRagdoll>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimNotify_BeginRagdoll>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAnimNotify_BeginRagdoll>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimNotify_BeginRagdoll>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimNotify_BeginRagdoll>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimNotify_BeginRagdoll>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAnimNotify_BeginRagdoll>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimNotify_BeginRagdoll>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// FloatProperty: BlendInDuration
    /// </summary>
    public unsafe float BlendInDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// FloatProperty: BlendOutDuration
    /// </summary>
    public unsafe float BlendOutDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// StructProperty: FixedParts
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FRagdollParts FixedParts
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FRagdollParts>(Ptr + 52);

    /// <summary>
    /// StructProperty: UnfixedParts
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FRagdollParts UnfixedParts
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FRagdollParts>(Ptr + 56);

    /// <summary>
    /// BoolProperty: MotorAll
    /// </summary>
    public unsafe bool MotorAll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// StructProperty: MotorParts
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil.FRagdollParts MotorParts
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil.FRagdollParts>(Ptr + 64);

    /// <summary>
    /// FloatProperty: MotorSpringScale
    /// </summary>
    public unsafe float MotorSpringScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// FloatProperty: MotorDampingScale
    /// </summary>
    public unsafe float MotorDampingScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }
}
