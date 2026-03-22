#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: AkAsset<br/>
/// (size = 56)
/// (flags = 134217875)
/// </summary>
public partial class AkAsset : BmSDK.Engine.AkAssetBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkAsset", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkAsset() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkAsset(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: RequiredAssetPack
    /// </summary>
    public unsafe BmSDK.Engine.AkAssetPack RequiredAssetPack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkAssetPack>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }
}
