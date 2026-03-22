#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkStateName<br/>
/// (size = 60)
/// (flags = 134217874)
/// </summary>
public partial class AkStateName : BmSDK.Engine.AkAsset, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkStateName", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkStateName() { }

    /// <summary>
    /// Constructs a new AkStateName
    /// </summary>
    public AkStateName(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkStateName Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkStateName(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: ParentStateGroup
    /// </summary>
    public unsafe BmSDK.Engine.AkStateGroupName ParentStateGroup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkStateGroupName>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }
}
