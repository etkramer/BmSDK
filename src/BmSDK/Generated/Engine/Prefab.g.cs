#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: Prefab<br/>
/// (size = 80)
/// (flags = 134217874)
/// </summary>
public partial class Prefab : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.Prefab", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Prefab() { }

    /// <summary>
    /// Constructs a new Prefab
    /// </summary>
    public Prefab(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Prefab Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Prefab(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: PrefabVersion
    /// </summary>
    public unsafe int PrefabVersion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// ArrayProperty: PrefabArchetypes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> PrefabArchetypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// ArrayProperty: RemovedArchetypes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> RemovedArchetypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// ObjectProperty: PrefabSequence
    /// </summary>
    public unsafe BmSDK.Engine.PrefabSequence PrefabSequence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrefabSequence>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }

    /// <summary>
    /// ObjectProperty: PrefabPreview
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D PrefabPreview
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 76); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }
    }
}
