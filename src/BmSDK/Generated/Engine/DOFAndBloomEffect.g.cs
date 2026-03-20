#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DOFAndBloomEffect<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class DOFAndBloomEffect : BmSDK.Engine.DOFEffect, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DOFAndBloomEffect", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DOFAndBloomEffect() { }

    /// <summary>
    /// Constructs a new DOFAndBloomEffect
    /// </summary>
    public DOFAndBloomEffect(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DOFAndBloomEffect Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DOFAndBloomEffect(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: BloomOverload
    /// </summary>
    public unsafe float BloomOverload
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// FloatProperty: BloomLowerCut
    /// </summary>
    public unsafe float BloomLowerCut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// FloatProperty: SceneMultiplier
    /// </summary>
    public unsafe float SceneMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ByteProperty: DepthOfFieldType
    /// </summary>
    public unsafe BmSDK.Engine.DOFAndBloomEffect.EDOFType DepthOfFieldType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DOFAndBloomEffect.EDOFType>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// ByteProperty: DepthOfFieldQuality
    /// </summary>
    public unsafe BmSDK.Engine.DOFAndBloomEffect.EDOFQuality DepthOfFieldQuality
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DOFAndBloomEffect.EDOFQuality>(Ptr + 145); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 145); }
    }

    /// <summary>
    /// ObjectProperty: BokehTexture
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D BokehTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }
}
