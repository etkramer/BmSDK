#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionFontSample<br/>
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionFontSample : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionFontSample", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionFontSample() { }

    /// <summary>
    /// Constructs a new MaterialExpressionFontSample
    /// </summary>
    public MaterialExpressionFontSample(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionFontSample Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionFontSample(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Font
    /// </summary>
    public unsafe BmSDK.Engine.Font Font
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Font>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// IntProperty: FontTexturePage
    /// </summary>
    public unsafe int FontTexturePage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }
}
