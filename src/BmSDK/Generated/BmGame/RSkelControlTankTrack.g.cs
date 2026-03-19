#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSkelControlTankTrack<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSkelControlTankTrack : BmSDK.Engine.SkelControlBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSkelControlTankTrack", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSkelControlTankTrack() { }

    /// <summary>
    /// Constructs a new RSkelControlTankTrack
    /// </summary>
    public RSkelControlTankTrack(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSkelControlTankTrack Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSkelControlTankTrack(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: SuspensionStride
    /// </summary>
    public unsafe float SuspensionStride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// FloatProperty: SuspensionPosFront
    /// </summary>
    public unsafe float SuspensionPosFront
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// FloatProperty: SuspensionPosRear
    /// </summary>
    public unsafe float SuspensionPosRear
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// FloatProperty: SuspensionMaxPosFront
    /// </summary>
    public unsafe float SuspensionMaxPosFront
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// FloatProperty: SuspensionMaxPosRear
    /// </summary>
    public unsafe float SuspensionMaxPosRear
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }
}
