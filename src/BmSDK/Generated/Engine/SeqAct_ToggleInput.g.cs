#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqAct_ToggleInput<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SeqAct_ToggleInput : BmSDK.Engine.SeqAct_Toggle, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqAct_ToggleInput", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_ToggleInput() { }

    /// <summary>
    /// Constructs a new SeqAct_ToggleInput
    /// </summary>
    public SeqAct_ToggleInput(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_ToggleInput Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_ToggleInput(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bToggleMovement
    /// </summary>
    public unsafe bool bToggleMovement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bToggleTurning
    /// </summary>
    public unsafe bool bToggleTurning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }
}
