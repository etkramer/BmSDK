#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AnimNodeCrossfader<br/>
/// (flags = 0)
/// </summary>
public partial class AnimNodeCrossfader : BmSDK.Engine.AnimNodeBlend, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AnimNodeCrossfader", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AnimNodeCrossfader() { }

    /// <summary>
    /// Constructs a new AnimNodeCrossfader
    /// </summary>
    public AnimNodeCrossfader(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AnimNodeCrossfader Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AnimNodeCrossfader(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: DefaultAnimSeqName
    /// </summary>
    public unsafe BmSDK.FName DefaultAnimSeqName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// BoolProperty: bDontBlendOutOneShot
    /// </summary>
    public unsafe bool bDontBlendOutOneShot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 328) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 328); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 328); }
    }

    /// <summary>
    /// FloatProperty: PendingBlendOutTimeOneShot
    /// </summary>
    public unsafe float PendingBlendOutTimeOneShot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }
}
