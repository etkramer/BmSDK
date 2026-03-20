#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: AkSDEntityFactPlayerInVehicleCombat<br/>
/// (flags = 0)
/// </summary>
public partial class AkSDEntityFactPlayerInVehicleCombat : BmSDK.AkAudio.AkSDEntityFact, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.AkSDEntityFactPlayerInVehicleCombat", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkSDEntityFactPlayerInVehicleCombat() { }

    /// <summary>
    /// Constructs a new AkSDEntityFactPlayerInVehicleCombat
    /// </summary>
    public AkSDEntityFactPlayerInVehicleCombat(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkSDEntityFactPlayerInVehicleCombat Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkSDEntityFactPlayerInVehicleCombat(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: FactToCheck
    /// </summary>
    public unsafe BmSDK.FString FactToCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// BoolProperty: ResetFactIfTrue
    /// </summary>
    public unsafe bool ResetFactIfTrue
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 268); }
    }
}
