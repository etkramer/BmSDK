#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqAct_MITV_Activate<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SeqAct_MITV_Activate : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqAct_MITV_Activate", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_MITV_Activate() { }

    /// <summary>
    /// Constructs a new SeqAct_MITV_Activate
    /// </summary>
    public SeqAct_MITV_Activate(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_MITV_Activate Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_MITV_Activate(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: DurationOfMITV
    /// </summary>
    public unsafe float DurationOfMITV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
}
