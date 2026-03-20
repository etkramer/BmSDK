#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqVar_DDAIntValue<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqVar_DDAIntValue : BmSDK.Engine.SeqVar_Int, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqVar_DDAIntValue", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqVar_DDAIntValue() { }

    /// <summary>
    /// Constructs a new RSeqVar_DDAIntValue
    /// </summary>
    public RSeqVar_DDAIntValue(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqVar_DDAIntValue Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqVar_DDAIntValue(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: IntValue
    /// </summary>
    public unsafe int IntValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }
}
