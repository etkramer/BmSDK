#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMDeathCutscene_FloorTakedownCam<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMDeathCutscene_FloorTakedownCam : BmSDK.BmGame.RBMDeathCutscene_Cam, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMDeathCutscene_FloorTakedownCam", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMDeathCutscene_FloorTakedownCam() { }

    /// <summary>
    /// Constructs a new RBMDeathCutscene_FloorTakedownCam
    /// </summary>
    public RBMDeathCutscene_FloorTakedownCam(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMDeathCutscene_FloorTakedownCam Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMDeathCutscene_FloorTakedownCam(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bRunTimer
    /// </summary>
    public unsafe bool bRunTimer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 236) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 236); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 236); }
    }

    /// <summary>
    /// BoolProperty: bLookUp
    /// </summary>
    public unsafe bool bLookUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 236) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 236); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 236); }
    }

    /// <summary>
    /// FloatProperty: ExitTimer
    /// </summary>
    public unsafe float ExitTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// StructProperty: NextPos
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT NextPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }
}
