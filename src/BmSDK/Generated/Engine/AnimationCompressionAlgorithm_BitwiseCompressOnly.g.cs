#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AnimationCompressionAlgorithm_BitwiseCompressOnly<br/>
/// (size = 64)
/// (flags = 134217874)
/// </summary>
public partial class AnimationCompressionAlgorithm_BitwiseCompressOnly : BmSDK.Engine.AnimationCompressionAlgorithm, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AnimationCompressionAlgorithm_BitwiseCompressOnly", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as AnimationCompressionAlgorithm_BitwiseCompressOnly.
    /// </summary>
    public static AnimationCompressionAlgorithm_BitwiseCompressOnly DefaultObject => (AnimationCompressionAlgorithm_BitwiseCompressOnly)StaticClass().DefaultObject;

    internal AnimationCompressionAlgorithm_BitwiseCompressOnly() { }

    /// <summary>
    /// Constructs a new AnimationCompressionAlgorithm_BitwiseCompressOnly
    /// </summary>
    public AnimationCompressionAlgorithm_BitwiseCompressOnly(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AnimationCompressionAlgorithm_BitwiseCompressOnly Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AnimationCompressionAlgorithm_BitwiseCompressOnly(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AnimationCompressionAlgorithm_BitwiseCompressOnly>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AnimationCompressionAlgorithm_BitwiseCompressOnly>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AnimationCompressionAlgorithm_BitwiseCompressOnly>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AnimationCompressionAlgorithm_BitwiseCompressOnly>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AnimationCompressionAlgorithm_BitwiseCompressOnly>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AnimationCompressionAlgorithm_BitwiseCompressOnly>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AnimationCompressionAlgorithm_BitwiseCompressOnly>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AnimationCompressionAlgorithm_BitwiseCompressOnly>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

}
