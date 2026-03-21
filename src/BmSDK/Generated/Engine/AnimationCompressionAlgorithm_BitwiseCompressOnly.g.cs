#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AnimationCompressionAlgorithm_BitwiseCompressOnly<br/>
/// (size = 64)
/// (flags = 134217874)
/// </summary>
public partial class AnimationCompressionAlgorithm_BitwiseCompressOnly : BmSDK.Engine.AnimationCompressionAlgorithm, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AnimationCompressionAlgorithm_BitwiseCompressOnly", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AnimationCompressionAlgorithm_BitwiseCompressOnly() { }

    /// <summary>
    /// Constructs a new AnimationCompressionAlgorithm_BitwiseCompressOnly
    /// </summary>
    public AnimationCompressionAlgorithm_BitwiseCompressOnly(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AnimationCompressionAlgorithm_BitwiseCompressOnly Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AnimationCompressionAlgorithm_BitwiseCompressOnly(nint ptr) : base(ptr) { }

}
