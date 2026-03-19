#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleSubUVMovie<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleSubUVMovie : BmSDK.Engine.ParticleModuleSubUV, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleSubUVMovie", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleSubUVMovie() { }

    /// <summary>
    /// Constructs a new ParticleModuleSubUVMovie
    /// </summary>
    public ParticleModuleSubUVMovie(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleSubUVMovie Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleSubUVMovie(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bUseEmitterTime
    /// </summary>
    public unsafe bool bUseEmitterTime
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 136); }
    }

    /// <summary>
    /// StructProperty: FrameRate
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleSubUV.SubImageIndex FrameRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleSubUV.SubImageIndex>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// IntProperty: StartingFrame
    /// </summary>
    public unsafe int StartingFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }
}
