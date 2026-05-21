#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RockOn<br/>
/// (size = 249)
/// (flags = 134217874)
/// </summary>
public partial class RockOn : BmSDK.Engine.DOFBloomMotionBlurEffect, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RockOn", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RockOn.
    /// </summary>
    public static RockOn DefaultObject => (RockOn)StaticClass().DefaultObject;

    internal RockOn() { }

    /// <summary>
    /// Constructs a new RockOn
    /// </summary>
    public RockOn(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RockOn Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RockOn(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RockOn>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RockOn>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RockOn>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RockOn>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RockOn>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RockOn>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RockOn>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RockOn>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Enum: EPostProcessAAType
    /// </summary>
    public enum EPostProcessAAType : byte
    {
        PostProcessAA_Off = 0,
        PostProcessAA_FXAA0 = 1,
        PostProcessAA_FXAA1 = 2,
        PostProcessAA_FXAA2 = 3,
        PostProcessAA_FXAA3 = 4,
        PostProcessAA_FXAA4 = 5,
        PostProcessAA_FXAA5 = 6,
        PostProcessAA_MLAA = 7,
        PostProcessAA_MAX = 8,
    }

    /// <summary>
    /// StructProperty: SceneShadows
    /// </summary>
    public unsafe ref BmSDK.GameObject.FLinearColor SceneShadows
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FLinearColor>(Ptr + 176);

    /// <summary>
    /// StructProperty: SceneHighLights
    /// </summary>
    public unsafe ref BmSDK.GameObject.FLinearColor SceneHighLights
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FLinearColor>(Ptr + 192);

    /// <summary>
    /// StructProperty: SceneMidTones
    /// </summary>
    public unsafe ref BmSDK.GameObject.FLinearColor SceneMidTones
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FLinearColor>(Ptr + 208);

    /// <summary>
    /// FloatProperty: SceneDesaturation
    /// </summary>
    public unsafe float SceneDesaturation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// StructProperty: SceneColorize
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SceneColorize
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 228);

    /// <summary>
    /// FloatProperty: MotionBlurSoftEdgeKernelSize
    /// </summary>
    public unsafe float MotionBlurSoftEdgeKernelSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// FloatProperty: EdgeDetectionThreshold
    /// </summary>
    public unsafe float EdgeDetectionThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// ByteProperty: PostProcessAAType
    /// </summary>
    public unsafe BmSDK.Engine.RockOn.EPostProcessAAType PostProcessAAType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockOn.EPostProcessAAType>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }
}
