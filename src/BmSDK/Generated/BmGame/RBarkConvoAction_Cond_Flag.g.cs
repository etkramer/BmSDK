#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBarkConvoAction_Cond_Flag<br/>
/// (flags = 0)
/// </summary>
public partial class RBarkConvoAction_Cond_Flag : BmSDK.BmGame.RBarkConvoActionCond, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBarkConvoAction_Cond_Flag", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBarkConvoAction_Cond_Flag() { }

    /// <summary>
    /// Constructs a new RBarkConvoAction_Cond_Flag
    /// </summary>
    public RBarkConvoAction_Cond_Flag(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBarkConvoAction_Cond_Flag Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBarkConvoAction_Cond_Flag(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: FlagType
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkValDef.FlagTypeEnum FlagType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkValDef.FlagTypeEnum>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }
}
