#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveConfig_FreezeFinalBeatdown<br/>
/// (size = 384)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_FreezeFinalBeatdown : BmSDK.BmGame.RSpecialMoveConfig_RelativeAnimWithAlignment, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveConfig_FreezeFinalBeatdown", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_FreezeFinalBeatdown() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_FreezeFinalBeatdown
    /// </summary>
    public RSpecialMoveConfig_FreezeFinalBeatdown(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_FreezeFinalBeatdown Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_FreezeFinalBeatdown(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: BeatdownIdle
    /// </summary>
    public unsafe BmSDK.FName BeatdownIdle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// NameProperty: BeatdownPunchAnim
    /// </summary>
    public unsafe BmSDK.FName BeatdownPunchAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// NameProperty: BeatdownFrightenAnim
    /// </summary>
    public unsafe BmSDK.FName BeatdownFrightenAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }
}
