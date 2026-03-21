#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAEC_Search<br/>
/// (size = 452)
/// (flags = 8388626)
/// </summary>
public partial class RAEC_Search : BmSDK.BmGame.RAEC_SearchBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAEC_Search", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAEC_Search() { }

    /// <summary>
    /// Constructs a new RAEC_Search
    /// </summary>
    public RAEC_Search(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAEC_Search Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAEC_Search(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Search>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Search>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Search>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Search>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Search>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAEC_Search>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAEC_Search>
        => ((GameObject)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: ReassignToPredatorPoint
    /// </summary>
    public unsafe virtual void ReassignToPredatorPoint(BmSDK.BmGame.RAEC_Search_Sub PointLeader, BmSDK.BmGame.RPredatorSpecialMovePointBase PredatorPoint)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RAEC_Search.ReassignToPredatorPoint", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PointLeader, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PredatorPoint, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ReassignToCornerTerrified
    /// </summary>
    public unsafe virtual void ReassignToCornerTerrified(BmSDK.BmGame.RAEC_Search_Sub_Terrified CornerLeader, BmSDK.BmGame.RCornerWallMarker StartCorner, BmSDK.BmGame.RCornerWallMarker EndCorner)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RAEC_Search.ReassignToCornerTerrified", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CornerLeader, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartCorner, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndCorner, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ReassignToRailPeek
    /// </summary>
    public unsafe virtual void ReassignToRailPeek(BmSDK.BmGame.RAEC_Search_Sub PeekLeader, BmSDK.BmGame.RBMPathNode_FenceJump FenceNode, System.Numerics.Vector3 StartPoint)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RAEC_Search.ReassignToRailPeek", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PeekLeader, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FenceNode, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPoint, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ReassignToCorner
    /// </summary>
    public unsafe virtual void ReassignToCorner(BmSDK.BmGame.RAEC_Search_Sub CornerLeader, BmSDK.BmGame.RCornerWallMarker StartCorner, BmSDK.BmGame.RCornerWallMarker EndCorner)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RAEC_Search.ReassignToCorner", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CornerLeader, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartCorner, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndCorner, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AssignFromTerrorCorner
    /// </summary>
    public unsafe virtual void AssignFromTerrorCorner(BmSDK.BmGame.RBMAIController NewMember, BmSDK.BmGame.RAEC_Search_Sub.FRestoreSearchState OldState)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RAEC_Search.AssignFromTerrorCorner", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldState, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AssignFromFollow
    /// </summary>
    public unsafe override void AssignFromFollow(BmSDK.BmGame.RBMAIController NewMember, BmSDK.BmGame.RAEC_Search_Sub.FRestoreSearchState OldState)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RAEC_Search.AssignFromFollow", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldState, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AssignToSniperPoint
    /// </summary>
    public unsafe virtual void AssignToSniperPoint(BmSDK.BmGame.RBMAIController NewMember)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RAEC_Search.AssignToSniperPoint", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AssignToSmashGenerators
    /// </summary>
    public unsafe virtual void AssignToSmashGenerators(BmSDK.BmGame.RBMAIController NewMember)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RAEC_Search.AssignToSmashGenerators", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AssignToSmashGargoyles
    /// </summary>
    public unsafe virtual void AssignToSmashGargoyles(BmSDK.BmGame.RBMAIController NewMember)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RAEC_Search.AssignToSmashGargoyles", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AssignFromThermalFail
    /// </summary>
    public unsafe virtual void AssignFromThermalFail(BmSDK.BmGame.RBMAIController NewMember)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RAEC_Search.AssignFromThermalFail", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Assign
    /// </summary>
    public unsafe override void Assign(BmSDK.BmGame.RBMAIController NewMember, bool bFirstAttempt = default, bool bHasHintLoc = default, System.Numerics.Vector3 HintLoc = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RAEC_Search.Assign", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFirstAttempt, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHasHintLoc, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HintLoc, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AssignToImmiediateSmash
    /// </summary>
    public unsafe virtual void AssignToImmiediateSmash(BmSDK.BmGame.RBMAIController NewMember)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RAEC_Search.AssignToImmiediateSmash", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AssignToGuard
    /// </summary>
    public unsafe virtual void AssignToGuard(BmSDK.BmGame.RBMAIController NewMember)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RAEC_Search.AssignToGuard", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMember, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SendToGuardPoint
    /// </summary>
    public unsafe virtual void SendToGuardPoint(BmSDK.BmGame.RBMAIController NewGuardCon, BmSDK.BmGame.RGuardPoint GuardPoint)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RAEC_Search.SendToGuardPoint", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGuardCon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GuardPoint, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanSnipe
    /// </summary>
    public unsafe override bool CanSnipe()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RAEC_Search.CanSnipe", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetNewFearLevel
    /// </summary>
    public unsafe override void SetNewFearLevel(BmSDK.BmGame.RBMRoomAIState.VillainFearLevel FearLevel)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RAEC_Search.SetNewFearLevel", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FearLevel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
