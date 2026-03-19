#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MDmgType_RedhoodCounterBlackMask<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MDmgType_RedhoodCounterBlackMask : BmSDK.BmGame.RDmgType_Counter, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MDmgType_RedhoodCounterBlackMask", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MDmgType_RedhoodCounterBlackMask() { }

    /// <summary>
    /// Constructs a new MDmgType_RedhoodCounterBlackMask
    /// </summary>
    public MDmgType_RedhoodCounterBlackMask(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MDmgType_RedhoodCounterBlackMask Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MDmgType_RedhoodCounterBlackMask(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: AlignmentPad
    /// </summary>
    public unsafe int AlignmentPad
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// ByteProperty: CounterStrength
    /// </summary>
    public unsafe byte CounterStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }
}
