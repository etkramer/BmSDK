#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCeilingClimbVolume<br/>
/// (size = 932)
/// (flags = 2292187794)
/// </summary>
public partial class RCeilingClimbVolume : BmSDK.Engine.Volume, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCeilingClimbVolume", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RCeilingClimbVolume.
    /// </summary>
    public static RCeilingClimbVolume DefaultObject => (RCeilingClimbVolume)StaticClass().DefaultObject;

    internal RCeilingClimbVolume() { }

    /// <summary>
    /// Constructs a new RCeilingClimbVolume
    /// </summary>
    public RCeilingClimbVolume(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCeilingClimbVolume(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCeilingClimbVolume>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCeilingClimbVolume>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCeilingClimbVolume>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCeilingClimbVolume>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCeilingClimbVolume>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCeilingClimbVolume>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCeilingClimbVolume>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCeilingClimbVolume>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: OnToggle
    /// </summary>
    public unsafe override void OnToggle(BmSDK.Engine.SeqAct_Toggle Action)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCeilingClimbVolume.OnToggle", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCeilingClimbVolume.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UnlinkToActor
    /// </summary>
    public unsafe override bool UnlinkToActor(BmSDK.Engine.Actor LinkTarget)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCeilingClimbVolume.UnlinkToActor", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: IsWallClimbVolume
    /// </summary>
    public unsafe virtual bool IsWallClimbVolume()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCeilingClimbVolume.IsWallClimbVolume", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsCeilingClimbVolume
    /// </summary>
    public unsafe virtual bool IsCeilingClimbVolume()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCeilingClimbVolume.IsCeilingClimbVolume", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: DebugDrawVolume
    /// </summary>
    public unsafe virtual void DebugDrawVolume(bool bDrawPersistent = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCeilingClimbVolume.DebugDrawVolume", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrawPersistent, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: FlagGrapplePoints
    /// </summary>
    public unsafe virtual void FlagGrapplePoints()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCeilingClimbVolume.FlagGrapplePoints", true);
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// ObjectProperty: CrossPoint1
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint CrossPoint1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ObjectProperty: CrossPoint2
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint CrossPoint2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ObjectProperty: CrossPoint3
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint CrossPoint3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ObjectProperty: CrossPoint4
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint CrossPoint4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ObjectProperty: CrossPoint5
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint CrossPoint5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ObjectProperty: CrossPoint6
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint CrossPoint6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ObjectProperty: CrossPoint7
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint CrossPoint7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ObjectProperty: CrossPoint8
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint CrossPoint8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// ObjectProperty: CrossPoint9
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint CrossPoint9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ObjectProperty: CrossPoint10
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint CrossPoint10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: Points
    /// </summary>
    public InlineArray<BmSDK.BmGame.RGrapplePoint> Points => new(10, Ptr + 820);

    /// <summary>
    /// ObjectProperty: Points
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint Points_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }
    /// <summary>
    /// ObjectProperty: Points
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint Points_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }
    /// <summary>
    /// ObjectProperty: Points
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint Points_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }
    /// <summary>
    /// ObjectProperty: Points
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint Points_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }
    /// <summary>
    /// ObjectProperty: Points
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint Points_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }
    /// <summary>
    /// ObjectProperty: Points
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint Points_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }
    /// <summary>
    /// ObjectProperty: Points
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint Points_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }
    /// <summary>
    /// ObjectProperty: Points
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint Points_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }
    /// <summary>
    /// ObjectProperty: Points
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint Points_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }
    /// <summary>
    /// ObjectProperty: Points
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint Points_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// ObjectProperty: ClimbLocators
    /// </summary>
    public unsafe BmSDK.BmGame.RClimbLocatorContainer ClimbLocators
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RClimbLocatorContainer>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// InlineArray{ByteProperty}: PointsCrossLevel
    /// </summary>
    public InlineArray<byte> PointsCrossLevel => new(10, Ptr + 908);

    /// <summary>
    /// ByteProperty: PointsCrossLevel
    /// </summary>
    public unsafe byte PointsCrossLevel_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }
    /// <summary>
    /// ByteProperty: PointsCrossLevel
    /// </summary>
    public unsafe byte PointsCrossLevel_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 909); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 909); }
    }
    /// <summary>
    /// ByteProperty: PointsCrossLevel
    /// </summary>
    public unsafe byte PointsCrossLevel_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 910); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 910); }
    }
    /// <summary>
    /// ByteProperty: PointsCrossLevel
    /// </summary>
    public unsafe byte PointsCrossLevel_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 911); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 911); }
    }
    /// <summary>
    /// ByteProperty: PointsCrossLevel
    /// </summary>
    public unsafe byte PointsCrossLevel_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }
    /// <summary>
    /// ByteProperty: PointsCrossLevel
    /// </summary>
    public unsafe byte PointsCrossLevel_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 913); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 913); }
    }
    /// <summary>
    /// ByteProperty: PointsCrossLevel
    /// </summary>
    public unsafe byte PointsCrossLevel_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 914); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 914); }
    }
    /// <summary>
    /// ByteProperty: PointsCrossLevel
    /// </summary>
    public unsafe byte PointsCrossLevel_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 915); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 915); }
    }
    /// <summary>
    /// ByteProperty: PointsCrossLevel
    /// </summary>
    public unsafe byte PointsCrossLevel_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }
    /// <summary>
    /// ByteProperty: PointsCrossLevel
    /// </summary>
    public unsafe byte PointsCrossLevel_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 917); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 917); }
    }

    /// <summary>
    /// IntProperty: TouchingGrapples
    /// </summary>
    public unsafe int TouchingGrapples
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// BoolProperty: bEnabled
    /// </summary>
    public unsafe bool bEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 924) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 924); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 924); }
    }

    /// <summary>
    /// BoolProperty: bCantPounceUp
    /// </summary>
    public unsafe bool bCantPounceUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 924) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 924); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 924); }
    }

    /// <summary>
    /// BoolProperty: bNoDropFromCeiling
    /// </summary>
    public unsafe bool bNoDropFromCeiling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 924) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 924); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 924); }
    }

    /// <summary>
    /// StructProperty: WallClimbVolumeColour
    /// </summary>
    public unsafe ref BmSDK.GameObject.FColor WallClimbVolumeColour
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FColor>(Ptr + 928);
}
