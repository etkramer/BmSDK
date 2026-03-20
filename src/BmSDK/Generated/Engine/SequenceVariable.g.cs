#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SequenceVariable<br/>
/// (flags = 0)
/// </summary>
public partial class SequenceVariable : BmSDK.Engine.SequenceObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SequenceVariable", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SequenceVariable() { }

    /// <summary>
    /// Constructs a new SequenceVariable
    /// </summary>
    public SequenceVariable(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SequenceVariable Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SequenceVariable(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: VarName
    /// </summary>
    public unsafe BmSDK.FName VarName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }
}
