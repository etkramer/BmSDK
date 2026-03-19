#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: PrefabSequence<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class PrefabSequence : BmSDK.Engine.Sequence, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.PrefabSequence", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal PrefabSequence() { }

    /// <summary>
    /// Constructs a new PrefabSequence
    /// </summary>
    public PrefabSequence(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, PrefabSequence Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected PrefabSequence(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: OwnerPrefab
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OwnerPrefab
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }
}
