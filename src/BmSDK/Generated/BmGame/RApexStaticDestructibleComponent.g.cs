#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RApexStaticDestructibleComponent<br/>
/// (flags = 0)
/// </summary>
public partial class RApexStaticDestructibleComponent : BmSDK.Engine.ApexStaticDestructibleComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RApexStaticDestructibleComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RApexStaticDestructibleComponent() { }

    /// <summary>
    /// Constructs a new RApexStaticDestructibleComponent
    /// </summary>
    public RApexStaticDestructibleComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RApexStaticDestructibleComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RApexStaticDestructibleComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetSocketWorldLocationAndRotation
    /// </summary>
    public unsafe bool GetSocketWorldLocationAndRotation(BmSDK.FName InSocketName, out System.Numerics.Vector3 OutLocation, out BmSDK.Rotator OutRotation, int Space)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RApexStaticDestructibleComponent.GetSocketWorldLocationAndRotation", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSocketName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Space, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 8);
        OutRotation = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 20);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 36);
    }

    /// <summary>
    /// Function: CalculateStaticCollisionBoundingBox
    /// </summary>
    public unsafe void CalculateStaticCollisionBoundingBox(out BmSDK.GameObject.FMatrix OutBoundsTransform, out System.Numerics.Vector3 OutBoundsHalfExtents)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RApexStaticDestructibleComponent.CalculateStaticCollisionBoundingBox", true);
        byte* paramsPtr = stackalloc byte[64];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutBoundsTransform = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FMatrix>(paramsPtr + 0);
        OutBoundsHalfExtents = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 64);
        return;
    }

    /// <summary>
    /// Function: LoadDamageStateFromSaveGame
    /// </summary>
    public unsafe void LoadDamageStateFromSaveGame()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RApexStaticDestructibleComponent.LoadDamageStateFromSaveGame", true);
        byte* paramsPtr = stackalloc byte[64];
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
    /// FloatProperty: InitialSupportArea
    /// </summary>
    public unsafe float InitialSupportArea
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// FloatProperty: MinimumAmountOfSupportToRemainStanding
    /// </summary>
    public unsafe float MinimumAmountOfSupportToRemainStanding
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bUsingReducedValidBounds
    /// </summary>
    public unsafe bool bUsingReducedValidBounds
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 716) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 716); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 716); }
    }

    /// <summary>
    /// BoolProperty: bValidPlayerNavigationGeomtry
    /// </summary>
    public unsafe bool bValidPlayerNavigationGeomtry
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 716) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 716); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 716); }
    }

    /// <summary>
    /// IntProperty: NumFracturedDestructibleChunks
    /// </summary>
    public unsafe int NumFracturedDestructibleChunks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// IntProperty: ForceRemoveChunksInGroupOnFirstDamage
    /// </summary>
    public unsafe int ForceRemoveChunksInGroupOnFirstDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// StructProperty: PlayerNavigationGeometry
    /// </summary>
    public unsafe BmSDK.Engine.KMeshProps.FKAggregateGeom PlayerNavigationGeometry
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.KMeshProps.FKAggregateGeom>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// FloatProperty: ValidBoundsExtentsBelowGround
    /// </summary>
    public unsafe float ValidBoundsExtentsBelowGround
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// ClassProperty: ChainGunDamageType
    /// </summary>
    public unsafe BmSDK.Class ChainGunDamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }
}
