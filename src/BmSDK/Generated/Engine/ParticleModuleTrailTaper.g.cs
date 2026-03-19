#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleTrailTaper<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleTrailTaper : BmSDK.Engine.ParticleModuleTrailBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleTrailTaper", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleTrailTaper() { }

    /// <summary>
    /// Constructs a new ParticleModuleTrailTaper
    /// </summary>
    public ParticleModuleTrailTaper(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleTrailTaper Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleTrailTaper(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: TaperMethod
    /// </summary>
    public unsafe byte TaperMethod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// StructProperty: TaperFactor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TaperFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// Enum: ETrailTaperMethod
    /// </summary>
    public enum ETrailTaperMethod
    {
        PETTM_None = 0,
        PETTM_Full = 1,
        PETTM_Partial = 2,
        PETTM_MAX = 3,
    }
}
