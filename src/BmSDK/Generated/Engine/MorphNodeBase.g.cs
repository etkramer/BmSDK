#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MorphNodeBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MorphNodeBase : BmSDK.Engine.AnimObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MorphNodeBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MorphNodeBase() { }

    /// <summary>
    /// Constructs a new MorphNodeBase
    /// </summary>
    public MorphNodeBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MorphNodeBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MorphNodeBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: NodeName
    /// </summary>
    public unsafe BmSDK.FName NodeName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: bDrawSlider
    /// </summary>
    public unsafe bool bDrawSlider
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 136); }
    }
}
