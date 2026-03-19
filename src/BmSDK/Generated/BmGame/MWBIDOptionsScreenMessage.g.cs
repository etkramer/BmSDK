#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MWBIDOptionsScreenMessage<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MWBIDOptionsScreenMessage : BmSDK.BmGame.MWBIDDataMessage, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MWBIDOptionsScreenMessage", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MWBIDOptionsScreenMessage() { }

    /// <summary>
    /// Constructs a new MWBIDOptionsScreenMessage
    /// </summary>
    public MWBIDOptionsScreenMessage(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MWBIDOptionsScreenMessage Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MWBIDOptionsScreenMessage(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bIsConfirm
    /// </summary>
    public unsafe bool bIsConfirm
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 84); }
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
