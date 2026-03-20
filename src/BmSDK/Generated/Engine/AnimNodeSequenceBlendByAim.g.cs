#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AnimNodeSequenceBlendByAim<br/>
/// (flags = 0)
/// </summary>
public partial class AnimNodeSequenceBlendByAim : BmSDK.Engine.AnimNodeSequenceBlendBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AnimNodeSequenceBlendByAim", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AnimNodeSequenceBlendByAim() { }

    /// <summary>
    /// Constructs a new AnimNodeSequenceBlendByAim
    /// </summary>
    public AnimNodeSequenceBlendByAim(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AnimNodeSequenceBlendByAim Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AnimNodeSequenceBlendByAim(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Aim
    /// </summary>
    public unsafe System.Numerics.Vector2 Aim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// StructProperty: PreviousAim
    /// </summary>
    public unsafe System.Numerics.Vector2 PreviousAim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// StructProperty: HorizontalRange
    /// </summary>
    public unsafe System.Numerics.Vector2 HorizontalRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// StructProperty: VerticalRange
    /// </summary>
    public unsafe System.Numerics.Vector2 VerticalRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// StructProperty: AngleOffset
    /// </summary>
    public unsafe System.Numerics.Vector2 AngleOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector2>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

    /// <summary>
    /// NameProperty: AnimName_LU
    /// </summary>
    public unsafe BmSDK.FName AnimName_LU
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// NameProperty: AnimName_LC
    /// </summary>
    public unsafe BmSDK.FName AnimName_LC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// NameProperty: AnimName_LD
    /// </summary>
    public unsafe BmSDK.FName AnimName_LD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// NameProperty: AnimName_CU
    /// </summary>
    public unsafe BmSDK.FName AnimName_CU
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// NameProperty: AnimName_CC
    /// </summary>
    public unsafe BmSDK.FName AnimName_CC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }

    /// <summary>
    /// NameProperty: AnimName_CD
    /// </summary>
    public unsafe BmSDK.FName AnimName_CD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// NameProperty: AnimName_RU
    /// </summary>
    public unsafe BmSDK.FName AnimName_RU
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// NameProperty: AnimName_RC
    /// </summary>
    public unsafe BmSDK.FName AnimName_RC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// NameProperty: AnimName_RD
    /// </summary>
    public unsafe BmSDK.FName AnimName_RD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }
}
