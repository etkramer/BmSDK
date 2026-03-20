#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MBMBehaviour_BulletHitReaction<br/>
/// (flags = 0)
/// </summary>
public partial class MBMBehaviour_BulletHitReaction : BmSDK.BmGame.RBMBehaviour_HitReaction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MBMBehaviour_BulletHitReaction", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MBMBehaviour_BulletHitReaction() { }

    /// <summary>
    /// Constructs a new MBMBehaviour_BulletHitReaction
    /// </summary>
    public MBMBehaviour_BulletHitReaction(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MBMBehaviour_BulletHitReaction Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MBMBehaviour_BulletHitReaction(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: StunTime
    /// </summary>
    public unsafe float StunTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }
}
