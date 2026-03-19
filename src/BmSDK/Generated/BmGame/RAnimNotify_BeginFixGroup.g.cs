#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNotify_BeginFixGroup<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RAnimNotify_BeginFixGroup : BmSDK.Engine.AnimNotify, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNotify_BeginFixGroup", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNotify_BeginFixGroup() { }

    /// <summary>
    /// Constructs a new RAnimNotify_BeginFixGroup
    /// </summary>
    public RAnimNotify_BeginFixGroup(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotify_BeginFixGroup Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_BeginFixGroup(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: GroupName
    /// </summary>
    public unsafe BmSDK.FName GroupName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
