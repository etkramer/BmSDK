#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_SideStory_Query<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_SideStory_Query : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_SideStory_Query", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_SideStory_Query() { }

    /// <summary>
    /// Constructs a new RSeqAct_SideStory_Query
    /// </summary>
    public RSeqAct_SideStory_Query(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_SideStory_Query Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_SideStory_Query(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_SideStory_Query.GetObjClassVersion", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CompareByValue
    /// </summary>
    public unsafe void CompareByValue(int Value)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_SideStory_Query.CompareByValue", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Activated
    /// </summary>
    public unsafe void Activated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_SideStory_Query.Activated", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// StrProperty: SideStoryName
    /// </summary>
    public unsafe BmSDK.FString SideStoryName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ByteProperty: QueryAction
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_SideStory_Query.SS_Query_Action QueryAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_SideStory_Query.SS_Query_Action>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// IntProperty: CompareValue
    /// </summary>
    public unsafe int CompareValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// StrProperty: IconNamed
    /// </summary>
    public unsafe BmSDK.FString IconNamed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// Enum: SS_Query_Action
    /// </summary>
    public enum SS_Query_Action
    {
        SS_Query_Action_None = 0,
        SS_Query_Action_SideStory_Exists = 1,
        SS_Query_Action_Locked = 2,
        SS_Query_Action_IdentityUnknown = 3,
        SS_Query_Action_HasIconNamed = 4,
        SS_Query_Action_Percentage = 5,
        SS_Query_Action_SynopsisTextId = 6,
        SS_Query_Action_ProgressTextId = 7,
        SS_Query_Action_MAX = 8,
    }

    /// <summary>
    /// Enum: SS_LinkIDs
    /// </summary>
    public enum SS_LinkIDs
    {
        SS_LinkID_LT = 0,
        SS_LinkID_LTEQ = 1,
        SS_LinkID_EQ = 2,
        SS_LinkID_NEQ = 3,
        SS_LinkID_GTEQ = 4,
        SS_LinkID_GT = 5,
        SS_LinkID_MAX = 6,
    }
}
