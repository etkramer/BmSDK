#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: GameMessage<br/>
/// (size = 340)
/// (flags = 50)
/// </summary>
public partial class GameMessage : BmSDK.Engine.LocalMessage, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.GameMessage", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal GameMessage() { }

    /// <summary>
    /// Constructs a new GameMessage
    /// </summary>
    public GameMessage(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GameMessage Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GameMessage(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetString
    /// </summary>
    public unsafe static BmSDK.FString GetString(int Switch = default, bool bPRI1HUD = default, BmSDK.Engine.PlayerReplicationInfo RelatedPRI = default, BmSDK.Engine.PlayerReplicationInfo RelatedPRI_1 = default, BmSDK.GameObject OptionalObject = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameMessage.GetString", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Switch, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPRI1HUD, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RelatedPRI, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RelatedPRI_1, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OptionalObject, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 20);
    }

    /// <summary>
    /// StrProperty: SwitchLevelMessage
    /// </summary>
    public unsafe BmSDK.FString SwitchLevelMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// StrProperty: LeftMessage
    /// </summary>
    public unsafe BmSDK.FString LeftMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 76); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }
    }

    /// <summary>
    /// StrProperty: FailedTeamMessage
    /// </summary>
    public unsafe BmSDK.FString FailedTeamMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// StrProperty: FailedPlaceMessage
    /// </summary>
    public unsafe BmSDK.FString FailedPlaceMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StrProperty: FailedSpawnMessage
    /// </summary>
    public unsafe BmSDK.FString FailedSpawnMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// StrProperty: EnteredMessage
    /// </summary>
    public unsafe BmSDK.FString EnteredMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// StrProperty: MaxedOutMessage
    /// </summary>
    public unsafe BmSDK.FString MaxedOutMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// StrProperty: ArbitrationMessage
    /// </summary>
    public unsafe BmSDK.FString ArbitrationMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// StrProperty: OvertimeMessage
    /// </summary>
    public unsafe BmSDK.FString OvertimeMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// StrProperty: GlobalNameChange
    /// </summary>
    public unsafe BmSDK.FString GlobalNameChange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// StrProperty: NewTeamMessage
    /// </summary>
    public unsafe BmSDK.FString NewTeamMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// StrProperty: NewTeamMessageTrailer
    /// </summary>
    public unsafe BmSDK.FString NewTeamMessageTrailer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// StrProperty: NoNameChange
    /// </summary>
    public unsafe BmSDK.FString NoNameChange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// StrProperty: VoteStarted
    /// </summary>
    public unsafe BmSDK.FString VoteStarted
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// StrProperty: VotePassed
    /// </summary>
    public unsafe BmSDK.FString VotePassed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }

    /// <summary>
    /// StrProperty: MustHaveStats
    /// </summary>
    public unsafe BmSDK.FString MustHaveStats
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// StrProperty: CantBeSpectator
    /// </summary>
    public unsafe BmSDK.FString CantBeSpectator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// StrProperty: CantBePlayer
    /// </summary>
    public unsafe BmSDK.FString CantBePlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// StrProperty: BecameSpectator
    /// </summary>
    public unsafe BmSDK.FString BecameSpectator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// StrProperty: NewPlayerMessage
    /// </summary>
    public unsafe BmSDK.FString NewPlayerMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// StrProperty: KickWarning
    /// </summary>
    public unsafe BmSDK.FString KickWarning
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// StrProperty: NewSpecMessage
    /// </summary>
    public unsafe BmSDK.FString NewSpecMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// StrProperty: SpecEnteredMessage
    /// </summary>
    public unsafe BmSDK.FString SpecEnteredMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }
}
