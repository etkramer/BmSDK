#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionAntialiasedTextureMask<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionAntialiasedTextureMask : BmSDK.Engine.MaterialExpressionTextureSampleParameter2D, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionAntialiasedTextureMask", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionAntialiasedTextureMask() { }

    /// <summary>
    /// Constructs a new MaterialExpressionAntialiasedTextureMask
    /// </summary>
    public MaterialExpressionAntialiasedTextureMask(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionAntialiasedTextureMask Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionAntialiasedTextureMask(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: Threshold
    /// </summary>
    public unsafe float Threshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// ByteProperty: Channel
    /// </summary>
    public unsafe byte Channel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }
}
