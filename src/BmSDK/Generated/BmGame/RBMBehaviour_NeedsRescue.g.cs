#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_NeedsRescue<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_NeedsRescue : BmSDK.BmGame.RBMBehaviour, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_NeedsRescue", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_NeedsRescue() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_NeedsRescue
    /// </summary>
    public RBMBehaviour_NeedsRescue(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_NeedsRescue Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_NeedsRescue(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: RescueText
    /// </summary>
    public unsafe BmSDK.FString RescueText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// BoolProperty: DontAppendCharName
    /// </summary>
    public unsafe bool DontAppendCharName
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 604); }
    }
}
