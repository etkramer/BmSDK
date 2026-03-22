#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqVar_External<br/>
/// (size = 144)
/// (flags = 134217874)
/// </summary>
public partial class SeqVar_External : BmSDK.Engine.SequenceVariable, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqVar_External", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqVar_External() { }

    /// <summary>
    /// Constructs a new SeqVar_External
    /// </summary>
    public SeqVar_External(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqVar_External Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqVar_External(nint ptr) : base(ptr) { }

    /// <summary>
    /// ClassProperty: ExpectedType
    /// </summary>
    public unsafe BmSDK.Class ExpectedType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// StrProperty: VariableLabel
    /// </summary>
    public unsafe BmSDK.FString VariableLabel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }
}
