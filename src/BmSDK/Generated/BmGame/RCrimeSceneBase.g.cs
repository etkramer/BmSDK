#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCrimeSceneBase<br/>
/// (flags = 0)
/// </summary>
public partial class RCrimeSceneBase : BmSDK.Engine.Volume, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCrimeSceneBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCrimeSceneBase() { }

    /// <summary>
    /// Constructs a new RCrimeSceneBase
    /// </summary>
    public RCrimeSceneBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCrimeSceneBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCrimeSceneBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCrimeSceneBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCrimeSceneBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCrimeSceneBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCrimeSceneBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCrimeSceneBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCrimeSceneBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCrimeSceneBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// NameProperty: CrimeSceneScreenName
    /// </summary>
    public unsafe BmSDK.FName CrimeSceneScreenName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// NameProperty: OptionalCasefileScreenName
    /// </summary>
    public unsafe BmSDK.FName OptionalCasefileScreenName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// StrProperty: OverrideCompletionString
    /// </summary>
    public unsafe BmSDK.FString OverrideCompletionString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ArrayProperty: DisallowFlags
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> DisallowFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ArrayProperty: MandatoryFlags
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> MandatoryFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// StrProperty: CrimeSceneInternalName
    /// </summary>
    public unsafe BmSDK.FString CrimeSceneInternalName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// BoolProperty: DoNotEnterScanMode
    /// </summary>
    public unsafe bool DoNotEnterScanMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 820); }
    }

    /// <summary>
    /// BoolProperty: HideCompletionPercentage
    /// </summary>
    public unsafe bool HideCompletionPercentage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 820); }
    }

    /// <summary>
    /// BoolProperty: mIsCaseFile
    /// </summary>
    public unsafe bool mIsCaseFile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 820); }
    }

    /// <summary>
    /// BoolProperty: DeepScanCrimeScene
    /// </summary>
    public unsafe bool DeepScanCrimeScene
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 820); }
    }

    /// <summary>
    /// BoolProperty: DeepScanEnabled
    /// </summary>
    public unsafe bool DeepScanEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 820); }
    }

    /// <summary>
    /// BoolProperty: DeepScanCrimeSceneInitialised
    /// </summary>
    public unsafe bool DeepScanCrimeSceneInitialised
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 820); }
    }

    /// <summary>
    /// BoolProperty: PlayerHasChangedLayerAtLeastOnce
    /// </summary>
    public unsafe bool PlayerHasChangedLayerAtLeastOnce
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 820); }
    }

    /// <summary>
    /// BoolProperty: CrimeSceneVisible
    /// </summary>
    public unsafe bool CrimeSceneVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 820); }
    }

    /// <summary>
    /// BoolProperty: CrimeSceneComplete
    /// </summary>
    public unsafe bool CrimeSceneComplete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 820); }
    }

    /// <summary>
    /// BoolProperty: bIn
    /// </summary>
    public unsafe bool bIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 820); }
    }

    /// <summary>
    /// BoolProperty: bIsEngaged
    /// </summary>
    public unsafe bool bIsEngaged
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 820); }
    }

    /// <summary>
    /// BoolProperty: bConstrainToArc
    /// </summary>
    public unsafe bool bConstrainToArc
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 820); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 820); }
    }

    /// <summary>
    /// ArrayProperty: ActorsToHideWhenLocked
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> ActorsToHideWhenLocked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// IntProperty: DeepScanLevel
    /// </summary>
    public unsafe int DeepScanLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// FloatProperty: InsideTimer
    /// </summary>
    public unsafe float InsideTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// FloatProperty: OutsideTimer
    /// </summary>
    public unsafe float OutsideTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// StructProperty: ConstrainToArcCentre
    /// </summary>
    public unsafe System.Numerics.Vector3 ConstrainToArcCentre
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// FloatProperty: ConstrainToArcRadius
    /// </summary>
    public unsafe float ConstrainToArcRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// FloatProperty: ConstrainToArcAngleMiddle
    /// </summary>
    public unsafe float ConstrainToArcAngleMiddle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// FloatProperty: ConstrainToArcAngleRange
    /// </summary>
    public unsafe float ConstrainToArcAngleRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }
}
