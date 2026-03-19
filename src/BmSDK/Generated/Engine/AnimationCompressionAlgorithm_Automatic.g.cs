#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AnimationCompressionAlgorithm_Automatic<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AnimationCompressionAlgorithm_Automatic : BmSDK.Engine.AnimationCompressionAlgorithm, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AnimationCompressionAlgorithm_Automatic", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AnimationCompressionAlgorithm_Automatic() { }

    /// <summary>
    /// Constructs a new AnimationCompressionAlgorithm_Automatic
    /// </summary>
    public AnimationCompressionAlgorithm_Automatic(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AnimationCompressionAlgorithm_Automatic Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AnimationCompressionAlgorithm_Automatic(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: MaxEndEffectorError
    /// </summary>
    public unsafe float MaxEndEffectorError
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: bTryFixedBitwiseCompression
    /// </summary>
    public unsafe bool bTryFixedBitwiseCompression
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: bTryPerTrackBitwiseCompression
    /// </summary>
    public unsafe bool bTryPerTrackBitwiseCompression
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: bTryLinearKeyRemovalCompression
    /// </summary>
    public unsafe bool bTryLinearKeyRemovalCompression
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: bTryIntervalKeyRemoval
    /// </summary>
    public unsafe bool bTryIntervalKeyRemoval
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: bRunCurrentDefaultCompressor
    /// </summary>
    public unsafe bool bRunCurrentDefaultCompressor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: bAutoReplaceIfExistingErrorTooGreat
    /// </summary>
    public unsafe bool bAutoReplaceIfExistingErrorTooGreat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: bRaiseMaxErrorToExisting
    /// </summary>
    public unsafe bool bRaiseMaxErrorToExisting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }
}
