#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_FireFPSGunDuringMatinee<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_FireFPSGunDuringMatinee : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_FireFPSGunDuringMatinee", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_FireFPSGunDuringMatinee() { }

    /// <summary>
    /// Constructs a new RSeqAct_FireFPSGunDuringMatinee
    /// </summary>
    public RSeqAct_FireFPSGunDuringMatinee(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_FireFPSGunDuringMatinee Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_FireFPSGunDuringMatinee(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: GunFiredCount
    /// </summary>
    public unsafe int GunFiredCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// IntProperty: NumShotsToTriggerOutput
    /// </summary>
    public unsafe int NumShotsToTriggerOutput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }
}
