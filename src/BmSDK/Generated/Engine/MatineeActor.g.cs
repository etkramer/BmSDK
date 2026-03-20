#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MatineeActor<br/>
/// (flags = 0)
/// </summary>
public partial class MatineeActor : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MatineeActor", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MatineeActor() { }

    /// <summary>
    /// Constructs a new MatineeActor
    /// </summary>
    public MatineeActor(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MatineeActor Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MatineeActor(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MatineeActor>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MatineeActor>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MatineeActor>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MatineeActor>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MatineeActor>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MatineeActor>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MatineeActor>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: InterpAction
    /// </summary>
    public unsafe BmSDK.Engine.SeqAct_Interp InterpAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SeqAct_Interp>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ObjectProperty: AIGroupPawns
    /// </summary>
    public unsafe BmSDK.Engine.Pawn AIGroupPawns_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }
    /// <summary>
    /// ObjectProperty: AIGroupPawns
    /// </summary>
    public unsafe BmSDK.Engine.Pawn AIGroupPawns_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }
    /// <summary>
    /// ObjectProperty: AIGroupPawns
    /// </summary>
    public unsafe BmSDK.Engine.Pawn AIGroupPawns_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }
    /// <summary>
    /// ObjectProperty: AIGroupPawns
    /// </summary>
    public unsafe BmSDK.Engine.Pawn AIGroupPawns_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }
    /// <summary>
    /// ObjectProperty: AIGroupPawns
    /// </summary>
    public unsafe BmSDK.Engine.Pawn AIGroupPawns_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }
    /// <summary>
    /// ObjectProperty: AIGroupPawns
    /// </summary>
    public unsafe BmSDK.Engine.Pawn AIGroupPawns_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }
    /// <summary>
    /// ObjectProperty: AIGroupPawns
    /// </summary>
    public unsafe BmSDK.Engine.Pawn AIGroupPawns_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }
    /// <summary>
    /// ObjectProperty: AIGroupPawns
    /// </summary>
    public unsafe BmSDK.Engine.Pawn AIGroupPawns_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }
    /// <summary>
    /// ObjectProperty: AIGroupPawns
    /// </summary>
    public unsafe BmSDK.Engine.Pawn AIGroupPawns_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }
    /// <summary>
    /// ObjectProperty: AIGroupPawns
    /// </summary>
    public unsafe BmSDK.Engine.Pawn AIGroupPawns_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bIsPlaying
    /// </summary>
    public unsafe bool bIsPlaying
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 756); }
    }

    /// <summary>
    /// BoolProperty: bReversePlayback
    /// </summary>
    public unsafe bool bReversePlayback
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 756); }
    }

    /// <summary>
    /// BoolProperty: bPaused
    /// </summary>
    public unsafe bool bPaused
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 756); }
    }

    /// <summary>
    /// BoolProperty: AllAIGroupsInitialized
    /// </summary>
    public unsafe bool AllAIGroupsInitialized
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 756); }
    }

    /// <summary>
    /// FloatProperty: PlayRate
    /// </summary>
    public unsafe float PlayRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// FloatProperty: Position
    /// </summary>
    public unsafe float Position
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// NameProperty: AIGroupNames
    /// </summary>
    public unsafe BmSDK.FName AIGroupNames_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }
    /// <summary>
    /// NameProperty: AIGroupNames
    /// </summary>
    public unsafe BmSDK.FName AIGroupNames_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }
    /// <summary>
    /// NameProperty: AIGroupNames
    /// </summary>
    public unsafe BmSDK.FName AIGroupNames_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }
    /// <summary>
    /// NameProperty: AIGroupNames
    /// </summary>
    public unsafe BmSDK.FName AIGroupNames_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }
    /// <summary>
    /// NameProperty: AIGroupNames
    /// </summary>
    public unsafe BmSDK.FName AIGroupNames_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }
    /// <summary>
    /// NameProperty: AIGroupNames
    /// </summary>
    public unsafe BmSDK.FName AIGroupNames_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }
    /// <summary>
    /// NameProperty: AIGroupNames
    /// </summary>
    public unsafe BmSDK.FName AIGroupNames_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }
    /// <summary>
    /// NameProperty: AIGroupNames
    /// </summary>
    public unsafe BmSDK.FName AIGroupNames_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }
    /// <summary>
    /// NameProperty: AIGroupNames
    /// </summary>
    public unsafe BmSDK.FName AIGroupNames_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }
    /// <summary>
    /// NameProperty: AIGroupNames
    /// </summary>
    public unsafe BmSDK.FName AIGroupNames_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// IntProperty: AIGroupInitStage
    /// </summary>
    public unsafe int AIGroupInitStage_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }
    /// <summary>
    /// IntProperty: AIGroupInitStage
    /// </summary>
    public unsafe int AIGroupInitStage_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }
    /// <summary>
    /// IntProperty: AIGroupInitStage
    /// </summary>
    public unsafe int AIGroupInitStage_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }
    /// <summary>
    /// IntProperty: AIGroupInitStage
    /// </summary>
    public unsafe int AIGroupInitStage_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }
    /// <summary>
    /// IntProperty: AIGroupInitStage
    /// </summary>
    public unsafe int AIGroupInitStage_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }
    /// <summary>
    /// IntProperty: AIGroupInitStage
    /// </summary>
    public unsafe int AIGroupInitStage_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }
    /// <summary>
    /// IntProperty: AIGroupInitStage
    /// </summary>
    public unsafe int AIGroupInitStage_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }
    /// <summary>
    /// IntProperty: AIGroupInitStage
    /// </summary>
    public unsafe int AIGroupInitStage_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }
    /// <summary>
    /// IntProperty: AIGroupInitStage
    /// </summary>
    public unsafe int AIGroupInitStage_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }
    /// <summary>
    /// IntProperty: AIGroupInitStage
    /// </summary>
    public unsafe int AIGroupInitStage_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// FloatProperty: ClientSidePositionErrorTolerance
    /// </summary>
    public unsafe float ClientSidePositionErrorTolerance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }
}
