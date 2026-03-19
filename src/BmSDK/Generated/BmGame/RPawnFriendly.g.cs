#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnFriendly<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RPawnFriendly : BmSDK.BmGame.RPawnSpeech, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnFriendly", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnFriendly() { }

    /// <summary>
    /// Constructs a new RPawnFriendly
    /// </summary>
    public RPawnFriendly(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnFriendly Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnFriendly(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnFriendly>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnFriendly>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnFriendly>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnFriendly>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnFriendly>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnFriendly>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnFriendly>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: VfTable_IInterface_NavMeshPathObstacle
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VfTable_IInterface_NavMeshPathObstacle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4676); }
    }

    /// <summary>
    /// BoolProperty: bNeedsRescuing
    /// </summary>
    public unsafe bool bNeedsRescuing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4684); }
    }

    /// <summary>
    /// BoolProperty: bUseCounterForRescue
    /// </summary>
    public unsafe bool bUseCounterForRescue
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4684); }
    }

    /// <summary>
    /// BoolProperty: bThugsCanGrabForHostageSituation
    /// </summary>
    public unsafe bool bThugsCanGrabForHostageSituation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4684); }
    }

    /// <summary>
    /// BoolProperty: bRegisteredNavMeshObstacle
    /// </summary>
    public unsafe bool bRegisteredNavMeshObstacle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4684); }
    }

    /// <summary>
    /// BoolProperty: bTalkToSuppressed
    /// </summary>
    public unsafe bool bTalkToSuppressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4684); }
    }

    /// <summary>
    /// BoolProperty: bMonkey
    /// </summary>
    public unsafe bool bMonkey
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4684) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4684); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4684); }
    }

    /// <summary>
    /// StrProperty: RescueText
    /// </summary>
    public unsafe BmSDK.FString RescueText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4688); }
    }

    /// <summary>
    /// ObjectProperty: HostageAttackerAnimSet
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HostageAttackerAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4704); }
    }

    /// <summary>
    /// ObjectProperty: HostageVictimAnimSet
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HostageVictimAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4712); }
    }

    /// <summary>
    /// ObjectProperty: PlayerPawn
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4720); }
    }

    /// <summary>
    /// FloatProperty: CustomHeightRange
    /// </summary>
    public unsafe float CustomHeightRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4728); }
    }

    /// <summary>
    /// FloatProperty: CustomAngleRange
    /// </summary>
    public unsafe float CustomAngleRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4732); }
    }

    /// <summary>
    /// IntProperty: NoPromptTimer
    /// </summary>
    public unsafe int NoPromptTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4736); }
    }
}
