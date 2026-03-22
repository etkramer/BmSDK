#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqAct_SetMatInstScalarParam<br/>
/// (size = 220)
/// (flags = 134226066)
/// </summary>
public partial class SeqAct_SetMatInstScalarParam : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqAct_SetMatInstScalarParam", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_SetMatInstScalarParam() { }

    /// <summary>
    /// Constructs a new SeqAct_SetMatInstScalarParam
    /// </summary>
    public SeqAct_SetMatInstScalarParam(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_SetMatInstScalarParam Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_SetMatInstScalarParam(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: MatInst
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant MatInst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// NameProperty: ParamName
    /// </summary>
    public unsafe BmSDK.FName ParamName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// FloatProperty: ScalarValue
    /// </summary>
    public unsafe float ScalarValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }
}
