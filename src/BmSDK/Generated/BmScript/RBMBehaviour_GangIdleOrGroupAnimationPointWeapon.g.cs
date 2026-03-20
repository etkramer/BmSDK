#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMBehaviour_GangIdleOrGroupAnimationPointWeapon<br/>
/// (size = 956)
/// (flags = 8210)
/// </summary>
public partial class RBMBehaviour_GangIdleOrGroupAnimationPointWeapon : BmSDK.BmScript.RBMBehaviour_GangIdleOrGroupAnimationPoint, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMBehaviour_GangIdleOrGroupAnimationPointWeapon", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_GangIdleOrGroupAnimationPointWeapon() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_GangIdleOrGroupAnimationPointWeapon
    /// </summary>
    public RBMBehaviour_GangIdleOrGroupAnimationPointWeapon(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_GangIdleOrGroupAnimationPointWeapon Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_GangIdleOrGroupAnimationPointWeapon(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetAnimationForPaired
    /// </summary>
    public unsafe override BmSDK.BmGame.RAnimConfig.FCustomAnimConfig GetAnimationForPaired(BmSDK.FName AnimationName, int Index)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMBehaviour_GangIdleOrGroupAnimationPointWeapon.GetAnimationForPaired", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimationName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimConfig.FCustomAnimConfig>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetAnimation
    /// </summary>
    public unsafe override BmSDK.BmGame.RAnimConfig.FCustomAnimConfig GetAnimation(BmSDK.FName AnimationName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMBehaviour_GangIdleOrGroupAnimationPointWeapon.GetAnimation", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimationName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimConfig.FCustomAnimConfig>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GetRandomAnimationFromArrayForPaired
    /// </summary>
    public unsafe override BmSDK.BmGame.RAnimConfig.FCustomAnimConfig GetRandomAnimationFromArrayForPaired(BmSDK.TArray<BmSDK.FName> AnimationArray, int Index)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMBehaviour_GangIdleOrGroupAnimationPointWeapon.GetRandomAnimationFromArrayForPaired", true);
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimationArray, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimConfig.FCustomAnimConfig>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: GetRandomAnimationFromArray
    /// </summary>
    public unsafe override BmSDK.BmGame.RAnimConfig.FCustomAnimConfig GetRandomAnimationFromArray(BmSDK.TArray<BmSDK.FName> AnimationArray)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMBehaviour_GangIdleOrGroupAnimationPointWeapon.GetRandomAnimationFromArray", true);
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimationArray, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimConfig.FCustomAnimConfig>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: GetWeaponAnimationSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetWeaponAnimationSet()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMBehaviour_GangIdleOrGroupAnimationPointWeapon.GetWeaponAnimationSet", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetInitialState
    /// </summary>
    public unsafe override void SetInitialState()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMBehaviour_GangIdleOrGroupAnimationPointWeapon.SetInitialState", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetRunVariants
    /// </summary>
    public unsafe override void SetRunVariants(BmSDK.BmGame.RBMAIAction_RiotRunBase MoveAction)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMBehaviour_GangIdleOrGroupAnimationPointWeapon.SetRunVariants", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CreateRunVariantWeaponConfig
    /// </summary>
    public unsafe override BmSDK.BmGame.RWeaponConfig CreateRunVariantWeaponConfig()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMBehaviour_GangIdleOrGroupAnimationPointWeapon.CreateRunVariantWeaponConfig", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 0);
    }

    /// <summary>
    /// ObjectProperty: PickedWeaponAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet PickedWeaponAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }
}
