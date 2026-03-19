#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqAct_CastToFloat<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SeqAct_CastToFloat : BmSDK.Engine.SeqAct_SetSequenceVariable, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqAct_CastToFloat", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_CastToFloat() { }

    /// <summary>
    /// Constructs a new SeqAct_CastToFloat
    /// </summary>
    public SeqAct_CastToFloat(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_CastToFloat Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_CastToFloat(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: Value
    /// </summary>
    public unsafe int Value
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// FloatProperty: FloatResult
    /// </summary>
    public unsafe float FloatResult
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }
}
