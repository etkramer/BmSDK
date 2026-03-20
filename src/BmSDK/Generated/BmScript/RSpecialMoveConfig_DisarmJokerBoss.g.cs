#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveConfig_DisarmJokerBoss<br/>
/// (size = 472)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_DisarmJokerBoss : BmSDK.BmGame.RSpecialMoveConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveConfig_DisarmJokerBoss", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_DisarmJokerBoss() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_DisarmJokerBoss
    /// </summary>
    public RSpecialMoveConfig_DisarmJokerBoss(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_DisarmJokerBoss Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_DisarmJokerBoss(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: ShootDeflectAnimation
    /// </summary>
    public unsafe BmSDK.FName ShootDeflectAnimation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// NameProperty: PostSwitchJokerAnimation
    /// </summary>
    public unsafe BmSDK.FName PostSwitchJokerAnimation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// ObjectProperty: JokerAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet JokerAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// ObjectProperty: JokerVillainAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet JokerVillainAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// FloatProperty: SecondTransStart
    /// </summary>
    public unsafe float SecondTransStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// FloatProperty: SecondTransEnd
    /// </summary>
    public unsafe float SecondTransEnd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

    /// <summary>
    /// FloatProperty: SecondRotStart
    /// </summary>
    public unsafe float SecondRotStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// FloatProperty: SecondRotEnd
    /// </summary>
    public unsafe float SecondRotEnd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// StructProperty: CameraLocOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 CameraLocOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// StructProperty: CameraRotOffset
    /// </summary>
    public unsafe BmSDK.Rotator CameraRotOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }
}
