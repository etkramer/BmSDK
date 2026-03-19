#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBarkConvoAction_SpeechBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBarkConvoAction_SpeechBase : BmSDK.BmGame.RBarkConvoAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBarkConvoAction_SpeechBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBarkConvoAction_SpeechBase() { }

    /// <summary>
    /// Constructs a new RBarkConvoAction_SpeechBase
    /// </summary>
    public RBarkConvoAction_SpeechBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBarkConvoAction_SpeechBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBarkConvoAction_SpeechBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bAllowOnKnockedOutPawns
    /// </summary>
    public unsafe bool bAllowOnKnockedOutPawns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 180); }
    }
}
