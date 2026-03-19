#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RBodyInstancePool<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBodyInstancePool : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RBodyInstancePool", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBodyInstancePool() { }

    /// <summary>
    /// Constructs a new RBodyInstancePool
    /// </summary>
    public RBodyInstancePool(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBodyInstancePool Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBodyInstancePool(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: FreeBodyInstIndices
    /// </summary>
    public unsafe BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT> FreeBodyInstIndices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// IntProperty: NumFreeBodyInstIndices
    /// </summary>
    public unsafe int NumFreeBodyInstIndices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: BodyInstancePool
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT BodyInstancePool
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

}
