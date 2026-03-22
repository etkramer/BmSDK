#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: SeqAct_LevelStreamingBase<br/>
/// (size = 224)
/// (flags = 134226067)
/// </summary>
public partial class SeqAct_LevelStreamingBase : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqAct_LevelStreamingBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_LevelStreamingBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_LevelStreamingBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bMakeVisibleAfterLoad
    /// </summary>
    public unsafe bool bMakeVisibleAfterLoad
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bShouldBlockOnLoad
    /// </summary>
    public unsafe bool bShouldBlockOnLoad
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bRegisterLevelIfMissing
    /// </summary>
    public unsafe bool bRegisterLevelIfMissing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }
}
