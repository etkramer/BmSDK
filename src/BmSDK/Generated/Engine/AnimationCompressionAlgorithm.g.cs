#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AnimationCompressionAlgorithm<br/>
/// (flags = 0)
/// </summary>
public partial class AnimationCompressionAlgorithm : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AnimationCompressionAlgorithm", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AnimationCompressionAlgorithm() { }

    /// <summary>
    /// Constructs a new AnimationCompressionAlgorithm
    /// </summary>
    public AnimationCompressionAlgorithm(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AnimationCompressionAlgorithm Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AnimationCompressionAlgorithm(nint ptr) : base(ptr) { }

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
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// ByteProperty: TranslationCompressionFormat
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence.AnimationCompressionFormat TranslationCompressionFormat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence.AnimationCompressionFormat>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// ByteProperty: RotationCompressionFormat
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence.AnimationCompressionFormat RotationCompressionFormat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence.AnimationCompressionFormat>(Ptr + 105); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 105); }
    }
}
