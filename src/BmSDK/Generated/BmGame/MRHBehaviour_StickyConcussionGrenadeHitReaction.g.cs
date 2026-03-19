#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MRHBehaviour_StickyConcussionGrenadeHitReaction<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MRHBehaviour_StickyConcussionGrenadeHitReaction : BmSDK.BmGame.RBMBehaviour_HitReaction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MRHBehaviour_StickyConcussionGrenadeHitReaction", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MRHBehaviour_StickyConcussionGrenadeHitReaction() { }

    /// <summary>
    /// Constructs a new MRHBehaviour_StickyConcussionGrenadeHitReaction
    /// </summary>
    public MRHBehaviour_StickyConcussionGrenadeHitReaction(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MRHBehaviour_StickyConcussionGrenadeHitReaction Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MRHBehaviour_StickyConcussionGrenadeHitReaction(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: OriginalStunTime
    /// </summary>
    public unsafe float OriginalStunTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }
}
