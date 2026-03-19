#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: Prefab<br/>
/// (size = 0)
/// (flags = 0)
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
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: PrefabArchetypes
    /// </summary>
    public unsafe BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT> PrefabArchetypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// ArrayProperty: RemovedArchetypes
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT RemovedArchetypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// ObjectProperty: PrefabSequence
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PrefabSequence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// ObjectProperty: PrefabPreview
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PrefabPreview
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// ObjectProperty: PivotArchetype
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PivotArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// BoolProperty: bRiotingPrefab
    /// </summary>
    public unsafe bool bRiotingPrefab
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 144); }
    }
}
