#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MBMBehaviour_ScarecrowBase<br/>
/// (size = 608)
/// (flags = 0)
/// </summary>
public partial class MBMBehaviour_ScarecrowBase : BmSDK.BmGame.RBMBehaviour, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MBMBehaviour_ScarecrowBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MBMBehaviour_ScarecrowBase() { }

    /// <summary>
    /// Constructs a new MBMBehaviour_ScarecrowBase
    /// </summary>
    public MBMBehaviour_ScarecrowBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MBMBehaviour_ScarecrowBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MBMBehaviour_ScarecrowBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: NumberOfWaves
    /// </summary>
    public unsafe int NumberOfWaves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// IntProperty: DefaultNumInputLink
    /// </summary>
    public unsafe int DefaultNumInputLink
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// IntProperty: DefaultNumOutputLink
    /// </summary>
    public unsafe int DefaultNumOutputLink
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// IntProperty: DefaultNumVarLink
    /// </summary>
    public unsafe int DefaultNumVarLink
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// IntProperty: CurrentWaveId
    /// </summary>
    public unsafe int CurrentWaveId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }
}
