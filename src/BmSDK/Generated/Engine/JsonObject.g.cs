#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: JsonObject<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class JsonObject : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.JsonObject", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal JsonObject() { }

    /// <summary>
    /// Constructs a new JsonObject
    /// </summary>
    public JsonObject(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, JsonObject Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected JsonObject(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: ValueMap
    /// </summary>
    public unsafe BmSDK.GameObject.FMap_Mirror ValueMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FMap_Mirror>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// StructProperty: ObjectMap
    /// </summary>
    public unsafe BmSDK.GameObject.FMap_Mirror ObjectMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FMap_Mirror>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ArrayProperty: ValueArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ValueArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// ArrayProperty: ObjectArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.JsonObject> ObjectArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.JsonObject>>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }
}
