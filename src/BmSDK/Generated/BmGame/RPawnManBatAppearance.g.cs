#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnManBatAppearance<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RPawnManBatAppearance : BmSDK.BmGame.RPawnFriendly, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnManBatAppearance", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnManBatAppearance() { }

    /// <summary>
    /// Constructs a new RPawnManBatAppearance
    /// </summary>
    public RPawnManBatAppearance(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnManBatAppearance Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnManBatAppearance(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnManBatAppearance>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnManBatAppearance>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnManBatAppearance>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnManBatAppearance>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnManBatAppearance>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnManBatAppearance>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnManBatAppearance>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: VfTable_IInterface_NavMeshPathObstacle
    /// </summary>
    public unsafe System.IntPtr VfTable_IInterface_NavMeshPathObstacle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 4676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4676); }
    }

    /// <summary>
    /// BoolProperty: bNeedsRescuing
    /// </summary>
    public unsafe bool bNeedsRescuing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4684) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4684); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4684); }
    }

    /// <summary>
    /// BoolProperty: bUseCounterForRescue
    /// </summary>
    public unsafe bool bUseCounterForRescue
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4684) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4684); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4684); }
    }

    /// <summary>
    /// BoolProperty: bThugsCanGrabForHostageSituation
    /// </summary>
    public unsafe bool bThugsCanGrabForHostageSituation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4684) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4684); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4684); }
    }

    /// <summary>
    /// BoolProperty: bRegisteredNavMeshObstacle
    /// </summary>
    public unsafe bool bRegisteredNavMeshObstacle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4684) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4684); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4684); }
    }

    /// <summary>
    /// BoolProperty: bTalkToSuppressed
    /// </summary>
    public unsafe bool bTalkToSuppressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4684) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4684); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4684); }
    }

    /// <summary>
    /// BoolProperty: bMonkey
    /// </summary>
    public unsafe bool bMonkey
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4684) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4684); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4684); }
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
    public unsafe BmSDK.Engine.AnimSet HostageAttackerAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 4704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4704); }
    }

    /// <summary>
    /// ObjectProperty: HostageVictimAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet HostageVictimAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 4712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4712); }
    }

    /// <summary>
    /// ObjectProperty: PlayerPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer PlayerPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 4720); }
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
