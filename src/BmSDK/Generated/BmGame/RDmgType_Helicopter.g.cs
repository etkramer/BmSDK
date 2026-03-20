#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_Helicopter<br/>
/// (flags = 0)
/// </summary>
public partial class RDmgType_Helicopter : BmSDK.BmGame.RDmgType_Ranged, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_Helicopter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_Helicopter() { }

    /// <summary>
    /// Constructs a new RDmgType_Helicopter
    /// </summary>
    public RDmgType_Helicopter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_Helicopter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_Helicopter(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: StaggerBatmanRange
    /// </summary>
    public unsafe float StaggerBatmanRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }
}
