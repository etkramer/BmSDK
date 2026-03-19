#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ActorFactoryApexDestructible<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ActorFactoryApexDestructible : BmSDK.Engine.ActorFactory, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ActorFactoryApexDestructible", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ActorFactoryApexDestructible() { }

    /// <summary>
    /// Constructs a new ActorFactoryApexDestructible
    /// </summary>
    public ActorFactoryApexDestructible(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ActorFactoryApexDestructible Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ActorFactoryApexDestructible(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bStartAwake
    /// </summary>
    public unsafe bool bStartAwake
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 144); }
    }

    /// <summary>
    /// BoolProperty: OverrideRBCollisionSettings
    /// </summary>
    public unsafe bool OverrideRBCollisionSettings
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 144); }
    }

    /// <summary>
    /// ByteProperty: RBChannel
    /// </summary>
    public unsafe byte RBChannel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ByteProperty: RBDominanceGroup
    /// </summary>
    public unsafe byte RBDominanceGroup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 149); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 149); }
    }

    /// <summary>
    /// StructProperty: DrawScale3D
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DrawScale3D
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// StructProperty: CollideWithChannels
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CollideWithChannels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ObjectProperty: DestructibleAsset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DestructibleAsset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }
}
