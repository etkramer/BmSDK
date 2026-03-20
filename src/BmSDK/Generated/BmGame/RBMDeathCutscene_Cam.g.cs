#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMDeathCutscene_Cam<br/>
/// (flags = 0)
/// </summary>
public partial class RBMDeathCutscene_Cam : BmSDK.BmGame.RBMCutscene_Cam, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMDeathCutscene_Cam", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMDeathCutscene_Cam() { }

    /// <summary>
    /// Constructs a new RBMDeathCutscene_Cam
    /// </summary>
    public RBMDeathCutscene_Cam(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMDeathCutscene_Cam Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMDeathCutscene_Cam(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: StrikeInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo StrikeInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.FStrikeInfo>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }
}
