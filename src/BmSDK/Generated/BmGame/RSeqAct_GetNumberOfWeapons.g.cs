#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_GetNumberOfWeapons<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_GetNumberOfWeapons : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_GetNumberOfWeapons", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_GetNumberOfWeapons() { }

    /// <summary>
    /// Constructs a new RSeqAct_GetNumberOfWeapons
    /// </summary>
    public RSeqAct_GetNumberOfWeapons(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_GetNumberOfWeapons Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_GetNumberOfWeapons(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: NumWeapons
    /// </summary>
    public unsafe int NumWeapons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
}
