#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionRainBufferNormal<br/>
/// (size = 225)
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionRainBufferNormal : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionRainBufferNormal", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionRainBufferNormal() { }

    /// <summary>
    /// Constructs a new MaterialExpressionRainBufferNormal
    /// </summary>
    public MaterialExpressionRainBufferNormal(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionRainBufferNormal Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionRainBufferNormal(nint ptr) : base(ptr) { }

    /// <summary>
    /// Enum: ERainBufferType
    /// </summary>
    public enum ERainBufferType
    {
        RAINBUFFER_FloorNormals = 0,
        RAINBUFFER_WallNormals = 1,
        RAINBUFFER_WallSpatterOnlyNormals = 2,
        RAINBUFFER_WallTrailOnlyNormals = 3,
        RAINBUFFER_FloorHeight = 4,
        RAINBUFFER_WallHeight = 5,
        RAINBUFFER_WallSpatterOnlyHeight = 6,
        RAINBUFFER_WallTrailOnlyHeight = 7,
        RAINBUFFER_MAX = 8,
    }

    /// <summary>
    /// StructProperty: Coordinates
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.FExpressionInput Coordinates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.FExpressionInput>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// ByteProperty: RainBufferType
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionRainBufferNormal.ERainBufferType RainBufferType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionRainBufferNormal.ERainBufferType>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }
}
