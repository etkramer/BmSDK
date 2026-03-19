#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AnimationCompressionAlgorithm_BitwiseCompressOnly<br/>
/// (size = 0)
/// (flags = 0)
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

    /// <summary>
    /// StrProperty: Description
    /// </summary>
    public unsafe BmSDK.FString Description
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// BoolProperty: bNeedsSkeleton
    /// </summary>
    public unsafe bool bNeedsSkeleton
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// ByteProperty: TranslationCompressionFormat
    /// </summary>
    public unsafe byte TranslationCompressionFormat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// ByteProperty: RotationCompressionFormat
    /// </summary>
    public unsafe byte RotationCompressionFormat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 105); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 105); }
    }
}
