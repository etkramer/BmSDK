#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAIBrain_PredLite<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RAIBrain_PredLite : BmSDK.BmGame.RAIBrain_Pred, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAIBrain_PredLite", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAIBrain_PredLite() { }

    /// <summary>
    /// Constructs a new RAIBrain_PredLite
    /// </summary>
    public RAIBrain_PredLite(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAIBrain_PredLite Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAIBrain_PredLite(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: SearchlightCowerAEC
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SearchlightCowerAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// BoolProperty: bPredStarted
    /// </summary>
    public unsafe bool bPredStarted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 512) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 512); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 512); }
    }
}
