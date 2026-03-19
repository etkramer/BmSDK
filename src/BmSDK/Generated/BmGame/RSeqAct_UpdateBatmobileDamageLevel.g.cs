#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_UpdateBatmobileDamageLevel<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_UpdateBatmobileDamageLevel : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_UpdateBatmobileDamageLevel", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_UpdateBatmobileDamageLevel() { }

    /// <summary>
    /// Constructs a new RSeqAct_UpdateBatmobileDamageLevel
    /// </summary>
    public RSeqAct_UpdateBatmobileDamageLevel(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_UpdateBatmobileDamageLevel Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_UpdateBatmobileDamageLevel(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: PlayerBatmobileName
    /// </summary>
    public unsafe BmSDK.FName PlayerBatmobileName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// IntProperty: DamageLevel
    /// </summary>
    public unsafe int DamageLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// IntProperty: LoadSlot
    /// </summary>
    public unsafe int LoadSlot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }
}
