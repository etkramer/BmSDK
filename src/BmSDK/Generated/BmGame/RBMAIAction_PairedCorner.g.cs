#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMAIAction_PairedCorner<br/>
/// (size = 1336)
/// (flags = 10485778)
/// </summary>
public partial class RBMAIAction_PairedCorner : BmSDK.BmGame.RBMAIAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMAIAction_PairedCorner", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMAIAction_PairedCorner.
    /// </summary>
    public static RBMAIAction_PairedCorner DefaultObject => (RBMAIAction_PairedCorner)StaticClass().DefaultObject;

    internal RBMAIAction_PairedCorner() { }

    /// <summary>
    /// Constructs a new RBMAIAction_PairedCorner
    /// </summary>
    public RBMAIAction_PairedCorner(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMAIAction_PairedCorner(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_PairedCorner>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_PairedCorner>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_PairedCorner>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_PairedCorner>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_PairedCorner>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_PairedCorner>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_PairedCorner>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_PairedCorner>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: ActionTick
    /// </summary>
    public unsafe override BmSDK.BmGame.RBMAIAction.ActionTickResult ActionTick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMAIAction_PairedCorner.ActionTick", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIAction.ActionTickResult>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: StartCornerOutAnim
    /// </summary>
    public unsafe virtual void StartCornerOutAnim()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMAIAction_PairedCorner.StartCornerOutAnim", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartCornerInAnim
    /// </summary>
    public unsafe virtual void StartCornerInAnim()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMAIAction_PairedCorner.StartCornerInAnim", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: MoveToStart
    /// </summary>
    public unsafe virtual void MoveToStart()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMAIAction_PairedCorner.MoveToStart", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnDeactivate
    /// </summary>
    public unsafe override void OnDeactivate()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMAIAction_PairedCorner.OnDeactivate", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnActivate
    /// </summary>
    public unsafe override void OnActivate()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMAIAction_PairedCorner.OnActivate", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AnimInit
    /// </summary>
    public unsafe virtual void AnimInit(System.Numerics.Vector3 pos, float Yaw, bool bLeft, bool inBFollower, int variant)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMAIAction_PairedCorner.AnimInit", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Yaw, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLeft, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inBFollower, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(variant, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EndJokerHallucination
    /// </summary>
    public unsafe virtual void EndJokerHallucination()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMAIAction_PairedCorner.EndJokerHallucination", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Joker_Out
    /// </summary>
    public unsafe virtual void Joker_Out()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMAIAction_PairedCorner.Joker_Out", true);
        byte* paramsPtr = stackalloc byte[92];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoSlavedJokerHallucination
    /// </summary>
    public unsafe virtual void DoSlavedJokerHallucination(bool bIgnoreCollisionCheck, float AngleOffset, System.Numerics.Vector3 refLoc, bool LeftCorner)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMAIAction_PairedCorner.DoSlavedJokerHallucination", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreCollisionCheck, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AngleOffset, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(refLoc, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LeftCorner, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetJokerHallucinationFadeMultiplier
    /// </summary>
    public unsafe virtual int GetJokerHallucinationFadeMultiplier()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMAIAction_PairedCorner.GetJokerHallucinationFadeMultiplier", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Enum: ePairedCornerAnimType
    /// </summary>
    public enum ePairedCornerAnimType : byte
    {
        ePCAT_Standard = 0,
        ePCAT_Silly = 1,
        ePCAT_NoSwap = 2,
        ePCAT_MAX = 3,
    }

    /// <summary>
    /// Struct: FcornerAnimNames
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FcornerAnimNames
    {
        /// <summary>
        /// NameProperty: leader
        /// </summary>
        public unsafe BmSDK.FName leader_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
        /// <summary>
        /// NameProperty: leader
        /// </summary>
        public unsafe BmSDK.FName leader_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// NameProperty: follower
        /// </summary>
        public unsafe BmSDK.FName follower_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
        /// <summary>
        /// NameProperty: follower
        /// </summary>
        public unsafe BmSDK.FName follower_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Enum: eCornerAnimStage
    /// </summary>
    public enum eCornerAnimStage : byte
    {
        eCAS_MoveToStart = 0,
        eCAS_In = 1,
        eCAS_Idle = 2,
        eCAS_Out = 3,
        eCAS_MAX = 4,
    }

    /// <summary>
    /// StructProperty: CornerPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CornerPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 864);

    /// <summary>
    /// FloatProperty: CornerYaw
    /// </summary>
    public unsafe float CornerYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// StructProperty: transID
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId transID
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 880);

    /// <summary>
    /// NameProperty: InName
    /// </summary>
    public unsafe BmSDK.FName InName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// NameProperty: IdleName
    /// </summary>
    public unsafe BmSDK.FName IdleName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// NameProperty: OutName
    /// </summary>
    public unsafe BmSDK.FName OutName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// ObjectProperty: AnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet AnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// BoolProperty: bFollower
    /// </summary>
    public unsafe bool bFollower
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 916) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 916); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 916); }
    }

    /// <summary>
    /// BoolProperty: bStoredLeft
    /// </summary>
    public unsafe bool bStoredLeft
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 916) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 916); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 916); }
    }

    /// <summary>
    /// ByteProperty: animStage
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIAction_PairedCorner.eCornerAnimStage animStage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIAction_PairedCorner.eCornerAnimStage>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// StructProperty: idealInAnimStartLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 idealInAnimStartLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 924);

    /// <summary>
    /// FloatProperty: idealDistFromCornerForInAnim
    /// </summary>
    public unsafe float idealDistFromCornerForInAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: InNamesSideOn
    /// </summary>
    public InlineArray<BmSDK.BmGame.RBMAIAction_PairedCorner.FcornerAnimNames> InNamesSideOn => new(3, Ptr + 940);

    /// <summary>
    /// StructProperty: InNamesSideOn
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMAIAction_PairedCorner.FcornerAnimNames InNamesSideOn_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMAIAction_PairedCorner.FcornerAnimNames>(Ptr + 940);
    /// <summary>
    /// StructProperty: InNamesSideOn
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMAIAction_PairedCorner.FcornerAnimNames InNamesSideOn_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMAIAction_PairedCorner.FcornerAnimNames>(Ptr + 972);
    /// <summary>
    /// StructProperty: InNamesSideOn
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMAIAction_PairedCorner.FcornerAnimNames InNamesSideOn_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMAIAction_PairedCorner.FcornerAnimNames>(Ptr + 1004);

    /// <summary>
    /// InlineArray{StructProperty}: InNamesHeadOn
    /// </summary>
    public InlineArray<BmSDK.BmGame.RBMAIAction_PairedCorner.FcornerAnimNames> InNamesHeadOn => new(3, Ptr + 1036);

    /// <summary>
    /// StructProperty: InNamesHeadOn
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMAIAction_PairedCorner.FcornerAnimNames InNamesHeadOn_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMAIAction_PairedCorner.FcornerAnimNames>(Ptr + 1036);
    /// <summary>
    /// StructProperty: InNamesHeadOn
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMAIAction_PairedCorner.FcornerAnimNames InNamesHeadOn_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMAIAction_PairedCorner.FcornerAnimNames>(Ptr + 1068);
    /// <summary>
    /// StructProperty: InNamesHeadOn
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMAIAction_PairedCorner.FcornerAnimNames InNamesHeadOn_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMAIAction_PairedCorner.FcornerAnimNames>(Ptr + 1100);

    /// <summary>
    /// InlineArray{StructProperty}: IdleNames
    /// </summary>
    public InlineArray<BmSDK.BmGame.RBMAIAction_PairedCorner.FcornerAnimNames> IdleNames => new(3, Ptr + 1132);

    /// <summary>
    /// StructProperty: IdleNames
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMAIAction_PairedCorner.FcornerAnimNames IdleNames_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMAIAction_PairedCorner.FcornerAnimNames>(Ptr + 1132);
    /// <summary>
    /// StructProperty: IdleNames
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMAIAction_PairedCorner.FcornerAnimNames IdleNames_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMAIAction_PairedCorner.FcornerAnimNames>(Ptr + 1164);
    /// <summary>
    /// StructProperty: IdleNames
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMAIAction_PairedCorner.FcornerAnimNames IdleNames_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMAIAction_PairedCorner.FcornerAnimNames>(Ptr + 1196);

    /// <summary>
    /// InlineArray{StructProperty}: OutNames
    /// </summary>
    public InlineArray<BmSDK.BmGame.RBMAIAction_PairedCorner.FcornerAnimNames> OutNames => new(3, Ptr + 1228);

    /// <summary>
    /// StructProperty: OutNames
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMAIAction_PairedCorner.FcornerAnimNames OutNames_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMAIAction_PairedCorner.FcornerAnimNames>(Ptr + 1228);
    /// <summary>
    /// StructProperty: OutNames
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMAIAction_PairedCorner.FcornerAnimNames OutNames_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMAIAction_PairedCorner.FcornerAnimNames>(Ptr + 1260);
    /// <summary>
    /// StructProperty: OutNames
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMAIAction_PairedCorner.FcornerAnimNames OutNames_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMAIAction_PairedCorner.FcornerAnimNames>(Ptr + 1292);

    /// <summary>
    /// InlineArray{IntProperty}: variantSwapsRoles
    /// </summary>
    public InlineArray<int> variantSwapsRoles => new(3, Ptr + 1324);

    /// <summary>
    /// IntProperty: variantSwapsRoles
    /// </summary>
    public unsafe int variantSwapsRoles_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }
    /// <summary>
    /// IntProperty: variantSwapsRoles
    /// </summary>
    public unsafe int variantSwapsRoles_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }
    }
    /// <summary>
    /// IntProperty: variantSwapsRoles
    /// </summary>
    public unsafe int variantSwapsRoles_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1332); }
    }
}
