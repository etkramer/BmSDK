#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DOFAndBloomEffect<br/>
/// (size = 156)
/// (flags = 134217874)
/// </summary>
public partial class DOFAndBloomEffect : BmSDK.Engine.DOFEffect, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DOFAndBloomEffect", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as DOFAndBloomEffect.
    /// </summary>
    public static DOFAndBloomEffect DefaultObject => (DOFAndBloomEffect)StaticClass().DefaultObject;

    internal DOFAndBloomEffect() { }

    /// <summary>
    /// Constructs a new DOFAndBloomEffect
    /// </summary>
    public DOFAndBloomEffect(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DOFAndBloomEffect Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DOFAndBloomEffect(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<DOFAndBloomEffect>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<DOFAndBloomEffect>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<DOFAndBloomEffect>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<DOFAndBloomEffect>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<DOFAndBloomEffect>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<DOFAndBloomEffect>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<DOFAndBloomEffect>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<DOFAndBloomEffect>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Enum: EDOFQuality
    /// </summary>
    public enum EDOFQuality : byte
    {
        DOFQuality_Low = 0,
        DOFQuality_Medium = 1,
        DOFQuality_High = 2,
        DOFQuality_MAX = 3,
    }

    /// <summary>
    /// Enum: EDOFType
    /// </summary>
    public enum EDOFType : byte
    {
        DOFType_SimpleDOF = 0,
        DOFType_ReferenceDOF = 1,
        DOFType_BokehDOF = 2,
        DOFType_MAX = 3,
    }

    /// <summary>
    /// FloatProperty: BloomOverload
    /// </summary>
    public unsafe float BloomOverload
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// FloatProperty: BloomLowerCut
    /// </summary>
    public unsafe float BloomLowerCut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// FloatProperty: SceneMultiplier
    /// </summary>
    public unsafe float SceneMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ByteProperty: DepthOfFieldType
    /// </summary>
    public unsafe BmSDK.Engine.DOFAndBloomEffect.EDOFType DepthOfFieldType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DOFAndBloomEffect.EDOFType>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// ByteProperty: DepthOfFieldQuality
    /// </summary>
    public unsafe BmSDK.Engine.DOFAndBloomEffect.EDOFQuality DepthOfFieldQuality
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DOFAndBloomEffect.EDOFQuality>(Ptr + 145); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 145); }
    }

    /// <summary>
    /// ObjectProperty: BokehTexture
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D BokehTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }
}
