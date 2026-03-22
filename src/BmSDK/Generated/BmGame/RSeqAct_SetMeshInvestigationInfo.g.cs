#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_SetMeshInvestigationInfo<br/>
/// (size = 220)
/// (flags = 134226066)
/// </summary>
public partial class RSeqAct_SetMeshInvestigationInfo : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_SetMeshInvestigationInfo", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_SetMeshInvestigationInfo() { }

    /// <summary>
    /// Constructs a new RSeqAct_SetMeshInvestigationInfo
    /// </summary>
    public RSeqAct_SetMeshInvestigationInfo(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_SetMeshInvestigationInfo Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_SetMeshInvestigationInfo(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqAct_SetMeshInvestigationInfo.GetObjClassVersion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: Set
    /// </summary>
    public unsafe virtual void Set()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqAct_SetMeshInvestigationInfo.Set", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: Act
    /// </summary>
    public unsafe BmSDK.Engine.Actor Act
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// ArrayProperty: NewInfo
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor.FInvestigationData> NewInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor.FInvestigationData>>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }
}
