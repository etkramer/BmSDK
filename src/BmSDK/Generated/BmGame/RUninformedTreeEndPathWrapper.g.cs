#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RUninformedTreeEndPathWrapper<br/>
/// (flags = 0)
/// </summary>
public partial class RUninformedTreeEndPathWrapper : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RUninformedTreeEndPathWrapper", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RUninformedTreeEndPathWrapper() { }

    /// <summary>
    /// Constructs a new RUninformedTreeEndPathWrapper
    /// </summary>
    public RUninformedTreeEndPathWrapper(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RUninformedTreeEndPathWrapper Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RUninformedTreeEndPathWrapper(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: NavMan
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationManager NavMan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationManager>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: BlockPolyPylon
    /// </summary>
    public unsafe BmSDK.Engine.Pylon BlockPolyPylon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pylon>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ObjectProperty: ParamProxy
    /// </summary>
    public unsafe BmSDK.Engine.Pawn ParamProxy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: BlockedPolyList
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> BlockedPolyList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ArrayProperty: Path
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RUninformedTreeEndPathWrapper.FTreeEndHandleCombo> Path
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RUninformedTreeEndPathWrapper.FTreeEndHandleCombo>>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// StructProperty: DestPoint
    /// </summary>
    public unsafe System.Numerics.Vector3 DestPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// NameProperty: ClaimName
    /// </summary>
    public unsafe BmSDK.FName ClaimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }
}
