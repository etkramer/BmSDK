#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSkelControlTwoBoneIK<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSkelControlTwoBoneIK : BmSDK.Engine.SkelControlBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSkelControlTwoBoneIK", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSkelControlTwoBoneIK() { }

    /// <summary>
    /// Constructs a new RSkelControlTwoBoneIK
    /// </summary>
    public RSkelControlTwoBoneIK(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSkelControlTwoBoneIK Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSkelControlTwoBoneIK(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: WidgetLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WidgetLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// BoolProperty: EnableMaxFootZ
    /// </summary>
    public unsafe bool EnableMaxFootZ
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: EnableOverExtensionClamp
    /// </summary>
    public unsafe bool EnableOverExtensionClamp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: UseLegIK
    /// </summary>
    public unsafe bool UseLegIK
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: WidgetIsVirtualFloorPlane
    /// </summary>
    public unsafe bool WidgetIsVirtualFloorPlane
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 260); }
    }

    /// <summary>
    /// StructProperty: WidgetRotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WidgetRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }
}
