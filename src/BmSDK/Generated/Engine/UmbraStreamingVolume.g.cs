#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: UmbraStreamingVolume<br/>
/// (flags = 0)
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

    internal UmbraStreamingVolume() { }

    /// <summary>
    /// Constructs a new UmbraStreamingVolume
    /// </summary>
    public UmbraStreamingVolume(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, UmbraStreamingVolume Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected UmbraStreamingVolume(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<UmbraStreamingVolume>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UmbraStreamingVolume>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<UmbraStreamingVolume>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UmbraStreamingVolume>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UmbraStreamingVolume>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<UmbraStreamingVolume>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UmbraStreamingVolume>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: UmbraVolumeGuid
    /// </summary>
    public unsafe BmSDK.GameObject.FGuid UmbraVolumeGuid
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FGuid>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

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
