#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqAct_SetMatInstVectorParam<br/>
/// (flags = 0)
/// </summary>
public partial class SeqAct_SetMatInstVectorParam : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqAct_SetMatInstVectorParam", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_SetMatInstVectorParam() { }

    /// <summary>
    /// Constructs a new SeqAct_SetMatInstVectorParam
    /// </summary>
    public SeqAct_SetMatInstVectorParam(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_SetMatInstVectorParam Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_SetMatInstVectorParam(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: MatInst
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant MatInst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ObjectProperty: ObjectPosition
    /// </summary>
    public unsafe BmSDK.GameObject ObjectPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// NameProperty: ParamName
    /// </summary>
    public unsafe BmSDK.FName ParamName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// StructProperty: VectorValue
    /// </summary>
    public unsafe BmSDK.GameObject.FLinearColor VectorValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FLinearColor>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }
}
