#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqCond_CompareInt<br/>
/// (flags = 0)
/// </summary>
public partial class SeqCond_CompareInt : BmSDK.Engine.SequenceCondition, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqCond_CompareInt", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqCond_CompareInt() { }

    /// <summary>
    /// Constructs a new SeqCond_CompareInt
    /// </summary>
    public SeqCond_CompareInt(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqCond_CompareInt Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqCond_CompareInt(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: ValueA
    /// </summary>
    public unsafe int ValueA
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// IntProperty: ValueB
    /// </summary>
    public unsafe int ValueB
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }
}
