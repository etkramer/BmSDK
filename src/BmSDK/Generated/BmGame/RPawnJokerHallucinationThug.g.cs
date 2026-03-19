#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnJokerHallucinationThug<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RPawnJokerHallucinationThug : BmSDK.BmGame.RPawnVillainThug, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnJokerHallucinationThug", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnJokerHallucinationThug() { }

    /// <summary>
    /// Constructs a new RPawnJokerHallucinationThug
    /// </summary>
    public RPawnJokerHallucinationThug(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnJokerHallucinationThug Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnJokerHallucinationThug(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnJokerHallucinationThug>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnJokerHallucinationThug>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnJokerHallucinationThug>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnJokerHallucinationThug>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnJokerHallucinationThug>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnJokerHallucinationThug>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnJokerHallucinationThug>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// BoolProperty: bShouldFadeIn
    /// </summary>
    public unsafe bool bShouldFadeIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6696) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6696); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6696); }
    }

    /// <summary>
    /// BoolProperty: bShouldFadeInSet
    /// </summary>
    public unsafe bool bShouldFadeInSet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6696) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6696); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6696); }
    }

    /// <summary>
    /// BoolProperty: bFadeInWhenOffScreen
    /// </summary>
    public unsafe bool bFadeInWhenOffScreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6696) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6696); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6696); }
    }

    /// <summary>
    /// BoolProperty: bFadingOut
    /// </summary>
    public unsafe bool bFadingOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6696) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6696); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6696); }
    }

    /// <summary>
    /// BoolProperty: bFadeOutInstant
    /// </summary>
    public unsafe bool bFadeOutInstant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6696) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6696); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6696); }
    }

    /// <summary>
    /// BoolProperty: bWaitingToFadeOut
    /// </summary>
    public unsafe bool bWaitingToFadeOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6696) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6696); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6696); }
    }

    /// <summary>
    /// BoolProperty: bFadeWhenNotInTransition
    /// </summary>
    public unsafe bool bFadeWhenNotInTransition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6696) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6696); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6696); }
    }

    /// <summary>
    /// BoolProperty: bAutoFadeIfBatmanTouches
    /// </summary>
    public unsafe bool bAutoFadeIfBatmanTouches
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6696) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6696); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6696); }
    }

    /// <summary>
    /// BoolProperty: bDontDeleteOnFade
    /// </summary>
    public unsafe bool bDontDeleteOnFade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6696) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6696); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6696); }
    }

    /// <summary>
    /// BoolProperty: bFadeOnCarWarning
    /// </summary>
    public unsafe bool bFadeOnCarWarning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6696) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6696); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6696); }
    }

    /// <summary>
    /// ObjectProperty: JokerDefine
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT JokerDefine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 6700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6700); }
    }

    /// <summary>
    /// ClassProperty: JokerCharacter
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT JokerCharacter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 6708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6708); }
    }

    /// <summary>
    /// StrProperty: CaseIdentifier
    /// </summary>
    public unsafe BmSDK.FString CaseIdentifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6716); }
    }

    /// <summary>
    /// FloatProperty: FadeSpeedMultiplier
    /// </summary>
    public unsafe float FadeSpeedMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6732); }
    }

    /// <summary>
    /// FloatProperty: JokerSpawnTime
    /// </summary>
    public unsafe float JokerSpawnTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6736); }
    }

    /// <summary>
    /// ByteProperty: InterceptHallucinationType
    /// </summary>
    public unsafe byte InterceptHallucinationType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 6740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6740); }
    }

    /// <summary>
    /// IntProperty: FramesOffScreen
    /// </summary>
    public unsafe int FramesOffScreen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6744); }
    }
}
