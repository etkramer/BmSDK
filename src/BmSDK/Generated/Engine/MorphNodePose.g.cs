#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MorphNodePose<br/>
/// (flags = 0)
/// </summary>
public partial class MorphNodePose : BmSDK.Engine.MorphNodeBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MorphNodePose", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MorphNodePose() { }

    /// <summary>
    /// Constructs a new MorphNodePose
    /// </summary>
    public MorphNodePose(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MorphNodePose Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MorphNodePose(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Target
    /// </summary>
    public unsafe BmSDK.Engine.MorphTarget Target
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MorphTarget>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// NameProperty: MorphName
    /// </summary>
    public unsafe BmSDK.FName MorphName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// FloatProperty: Weight
    /// </summary>
    public unsafe float Weight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }
}
