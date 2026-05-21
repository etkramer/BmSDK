#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionRainBufferNormal<br/>
/// (size = 225)
/// (flags = 134226066)
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

    /// <summary>
    /// Gets the class default object as MaterialExpressionRainBufferNormal.
    /// </summary>
    public static MaterialExpressionRainBufferNormal DefaultObject => (MaterialExpressionRainBufferNormal)StaticClass().DefaultObject;

    internal MaterialExpressionRainBufferNormal() { }

    /// <summary>
    /// Constructs a new MaterialExpressionRainBufferNormal
    /// </summary>
    public MaterialExpressionRainBufferNormal(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionRainBufferNormal Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionRainBufferNormal(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MaterialExpressionRainBufferNormal>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MaterialExpressionRainBufferNormal>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MaterialExpressionRainBufferNormal>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MaterialExpressionRainBufferNormal>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MaterialExpressionRainBufferNormal>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MaterialExpressionRainBufferNormal>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MaterialExpressionRainBufferNormal>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MaterialExpressionRainBufferNormal>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Enum: ERainBufferType
    /// </summary>
    public enum ERainBufferType : byte
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
    public unsafe ref BmSDK.Engine.MaterialExpression.FExpressionInput Coordinates
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.MaterialExpression.FExpressionInput>(Ptr + 172);

    /// <summary>
    /// ByteProperty: RainBufferType
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionRainBufferNormal.ERainBufferType RainBufferType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionRainBufferNormal.ERainBufferType>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }
}
