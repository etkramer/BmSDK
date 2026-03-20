#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: InterpFilter_Custom<br/>
/// (flags = 0)
/// </summary>
public partial class InterpFilter_Custom : BmSDK.Engine.InterpFilter, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.InterpFilter_Custom", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InterpFilter_Custom() { }

    /// <summary>
    /// Constructs a new InterpFilter_Custom
    /// </summary>
    public InterpFilter_Custom(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InterpFilter_Custom Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InterpFilter_Custom(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: GroupsToInclude
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.InterpGroup> GroupsToInclude
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.InterpGroup>>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }
}
