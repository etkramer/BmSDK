#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: GenericParamListStatEntry<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class GenericParamListStatEntry : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.GenericParamListStatEntry", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal GenericParamListStatEntry() { }

    /// <summary>
    /// Constructs a new GenericParamListStatEntry
    /// </summary>
    public GenericParamListStatEntry(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GenericParamListStatEntry Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GenericParamListStatEntry(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: StatEvent
    /// </summary>
    public unsafe System.IntPtr StatEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: Writer
    /// </summary>
    public unsafe BmSDK.Engine.GameplayEventsWriter Writer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameplayEventsWriter>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }
}
