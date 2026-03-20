#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MWBIDVerifyScreenMessage<br/>
/// (flags = 0)
/// </summary>
public partial class MWBIDVerifyScreenMessage : BmSDK.BmGame.MWBIDDataMessage, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MWBIDVerifyScreenMessage", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MWBIDVerifyScreenMessage() { }

    /// <summary>
    /// Constructs a new MWBIDVerifyScreenMessage
    /// </summary>
    public MWBIDVerifyScreenMessage(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MWBIDVerifyScreenMessage Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MWBIDVerifyScreenMessage(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bIsConfirm
    /// </summary>
    public unsafe bool bIsConfirm
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 84); }
    }

    /// <summary>
    /// IntProperty: SelectedButton
    /// </summary>
    public unsafe int SelectedButton
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }
}
