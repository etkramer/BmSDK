#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SkelControl_Multiply<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SkelControl_Multiply : BmSDK.Engine.SkelControlBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SkelControl_Multiply", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SkelControl_Multiply() { }

    /// <summary>
    /// Constructs a new SkelControl_Multiply
    /// </summary>
    public SkelControl_Multiply(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SkelControl_Multiply Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SkelControl_Multiply(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: Multiplier
    /// </summary>
    public unsafe float Multiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }
}
