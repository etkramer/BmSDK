#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnManBatBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RPawnManBatBase : BmSDK.BmGame.RPawnFriendly, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnManBatBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnManBatBase() { }

    /// <summary>
    /// Constructs a new RPawnManBatBase
    /// </summary>
    public RPawnManBatBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnManBatBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnManBatBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnManBatBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnManBatBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnManBatBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnManBatBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnManBatBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnManBatBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnManBatBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: ManbatDefine
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ManbatDefine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4740); }
    }

    /// <summary>
    /// ObjectProperty: ScreechLine
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ScreechLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4748); }
    }

    /// <summary>
    /// ObjectProperty: FlyAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FlyAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4756); }
    }

    /// <summary>
    /// ClassProperty: ManbatCharacter
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ManbatCharacter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4764); }
    }

    /// <summary>
    /// FloatProperty: NextAppearCheckTime
    /// </summary>
    public unsafe float NextAppearCheckTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4772); }
    }
}
