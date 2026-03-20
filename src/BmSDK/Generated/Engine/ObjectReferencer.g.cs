#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ObjectReferencer<br/>
/// (flags = 0)
/// </summary>
public partial class ObjectReferencer : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ObjectReferencer", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ObjectReferencer() { }

    /// <summary>
    /// Constructs a new ObjectReferencer
    /// </summary>
    public ObjectReferencer(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ObjectReferencer Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ObjectReferencer(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: ReferencedObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> ReferencedObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
