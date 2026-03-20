#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_SimultaneousCounter<br/>
/// (flags = 0)
/// </summary>
public partial class RDmgType_SimultaneousCounter : BmSDK.BmGame.RDmgType_Strike, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_SimultaneousCounter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_SimultaneousCounter() { }

    /// <summary>
    /// Constructs a new RDmgType_SimultaneousCounter
    /// </summary>
    public RDmgType_SimultaneousCounter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_SimultaneousCounter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_SimultaneousCounter(nint ptr) : base(ptr) { }

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
    public unsafe BmSDK.BmGame.RPawnPlayerCombat.CounterStrength CounterStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.CounterStrength>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }
}
