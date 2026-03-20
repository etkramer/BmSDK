#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNotify_CurveFloat<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RAnimNotify_CurveFloat : BmSDK.Engine.AnimNotify, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNotify_CurveFloat", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNotify_CurveFloat() { }

    /// <summary>
    /// Constructs a new RAnimNotify_CurveFloat
    /// </summary>
    public RAnimNotify_CurveFloat(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotify_CurveFloat Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_CurveFloat(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: CurveName
    /// </summary>
    public unsafe BmSDK.FName CurveName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// FloatProperty: NewValue
    /// </summary>
    public unsafe float NewValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ByteProperty: ControlType
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNotify_CurveFloat.EFloatControlType ControlType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNotify_CurveFloat.EFloatControlType>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// Enum: EFloatControlType
    /// </summary>
    public enum EFloatControlType
    {
        FCC_Set = 0,
        FCC_LinearInterpolate = 1,
        FCC_MAX = 2,
    }
}
