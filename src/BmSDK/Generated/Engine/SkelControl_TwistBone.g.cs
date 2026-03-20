#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SkelControl_TwistBone<br/>
/// (flags = 0)
/// </summary>
public partial class SkelControl_TwistBone : BmSDK.Engine.SkelControlBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SkelControl_TwistBone", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SkelControl_TwistBone() { }

    /// <summary>
    /// Constructs a new SkelControl_TwistBone
    /// </summary>
    public SkelControl_TwistBone(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SkelControl_TwistBone Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SkelControl_TwistBone(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: SourceBoneName
    /// </summary>
    public unsafe BmSDK.FName SourceBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// FloatProperty: TwistAngleScale
    /// </summary>
    public unsafe float TwistAngleScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }
}
