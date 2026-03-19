#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqVar_Int<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SeqVar_Int : BmSDK.Engine.SequenceVariable, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqVar_Int", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqVar_Int() { }

    /// <summary>
    /// Constructs a new SeqVar_Int
    /// </summary>
    public SeqVar_Int(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqVar_Int Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqVar_Int(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: IntValue
    /// </summary>
    public unsafe int IntValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }
}
