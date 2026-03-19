#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleOrbit<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleOrbit : BmSDK.Engine.ParticleModuleOrbitBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleOrbit", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleOrbit() { }

    /// <summary>
    /// Constructs a new ParticleModuleOrbit
    /// </summary>
    public ParticleModuleOrbit(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleOrbit Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleOrbit(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: ChainMode
    /// </summary>
    public unsafe byte ChainMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: OffsetAmount
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleOrbit.RotationAmount OffsetAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleOrbit.RotationAmount>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// StructProperty: OffsetOptions
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OffsetOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// StructProperty: RotationAmount
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleOrbit.RotationRateAmount RotationAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleOrbit.RotationRateAmount>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// StructProperty: RotationOptions
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RotationOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// StructProperty: RotationRateAmount
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RotationRateAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// StructProperty: RotationRateOptions
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RotationRateOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// Enum: EOrbitChainMode
    /// </summary>
    public enum EOrbitChainMode
    {
        EOChainMode_Add = 0,
        EOChainMode_Scale = 1,
        EOChainMode_Link = 2,
        EOChainMode_MAX = 3,
    }
}
