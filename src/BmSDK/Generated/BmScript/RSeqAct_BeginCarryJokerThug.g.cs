#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_BeginCarryJokerThug<br/>
/// (size = 485)
/// (flags = 8722)
/// </summary>
public partial class RSeqAct_BeginCarryJokerThug : BmSDK.BmGame.RSeqAct_BeginCarryJokerThugBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_BeginCarryJokerThug", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_BeginCarryJokerThug() { }

    /// <summary>
    /// Constructs a new RSeqAct_BeginCarryJokerThug
    /// </summary>
    public RSeqAct_BeginCarryJokerThug(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_BeginCarryJokerThug Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_BeginCarryJokerThug(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_BeginCarryJokerThug.GetObjClassVersion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: Update
    /// </summary>
    public unsafe bool Update(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_BeginCarryJokerThug.Update", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: TryPlayCustomAdditiveHarley
    /// </summary>
    public unsafe void TryPlayCustomAdditiveHarley()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_BeginCarryJokerThug.TryPlayCustomAdditiveHarley", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetMovePoint
    /// </summary>
    public unsafe void SetMovePoint(int JokerType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_BeginCarryJokerThug.SetMovePoint", true);
        byte* paramsPtr = stackalloc byte[88];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JokerType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DestroyWeapons
    /// </summary>
    public unsafe void DestroyWeapons()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_BeginCarryJokerThug.DestroyWeapons", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Activated
    /// </summary>
    public unsafe void Activated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_BeginCarryJokerThug.Activated", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AttachJoker
    /// </summary>
    public unsafe void AttachJoker(int JokerType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_BeginCarryJokerThug.AttachJoker", true);
        byte* paramsPtr = stackalloc byte[460];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JokerType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddBatWalkIfCan
    /// </summary>
    public unsafe void AddBatWalkIfCan(BmSDK.BmScript.RSeqAct_BeginCarryJokerThug.JokerTypes JokerType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_BeginCarryJokerThug.AddBatWalkIfCan", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JokerType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PutDownJoker
    /// </summary>
    public unsafe void PutDownJoker(BmSDK.BmScript.RSeqAct_BeginCarryJokerThug.JokerTypes JokerType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_BeginCarryJokerThug.PutDownJoker", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JokerType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RemoveBatWalk
    /// </summary>
    public unsafe void RemoveBatWalk()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_BeginCarryJokerThug.RemoveBatWalk", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: JokerTypes
    /// </summary>
    public enum JokerTypes
    {
        JT_None = 0,
        JT_Cop = 1,
        JT_Elvis = 2,
        JT_Teacher = 3,
        JT_Harley = 4,
        JT_MAX = 5,
    }

    /// <summary>
    /// ObjectProperty: BatmanCarryCop
    /// </summary>
    public unsafe BmSDK.BmScript.RBMWeaponBatmanCarryJokerCop BatmanCarryCop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RBMWeaponBatmanCarryJokerCop>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// ObjectProperty: BatmanCarryElvis
    /// </summary>
    public unsafe BmSDK.BmScript.RBMWeaponBatmanCarryJokerElvis BatmanCarryElvis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RBMWeaponBatmanCarryJokerElvis>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// ObjectProperty: BatmanCarryTeacherOrHarley
    /// </summary>
    public unsafe BmSDK.BmScript.RBMWeaponBatmanCarryJokerTeacherOrHarley BatmanCarryTeacherOrHarley
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RBMWeaponBatmanCarryJokerTeacherOrHarley>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// ObjectProperty: SavedPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer SavedPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// ObjectProperty: TieUpPoint
    /// </summary>
    public unsafe BmSDK.Engine.Actor TieUpPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// ObjectProperty: MovePoint
    /// </summary>
    public unsafe BmSDK.Engine.Actor MovePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// BoolProperty: bPickingup
    /// </summary>
    public unsafe bool bPickingup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 440); }
    }

    /// <summary>
    /// BoolProperty: bPuttingDown
    /// </summary>
    public unsafe bool bPuttingDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 440); }
    }

    /// <summary>
    /// BoolProperty: bOtherPawn
    /// </summary>
    public unsafe bool bOtherPawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 440); }
    }

    /// <summary>
    /// BoolProperty: bInstant
    /// </summary>
    public unsafe bool bInstant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 440); }
    }

    /// <summary>
    /// BoolProperty: bIsTied
    /// </summary>
    public unsafe bool bIsTied
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 440); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreSocketAttach
    /// </summary>
    public unsafe bool bIgnoreSocketAttach
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 440); }
    }

    /// <summary>
    /// BoolProperty: bGlobalAdditive
    /// </summary>
    public unsafe bool bGlobalAdditive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 440); }
    }

    /// <summary>
    /// StructProperty: AttachOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 AttachOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// StructProperty: AttachRot
    /// </summary>
    public unsafe BmSDK.Rotator AttachRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// ArrayProperty: HarleyAdditives
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> HarleyAdditives
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// ByteProperty: SavedJokerType
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_BeginCarryJokerThug.JokerTypes SavedJokerType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_BeginCarryJokerThug.JokerTypes>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }
}
