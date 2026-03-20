#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AnimationCompressionAlgorithm_RemoveTrivialKeys<br/>
/// (size = 116)
/// (flags = 0)
/// </summary>
public partial class AnimationCompressionAlgorithm_RemoveTrivialKeys : BmSDK.Engine.AnimationCompressionAlgorithm, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AnimationCompressionAlgorithm_RemoveTrivialKeys", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AnimationCompressionAlgorithm_RemoveTrivialKeys() { }

    /// <summary>
    /// Constructs a new AnimationCompressionAlgorithm_RemoveTrivialKeys
    /// </summary>
    public AnimationCompressionAlgorithm_RemoveTrivialKeys(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AnimationCompressionAlgorithm_RemoveTrivialKeys Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AnimationCompressionAlgorithm_RemoveTrivialKeys(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: MaxPosDiff
    /// </summary>
    public unsafe float MaxPosDiff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// FloatProperty: MaxAngleDiff
    /// </summary>
    public unsafe float MaxAngleDiff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }
}
