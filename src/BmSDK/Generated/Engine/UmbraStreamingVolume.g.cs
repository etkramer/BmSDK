#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: UmbraStreamingVolume<br/>
/// (size = 764)
/// (flags = 144703635)
/// </summary>
public partial class UmbraStreamingVolume : BmSDK.Engine.Volume, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.UmbraStreamingVolume", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as UmbraStreamingVolume.
    /// </summary>
    public static UmbraStreamingVolume DefaultObject => (UmbraStreamingVolume)StaticClass().DefaultObject;

    internal UmbraStreamingVolume() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected UmbraStreamingVolume(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<UmbraStreamingVolume>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UmbraStreamingVolume>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<UmbraStreamingVolume>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UmbraStreamingVolume>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UmbraStreamingVolume>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UmbraStreamingVolume>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<UmbraStreamingVolume>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UmbraStreamingVolume>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Enum: EUmbraStorageMode
    /// </summary>
    public enum EUmbraStorageMode : byte
    {
        USM_None = 0,
        USM_WithVolume = 1,
        USM_SeparatePackage = 2,
        USM_Max = 3,
    }

    /// <summary>
    /// StructProperty: UmbraVolumeGuid
    /// </summary>
    public unsafe ref BmSDK.GameObject.FGuid UmbraVolumeGuid
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FGuid>(Ptr + 740);

    /// <summary>
    /// ByteProperty: UmbraStorageMode
    /// </summary>
    public unsafe BmSDK.Engine.UmbraStreamingVolume.EUmbraStorageMode UmbraStorageMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.UmbraStreamingVolume.EUmbraStorageMode>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ByteProperty: UmbraCurrentStorageMode
    /// </summary>
    public unsafe BmSDK.Engine.UmbraStreamingVolume.EUmbraStorageMode UmbraCurrentStorageMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.UmbraStreamingVolume.EUmbraStorageMode>(Ptr + 757); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 757); }
    }

    /// <summary>
    /// IntProperty: UmbraBackfaceCullingOverride
    /// </summary>
    public unsafe int UmbraBackfaceCullingOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }
}
