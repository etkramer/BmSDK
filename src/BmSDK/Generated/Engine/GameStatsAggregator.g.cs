#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: GameStatsAggregator<br/>
/// (flags = 0)
/// </summary>
public partial class GameStatsAggregator : BmSDK.Engine.GameplayEventsHandler, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.GameStatsAggregator", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal GameStatsAggregator() { }

    /// <summary>
    /// Constructs a new GameStatsAggregator
    /// </summary>
    public GameStatsAggregator(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GameStatsAggregator Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GameStatsAggregator(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: GameState
    /// </summary>
    public unsafe BmSDK.Engine.GameStateObject GameState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStateObject>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ArrayProperty: AggregatesList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.GameStatsAggregator.FAggregateEventMapping> AggregatesList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.GameStatsAggregator.FAggregateEventMapping>>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// StructProperty: AggregateEventsMapping
    /// </summary>
    public unsafe BmSDK.GameObject.FMap_Mirror AggregateEventsMapping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FMap_Mirror>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ArrayProperty: AggregateEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.GameplayEvents.FGameplayEventMetaData> AggregateEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.GameplayEvents.FGameplayEventMetaData>>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// ArrayProperty: AggregatesFound
    /// </summary>
    public unsafe BmSDK.TArray<int> AggregatesFound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// StructProperty: AllGameEvents
    /// </summary>
    public unsafe BmSDK.Engine.GameStatsAggregator.FGameEvents AllGameEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FGameEvents>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// ArrayProperty: AllTeamEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.GameStatsAggregator.FTeamEvents> AllTeamEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.GameStatsAggregator.FTeamEvents>>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// ArrayProperty: AllPlayerEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.GameStatsAggregator.FPlayerEvents> AllPlayerEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.GameStatsAggregator.FPlayerEvents>>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// StructProperty: AllWeaponEvents
    /// </summary>
    public unsafe BmSDK.Engine.GameStatsAggregator.FWeaponEvents AllWeaponEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FWeaponEvents>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// StructProperty: AllProjectileEvents
    /// </summary>
    public unsafe BmSDK.Engine.GameStatsAggregator.FProjectileEvents AllProjectileEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FProjectileEvents>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// StructProperty: AllPawnEvents
    /// </summary>
    public unsafe BmSDK.Engine.GameStatsAggregator.FPawnEvents AllPawnEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FPawnEvents>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// StructProperty: AllDamageEvents
    /// </summary>
    public unsafe BmSDK.Engine.GameStatsAggregator.FDamageEvents AllDamageEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FDamageEvents>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

}
