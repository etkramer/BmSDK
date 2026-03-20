#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_AddBatmobileWeapon<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_AddBatmobileWeapon : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_AddBatmobileWeapon", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_AddBatmobileWeapon() { }

    /// <summary>
    /// Constructs a new RSeqAct_AddBatmobileWeapon
    /// </summary>
    public RSeqAct_AddBatmobileWeapon(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_AddBatmobileWeapon Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_AddBatmobileWeapon(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: BatmobileWeapon
    /// </summary>
    public unsafe BmSDK.FString BatmobileWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
}
