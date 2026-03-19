#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_UnlockCharacterBio<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_UnlockCharacterBio : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_UnlockCharacterBio", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_UnlockCharacterBio() { }

    /// <summary>
    /// Constructs a new RSeqAct_UnlockCharacterBio
    /// </summary>
    public RSeqAct_UnlockCharacterBio(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_UnlockCharacterBio Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_UnlockCharacterBio(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: Character
    /// </summary>
    public unsafe byte Character
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bUnknownCharacter
    /// </summary>
    public unsafe bool bUnknownCharacter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 356); }
    }

    /// <summary>
    /// BoolProperty: bDontDisplayMessage
    /// </summary>
    public unsafe bool bDontDisplayMessage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 356); }
    }

    /// <summary>
    /// BoolProperty: bDontShowBackPrompt
    /// </summary>
    public unsafe bool bDontShowBackPrompt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 356); }
    }
}
