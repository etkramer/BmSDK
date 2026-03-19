#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MPawnPlayerBatgirlBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MPawnPlayerBatgirlBase : BmSDK.BmGame.RPawnPlayerBmBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MPawnPlayerBatgirlBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MPawnPlayerBatgirlBase() { }

    /// <summary>
    /// Constructs a new MPawnPlayerBatgirlBase
    /// </summary>
    public MPawnPlayerBatgirlBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MPawnPlayerBatgirlBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MPawnPlayerBatgirlBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerBatgirlBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerBatgirlBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerBatgirlBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerBatgirlBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerBatgirlBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerBatgirlBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerBatgirlBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: PlayerCounterAnimset_JokerKnife
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerCounterAnimset_JokerKnife
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10252); }
    }

    /// <summary>
    /// ObjectProperty: VillainCounterAnimset_JokerKnife
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VillainCounterAnimset_JokerKnife
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10260); }
    }

    /// <summary>
    /// ObjectProperty: BatgirlHackingGadget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BatgirlHackingGadget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10268); }
    }

    /// <summary>
    /// BoolProperty: bDebugBatgirlAttractHackVisibility
    /// </summary>
    public unsafe bool bDebugBatgirlAttractHackVisibility
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10276) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10276); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10276); }
    }

    /// <summary>
    /// BoolProperty: bScareModeOn
    /// </summary>
    public unsafe bool bScareModeOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10276) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10276); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10276); }
    }

    /// <summary>
    /// BoolProperty: bBlindModeOn
    /// </summary>
    public unsafe bool bBlindModeOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10276) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10276); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10276); }
    }

    /// <summary>
    /// IntProperty: MaxBalloon
    /// </summary>
    public unsafe int MaxBalloon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10280); }
    }

    /// <summary>
    /// IntProperty: MaxTheeth
    /// </summary>
    public unsafe int MaxTheeth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10284); }
    }

    /// <summary>
    /// IntProperty: MaxJITB
    /// </summary>
    public unsafe int MaxJITB
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10288); }
    }

    /// <summary>
    /// IntProperty: Achievement_Scared_ThugDefeated_Amount_Needed
    /// </summary>
    public unsafe int Achievement_Scared_ThugDefeated_Amount_Needed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10292); }
    }

    /// <summary>
    /// IntProperty: Achievement_Scared_ThugsDefeated
    /// </summary>
    public unsafe int Achievement_Scared_ThugsDefeated
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10296); }
    }

    /// <summary>
    /// IntProperty: Achievement_ThugDefeated_DuringHack_Amount_Needed
    /// </summary>
    public unsafe int Achievement_ThugDefeated_DuringHack_Amount_Needed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10300); }
    }

    /// <summary>
    /// IntProperty: Achievement_ThugDefeated_DuringHack
    /// </summary>
    public unsafe int Achievement_ThugDefeated_DuringHack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10304); }
    }
}
