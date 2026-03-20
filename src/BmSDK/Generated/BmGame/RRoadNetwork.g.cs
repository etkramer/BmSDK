#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RRoadNetwork<br/>
/// (flags = 0)
/// </summary>
public partial class RRoadNetwork : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RRoadNetwork", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RRoadNetwork() { }

    /// <summary>
    /// Constructs a new RRoadNetwork
    /// </summary>
    public RRoadNetwork(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RRoadNetwork Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRoadNetwork(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRoadNetwork>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRoadNetwork>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRoadNetwork>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRoadNetwork>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRoadNetwork>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRoadNetwork>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRoadNetwork>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe void Destroyed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.Destroyed", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PreStreamOut
    /// </summary>
    public unsafe void PreStreamOut()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.PreStreamOut", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PreBeginPlay
    /// </summary>
    public unsafe void PreBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.PreBeginPlay", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlanTightAreaRoute
    /// </summary>
    public unsafe bool PlanTightAreaRoute(out BmSDK.TArray<int> Route, out BmSDK.BmGame.RRoadNetwork.FRoadNetworkTightArea TightArea, System.Numerics.Vector3 StartLoc, System.Numerics.Vector3 EndLoc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.PlanTightAreaRoute", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLoc, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndLoc, paramsPtr + 52);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Route = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(paramsPtr + 0);
        TightArea = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork.FRoadNetworkTightArea>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 64);
    }

    /// <summary>
    /// Function: GenerateTightArea
    /// </summary>
    public unsafe void GenerateTightArea(out BmSDK.BmGame.RRoadNetwork.FRoadNetworkTightArea TightArea, System.Numerics.Vector3 centre, byte RoadObstacleAvoidBits, float AvoidExtent, float AreaRadius, out BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction Restriction)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.GenerateTightArea", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(centre, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RoadObstacleAvoidBits, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AvoidExtent, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AreaRadius, paramsPtr + 44);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        TightArea = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork.FRoadNetworkTightArea>(paramsPtr + 0);
        Restriction = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction>(paramsPtr + 48);
        return;
    }

    /// <summary>
    /// Function: GetTightAreaVertexForLocation
    /// </summary>
    public unsafe bool GetTightAreaVertexForLocation(out BmSDK.BmGame.RRoadNetwork.FRoadNetworkTightArea TightArea, out int X, out int Y, System.Numerics.Vector3 Loc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.GetTightAreaVertexForLocation", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        TightArea = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork.FRoadNetworkTightArea>(paramsPtr + 0);
        X = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 24);
        Y = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 28);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 44);
    }

    /// <summary>
    /// Function: GetTightAreaLocationFromNodeIndex
    /// </summary>
    public unsafe System.Numerics.Vector3 GetTightAreaLocationFromNodeIndex(out BmSDK.BmGame.RRoadNetwork.FRoadNetworkTightArea TightArea, int NodeIndex)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.GetTightAreaLocationFromNodeIndex", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NodeIndex, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        TightArea = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork.FRoadNetworkTightArea>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: GetTightAreaLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 GetTightAreaLocation(out BmSDK.BmGame.RRoadNetwork.FRoadNetworkTightArea TightArea, int X, int Y)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.GetTightAreaLocation", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(X, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Y, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        TightArea = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork.FRoadNetworkTightArea>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: GetLinkLoc
    /// </summary>
    public unsafe System.Numerics.Vector3 GetLinkLoc(int LinkIndex, float LinkTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.GetLinkLoc", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkTime, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: IsDeadEnd
    /// </summary>
    public unsafe bool IsDeadEnd(int InitialLinkEndPoint, int InitialLink, System.Numerics.Vector3 AvoidLocation, float AvoidLocationRadius, BmSDK.TArray<int> ExcludeLinks, bool CanJumpDown, bool CanJumpUp, out int ReasonCode, out BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction Restriction, int MaxDepth, int Depth, bool bOutputToLog)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.IsDeadEnd", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InitialLinkEndPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InitialLink, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AvoidLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AvoidLocationRadius, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExcludeLinks, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CanJumpDown, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CanJumpUp, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxDepth, paramsPtr + 220);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Depth, paramsPtr + 224);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOutputToLog, paramsPtr + 228);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ReasonCode = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 48);
        Restriction = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction>(paramsPtr + 52);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 232);
    }

    /// <summary>
    /// Function: GetLinkLaneInfoAtEndPoint
    /// </summary>
    public unsafe void GetLinkLaneInfoAtEndPoint(out BmSDK.BmGame.RRoadLink.FLaneInfo LeftInfo, out BmSDK.BmGame.RRoadLink.FLaneInfo RightInfo, int LinkIndex, int LinkEndPoint)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.GetLinkLaneInfoAtEndPoint", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkIndex, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkEndPoint, paramsPtr + 44);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        LeftInfo = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadLink.FLaneInfo>(paramsPtr + 0);
        RightInfo = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadLink.FLaneInfo>(paramsPtr + 20);
        return;
    }

    /// <summary>
    /// Function: GetLinkLaneInfoAtClosestPoint
    /// </summary>
    public unsafe void GetLinkLaneInfoAtClosestPoint(out BmSDK.BmGame.RRoadLink.FLaneInfo LeftInfo, out BmSDK.BmGame.RRoadLink.FLaneInfo RightInfo, System.Numerics.Vector3 RefPoint, int LinkIndex, int LinkEndPoint, out float TimeOnLink)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.GetLinkLaneInfoAtClosestPoint", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RefPoint, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkIndex, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkEndPoint, paramsPtr + 56);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        LeftInfo = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadLink.FLaneInfo>(paramsPtr + 0);
        RightInfo = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadLink.FLaneInfo>(paramsPtr + 20);
        TimeOnLink = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 60);
        return;
    }

    /// <summary>
    /// Function: GetLinkHeadRoom
    /// </summary>
    public unsafe float GetLinkHeadRoom(int LinkIndex)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.GetLinkHeadRoom", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkIndex, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: LinkHasMinHeadroom
    /// </summary>
    public unsafe bool LinkHasMinHeadroom(int LinkIndex, int LaneIndex, float MinHeadroom)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.LinkHasMinHeadroom", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LaneIndex, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinHeadroom, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetLinkPointEndIndex
    /// </summary>
    public unsafe int GetLinkPointEndIndex(int LinkIndex, int PointIndex)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.GetLinkPointEndIndex", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PointIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GetLinkOtherPoint
    /// </summary>
    public unsafe int GetLinkOtherPoint(int LinkIndex, int PointIndex)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.GetLinkOtherPoint", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PointIndex, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: IsPointAtJunction
    /// </summary>
    public unsafe bool IsPointAtJunction(int PointIndex, bool ExcludeOpenAreas)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.IsPointAtJunction", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PointIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExcludeOpenAreas, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: IsPointInExcludedPointList
    /// </summary>
    public unsafe static bool IsPointInExcludedPointList(int PointIndex, out BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction Restriction)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.IsPointInExcludedPointList", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PointIndex, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Restriction = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 172);
    }

    /// <summary>
    /// Function: IsPointInAnyVolume
    /// </summary>
    public unsafe static bool IsPointInAnyVolume(System.Numerics.Vector3 Point, out BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction Restriction, out BmSDK.Engine.Volume HitVolume)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.IsPointInAnyVolume", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Point, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Restriction = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction>(paramsPtr + 12);
        HitVolume = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Volume>(paramsPtr + 180);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 188);
    }

    /// <summary>
    /// Function: TraceObstacles
    /// </summary>
    public unsafe bool TraceObstacles(BmSDK.BmGame.RVehicle Vehicle, System.Numerics.Vector3 Start, System.Numerics.Vector3 End, System.Numerics.Vector3 Extent)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.TraceObstacles", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Vehicle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 44);
    }

    /// <summary>
    /// Function: UpdateObstacleBounds
    /// </summary>
    public unsafe void UpdateObstacleBounds(int ObstacleIndex)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.UpdateObstacleBounds", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObstacleIndex, paramsPtr + 0);
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
    /// Function: RemoveObstacle
    /// </summary>
    public unsafe void RemoveObstacle(int ObstacleIndex)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.RemoveObstacle", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObstacleIndex, paramsPtr + 0);
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
    /// Function: AddObstacle
    /// </summary>
    public unsafe int AddObstacle(BmSDK.Engine.Actor Obstacle, int FilterBits)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.AddObstacle", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Obstacle, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FilterBits, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetTimeOnLink
    /// </summary>
    public unsafe float GetTimeOnLink(int LinkIndex, System.Numerics.Vector3 TestLocation, bool ClampTime = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.GetTimeOnLink", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClampTime, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: ChooseClosestLinkFromPointToPosition
    /// </summary>
    public unsafe int ChooseClosestLinkFromPointToPosition(int StartPoint, int ExcludeLink, bool NoDeadEnds, out int LinkEndPoint, System.Numerics.Vector3 Position, out BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction Restrictions)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.ChooseClosestLinkFromPointToPosition", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExcludeLink, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NoDeadEnds, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        LinkEndPoint = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 12);
        Restrictions = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction>(paramsPtr + 28);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 196);
    }

    /// <summary>
    /// Function: ChooseRandomLinkFromPoint_ExcludeArray_AvoidArray
    /// </summary>
    public unsafe int ChooseRandomLinkFromPoint_ExcludeArray_AvoidArray(int StartPoint, BmSDK.TArray<int> ExcludeLinkList, bool NoDeadEnds, out int LinkEndPoint, bool CanJumpDown, bool CanJumpUp, bool TendToGoStraight, out BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction Restriction, System.Numerics.Vector3 MoveInDirection, BmSDK.TArray<System.Numerics.Vector3> AvoidLocations, BmSDK.TArray<float> AvoidLocationsConeCos, System.Numerics.Vector3 DeadEndLocation, bool bAllowUTurns, BmSDK.Engine.Actor TestActor, bool bForceDrawDebug, bool bAllowDeadEndAsFallback, int DeadEndRecursionDepth)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.ChooseRandomLinkFromPoint_ExcludeArray_AvoidArray", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExcludeLinkList, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NoDeadEnds, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CanJumpDown, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CanJumpUp, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TendToGoStraight, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveInDirection, paramsPtr + 208);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AvoidLocations, paramsPtr + 220);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AvoidLocationsConeCos, paramsPtr + 236);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeadEndLocation, paramsPtr + 252);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowUTurns, paramsPtr + 264);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestActor, paramsPtr + 268);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceDrawDebug, paramsPtr + 276);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowDeadEndAsFallback, paramsPtr + 280);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeadEndRecursionDepth, paramsPtr + 284);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        LinkEndPoint = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 24);
        Restriction = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction>(paramsPtr + 40);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 288);
    }

    /// <summary>
    /// Function: ChooseRandomLinkFromPoint_ExcludeArray
    /// </summary>
    public unsafe int ChooseRandomLinkFromPoint_ExcludeArray(int StartPoint, BmSDK.TArray<int> ExcludeLinkList, bool NoDeadEnds, out int LinkEndPoint, bool CanJumpDown, bool CanJumpUp, bool TendToGoStraight, out BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction Restriction, System.Numerics.Vector3 MoveInDirection, System.Numerics.Vector3 AvoidLocation, System.Numerics.Vector3 DeadEndLocation, bool bAllowUTurns, BmSDK.Engine.Actor TestActor, bool bForceDrawDebug, bool bAllowDeadEndAsFallback)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.ChooseRandomLinkFromPoint_ExcludeArray", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExcludeLinkList, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NoDeadEnds, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CanJumpDown, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CanJumpUp, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TendToGoStraight, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveInDirection, paramsPtr + 208);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AvoidLocation, paramsPtr + 220);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeadEndLocation, paramsPtr + 232);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowUTurns, paramsPtr + 244);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestActor, paramsPtr + 248);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceDrawDebug, paramsPtr + 256);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowDeadEndAsFallback, paramsPtr + 260);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        LinkEndPoint = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 24);
        Restriction = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction>(paramsPtr + 40);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 264);
    }

    /// <summary>
    /// Function: ChooseRandomLinkFromPoint
    /// </summary>
    public unsafe int ChooseRandomLinkFromPoint(int StartPoint, int ExcludeLink, bool NoDeadEnds, out int LinkEndPoint, bool CanJumpDown, bool CanJumpUp, bool TendToGoStraight, out BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction Restriction, System.Numerics.Vector3 MoveInDirection, System.Numerics.Vector3 AvoidLocation, System.Numerics.Vector3 DeadEndLocation, bool bAllowUTurns, BmSDK.Engine.Actor TestActor, bool bForceDrawDebug, bool bAllowDeadEndAsFallback)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.ChooseRandomLinkFromPoint", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExcludeLink, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NoDeadEnds, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CanJumpDown, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CanJumpUp, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TendToGoStraight, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveInDirection, paramsPtr + 196);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AvoidLocation, paramsPtr + 208);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeadEndLocation, paramsPtr + 220);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowUTurns, paramsPtr + 232);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestActor, paramsPtr + 236);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceDrawDebug, paramsPtr + 244);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowDeadEndAsFallback, paramsPtr + 248);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        LinkEndPoint = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 12);
        Restriction = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction>(paramsPtr + 28);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 252);
    }

    /// <summary>
    /// Function: RefineRacingLine
    /// </summary>
    public unsafe bool RefineRacingLine(out BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FRacingLineSeg> RacingLine, out BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FRoadNetworkSpan> Spans, BmSDK.BmGame.RVehicle Vehicle, System.Numerics.Vector3 StartLoc, System.Numerics.Vector3 DriveToTarget, out BmSDK.Engine.Actor FirstObstacleAvoided, out int FirstObstacleTypeBits, float LineMinLimit, float LineMaxLimit, bool UsePavementToAvoidObstacles, int NumSpansToLookBehind)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.RefineRacingLine", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Vehicle, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLoc, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DriveToTarget, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LineMinLimit, paramsPtr + 76);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LineMaxLimit, paramsPtr + 80);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UsePavementToAvoidObstacles, paramsPtr + 84);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NumSpansToLookBehind, paramsPtr + 88);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        RacingLine = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FRacingLineSeg>>(paramsPtr + 0);
        Spans = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FRoadNetworkSpan>>(paramsPtr + 16);
        FirstObstacleAvoided = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(paramsPtr + 64);
        FirstObstacleTypeBits = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 72);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 92);
    }

    /// <summary>
    /// Function: GetRacingLine
    /// </summary>
    public unsafe void GetRacingLine(out BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FRacingLineSeg> RacingLine, out BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FRoadNetworkSpan> Spans, BmSDK.BmGame.RVehicle Vehicle, float LineMinLimit = default, float LineMaxLimit = default, bool FastInitialApproximation = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.GetRacingLine", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Vehicle, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LineMinLimit, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LineMaxLimit, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FastInitialApproximation, paramsPtr + 48);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        RacingLine = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FRacingLineSeg>>(paramsPtr + 0);
        Spans = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FRoadNetworkSpan>>(paramsPtr + 16);
        return;
    }

    /// <summary>
    /// Function: GetClosestPointOnRacingLineToPoint
    /// </summary>
    public unsafe bool GetClosestPointOnRacingLineToPoint(System.Numerics.Vector3 VehicleLoc, int FirstSpan, out BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FRacingLineSeg> RacingLine, out BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FRoadNetworkSpan> Spans, System.Numerics.Vector3 RefPoint, float MaxRadius, float MaxRouteDist, out System.Numerics.Vector3 OutPoint, out float OutRadius, out float OutRouteDist)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.GetClosestPointOnRacingLineToPoint", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VehicleLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FirstSpan, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RefPoint, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxRadius, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxRouteDist, paramsPtr + 64);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        RacingLine = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FRacingLineSeg>>(paramsPtr + 16);
        Spans = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FRoadNetworkSpan>>(paramsPtr + 32);
        OutPoint = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 68);
        OutRadius = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 80);
        OutRouteDist = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 84);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 88);
    }

    /// <summary>
    /// Function: GetClosestPointOnRouteSpansToPoint
    /// </summary>
    public unsafe void GetClosestPointOnRouteSpansToPoint(out BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FRoadNetworkSpan> RouteSpans, int FirstSpan, System.Numerics.Vector3 StartLocation, System.Numerics.Vector3 TargetLocation, out System.Numerics.Vector3 OutPoint, out int SpanIndex)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.GetClosestPointOnRouteSpansToPoint", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FirstSpan, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLocation, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        RouteSpans = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FRoadNetworkSpan>>(paramsPtr + 0);
        OutPoint = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 44);
        SpanIndex = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 56);
        return;
    }

    /// <summary>
    /// Function: GetClosestRouteLinkToPoint
    /// </summary>
    public unsafe int GetClosestRouteLinkToPoint(out BmSDK.TArray<int> Route, int RouteStart, System.Numerics.Vector3 TargetLocation, int MaxIndexInRoute, out int OutLinkStartPoint, out int OutLinkIndexInRoute, System.Numerics.Vector3 TargetDirection)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.GetClosestRouteLinkToPoint", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RouteStart, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxIndexInRoute, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetDirection, paramsPtr + 44);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Route = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(paramsPtr + 0);
        OutLinkStartPoint = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 36);
        OutLinkIndexInRoute = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 40);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 56);
    }

    /// <summary>
    /// Function: GetRouteSpans
    /// </summary>
    public unsafe int GetRouteSpans(out BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FRoadNetworkSpan> Spans, out BmSDK.TArray<int> Route, int StartPoint, System.Numerics.Vector3 EndPoint, float VehicleHalfWidth, bool ObeyTheLaw, BmSDK.BmGame.RRoadNetwork.EUsePavementMode UsePavement, bool ObeyLaneObstacles = default, int MaxSpans = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.GetRouteSpans", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPoint, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndPoint, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VehicleHalfWidth, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObeyTheLaw, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UsePavement, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObeyLaneObstacles, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxSpans, paramsPtr + 64);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Spans = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FRoadNetworkSpan>>(paramsPtr + 0);
        Route = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 68);
    }

    /// <summary>
    /// Function: GetNearestStreamedInLinkPoint
    /// </summary>
    public unsafe bool GetNearestStreamedInLinkPoint(out System.Numerics.Vector3 Loc, out BmSDK.Rotator Rot, System.Numerics.Vector3 RefPt, float MaxRangeXY, float MaxRangeZ, float MinDistFromStreamingEdge, float ClearDistFromStreamingEdge)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.GetNearestStreamedInLinkPoint", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RefPt, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxRangeXY, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxRangeZ, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinDistFromStreamingEdge, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClearDistFromStreamingEdge, paramsPtr + 48);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Loc = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        Rot = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 52);
    }

    /// <summary>
    /// Function: TrimRouteStartToFurthestStreamedInPoint
    /// </summary>
    public unsafe bool TrimRouteStartToFurthestStreamedInPoint(out BmSDK.TArray<int> Route, out int StartPoint, BmSDK.BmGame.RVehicleBatmobileBase Batmobile, float MinDistFromStreamingEdge, float ClearDistFromStreamingEdge)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.TrimRouteStartToFurthestStreamedInPoint", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Batmobile, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinDistFromStreamingEdge, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClearDistFromStreamingEdge, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Route = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(paramsPtr + 0);
        StartPoint = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 36);
    }

    /// <summary>
    /// Function: TrimRouteStartToNearestHiddenPoint
    /// </summary>
    public unsafe bool TrimRouteStartToNearestHiddenPoint(out BmSDK.TArray<int> Route, out int StartPoint, System.Numerics.Vector3 CameraLoc, System.Numerics.Vector3 CameraDir, float MinTrimRangeXY)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.TrimRouteStartToNearestHiddenPoint", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraLoc, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraDir, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinTrimRangeXY, paramsPtr + 44);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Route = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(paramsPtr + 0);
        StartPoint = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 48);
    }

    /// <summary>
    /// Function: GetLookAheadOnRoute
    /// </summary>
    public unsafe bool GetLookAheadOnRoute(System.Numerics.Vector3 Origin, BmSDK.TArray<int> Route, int RouteStartPt, float LookAheadDist, out System.Numerics.Vector3 Position, out System.Numerics.Vector3 Direction, out int LinkIndex)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.GetLookAheadOnRoute", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Origin, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Route, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RouteStartPt, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LookAheadDist, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Position = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 36);
        Direction = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 48);
        LinkIndex = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 60);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 64);
    }

    /// <summary>
    /// Function: GetStraightLineRoute
    /// </summary>
    public unsafe bool GetStraightLineRoute(out BmSDK.TArray<int> Route, int StartVertex, System.Numerics.Vector3 Direction, float CosMaxAngle, float MaxDistance)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.GetStraightLineRoute", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartVertex, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CosMaxAngle, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxDistance, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Route = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 40);
    }

    /// <summary>
    /// Function: PlanRouteBetweenVertices
    /// </summary>
    public unsafe bool PlanRouteBetweenVertices(out BmSDK.TArray<int> Route, int StartVertex, int EndVertex, bool ObeyTheLaw, bool CanJumpDown, bool CanJumpUp, int ExcludeLink, out BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction Restriction, int PreferFirstLink, bool OutputPartialRoute, out float TotalCost)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.PlanRouteBetweenVertices", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartVertex, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndVertex, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObeyTheLaw, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CanJumpDown, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CanJumpUp, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExcludeLink, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreferFirstLink, paramsPtr + 208);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutputPartialRoute, paramsPtr + 212);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Route = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(paramsPtr + 0);
        Restriction = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction>(paramsPtr + 40);
        TotalCost = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 216);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 220);
    }

    /// <summary>
    /// Function: PlanRoute
    /// </summary>
    public unsafe bool PlanRoute(out BmSDK.TArray<int> Route, out int StartPoint, int StartLink, float StartT, int EndLink, float EndT, bool ObeyTheLaw, bool CanJumpDown, bool CanJumpUp, out BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction Restriction, bool OutputPartialRoute, out float TotalCost)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.PlanRoute", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLink, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartT, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndLink, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndT, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObeyTheLaw, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CanJumpDown, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CanJumpUp, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutputPartialRoute, paramsPtr + 216);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Route = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(paramsPtr + 0);
        StartPoint = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
        Restriction = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction>(paramsPtr + 48);
        TotalCost = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 220);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 224);
    }

    /// <summary>
    /// Function: GetLinkEndPointInDirection
    /// </summary>
    public unsafe int GetLinkEndPointInDirection(int LinkIndex, System.Numerics.Vector3 ReferenceDir, out BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction Restriction)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.GetLinkEndPointInDirection", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReferenceDir, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Restriction = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 184);
    }

    /// <summary>
    /// Function: GetAllVerticesInRange
    /// </summary>
    public unsafe int GetAllVerticesInRange(out BmSDK.TArray<int> VertList, System.Numerics.Vector3 ReferencePoint, float MaxXYOffset, float MinZOffset, float MaxZOffset, out BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction Restriction)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.GetAllVerticesInRange", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReferencePoint, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxXYOffset, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinZOffset, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxZOffset, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        VertList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(paramsPtr + 0);
        Restriction = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction>(paramsPtr + 40);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 208);
    }

    /// <summary>
    /// Function: GetNearestVertex
    /// </summary>
    public unsafe int GetNearestVertex(System.Numerics.Vector3 ReferencePoint, float MaxXYOffset, float MinZOffset, float MaxZOffset, out BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction Restriction)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.GetNearestVertex", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReferencePoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxXYOffset, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinZOffset, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxZOffset, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Restriction = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 192);
    }

    /// <summary>
    /// Function: GetNearestPointDirectionalBias
    /// </summary>
    public unsafe int GetNearestPointDirectionalBias(out float LinkTime, System.Numerics.Vector3 ReferencePoint, System.Numerics.Vector3 BiasDir, float BiasAmount, float MaxXYOffset, float MinZOffset, float MaxZOffset, out BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction Restriction, int LinkBias, int LinkBias2, float LinkBiasAmount, bool AllowDisabledLinks, float DefaultZBias)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.GetNearestPointDirectionalBias", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReferencePoint, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BiasDir, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BiasAmount, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxXYOffset, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinZOffset, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxZOffset, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkBias, paramsPtr + 212);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkBias2, paramsPtr + 216);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LinkBiasAmount, paramsPtr + 220);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AllowDisabledLinks, paramsPtr + 224);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DefaultZBias, paramsPtr + 228);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        LinkTime = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
        Restriction = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction>(paramsPtr + 44);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 232);
    }

    /// <summary>
    /// Function: GetLinksFromLocation
    /// </summary>
    public unsafe bool GetLinksFromLocation(out BmSDK.TArray<int> out_Links, System.Numerics.Vector3 TestLocation, out BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction Restriction)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.GetLinksFromLocation", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLocation, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_Links = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(paramsPtr + 0);
        Restriction = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction>(paramsPtr + 28);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 196);
    }

    /// <summary>
    /// Function: GetNearestPoint2D
    /// </summary>
    public unsafe int GetNearestPoint2D(out float LinkTime, System.Numerics.Vector3 ReferencePoint, float MaxXYOffset, float MinZOffset, float MaxZOffset, out BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction Restriction)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.GetNearestPoint2D", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReferencePoint, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxXYOffset, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinZOffset, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxZOffset, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        LinkTime = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
        Restriction = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction>(paramsPtr + 28);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 196);
    }

    /// <summary>
    /// Function: GetNearestPoint
    /// </summary>
    public unsafe int GetNearestPoint(out float LinkTime, System.Numerics.Vector3 ReferencePoint, float MaxXYOffset, float MinZOffset, float MaxZOffset, out BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction Restriction, bool AllowDisabledLinks, float DefaultZBias)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.GetNearestPoint", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ReferencePoint, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxXYOffset, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinZOffset, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxZOffset, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AllowDisabledLinks, paramsPtr + 196);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DefaultZBias, paramsPtr + 200);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        LinkTime = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
        Restriction = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork.FRoadRouteRestriction>(paramsPtr + 28);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 204);
    }

    /// <summary>
    /// Function: SetPointLocation
    /// </summary>
    public unsafe void SetPointLocation(int PointIndex, System.Numerics.Vector3 Loc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RRoadNetwork.SetPointLocation", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PointIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 4);
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
    /// Enum: EUsePavementMode
    /// </summary>
    public enum EUsePavementMode
    {
        UPM_No = 0,
        UPM_Yes = 1,
        UPM_NearEnd = 2,
        UPM_MAX = 3,
    }

    /// <summary>
    /// Struct: FRoadNetworkTightArea
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FRoadNetworkTightArea
    {
        /// <summary>
        /// ByteProperty: Lattice
        /// </summary>
        public unsafe byte Lattice_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
        /// <summary>
        /// ByteProperty: Lattice
        /// </summary>
        public unsafe byte Lattice_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1); }; }
        }
        /// <summary>
        /// ByteProperty: Lattice
        /// </summary>
        public unsafe byte Lattice_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2); }; }
        }
        /// <summary>
        /// ByteProperty: Lattice
        /// </summary>
        public unsafe byte Lattice_3
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 3); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3); }; }
        }
        /// <summary>
        /// ByteProperty: Lattice
        /// </summary>
        public unsafe byte Lattice_4
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
        /// <summary>
        /// ByteProperty: Lattice
        /// </summary>
        public unsafe byte Lattice_5
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 5); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5); }; }
        }
        /// <summary>
        /// ByteProperty: Lattice
        /// </summary>
        public unsafe byte Lattice_6
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 6); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6); }; }
        }
        /// <summary>
        /// ByteProperty: Lattice
        /// </summary>
        public unsafe byte Lattice_7
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 7); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7); }; }
        }

        /// <summary>
        /// StructProperty: Origin
        /// </summary>
        public unsafe System.Numerics.Vector3 Origin
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: Scale
        /// </summary>
        public unsafe float Scale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FRacingLineSeg
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FRacingLineSeg
    {
        /// <summary>
        /// FloatProperty: Value
        /// </summary>
        public unsafe float Value
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: MinValue
        /// </summary>
        public unsafe float MinValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: MaxValue
        /// </summary>
        public unsafe float MaxValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ByteProperty: Sequence
        /// </summary>
        public unsafe byte Sequence
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ByteProperty: Obstacle
        /// </summary>
        public unsafe byte Obstacle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 13); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13); }; }
        }
    }

    /// <summary>
    /// Struct: FRoadNetworkSpan
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FRoadNetworkSpan
    {
        /// <summary>
        /// StructProperty: Points
        /// </summary>
        public unsafe System.Numerics.Vector3 Points_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
        /// <summary>
        /// StructProperty: Points
        /// </summary>
        public unsafe System.Numerics.Vector3 Points_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: RouteIndex
        /// </summary>
        public unsafe int RouteIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// FloatProperty: MaxHeadroom
        /// </summary>
        public unsafe float MaxHeadroom
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: ObstacleMin
        /// </summary>
        public unsafe float ObstacleMin
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: ObstacleMax
        /// </summary>
        public unsafe float ObstacleMax
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// FloatProperty: FootpathMin
        /// </summary>
        public unsafe float FootpathMin
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// FloatProperty: FootpathMax
        /// </summary>
        public unsafe float FootpathMax
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }
    }

    /// <summary>
    /// Struct: FRoadNetworkJunction
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FRoadNetworkJunction
    {
        /// <summary>
        /// StructProperty: Location
        /// </summary>
        public unsafe System.Numerics.Vector3 Location
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: Points
        /// </summary>
        public unsafe BmSDK.TArray<int> Points
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FRoadNetworkLink
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FRoadNetworkLink
    {
        /// <summary>
        /// IntProperty: Points
        /// </summary>
        public unsafe int Points_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
        /// <summary>
        /// IntProperty: Points
        /// </summary>
        public unsafe int Points_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: Next
        /// </summary>
        public unsafe int Next_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
        /// <summary>
        /// IntProperty: Next
        /// </summary>
        public unsafe int Next_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: Lanes
        /// </summary>
        public unsafe int Lanes_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
        /// <summary>
        /// IntProperty: Lanes
        /// </summary>
        public unsafe int Lanes_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// IntProperty: AltLanes
        /// </summary>
        public unsafe int AltLanes_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
        /// <summary>
        /// IntProperty: AltLanes
        /// </summary>
        public unsafe int AltLanes_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// NameProperty: StreetName
        /// </summary>
        public unsafe BmSDK.FName StreetName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// BoolProperty: IsJump
        /// </summary>
        public unsafe bool IsJump
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: IsMainRoad
        /// </summary>
        public unsafe bool IsMainRoad
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: IsArmouredRoad
        /// </summary>
        public unsafe bool IsArmouredRoad
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: IsOpenArea
        /// </summary>
        public unsafe bool IsOpenArea
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: IsOpenAreaPath
        /// </summary>
        public unsafe bool IsOpenAreaPath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: IsDisabled
        /// </summary>
        public unsafe bool IsDisabled
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 32) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: IsSharpTurn
        /// </summary>
        public unsafe bool IsSharpTurn
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 64) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: IsStairs
        /// </summary>
        public unsafe bool IsStairs
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 128) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: NoUturns
        /// </summary>
        public unsafe bool NoUturns
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 256) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: NoSkip
        /// </summary>
        public unsafe bool NoSkip
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 512) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: CantCallBatmobile
        /// </summary>
        public unsafe bool CantCallBatmobile
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 1024) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: CantSatNav
        /// </summary>
        public unsafe bool CantSatNav
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 2048) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: OnlySatNav
        /// </summary>
        public unsafe bool OnlySatNav
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 4096) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: IsUnderGround
        /// </summary>
        public unsafe bool IsUnderGround
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 8192) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: OnlyFriendly
        /// </summary>
        public unsafe bool OnlyFriendly
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 16384) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: ObstaclesBetweenLanes
        /// </summary>
        public unsafe bool ObstaclesBetweenLanes
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 32768) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: SeaWall0
        /// </summary>
        public unsafe bool SeaWall0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 65536) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: SeaWall1
        /// </summary>
        public unsafe bool SeaWall1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 131072) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: IsTouched
        /// </summary>
        public unsafe bool IsTouched
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 262144) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: IsAlt
        /// </summary>
        public unsafe bool IsAlt
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 524288) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: IsActiveChallenge
        /// </summary>
        public unsafe bool IsActiveChallenge
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 1048576) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: CantSpawn
        /// </summary>
        public unsafe bool CantSpawn
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 2097152) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: ThugsCannotFlee
        /// </summary>
        public unsafe bool ThugsCannotFlee
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 4194304) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: NoZBiasOnFindNearestPoint
        /// </summary>
        public unsafe bool NoZBiasOnFindNearestPoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 8388608) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: IsDoor
        /// </summary>
        public unsafe bool IsDoor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 16777216) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: CantSpawnBatmobile
        /// </summary>
        public unsafe bool CantSpawnBatmobile
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 33554432) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: OnlyStreaming
        /// </summary>
        public unsafe bool OnlyStreaming
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 67108864) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: IsBuddy0
        /// </summary>
        public unsafe bool IsBuddy0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 134217728) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: IsBuddy1
        /// </summary>
        public unsafe bool IsBuddy1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 268435456) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// ByteProperty: SatNavInLane
        /// </summary>
        public unsafe byte SatNavInLane
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// ByteProperty: CityDistrict
        /// </summary>
        public unsafe byte CityDistrict
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 45); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 45); }; }
        }

        /// <summary>
        /// ByteProperty: Camber
        /// </summary>
        public unsafe byte Camber
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 46); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 46); }; }
        }

        /// <summary>
        /// IntProperty: IndexInHash
        /// </summary>
        public unsafe int IndexInHash
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }
    }

    /// <summary>
    /// Struct: FRoadNetworkLane
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FRoadNetworkLane
    {
        /// <summary>
        /// StructProperty: Infos
        /// </summary>
        public unsafe BmSDK.BmGame.RRoadLink.FLaneInfo Infos_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadLink.FLaneInfo>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
        /// <summary>
        /// StructProperty: Infos
        /// </summary>
        public unsafe BmSDK.BmGame.RRoadLink.FLaneInfo Infos_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadLink.FLaneInfo>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FRoadNetworkPoint
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FRoadNetworkPoint
    {
        /// <summary>
        /// StructProperty: Location
        /// </summary>
        public unsafe System.Numerics.Vector3 Location
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: FirstLink
        /// </summary>
        public unsafe int FirstLink
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: LastRandomLink
        /// </summary>
        public unsafe int LastRandomLink
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: Junction
        /// </summary>
        public unsafe int Junction
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FRoadRouteRestriction
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FRoadRouteRestriction
    {
        /// <summary>
        /// ObjectProperty: RestrictActor
        /// </summary>
        public unsafe BmSDK.Engine.Actor RestrictActor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bVolumeRestricted
        /// </summary>
        public unsafe bool bVolumeRestricted
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8); }; }
        }

        /// <summary>
        /// ArrayProperty: ValidVolumes
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.Volume> ValidVolumes
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Volume>>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bVolumesAreInvalid
        /// </summary>
        public unsafe bool bVolumesAreInvalid
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }

        /// <summary>
        /// BoolProperty: bObeyExclusionZones
        /// </summary>
        public unsafe bool bObeyExclusionZones
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }

        /// <summary>
        /// BoolProperty: bRadiusRestricted
        /// </summary>
        public unsafe bool bRadiusRestricted
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }

        /// <summary>
        /// BoolProperty: bRadiusIsInvalid
        /// </summary>
        public unsafe bool bRadiusIsInvalid
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }

        /// <summary>
        /// StructProperty: RadiusOrigin
        /// </summary>
        public unsafe System.Numerics.Vector3 RadiusOrigin
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: Radius
        /// </summary>
        public unsafe float Radius
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// BoolProperty: MainRoadsOnly
        /// </summary>
        public unsafe bool MainRoadsOnly
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }; }
        }

        /// <summary>
        /// BoolProperty: AllowArmouredRoads
        /// </summary>
        public unsafe bool AllowArmouredRoads
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }; }
        }

        /// <summary>
        /// BoolProperty: ExcludeOpenAreas
        /// </summary>
        public unsafe bool ExcludeOpenAreas
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }; }
        }

        /// <summary>
        /// BoolProperty: ExcludeStairs
        /// </summary>
        public unsafe bool ExcludeStairs
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: MinHeadroom
        /// </summary>
        public unsafe float MinHeadroom
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// FloatProperty: MainRoadCostScale
        /// </summary>
        public unsafe float MainRoadCostScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// FloatProperty: ArmouredRoadCostScale
        /// </summary>
        public unsafe float ArmouredRoadCostScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// FloatProperty: PreferredRoadCostScale
        /// </summary>
        public unsafe float PreferredRoadCostScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// FloatProperty: OpenAreaCostScale
        /// </summary>
        public unsafe float OpenAreaCostScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// FloatProperty: TurningCostScale
        /// </summary>
        public unsafe float TurningCostScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }

        /// <summary>
        /// FloatProperty: MaxSearchDistance
        /// </summary>
        public unsafe float MaxSearchDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 76); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }; }
        }

        /// <summary>
        /// FloatProperty: FindPointDistScaleZ
        /// </summary>
        public unsafe float FindPointDistScaleZ
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// ArrayProperty: ExcludePoints
        /// </summary>
        public unsafe BmSDK.TArray<int> ExcludePoints
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// ArrayProperty: OneWayLinks
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FOneWayLink> OneWayLinks
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FOneWayLink>>(Ptr + 100); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }; }
        }

        /// <summary>
        /// ArrayProperty: CostScaleSpheres
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FCostScaleSphere> CostScaleSpheres
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FCostScaleSphere>>(Ptr + 116); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }; }
        }

        /// <summary>
        /// IntProperty: VehicleExclusionVolumesFilterIndex
        /// </summary>
        public unsafe int VehicleExclusionVolumesFilterIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }; }
        }

        /// <summary>
        /// BoolProperty: OverrideMaxTurnAngle
        /// </summary>
        public unsafe bool OverrideMaxTurnAngle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 136); }; }
        }

        /// <summary>
        /// FloatProperty: CosMaxTurnAngle
        /// </summary>
        public unsafe float CosMaxTurnAngle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 140); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }; }
        }

        /// <summary>
        /// BoolProperty: DontCrossDistrictBoundaries
        /// </summary>
        public unsafe bool DontCrossDistrictBoundaries
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 144); }; }
        }

        /// <summary>
        /// BoolProperty: PreventCrossingIntoDistrictsWithTanks
        /// </summary>
        public unsafe bool PreventCrossingIntoDistrictsWithTanks
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 144); }; }
        }

        /// <summary>
        /// BoolProperty: CallBatmobile
        /// </summary>
        public unsafe bool CallBatmobile
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 144); }; }
        }

        /// <summary>
        /// BoolProperty: SatNav
        /// </summary>
        public unsafe bool SatNav
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 144); }; }
        }

        /// <summary>
        /// BoolProperty: Challenge
        /// </summary>
        public unsafe bool Challenge
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 144); }; }
        }

        /// <summary>
        /// BoolProperty: Friendly
        /// </summary>
        public unsafe bool Friendly
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144) & 32) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 144); }; }
        }

        /// <summary>
        /// BoolProperty: Spawning
        /// </summary>
        public unsafe bool Spawning
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144) & 64) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 144); }; }
        }

        /// <summary>
        /// BoolProperty: FleeingThug
        /// </summary>
        public unsafe bool FleeingThug
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144) & 128) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 144); }; }
        }

        /// <summary>
        /// BoolProperty: AllowDisabledLinks
        /// </summary>
        public unsafe bool AllowDisabledLinks
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144) & 256) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 144); }; }
        }

        /// <summary>
        /// BoolProperty: Streaming
        /// </summary>
        public unsafe bool Streaming
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144) & 512) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 144); }; }
        }

        /// <summary>
        /// FloatProperty: InitialTurningCostScale
        /// </summary>
        public unsafe float InitialTurningCostScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 148); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }; }
        }

        /// <summary>
        /// StructProperty: InitialDir
        /// </summary>
        public unsafe System.Numerics.Vector3 InitialDir
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 152); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }; }
        }

        /// <summary>
        /// ByteProperty: GetPointInDistrict
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.EDistrict GetPointInDistrict
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EDistrict>(Ptr + 164); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }; }
        }
    }

    /// <summary>
    /// Struct: FCostScaleSphere
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FCostScaleSphere
    {
        /// <summary>
        /// StructProperty: Origin
        /// </summary>
        public unsafe System.Numerics.Vector3 Origin
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Radius
        /// </summary>
        public unsafe float Radius
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: CostScale
        /// </summary>
        public unsafe float CostScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FOneWayLink
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FOneWayLink
    {
        /// <summary>
        /// IntProperty: LinkIndex
        /// </summary>
        public unsafe int LinkIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: StartPoint
        /// </summary>
        public unsafe int StartPoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// StructProperty: HashLinks
    /// </summary>
    public unsafe System.IntPtr HashLinks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// StructProperty: HashObstacles
    /// </summary>
    public unsafe System.IntPtr HashObstacles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ArrayProperty: Points
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FRoadNetworkPoint> Points
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FRoadNetworkPoint>>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// IntProperty: NumNonBuddyPoints
    /// </summary>
    public unsafe int NumNonBuddyPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ArrayProperty: Lanes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FRoadNetworkLane> Lanes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FRoadNetworkLane>>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ArrayProperty: Links
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FRoadNetworkLink> Links
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FRoadNetworkLink>>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// ArrayProperty: Junctions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FRoadNetworkJunction> Junctions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RRoadNetwork.FRoadNetworkJunction>>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// StructProperty: Bounds
    /// </summary>
    public unsafe BmSDK.GameObject.FSimpleBox Bounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FSimpleBox>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }
}
