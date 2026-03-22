#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: SeqCond_SwitchBase<br/>
/// (size = 180)
/// (flags = 134218387)
/// </summary>
public partial class SeqCond_SwitchBase : BmSDK.Engine.SequenceCondition, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqCond_SwitchBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqCond_SwitchBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqCond_SwitchBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: RemoveValueEntry
    /// </summary>
    public unsafe virtual void RemoveValueEntry(int RemoveIndex)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.SeqCond_SwitchBase.RemoveValueEntry", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RemoveIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InsertValueEntry
    /// </summary>
    public unsafe virtual void InsertValueEntry(int InsertIndex)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.SeqCond_SwitchBase.InsertValueEntry", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InsertIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsFallThruEnabled
    /// </summary>
    public unsafe virtual bool IsFallThruEnabled(int ValueIndex)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.SeqCond_SwitchBase.IsFallThruEnabled", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ValueIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: VerifyDefaultCaseValue
    /// </summary>
    public unsafe virtual void VerifyDefaultCaseValue()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.SeqCond_SwitchBase.VerifyDefaultCaseValue", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
