#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqEvt_PressurePad<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqEvt_PressurePad : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqEvt_PressurePad", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvt_PressurePad() { }

    /// <summary>
    /// Constructs a new RSeqEvt_PressurePad
    /// </summary>
    public RSeqEvt_PressurePad(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvt_PressurePad Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvt_PressurePad(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: Bats
    /// </summary>
    public unsafe bool Bats
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 380); }
    }

    /// <summary>
    /// BoolProperty: Cats
    /// </summary>
    public unsafe bool Cats
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 380); }
    }

    /// <summary>
    /// BoolProperty: Mobile
    /// </summary>
    public unsafe bool Mobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 380); }
    }

    /// <summary>
    /// BoolProperty: Robot
    /// </summary>
    public unsafe bool Robot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 380); }
    }

    /// <summary>
    /// BoolProperty: Monkey
    /// </summary>
    public unsafe bool Monkey
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 380); }
    }
}
