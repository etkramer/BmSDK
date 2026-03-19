#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RExplosiveGooMine_SprayOnObject<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RExplosiveGooMine_SprayOnObject : BmSDK.BmScript.RExplosiveGooMineBm, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RExplosiveGooMine_SprayOnObject", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RExplosiveGooMine_SprayOnObject() { }

    /// <summary>
    /// Constructs a new RExplosiveGooMine_SprayOnObject
    /// </summary>
    public RExplosiveGooMine_SprayOnObject(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RExplosiveGooMine_SprayOnObject Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RExplosiveGooMine_SprayOnObject(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RExplosiveGooMine_SprayOnObject>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RExplosiveGooMine_SprayOnObject>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RExplosiveGooMine_SprayOnObject>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RExplosiveGooMine_SprayOnObject>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RExplosiveGooMine_SprayOnObject>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RExplosiveGooMine_SprayOnObject>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RExplosiveGooMine_SprayOnObject>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ComponentProperty: ForceField
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ForceField
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// BoolProperty: bMovePerformed
    /// </summary>
    public unsafe bool bMovePerformed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1104); }
    }

    /// <summary>
    /// ObjectProperty: LethalExplosion
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LethalExplosion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }
}
