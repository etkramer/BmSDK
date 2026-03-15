#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: SequenceVariable<br/>
/// (size = 128)
/// (flags = 134217875)
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
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SequenceVariable(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: VarName
    /// </summary>
    public unsafe BmSDK.FName VarName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }
}
