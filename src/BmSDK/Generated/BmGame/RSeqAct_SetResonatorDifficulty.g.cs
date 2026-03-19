#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_SetResonatorDifficulty<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_SetResonatorDifficulty : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_SetResonatorDifficulty", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_SetResonatorDifficulty() { }

    /// <summary>
    /// Constructs a new RSeqAct_SetResonatorDifficulty
    /// </summary>
    public RSeqAct_SetResonatorDifficulty(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_SetResonatorDifficulty Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_SetResonatorDifficulty(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: NewDifficulty
    /// </summary>
    public unsafe byte NewDifficulty
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ObjectProperty: DisruptableObject
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DisruptableObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }
}
