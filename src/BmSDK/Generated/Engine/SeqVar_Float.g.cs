#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqVar_Float<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SeqVar_Float : BmSDK.Engine.SequenceVariable, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqVar_Float", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqVar_Float() { }

    /// <summary>
    /// Constructs a new SeqVar_Float
    /// </summary>
    public SeqVar_Float(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqVar_Float Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqVar_Float(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: FloatValue
    /// </summary>
    public unsafe float FloatValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }
}
