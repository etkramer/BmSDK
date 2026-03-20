#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMBehaviour_JokerBossRiddlerHostage<br/>
/// (size = 604)
/// (flags = 8210)
/// </summary>
public partial class RBMBehaviour_JokerBossRiddlerHostage : BmSDK.BmGame.RBMBehaviour, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMBehaviour_JokerBossRiddlerHostage", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_JokerBossRiddlerHostage() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_JokerBossRiddlerHostage
    /// </summary>
    public RBMBehaviour_JokerBossRiddlerHostage(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_JokerBossRiddlerHostage Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_JokerBossRiddlerHostage(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: ShotByJokerGun
    /// </summary>
    public unsafe void ShotByJokerGun()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RBMBehaviour_JokerBossRiddlerHostage.ShotByJokerGun", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: Riddler
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain Riddler
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// BoolProperty: bDied
    /// </summary>
    public unsafe bool bDied
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// FloatProperty: ThugDiedTime
    /// </summary>
    public unsafe float ThugDiedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }
}
