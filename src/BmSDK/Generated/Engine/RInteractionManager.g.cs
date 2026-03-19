#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RInteractionManager<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RInteractionManager : BmSDK.Component, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RInteractionManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RInteractionManager() { }

    /// <summary>
    /// Constructs a new RInteractionManager
    /// </summary>
    public RInteractionManager(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RInteractionManager Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RInteractionManager(nint ptr) : base(ptr) { }

    /// <summary>
    /// MapProperty: InteractionClasses
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ InteractionClasses
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: ReferencedClasses
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT ReferencedClasses
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }
}
