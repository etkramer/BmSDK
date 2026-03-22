#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK;

/// <summary>
/// Class: ObjectSerializer<br/>
/// (size = 56)
/// (flags = 268435592)
/// </summary>
public partial class ObjectSerializer : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Core.ObjectSerializer", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ObjectSerializer() { }

    /// <summary>
    /// Constructs a new ObjectSerializer
    /// </summary>
    public ObjectSerializer(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ObjectSerializer Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ObjectSerializer(nint ptr) : base(ptr) { }

}
