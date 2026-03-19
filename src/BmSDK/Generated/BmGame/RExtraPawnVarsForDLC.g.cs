#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RExtraPawnVarsForDLC<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RExtraPawnVarsForDLC : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RExtraPawnVarsForDLC", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RExtraPawnVarsForDLC() { }

    /// <summary>
    /// Constructs a new RExtraPawnVarsForDLC
    /// </summary>
    public RExtraPawnVarsForDLC(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RExtraPawnVarsForDLC Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RExtraPawnVarsForDLC(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RExtraPawnVarsForDLC>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RExtraPawnVarsForDLC>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RExtraPawnVarsForDLC>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RExtraPawnVarsForDLC>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RExtraPawnVarsForDLC>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RExtraPawnVarsForDLC>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RExtraPawnVarsForDLC>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// FloatProperty: lastHitByFlashBangTime
    /// </summary>
    public unsafe float lastHitByFlashBangTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// FloatProperty: LastCheckUnconsciousThugTime
    /// </summary>
    public unsafe float LastCheckUnconsciousThugTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// FloatProperty: LastStartledByPlayerTime
    /// </summary>
    public unsafe float LastStartledByPlayerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// BoolProperty: bSnaredAtStartOfTakedown
    /// </summary>
    public unsafe bool bSnaredAtStartOfTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 680); }
    }

    /// <summary>
    /// BoolProperty: lastFearTakedownContributedToVoiceSynthChallenge
    /// </summary>
    public unsafe bool lastFearTakedownContributedToVoiceSynthChallenge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 680); }
    }

    /// <summary>
    /// BoolProperty: bAttackedFromGrate
    /// </summary>
    public unsafe bool bAttackedFromGrate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 680); }
    }

    /// <summary>
    /// BoolProperty: bKnockoutSmashFromTakedownFromAbove
    /// </summary>
    public unsafe bool bKnockoutSmashFromTakedownFromAbove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 680); }
    }

    /// <summary>
    /// BoolProperty: bKnockoutSmashFromCorner
    /// </summary>
    public unsafe bool bKnockoutSmashFromCorner
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 680); }
    }

    /// <summary>
    /// BoolProperty: bFrozenThugTakedown
    /// </summary>
    public unsafe bool bFrozenThugTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 680); }
    }

    /// <summary>
    /// BoolProperty: bLastTakedownWasFromLedge
    /// </summary>
    public unsafe bool bLastTakedownWasFromLedge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 680); }
    }

    /// <summary>
    /// BoolProperty: bLastTakedownStartedDuringMayhemMode
    /// </summary>
    public unsafe bool bLastTakedownStartedDuringMayhemMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 680); }
    }

    /// <summary>
    /// FloatProperty: lastHitByElectroBlastStrongTime
    /// </summary>
    public unsafe float lastHitByElectroBlastStrongTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// FloatProperty: lastFearTakedownTime
    /// </summary>
    public unsafe float lastFearTakedownTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// FloatProperty: lastFollowingVoiceSynthOrderTime
    /// </summary>
    public unsafe float lastFollowingVoiceSynthOrderTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// FloatProperty: lastHadAMiniDroneTime
    /// </summary>
    public unsafe float lastHadAMiniDroneTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// FloatProperty: miniDroneBlindUntil
    /// </summary>
    public unsafe float miniDroneBlindUntil
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// FloatProperty: lastHitByReverseBatarangTime
    /// </summary>
    public unsafe float lastHitByReverseBatarangTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// FloatProperty: lastGunJamReactionTime
    /// </summary>
    public unsafe float lastGunJamReactionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// FloatProperty: StartReviveTime
    /// </summary>
    public unsafe float StartReviveTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }
}
