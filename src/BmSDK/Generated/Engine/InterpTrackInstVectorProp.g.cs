#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: InterpTrackInstVectorProp<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class InterpTrackInstVectorProp : BmSDK.Engine.InterpTrackInstProperty, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.InterpTrackInstVectorProp", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InterpTrackInstVectorProp() { }

    /// <summary>
    /// Constructs a new InterpTrackInstVectorProp
    /// </summary>
    public InterpTrackInstVectorProp(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InterpTrackInstVectorProp Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InterpTrackInstVectorProp(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: VectorProp
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VectorProp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: ResetVector
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ResetVector
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }
}
