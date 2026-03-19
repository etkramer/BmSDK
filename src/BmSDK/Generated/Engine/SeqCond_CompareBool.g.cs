#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqCond_CompareBool<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SeqCond_CompareBool : BmSDK.Engine.SequenceCondition, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqCond_CompareBool", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqCond_CompareBool() { }

    /// <summary>
    /// Constructs a new SeqCond_CompareBool
    /// </summary>
    public SeqCond_CompareBool(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqCond_CompareBool Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqCond_CompareBool(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bResult
    /// </summary>
    public unsafe bool bResult
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 324); }
    }
}
