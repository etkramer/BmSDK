#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: InterpGroupCamera<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class InterpGroupCamera : BmSDK.Engine.InterpGroup, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.InterpGroupCamera", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InterpGroupCamera() { }

    /// <summary>
    /// Constructs a new InterpGroupCamera
    /// </summary>
    public InterpGroupCamera(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InterpGroupCamera Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InterpGroupCamera(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: CameraAnimInst
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CameraAnimInst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// StructProperty: Target
    /// </summary>
    public unsafe BmSDK.Engine.InterpGroup.InterpTracks Target
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.InterpGroup.InterpTracks>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// FloatProperty: CompressTolerance
    /// </summary>
    public unsafe float CompressTolerance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }
}
