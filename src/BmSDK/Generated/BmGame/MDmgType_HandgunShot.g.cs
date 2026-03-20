#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MDmgType_HandgunShot<br/>
/// (flags = 0)
/// </summary>
public partial class MDmgType_HandgunShot : BmSDK.BmGame.RDmgType_Strike, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MDmgType_HandgunShot", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MDmgType_HandgunShot() { }

    /// <summary>
    /// Constructs a new MDmgType_HandgunShot
    /// </summary>
    public MDmgType_HandgunShot(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MDmgType_HandgunShot Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MDmgType_HandgunShot(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: StunTime
    /// </summary>
    public unsafe float StunTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// FloatProperty: ImpulseMulti
    /// </summary>
    public unsafe float ImpulseMulti
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }
}
