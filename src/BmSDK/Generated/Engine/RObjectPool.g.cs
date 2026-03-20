#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RObjectPool<br/>
/// (flags = 0)
/// </summary>
public partial class RObjectPool : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RObjectPool", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RObjectPool() { }

    /// <summary>
    /// Constructs a new RObjectPool
    /// </summary>
    public RObjectPool(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RObjectPool Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RObjectPool(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Emitters
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FREmitterPool Emitters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FREmitterPool>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// StructProperty: Decals
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRDecalPool Decals
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRDecalPool>(Ptr + 2488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2488); }
    }

    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 6588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6588); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 6632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6632); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 6676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6676); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 6720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6720); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 6764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6764); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 6808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6808); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 6852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6852); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 6896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6896); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 6940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6940); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 6984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6984); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7028); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7072); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7116); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7160); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7204); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7248); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7292); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7336); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7380); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7424); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7468); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7512); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7556); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7600); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7644); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7688); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7732); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7776); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7820); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7864); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7908); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7952); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_32
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 7996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7996); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_33
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8040); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_34
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8084); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_35
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8128); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_36
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8172); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_37
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8216); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_38
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8260); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_39
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8304); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_40
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8348); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_41
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8392); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_42
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8436); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_43
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8480); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_44
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8524); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_45
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8568); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_46
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8612); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_47
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8656); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_48
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8700); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_49
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8744); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_50
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8788); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_51
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8832); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_52
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8876); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_53
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8920); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_54
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 8964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8964); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_55
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 9008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9008); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_56
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 9052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9052); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_57
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 9096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9096); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_58
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 9140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9140); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_59
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 9184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9184); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_60
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 9228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9228); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_61
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 9272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9272); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_62
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 9316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9316); }
    }
    /// <summary>
    /// StructProperty: DamageInstances
    /// </summary>
    public unsafe BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance DamageInstances_63
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RObjectPool.FRAdvancedDamageInstance>(Ptr + 9360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9360); }
    }

    /// <summary>
    /// IntProperty: DamageInstancesIndex
    /// </summary>
    public unsafe int DamageInstancesIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 9404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9404); }
    }

    /// <summary>
    /// Struct: FREmitterPool
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FREmitterPool
    {
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_3
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_4
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_5
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_6
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_7
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_8
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_9
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_10
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_11
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 88); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_12
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_13
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 104); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_14
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 112); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_15
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 120); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_16
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 128); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_17
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 136); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_18
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 144); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_19
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 152); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_20
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 160); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_21
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 168); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_22
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 176); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_23
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 184); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_24
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 192); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_25
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 200); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_26
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 208); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_27
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 216); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_28
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 224); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_29
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 232); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_30
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 240); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_31
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 248); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_32
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 256); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_33
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 264); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_34
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 272); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_35
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 280); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_36
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 288); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_37
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 296); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_38
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 304); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_39
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 312); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_40
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 320); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_41
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 328); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_42
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 336); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_43
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 344); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_44
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 352); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_45
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 360); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_46
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 368); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_47
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 376); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_48
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 384); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_49
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 392); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_50
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 400); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_51
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 408); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_52
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 416); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_53
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 424); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_54
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 432); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_55
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 440); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_56
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 448); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_57
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 456); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_58
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 464); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_59
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 472); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_60
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 480); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_61
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 488); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_62
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 496); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_63
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 504); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_64
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 512); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_65
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 520); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_66
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 528); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_67
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 536); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_68
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 544); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_69
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 552); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_70
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 560); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_71
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 568); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_72
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 576); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_73
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 584); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_74
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 592); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_75
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 600); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_76
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 608); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_77
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 616); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_78
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 624); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_79
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 632); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_80
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 640); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_81
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 648); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_82
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 656); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_83
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 664); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_84
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 672); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_85
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 680); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_86
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 688); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_87
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 696); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_88
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 704); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_89
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 712); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_90
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 720); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_91
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 728); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_92
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 736); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_93
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 744); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_94
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 752); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_95
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 760); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_96
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 768); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_97
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 776); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_98
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 784); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_99
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 792); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_100
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 800); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_101
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 808); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_102
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 816); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_103
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 824); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_104
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 832); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_105
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 840); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_106
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 848); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_107
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 856); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_108
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 864); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_109
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 872); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_110
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 880); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_111
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 888); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_112
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 896); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_113
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 904); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_114
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 912); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_115
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 920); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_116
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 928); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_117
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 936); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_118
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 944); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_119
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 952); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_120
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 960); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_121
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 968); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_122
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 976); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_123
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 984); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_124
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 992); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_125
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1000); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_126
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1008); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_127
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1016); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_128
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1024); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_129
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1032); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_130
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1040); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_131
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1048); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_132
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1056); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_133
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1064); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_134
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1072); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_135
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1080); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_136
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1088); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_137
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1096); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_138
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1104); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_139
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1112); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_140
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1120); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_141
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1128); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_142
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1136); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_143
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1144); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_144
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1152); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_145
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1160); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_146
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1168); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_147
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1176); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_148
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1184); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }; }
        }
        /// <summary>
        /// ObjectProperty: Pool
        /// </summary>
        public unsafe BmSDK.Engine.REmitter Pool_149
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.REmitter>(Ptr + 1192); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }; }
        }

        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1200); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1208); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1216); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_3
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1224); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_4
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1232); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_5
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1240); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_6
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1248); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_7
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1256); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_8
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1264); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_9
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1272); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_10
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1280); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_11
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1288); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_12
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1296); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_13
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1304); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1304); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_14
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1312); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_15
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1320); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_16
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1328); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_17
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1336); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1336); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_18
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1344); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_19
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1352); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_20
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1360); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_21
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1368); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1368); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_22
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1376); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1376); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_23
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1384); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1384); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_24
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1392); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1392); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_25
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1400); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1400); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_26
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1408); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1408); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_27
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1416); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1416); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_28
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1424); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_29
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1432); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1432); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_30
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1440); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1440); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_31
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1448); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1448); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_32
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1456); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1456); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_33
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1464); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1464); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_34
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1472); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1472); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_35
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1480); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1480); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_36
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1488); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1488); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_37
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1496); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1496); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_38
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1504); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1504); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_39
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1512); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1512); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_40
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1520); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1520); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_41
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1528); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1528); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_42
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1536); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1536); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_43
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1544); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1544); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_44
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1552); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1552); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_45
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1560); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1560); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_46
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1568); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1568); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_47
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1576); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1576); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_48
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1584); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1584); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_49
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1592); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1592); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_50
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1600); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1600); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_51
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1608); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1608); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_52
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1616); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1616); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_53
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1624); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1624); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_54
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1632); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1632); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_55
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1640); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1640); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_56
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1648); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1648); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_57
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1656); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1656); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_58
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1664); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1664); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_59
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1672); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1672); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_60
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1680); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1680); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_61
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1688); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1688); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_62
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1696); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1696); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_63
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1704); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1704); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_64
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1712); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1712); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_65
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1720); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1720); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_66
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1728); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1728); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_67
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1736); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1736); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_68
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1744); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1744); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_69
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1752); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1752); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_70
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1760); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1760); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_71
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1768); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1768); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_72
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1776); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1776); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_73
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1784); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1784); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_74
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1792); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1792); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_75
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1800); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1800); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_76
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1808); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1808); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_77
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1816); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1816); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_78
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1824); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1824); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_79
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1832); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1832); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_80
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1840); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1840); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_81
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1848); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1848); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_82
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1856); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1856); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_83
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1864); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1864); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_84
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1872); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1872); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_85
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1880); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1880); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_86
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1888); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1888); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_87
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1896); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1896); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_88
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1904); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1904); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_89
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1912); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1912); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_90
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1920); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1920); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_91
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1928); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1928); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_92
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1936); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1936); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_93
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1944); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1944); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_94
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1952); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1952); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_95
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1960); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1960); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_96
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1968); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1968); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_97
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1976); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1976); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_98
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1984); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1984); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_99
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1992); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1992); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_100
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2000); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2000); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_101
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2008); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2008); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_102
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2016); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2016); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_103
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2024); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2024); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_104
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2032); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2032); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_105
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2040); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2040); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_106
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2048); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2048); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_107
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2056); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2056); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_108
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2064); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2064); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_109
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2072); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2072); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_110
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2080); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2080); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_111
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2088); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2088); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_112
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2096); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2096); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_113
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2104); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2104); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_114
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2112); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2112); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_115
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2120); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2120); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_116
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2128); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2128); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_117
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2136); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2136); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_118
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2144); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2144); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_119
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2152); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2152); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_120
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2160); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2160); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_121
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2168); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2168); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_122
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2176); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2176); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_123
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2184); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2184); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_124
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2192); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2192); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_125
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2200); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2200); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_126
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2208); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2208); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_127
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2216); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2216); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_128
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2224); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2224); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_129
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2232); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2232); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_130
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2240); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2240); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_131
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2248); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2248); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_132
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2256); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2256); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_133
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2264); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2264); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_134
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2272); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2272); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_135
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2280); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2280); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_136
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2288); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2288); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_137
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2296); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2296); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_138
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2304); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2304); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_139
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2312); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2312); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_140
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2320); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2320); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_141
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2328); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2328); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_142
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2336); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2336); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_143
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2344); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2344); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_144
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2352); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2352); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_145
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2360); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2360); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_146
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2368); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2368); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_147
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2376); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2376); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_148
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2384); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2384); }; }
        }
        /// <summary>
        /// NameProperty: DebugTemplateName
        /// </summary>
        public unsafe BmSDK.FName DebugTemplateName_149
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2392); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2392); }; }
        }

        /// <summary>
        /// IntProperty: Index
        /// </summary>
        public unsafe int Index
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2400); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2400); }; }
        }
    }

}
