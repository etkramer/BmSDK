#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPounceBlockingVolumeContainer<br/>
/// (flags = 0)
/// </summary>
public partial class RPounceBlockingVolumeContainer : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPounceBlockingVolumeContainer", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPounceBlockingVolumeContainer() { }

    /// <summary>
    /// Constructs a new RPounceBlockingVolumeContainer
    /// </summary>
    public RPounceBlockingVolumeContainer(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPounceBlockingVolumeContainer Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPounceBlockingVolumeContainer(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: Volumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPounceBlockingVolume> Volumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPounceBlockingVolume>>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
