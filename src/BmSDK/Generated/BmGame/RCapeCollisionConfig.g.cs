#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCapeCollisionConfig<br/>
/// (size = 56)
/// (flags = 134217874)
/// </summary>
public partial class RCapeCollisionConfig : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCapeCollisionConfig", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCapeCollisionConfig() { }

    /// <summary>
    /// Constructs a new RCapeCollisionConfig
    /// </summary>
    public RCapeCollisionConfig(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCapeCollisionConfig Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCapeCollisionConfig(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: CollisionShapeConfigs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCapeCollisionShapeConfig> CollisionShapeConfigs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCapeCollisionShapeConfig>>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }
}
