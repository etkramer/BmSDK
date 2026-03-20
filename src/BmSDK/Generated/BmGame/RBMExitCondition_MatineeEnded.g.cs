#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMExitCondition_MatineeEnded<br/>
/// (size = 445)
/// (flags = 8210)
/// </summary>
public partial class RBMExitCondition_MatineeEnded : BmSDK.BmGame.RBMExitCondition, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMExitCondition_MatineeEnded", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMExitCondition_MatineeEnded() { }

    /// <summary>
    /// Constructs a new RBMExitCondition_MatineeEnded
    /// </summary>
    public RBMExitCondition_MatineeEnded(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMExitCondition_MatineeEnded Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMExitCondition_MatineeEnded(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: MatineeBlendOutStarted
    /// </summary>
    public unsafe virtual void MatineeBlendOutStarted()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMExitCondition_MatineeEnded.MatineeBlendOutStarted", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: MatineeControlFinished
    /// </summary>
    public unsafe virtual void MatineeControlFinished()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMExitCondition_MatineeEnded.MatineeControlFinished", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ByteProperty: TriggerType
    /// </summary>
    public unsafe BmSDK.BmGame.RBMExitCondition_MatineeEnded.EMatineeEndedType TriggerType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMExitCondition_MatineeEnded.EMatineeEndedType>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// Enum: EMatineeEndedType
    /// </summary>
    public enum EMatineeEndedType
    {
        EMATINEE_BlendStartedOrMatineeFinished = 0,
        EMATINEE_BlendStarted = 1,
        EMATINEE_MatineeFinished = 2,
        EMATINEE_MAX = 3,
    }
}
