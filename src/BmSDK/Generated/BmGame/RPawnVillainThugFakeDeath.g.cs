#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnVillainThugFakeDeath<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RPawnVillainThugFakeDeath : BmSDK.BmGame.RPawnVillainThug, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnVillainThugFakeDeath", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnVillainThugFakeDeath() { }

    /// <summary>
    /// Constructs a new RPawnVillainThugFakeDeath
    /// </summary>
    public RPawnVillainThugFakeDeath(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnVillainThugFakeDeath Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnVillainThugFakeDeath(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThugFakeDeath>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThugFakeDeath>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThugFakeDeath>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThugFakeDeath>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThugFakeDeath>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThugFakeDeath>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainThugFakeDeath>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// BoolProperty: bFakeDead
    /// </summary>
    public unsafe bool bFakeDead
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6696) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6696); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6696); }
    }

    /// <summary>
    /// BoolProperty: bHasGottenUp
    /// </summary>
    public unsafe bool bHasGottenUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6696) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6696); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6696); }
    }

    /// <summary>
    /// BoolProperty: bKillMeSpecial
    /// </summary>
    public unsafe bool bKillMeSpecial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6696) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6696); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6696); }
    }

    /// <summary>
    /// BoolProperty: bJoker
    /// </summary>
    public unsafe bool bJoker
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6696) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6696); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6696); }
    }

    /// <summary>
    /// BoolProperty: bDoubleDead
    /// </summary>
    public unsafe bool bDoubleDead
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6696) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6696); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6696); }
    }

    /// <summary>
    /// FloatProperty: DeathTime
    /// </summary>
    public unsafe float DeathTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6700); }
    }
}
